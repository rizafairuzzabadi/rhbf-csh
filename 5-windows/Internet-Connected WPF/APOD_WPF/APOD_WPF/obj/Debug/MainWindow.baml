   M S B A M L   `   `   `  ����C  ?APOD_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:APOD_WPFAPOD_WPF  5   	       APOD_WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:APOD_WPF     5   	   -   5          � Title$  
MainWindow��5   	   $��587.389��6   $��906.527��6-   .��5	      � .+�5
   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ MonthCalendar��5
      $
��Left=�6,   $��23��6G   $��	22,27,0,0q�6S   $	��Top=�6f   $	��210��6~   6�   �� 5   
   -   5         ��Name$ LaunchButton��5      $��Go to APOD launch date��6'   $
��Left=�6H   $��	22,64,0,0q�6c   $	��Top=�6v   $	��210��6�   6�   �� 5   
   $��Settings��6   $
��Left=�6%   $	��154��6@   $��
22,156,0,0q�6M   $	��Top=�6a   $	��244��6y    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ -0.393Q�6$   �� 5      T� 5       T� Y$ -0.491Q�6)   5      5      �� 5   
   -   5         ��Name$ ShowTodaysImageCheckBox��5      $$��Show today's image on start up��64   $
��Left=�6]   $��
39,181,0,0q�6x   $	��Top=�6�   �� 5   
   -   5        $ LimitRangeCheckBox��5      $"��Limit range to current year.��6/   $
��Left=�6V   $��
39,201,0,0q�6q   $	��Top=�6�   6�   �� 5   
   $��Images downloaded today��6   $
��Left=�62   $��
39,259,0,0q�6M   $	��Top=�6a   $ 0.849,-4.739&�6y   �� 5   
   -   5         ��Name$ ImagesTodayTextBox��5      $
��Left=�6.   $��23��6I   $��195,262,0,0q�6U    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $��51��6�   	 �� 
IsReadOnly	 . ���	#FFFFFFC06�   �� 5   
   $!��Image Credit and Copyright:��6   $
��Left=�66   $��
39,337,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ ImageCopyrightTextBox��5      $
��Left=�61   $��23��6L   $��
39,368,0,0q�6X   $
 Wrap=�6l   $	��Top=�6�   $	��160��6�   	 . ���	#FFFFFFC06�   �� 5   
   $��Description��6   $
��Left=�6&   $��
39,405,0,0q�6A   $	��Top=�6U   �� 5   
   -   5        $ DescriptionTextBox��5      $
��Left=�6.   $��85��6I   $��
42,436,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��812��6�   	 . ���	#FFFFFFC06�   �� 5   
   -	   5        
 ��Name$
 PictureBorder��5      
���   �$��1q�6<   $
��Left=�6P   $	��364��6k   $��
310,27,0,0q�6x   $	��Top=�6�   $	��544��6�   ._�5       �� -
   5         ��Name$ ImagePictureBox��5       5!      5#      5$      