   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1.WindowsWpfApp1.Windows  5   	        WpfApp1.Windows.UserWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApp1.Windows     5   	     � Title$  
UserWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $	��800��5      $	��500��6   $��Center=�6&   $	��Top=�5       �� Orientation$ Vertical=�6%   ���	#FF48D1CC.+�5      �� $��5q�6    �� TextAlignment$ Center=�6#   $��Center=�6u   $	��200��6�   ��6:   �� *Title+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��
Full Name:��6   $��5q�6*   �� 5      $��5q�6U   $��1��6`   ��6   �� *
Fullname+$ PropertyChanged=�6`   �� 5      $��Address:��6   $��5q�6(   $��1��63   �� 5      $��5q�6T   $��1��6_   ��6   �� *	Address+$ PropertyChanged=�6_   �� 5      $��Course:��6   $��5q�6'   $��1��62   �� 5      $��5q�6S   $��1��6^   ��6   �� *Course+$ PropertyChanged=�6^   �� 5      $��National ID:��6   $��5q�6,   $��1��67   �� 5      $��5q�6W   $��1��6b   $��1��6o   ��6   �� *
NationalID+$ PropertyChanged=�6o   �� 5       $��Enrooll Key:��6   $��5q�6,   $��1��67   �� 5!      $��5q�6V   $��1��6a   $��1��6n   ��6   �� *	EnrollKey+$ PropertyChanged=�6n   �� 5"      $��
Department��6   $��5q�6*   $��1��65   �� 5#      $��5q�6W   $��1��6b   $��1��6o   ��6   �� *
Department+$ PropertyChanged=�6o   �� 5$      $��Email:��6   $��5q�6&   $��1��61   �� 5%      $��5q�6R   $��1��6]   ��6   �� *Email+$ PropertyChanged=�6]   �� 5&      $
��Save��6      	keyButton#��[  6D   $
��0 10q�6g   $��3��6u   $��Bottom=�6�   $��2��6�   ��6$   �� *SaveCommand+6�   5)      5+      5,      