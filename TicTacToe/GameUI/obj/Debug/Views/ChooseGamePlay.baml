   M S B A M L   `   `   `  ����A  =GameUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:GameUI.ViewsGameUI.Views  5      !    GameUI.Views.ChooseGamePlay   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:GameUI.Views     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��	onePlayer��5      $��80��5      $��80��6   $��0��5      $��0��6   $��Bottom=�5      ��5      �� 5      .R�5      �� $��..\Resource\elf.png��6   5      5!      �� 5"   
   -   5        $��playerVsComputerText��5&      $��1��5#      $��0��5$      $	��Top=�5%      
�������$��18(�5(       �� TextAlignment$ Center=�5)      6&   � 5+   
   $��0��6   $��1��6     5,      �� 5-      $��1* �6#   �� 5.      $��1* �6$   �� 5/      $
��0.3* �6$   .+�52      �� -   5        $��	twoPlayer��55      $��80��53      $��80��6   $��0��54      $��0��6   $��Bottom=�56      ��5:      �� 5;      .R�5<      �� $��..\Resource\elf.png��6    5=      5?      �� 5A      -   5        $��
twoPlayerb��5D      $��80��5B      $��80��6   $��0��5C      $��1��6   $��Bottom=�5E      ��5I      �� 5J      .R�5K      �� $��..\Resource\elf.png��6    5L      5N      5Q      �� 5R   
   -   5        $��twoPlayersTextBox��5T      $��1��5S      $��1��5U      $	��Top=�5V      
�������$��18(�5X      $ Center=�5Y      6&   �� 5[   
   -   5        $��startButtonBorder��5]      $y�Hidden=�5\      $��2��5^      $��2��5_      $��Center=�5`      
������� �� CornerRadius$ 2��5b      $	��100��5c      $��40��6   $��1q�5d      ._�5e      �� -   5        $��	startGame��5e      
�������
����� �.��6e   Start6l   5f      5g      5h      