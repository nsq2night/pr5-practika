   M S B A M L   `   `   `  ����A  =pract5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:pract5pract5  5   	   '    !pract5.Timetable_of_classesWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:pract5     5   	     � Title$   Timetable_of_classesWindow��5	   	   $	��450��6,   $	��800��69   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��5      $��2��6P   $��4��6d   6u   �� 5   
   -   5         ��Name$ Button��5      $��добавить��6!   $��1��64   $��
65,14,65,8q�6D   $��4��6X   6e   �� 5   
   -   5        $ Delete��5      $��удалить��6!   $��1��63   $��65,13,65,10q�6C   $��5��6X   6e   �� 5   
   -   5        $ Up��5      $��изменить��6   $��1��60   $��
65,13,65,9q�6@   $��6��6T   6a   �� 5   
   -   5        $
 Exit��5      $��
выход��6   $��1��6/   $��65,12,65,10q�6?   $��7��6T   6a   �� 5   
   -   5         ��Name$ 	ComboBox1��5      $��
86,12,44,0q�6&   $��7��6:   $	��Top=�6G   $��32��6_   6k   �� 5   
   -   5         ��Name$ TextBox1��5       �� TextWrapping$
 Wrap=�6$   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Day_of_the_week��68   $�� ��6i   $��
86,15,44,8q�6q   $��4��6�   �� 5    
   -   5        $ TextBox2��5       $
 Wrap=�6$   $ Start_time(hh:mm)��68   $�� ��6k   $��86,12,44,12q�6s   $��5��6�   �� 5!   
   -	   5        $ TextBox3��5!      $
 Wrap=�6$   $ Teacher��68   $�� ��6a   $��
86,13,44,9q�6i   $��6��6}   5"      5#      