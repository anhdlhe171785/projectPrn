   M S B A M L   `   `   `  ����D  @Group2WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Group2WPF	Group2WPF  5   	   %    Group2WPF.BookingPlatformWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Group2WPF     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Booking Platform��5	   	   $	��750��6"   $
��1000��6/    � 	Resources 5       �� 
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
   �� $��Booking Platform��6   $��Center=�6+   $	��Top=�6H   $��0,10,0,0q�6`   $��24(�6r   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  53   
   -   5          Name$ DataGrid��53         AutoGenerateColumns$ False��6%   $
��Left=�6A   $	��483��6\   $��306,147,0,0q�6i   $	��Top=�6~   $	��646��6�      Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6<      
IsReadOnly$
 True��6H      FontSize$ 14Q�6Z      
FontWeight$
 Bold"�6h      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6z     56      $
 Name��6>   $ 14Q�6L   $ * 6Z    6%   �� *Name+6Z     57      $	 URL��6=   $ 14Q�6J   $ * 6X    6%   �� *Url+6X   59      �� 5;   
   -   5         ��Name$ 	IdTextBox��5;      $
��Left=�6%   $	��Top=�6@   $	��200��6X   $��
75,147,0,0q�6d   �� 5=   
   $��Name:��6   $
��Left=�6    $	��Top=�6;   $��
16,242,0,0q�6S    J� RenderTransformOrigin$ 0.592,0.218&�6g   �� 5>   
   -   5        $ NameTextBox��5>      $
��Left=�6'   $	��Top=�6B   $	��200��6Z   $��
75,250,0,0q�6f   �� 5@   
   $
��URL:��6   $
��Left=�6   $	��Top=�6:   $��
20,347,0,0q�6R   $ 0.447,4.579&�6f   �� 5A   
   -   5        $ 
UrlTextBox��5A      $
��Left=�6&   $��Center=�6A   $	��200��6\   $��75,0,0,0q�6h   $ 0.499,-3.238&�6z   �� 5C   
   -   5        $	��Add��5C      $
��Left=�6   $	��Top=�6:   $��75��6R   $��306,671,0,0q�6]   ���	#FF007ACC$ -2.876,3.833&�6�   �� 5D   
   -   5        $
��Edit��5D      $
��Left=�6    $	��Top=�6;   $��75��6S   $��425,671,0,0q�6^   ���	#FF28A7456�   �� 5E   
   -   5        $��Delete��5E      $
��Left=�6"   $	��Top=�6=   $��75��6U   $��554,671,0,0q�6`   ���	#FFDC3545$ 
0.189,0.38&�6�   �� 5F   
   -   5        $��Reset��5F      $
��Left=�6!   $	��Top=�6<   $��75��6T   $��706,671,0,0q�6_   ���	#FF6C757D$ -0.069,0.613&�6�   �� 5G   
   -	   5        $��Close��5G      $
��Left=�6!   $	��Top=�6<   $��75��6T   $��850,671,0,0q�6_   ���	#FF343A406�   �� 5I   
   $��Filter By Name:��6   $
��Left=�6*   $	��Top=�6E   $��306,113,0,0q�6]   �� 5J   
   -
   5        $ FilterTextBox��5J      $
��Left=�6)   $	��Top=�6D   $	��200��6\   $��500,113,0,0q�6h   $ 0.497,-0.987&�6�   �� 5K   
   $
��ID :��6   $
��Left=�6   $	��Top=�6:   $��
20,139,0,0q�6R   $ 0.5,0.5&�6f   $��50��6�   5L      5M      