   M S B A M L   `   `   `  ����C  ?PraktWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PraktWPFPraktWPF  5   	       PraktWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PraktWPF     5   	   -   5          � Title$  Окно клиентов��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagrid��5
      $
��Left=�6%   $	��354��6@   $��	10,10,0,0q�6M   $	��Top=�6`   $	��774��6x      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
idklient+6N     5      $ Имя��6%   $	 250 6K    62   �� *name+6K     5      $ Тип��6%   $	 250 6J    62   �� *tip+6J     5      $ 
адрес��6%   $	 150 6N    64   �� *adres+6N   5      �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��
10,369,0,0q�6?   $	��Top=�6S   $	��123��6k   $��41��6w   6�   �� 5   
   -   5        $ ��Редактировать��5      $
��Left=�6)   $��157,369,0,0q�6D   $	��Top=�6Y   $	��123��6q   $��41��6}   6�   �� 5   
   -   5        $��Удалить��5      $
��Left=�6#   $��320,369,0,0q�6>   $	��Top=�6S   $	��123��6k   $��41��6w   6�   �� 5   
   -   5        $��
Выход��5      $
��Left=�6!   $��508,369,0,0q�6<   $	��Top=�6Q   $	��123��6i   $��41��6u   6�   5      5      