   M S B A M L   `   `   `  ����D  @ModernVpn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ModernVpn	ModernVpn  5   	   C&clr-namespace:ModernVpn.MVVM.ViewModelModernVpn.MVVM.ViewModel  5   	   /clr-namespace:ModernVpn.CoreModernVpn.Core  5   	       ModernVpn.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ModernVpn     5   	   <	viewmodel&clr-namespace:ModernVpn.MVVM.ViewModel     5   	   3
extensionsclr-namespace:ModernVpn.Core     5   	     � Title$  
MainWindow��5
   	   $	��450��5   	   $	��800��6    � WindowStyle$  None=�5   	   
������  � AllowsTransparency$
 True��5   	    � 
ResizeMode$ 	CanResize=�5   	    � DataContext 5      ,  &ModernVpn.MVVM.ViewModel.MainViewModel  5   
   .��5      ]� ���#1E1E1E$��7q�5      .+�5   
   �� $��28��6   ���#252525$	��Top=�5       J� InputBindings 5      d� 5       d� MouseAction$ 	LeftClicke�6    �� Command 5      �� *MoveWindowsCommand+._�5      �  � ColumnDefinitions 5      �� 5       �� 5"      $	��100 �6'   .+�5$      �� $��SurfHub 1.0.0��6   
�������$��Consolas)�5&      $��Center=�5'      $��Center=�5(      $��	100,0,0,0q�5)      �� 5*      $��1��6   	 �� Orientation$	 
Horizontal=�5+      $��Right=�5,      $��0,0,4,0q�5-      .+�5.      �� $��-��6   $��0,0,0,2q�50      ��5/      �� *MinimizeWindowsCommand+50      �� 51      $��O��6   $��0,0,0,3q�52      ��53      �� *MaximizeWindowsCommand+�� 54      $��x��6   $��0,0,0,2q�55      ��56      �� *ShutDownWindowsCommand+57      58      59      �� 5;   
   $��48��6   $
��Left=�5<      ���#252525��5>      �� 5?      
 �� Triggers
 5@      :� 5A       :� RoutedEvent$ Border.MouseEnter��6'   [�5B      �� 5C   "   .��5D   &   �� .��5E   *   W�  �� TargetProperty$ (Border.Width)�6:   	 W� To 1205F   :    g� Duration$ 0:0:01D�5G   :   5H   '   5I   #   5K      :� 5M      $ Border.MouseLeave��6'   [�5N      �� 5O   "   .��5P   &   �� .��5Q   *   W� $ (Border.Width)�6:    485R   :   $ 0:0:01D�5S   :   5T   '   5U   #   5W      5Y      ._�5\      �� .+�5]      	� $��Sheild��6   $��16(�5^      $��Normal"�5_      
������� d� 	IsChecked$
 TrueY�5a      ��5b      �� *ShowProtetionView+	� 5c      $	��VPN��6   $��16(�5d      $��Normal"�5e      
�������5f      	� 5g      $��Settings��6   $��16(�5i      $��Normal"�5j      
���������5l      �� *ShowSettingsView+5m      5n      �� 5p   
   ��6   �� *CurrentView+5r      5s      