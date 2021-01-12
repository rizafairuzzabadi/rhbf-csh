using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;

namespace APOD_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // The objective of the NASA API portal is to make NASA data, including imagery, eminently accessible to application developers. 
        const string EndpointURL = "https://api.nasa.gov/planetary/apod";
        
        // Init file name strings, used to preserve UI values between sessions.
        const string SettingToday = "date today";
        const string SettingShowOnStartup = "show on startup";
        const string SettingImageCountToday = "images today";
        const string SettingLimitRange = "limit range";
        
        // The full path to the init file.
        string initFilePath;

        // A char used to divide the name from the value in the init file.
        const char SettingDivider = ':';



        // June 16, 1995: the APOD launch date.
        DateTime launchDate = new DateTime(1995, 6, 16);

        // A count of images downloaded today.
        int imageCountToday;

        // Flag to ignore a strange double event in WPF.
        bool ignoreDoubleEvent = false;

        public MainWindow()
        {
            InitializeComponent();

            // Set the maximum date to today, and the minimum date to the date APOD was launched.
            MonthCalendar.DisplayDateEnd = DateTime.Today;
            MonthCalendar.DisplayDateStart = launchDate;

            // Store the init file in the same folder as the application.
            initFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "init_apod.txt");

            // Read the init file and set UI fields.
            ReadInitFile();
        }

        private void LaunchButton_Click(object sender, RoutedEventArgs e)
        {
            // Make sure the full range of dates is available.
            // This might invoke a call to LimitRangeCheckBox_CheckedChanged.
            LimitRangeCheckBox.IsChecked = false;

            // This will not load up the image, just sets the calendar to the APOD launch date.
            // This will fire a double event, the first of which needs to be ignored.
            ignoreDoubleEvent = true;
            MonthCalendar.SelectedDate = launchDate;
        }

        private void LimitRangeCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (LimitRangeCheckBox.IsChecked == true)
            {
                // Set the minimum date of the calendar to the beginning of the year.
                var thisYear = new DateTime(DateTime.Today.Year, 1, 1);
                MonthCalendar.DisplayDateStart = thisYear;
            }
            else
            {
                // Set the minimum date of the calendar to the launch date of the APOD program.
                MonthCalendar.DisplayDateStart = launchDate;
            }
        }

        private async void MonthCalendar_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            // Retrieve an image, unless a double event has been fired, in which case ignore the first event.
            if (!ignoreDoubleEvent)
            {
                await RetrievePhoto();
            }
            else
            {
                ignoreDoubleEvent = false;
            }
        }
        private bool IsSupportedFormat(string photoURL)
        {
            // Extract the extension and force to lower case for comparison purposes.
            string ext = System.IO.Path.GetExtension(photoURL).ToLower();

            // Check the extension against supported WPF formats.
            return (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif" || ext == ".bmp" ||
                    ext == ".wmf" || ext == ".tif" || ext == ".ico");
        }

        private async Task RetrievePhoto()
        {
            var client = new HttpClient();
            JObject jResult = null;
            string responseContent = null;
            string description = null;
            string photoUrl = null;
            string copyright = null;

            // Set the UI elements to defaults.
            ImageCopyrightTextBox.Text = "NASA";
            DescriptionTextBox.Text = "";

            // Build the date parameter string for the date selected, or the last date if a range is specified.
            DateTime dt = (DateTime)MonthCalendar.SelectedDate;
            string dateSelected = $"{dt.Year.ToString()}-{dt.Month.ToString("00")}-{dt.Day.ToString("00")}";
            string URLParams = $"?date={dateSelected}&api_key=DEMO_KEY";

            // Populate the HTTP client appropriately.
            client.BaseAddress = new Uri(EndpointURL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // The critical call: send a GET request with the appropriate parameters.
            HttpResponseMessage response = client.GetAsync(URLParams).Result;

            if (response.IsSuccessStatusCode)
            {
                // Be ready to catch any data or server errors.
                try
                {
                    // Parse the response by using the Newtonsoft APIs.
                    responseContent = await response.Content.ReadAsStringAsync();

                    // Parse the response string for the details we need.
                    jResult = JObject.Parse(responseContent);

                    // Now get the image.
                    photoUrl = (string)jResult["url"];
                    var photoURI = new Uri(photoUrl);
                    var bmi = new BitmapImage(photoURI);

                    ImagePictureBox.Source = bmi;

                    if (IsSupportedFormat(photoUrl))
                    {
                        // Get the copyright message, but fill with "NASA" if no name is provided.
                        copyright = (string)jResult["copyright"];
                        if (copyright != null && copyright.Length > 0)
                        {
                            ImageCopyrightTextBox.Text = copyright;
                        }

                        // Populate the description text box.
                        description = (string)jResult["explanation"];
                        DescriptionTextBox.Text = description;
                    }
                    else
                    {
                        DescriptionTextBox.Text = $"Image type is not supported. URL is {photoUrl}";
                    }
                }
                catch (Exception ex)
                {
                    DescriptionTextBox.Text = $"Image data is not supported. {ex.Message}";
                }

                // Keep track of our downloads in case we reach the limit.
                ++imageCountToday;
                ImagesTodayTextBox.Text = imageCountToday.ToString();
            }
            else
            {
                DescriptionTextBox.Text = "We were unable to retrieve the NASA picture for that day: " +
                    $"{response.StatusCode.ToString()} {response.ReasonPhrase}";
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            WriteInitFile();
        }

        private void WriteInitFile()
        {
            using (var sw = new StreamWriter(initFilePath))
            {
                // Write out todays date, to keep track on the downloads per day.
                sw.WriteLine(SettingToday + SettingDivider + DateTime.Today.ToShortDateString());

                // Write out the number of images we have downloaded today.
                sw.WriteLine(SettingImageCountToday + SettingDivider + imageCountToday.ToString());

                // Write out the UI settings we want to preserve for the next time.
                sw.WriteLine(SettingShowOnStartup + SettingDivider + ShowTodaysImageCheckBox.IsChecked.ToString());
                sw.WriteLine(SettingLimitRange + SettingDivider + LimitRangeCheckBox.IsChecked.ToString());
            }
        }

        private void ReadInitFile()
        {
            // Check that we have an init file.
            if (File.Exists(initFilePath))
            {
                String line = null;
                String[] part;
                bool isToday = false;

                using (var sr = new StreamReader(initFilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Split the line into the part before the colon (the name), and the part after (the value).
                        part = line.Split(SettingDivider);

                        // Switch on the "name" part, and then process the "value" part.
                        switch (part[0])
                        {
                            // Read the date and, if it's today's date, read the number of images already downloaded.
                            // If it's not today's date, set the number of downloads back to zero.
                            case SettingToday:
                                var dt = DateTime.Parse(part[1]);
                                if (dt.Equals(DateTime.Today))
                                {
                                    isToday = true;
                                }
                                break;

                            case SettingImageCountToday:

                                // If the last time the app was used was earlier today, the
                                // image count stored is valid against the 50-per-day maximum.
                                if (isToday)
                                {
                                    imageCountToday = int.Parse(part[1]);
                                }
                                else
                                {
                                    imageCountToday = 0;
                                }
                                break;

                            case SettingShowOnStartup:
                                ShowTodaysImageCheckBox.IsChecked = bool.Parse(part[1]);
                                break;

                            case SettingLimitRange:

                                // This statement might invoke a call to LimitRangeCheckBox_CheckedChanged.
                                LimitRangeCheckBox.IsChecked = bool.Parse(part[1]);
                                break;

                            default:
                                throw new Exception("Unknown init file entry: " + line);
                        }
                    }
                }
            }
            else
            {
                // No init file exists yet, so set defaults.
                imageCountToday = 0;
                ShowTodaysImageCheckBox.IsChecked = true;
                LimitRangeCheckBox.IsChecked = false;
            }

            ImagesTodayTextBox.Text = imageCountToday.ToString();

            // Make a call to retrieve a picture on startup, if required by the setting.
            if (ShowTodaysImageCheckBox.IsChecked == true)
            {
                // Note that, in WPF, this fires a double event, the first of which should be ignored.
                ignoreDoubleEvent = true;
                MonthCalendar.SelectedDate = DateTime.Today;
            }
        }
    }
}
