   M S B A M L   `   `   `  ����A  =pract5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:pract5pract5  5   	       pract5.studentsWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:pract5     5   	     � Title$  studentsWindow��5	   	   $	��450��6    $	��800��6-   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��5      $��2��6P   $��4��6d   6u   �� 5   
   -   5         ��Name$
 Exit��5      $��
выход��6   $��1��6/   $��
48,7,96,15q�6?   $��7��6S   6`   �� 5   
   -   5        $ Delete��5      $��удалить��6!   $��1��63   $��48,10,96,13q�6C   $��5��6X   6e   �� 5   
   -   5        $ Up��5      $��изменить��6   $��1��60   $��
48,7,96,15q�6@   $��6��6T   6a   �� 5   
   -   5        $ Button��5      $��добавить��6!   $��1��64   $��48,11,96,11q�6D   $��4��6Y   6f   �� 5   
   -   5         ��Name$ 	ComboBox1��5      $��	61,0,34,0q�6&   $��4��69   $��30��6F   6R   �� 5   
   -   5         ��Name$ TextBox2��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Full_name��6$    �� TextWrapping$
 Wrap=�6O   $�� ��6c   $��61,11,34,11q�6k   $��6��6�   �� 5    
   -   5        $ TextBox1��5       $ Contact_details��6$   $
 Wrap=�6U   $�� ��6i   $��61,10,34,12q�6q   $��5��6�   5!      5"      