   M S B A M L   `   `   `  ����A  =pract5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:pract5pract5  5   	       pract5.CoursesWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:pract5     5   	     � Title$  CoursesWindow��5	   	   $	��450��6   $	��800��6,   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DataGridC��5      $��4��6Q   $��3��6b   6v   �� 5   
   -   5         ��Name$ ButtonC��5      $��добавить��6"   $��23,11,22,11q�65   $��4��6J   $��2��6W   6g   �� 5   
   -   5        $ DeleteC��5      $��Удалить��6"   $��23,50,22,27q�64   $��4��6I   $��2��6V   $��2��6f   6w   �� 5   
   -   5        $	 UpC��5      $��Изменить��6   $��23,33,22,44q�61   $��5��6F   $��2��6S   $��2��6c   6t   �� 5   
   -   5        $
 ison��5      $
��json��6   $��
23,17,22,5q�6.   $��6��6B   $��2��6O   6_   �� 5   
   -   5        $ ExitC��5      $��
выход��6    $��
23,0,22,22q�60   $��7��6D   $��2��6Q   6a   �� 5    
   -   5         ��Name$ Course_name��5       )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Course_name��6'    �� TextWrapping$
 Wrap=�6T   $�� ��6h   $��10,11,10,11q�6p   $��4��6�   $��1��6�   �� 5!   
   -   5        $ Price��5!      $ Price��6!   $
 Wrap=�6H   $�� ��6\   $��
10,15,10,5q�6d   $��6��6x   $��1��6�   �� 5"   
   -	   5         ��Name$ 	ComboBox1��5"      $��1��6&   $��
13,50,10,0q�66   $��4��6J   $	��Top=�6W   $��2��6o   6�   �� 5#   
   -
   5        $ 	ComboBox2��5#      $��1��6&   $��
13,37,10,0q�66   $��2��6J   $��5��6[   $	��Top=�6h   6�   5&      5'      