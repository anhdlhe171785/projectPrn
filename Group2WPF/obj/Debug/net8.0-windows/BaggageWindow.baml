   M S B A M L   `   `   `  ����D  @Group2WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Group2WPF	Group2WPF  5   	       Group2WPF.BaggageWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Group2WPF     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Baggage Management��5	   	   $	��750��6$   $
��1000��61    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius	 �� Triggers
 P� Property P� Value �� 
TargetName��%v  '��       '�� �     '�� �     �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ Segoe UI)�6+   �� 5       � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 14(�6)   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��5   !   #��z��5   !   $ 5��5   !   ._�5      �� $��Center=�6/   $��Center=�6L   5       	 5!      P� 5"      
 �@J�IsMouseOver$
 True��6=   . �5#   "   �� $ border��6)    � �� �	#FF00588A6S   5$      P� 5%      
 � ��$
 True��6;   . �5&   "   �� $ border��6)    � �� �	#FF003E626S   5'      5)      5+      5,      5-      .��5/      � .+�51   
   �� $��Baggage Management��6   $��Center=�6-   $	��Top=�6J   $��0,10,0,0q�6b   $��24(�6t   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  53   
   -   5          Name$ BaggageDataGrid��53         AutoGenerateColumns$ False��6,   $
��Left=�6H   $
��auto��6c   $��306,147,0,0q�6q   $	��Top=�6�   $	��646��6�      CanUserAddRows$ False��54         Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6<      
IsReadOnly$
 True��6H      FontSize$ 14Q�6Z      
FontWeight$
 Bold"�6h      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6z     57      $ 
Booking ID��6C   $ 14Q�6W   $ * 6e    6%   �� *	BookingId+6e     58      $ Weight (kg)��6D   $ 14Q�6Y   $ * 6g    6%   �� *
WeightInKg+6g   5:      �� 5;   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $��Bottom=�6I   $��
45,0,0,122q�6d   .+�5<      �� -   5        $��First��5<      $��5q�6C   �� 5=      -   5        $��Previous��5=      $��5q�6I   �� 5>      $��Center=�69   $
��10,0q�6T   ��6   �� *CurrentPageText+6T   �� 5?      -   5        $
��Next��5?      $��5q�6A    J� RenderTransformOrigin$ 0.5,0.5&�6L   z�5@      V� 5A      .~�5B      �� �� 5C      �� 5D       �� Angle$ 0.521Q�6*   T� 5E      5F      5H      �� 5I      -   5        $
��Last��5I      $��5q�6A   5J      �� 5L   
   $
��ID :��6   $
��Left=�6   $	��Top=�6:   $��
20,139,0,0q�6R   $ 0.5,0.5&�6f   $��50��6�   �� 5M   
   -   5         ��Name$ 	IdTextBox��5M      $
��Left=�6%   $	��Top=�6@   $	��188��6X   $��104,147,0,0q�6d   $��21��6y   �� 5O   
   $��Booking ID:��6   $
��Left=�6&   $	��Top=�6A   $��
16,242,0,0q�6Y   $ 0.592,0.218&�6m   �� 5P   
   -   5         ��Name$ BookingIdComboBox��5P      $
��Left=�6.   $	��Top=�6I   $	��188��6a   $��104,251,0,0q�6m    �� DisplayMemberPath$ Id��6�    �� SelectedValuePath$ Id��6�   $��20��6�   �� 5R   
   $��Weight (kg):��6   $
��Left=�6'   $	��Top=�6B   $��
14,349,0,0q�6Z   $ 0.447,4.579&�6n   �� 5S   
   -   5        $ WeightInKgTextBox��5S      $
��Left=�6-   $	��Top=�6H   $	��188��6`   $��104,349,0,0q�6l   $ 0.499,-3.238&�6�   $��25��6�   6�   �� 5U   
   -	   5        $	��Add��5U      $
��Left=�6   $	��Top=�6:   $��75��6R   $��306,671,0,0q�6]   ���	#FF007ACC6�   �� 5V   
   -
   5        $
��Edit��5V      $
��Left=�6    $	��Top=�6;   $��75��6S   $��425,671,0,0q�6^   ���	#FF28A7456�   �� 5W   
   -   5        $��Delete��5W      $
��Left=�6"   $	��Top=�6=   $��75��6U   $��554,671,0,0q�6`   ���	#FFDC35456�   �� 5X   
   -   5        $��Reset��5X      $
��Left=�6!   $	��Top=�6<   $��75��6T   $��706,671,0,0q�6_   ���	#FF6C757D6�   �� 5Y   
   -   5        $��Close��5Y      $
��Left=�6!   $	��Top=�6<   $��75��6T   $��825,671,0,0q�6_   ���	#FF343A406�   5Z      5[      