   M S B A M L   `   `   `  ����   Host tester    Host_tester.MainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Host tester��$	��450��$	��800��.���  � ColumnDefinitions �� $��* ��� $
��auto �.+�&   System.Windows.Controls.DataGrid  -     Name$ MainDataGrid��   AutoGenerateColumns$ False��$��0,0,0,0q�$��0������ *MyData+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+  $ Address�� �� *	Address+4  .System.Windows.Controls.DataGridCheckBoxColumn  $ Enabled�� �� *	Enabled+  $ Status��   
IsReadOnly$
 True�� �� *Status+� $��1�� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��Center=�$��	05,0,05,0q�$
��Wrap=�$��Ping interval��$	��Top=�$��0���� -   	 ��Name$	 TimerTB��$��Center=�$��0,5,0,0q�
 �� TextWrapping$
 NoWrap=�$��50��$
��6000��$	��Top=�$��1��� $��2�� �� $��* ��� $��* �.+��� -    ��Name$ BtnStopPing��$
��Stop��$��Stretch=�$��5,5,5,0q�$	��Top=�$��0���� -   $ BtnStartPing��$��Start��$��Stretch=�$��5,5,5,0q�$	��Top=�$��1���� $��Center=�$��
05,20,05,0q�$
��Wrap=�$��New Host��$	��Top=�$��3��� $��4�� �� $��* ��� $��* �.+��� $��Name:��$
��Left=�$��0,5,0,0q�$
��Wrap=�$��Center=��� -   $	 TBNewHostName��$��Right=�$��0,5,0,0q�$
 NoWrap=�$��80��$��
john smith��$	��Top=�$��1��� $��5�� �� $��* ��� $��* �.+��� $	��Ip:��$
��Left=�$��0,5,0,0q�$
��Wrap=�$��Center=��� -   $	 TBNewHostIp��$��Right=�$��0,5,0,0q�$
 NoWrap=�$��80��$��	127.0.0.1��$	��Top=�$��1���� -   $ BtnAddNewHost��$��Add host��$��Stretch=�$��5,10,5,0q�$	��Top=�$��6���� -   $ BtnSaveToXml��$��Save to xml��$��Stretch=�$��5,25,5,0q�$	��Top=�$��7��