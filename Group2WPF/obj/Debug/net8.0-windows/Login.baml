   M S B A M L   `   `   `  ����D  @Group2WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Group2WPF	Group2WPF  5   	       Group2WPF.Login   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Group2WPF     5   	   
���   �$��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   $��Segoe UI)�5   	    � WindowStyle$
 None=�5   
    � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Login��5   	   $	��450��6   $	��800��6$   ��5      �� 5   
    �� ImageSource$" D:\FU\PRN212\Fly\img\bay.jpg��6    j� Stretch$ UniformToFill=�6@    J� Clip 5      �� 5   
   	 �� Rect$	 0,0,900,500�6   
 �� RadiusX$
 10Q�6/    �� RadiusY$ 10Q�6<   -   5        	boGoc��5      .��5      � .+�5   
   �� -   5         ��Name$ 	btn_Close��5   (   $��65��6   $��60��6   $��Right=�5      $	��Top=�6-   
������ $��0q�5       � ToolTip$ Close��6%    5      �� 5      $	 	0,0,65,50�6$   $
 20Q�65   $ 20Q�6B   .��5!      �� $��X��6   $��24(�6!   
������� J� Opacity$	 0.7Q�6B   $��Center=�6P   $��Center=�6m   5"      �� 5$   
   $	��238��6   $	��325��6   ���#FFFFFF �� CornerRadius$ 10��6?   $	��Top=�5%      $
��Left=�6)   $��
100 80 0 0q�5&      ._�5'      � .+�5)      �� $��35��6   $
��Bold"�6(   $��30(�6:   ���#0056FC$��Center=�5*      $	��Top=�69   $��0,30,0,0q�6Q   $	��108��6c   LOG IN6w   �� 5,      $��UserName��6   $
��Left=�6,   $	��Top=�6G   $��19��5-      $��46��6(   $��	5,114,0,0q�5.      �� 5/      $��Password��6   $
��Left=�6,   $	��Top=�6G   $��19��50      $��46��6(   $��	5,160,0,0q�51      � 54      $��
55,107,0,0q�6   $��26��6+   $	��130��67   $
��Left=�6C   $	��Top=�6^   .+�55      �� -   5         ��Name$ txbTenDangNhap��55      $��Center=�66   �� 56      $��Tên đăng nhập��6    
�������$��Center=�6G    J� IsHitTestVisible$ False��6b   $��5,0,0,0q�57      y�6)   �� *Text+ �� ElementName$ txbTenDangNhap��    BooleanToVisibilityConverter �� 	Converter# [  58      � 5;      $��
55,154,0,0q�6   $��26��6+   $	��130��67   $
��Left=�6C   $	��Top=�6^   .+�5<      G� -   5         G�Name$ 
txbMatKhau��5<   "   $��Center=�66   �� 5=      $��Mật khẩu��6    
�������$��Center=�6B   $
 true��6]   $��5,0,0,0q�5>      y�6)   �� *
Password+$ 
txbMatKhau��# [  5?      �� 5C      -   5        $��28��5C      $	��107��6%   ���#0056FC$
��Left=�5D      $	��Top=�64   $��
63,240,0,0q�5E       5F      �� 5G      $	 
0,0,107,28�6,   $
 10Q�6>   $ 10Q�6K   .��5I      �� $��Login��6    $��15(�6-   
�������6;   5J      5K      5L      5M      5N      