   M S B A M L   `   `   `  ����  Host tester    Host_tester.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Host tester��5   	   $	��450��6   $	��800��6*   .��5      �  � ColumnDefinitions 5	   
   �� 5
      $��* �6   �� 5      $
��auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ MainDataGrid��5         AutoGenerateColumns$ False��6J   $��0,0,0,0q�6g   $��0��6x   ��6*   �� *MyData+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *Name+  5      $ Address��6%    5      �� *	Address+4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Enabled��6)    5      �� *	Enabled+  5      $ Status��6%      
IsReadOnly$
 True��65    5      �� *Status+5      � 5   
   $��1��6    � RowDefinitions 5       �� 5!      $
��auto �6    �� 5"      $
��auto �6    �� 5#      $
��auto �6    �� 5$      $
��auto �6    �� 5%      $
��auto �6    �� 5&      $
��auto �6    �� 5'      $
��auto �6    �� 5(      $
��auto �6    �� 5)      $
��auto �6    .+�5-      �� $��Center=�6   $��	05,0,05,0q�65   $
��Wrap=�6H   $��Ping interval��6\   $	��Top=�6q   $��0��6�   �� 5.      -   5        	 ��Name$	 TimerTB��5.      $��Center=�6I   $��0,5,0,0q�6f   
 �� TextWrapping$
 NoWrap=�6x   $��50��6�   $
��6000��6�   $	��Top=�6�   $��1��6�   � 5/      $��2��6    50      �� 51      $��* �6'   �� 52      $��* �6'   .+�54      �� -   5         ��Name$ BtnStopPing��54      $
��Stop��6.   $��Stretch=�6=   $��5,5,5,0q�6[   $	��Top=�6l   $��0��6�   6�   �� 55      -   5        $ BtnStartPing��55      $��Start��6/   $��Stretch=�6?   $��5,5,5,0q�6]   $	��Top=�6n   $��1��6�   6�   56      �� 59      $��Center=�6   $��
05,20,05,0q�65   $
��Wrap=�6I   $��New Host��6]   $	��Top=�6m   $��3��6�   � 5:      $��4��6    5;      �� 5<      $��* �6'   �� 5=      $��* �6'   .+�5?      �� $��Name:��6   $
��Left=�6+   $��0,5,0,0q�6F   $
��Wrap=�6X   $��Center=�6m   6�   �� 5@      -   5        $	 TBNewHostName��5@      $��Right=�6S   $��0,5,0,0q�6o   $
 NoWrap=�6�   $��80��6�   $��
john smith��6�   $	��Top=�6�   $��1��6�   5A      � 5D      $��5��6    5E      �� 5F      $��* �6'   �� 5G      $��* �6'   .+�5I      �� $	��Ip:��6   $
��Left=�6)   $��0,5,0,0q�6D   $
��Wrap=�6V   $��Center=�6k   6�   �� 5J      -   5        $	 TBNewHostIp��5J      $��Right=�6Q   $��0,5,0,0q�6m   $
 NoWrap=�6   $��80��6�   $��	127.0.0.1��6�   $	��Top=�6�   $��1��6�   5K      �� 5L      -   5        $ BtnAddNewHost��5L      $��Add host��6,   $��Stretch=�6?   $��5,10,5,0q�6]   $	��Top=�6o   $��6��6�   6�   �� 5O      -   5        $ BtnSaveToXml��5O      $��Save to xml��6+   $��Stretch=�6A   $��5,25,5,0q�6_   $	��Top=�6q   $��7��6�   6�   5Q      5R      5S      