   M S B A M L   `   `   `  ����D  @Group2WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Group2WPF	Group2WPF  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	       Group2WPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Group2WPF     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ PassengerWPF��5
   	   $	��700��6   $
��1200��6+    � 	Resources 5       �� 
TargetType �� Property �� Value��%�  '��       �� 5   
   " ��6   .�5      ��  � ��$ 10q�6'   �� 5       � ��$ 10q�6(   �� 5       � ��$ 16(�6)   �� 5       � ��$	 120��6&   �� 5       � ��$ 40��6'   �� 5       � �� �#007ACC6+   �� 5       � ��
 �����6+   �� 5       � ��
 ���� 6,   �� 5       � ��$
 Left=�64   �� 5       � ��$	 Top=�62   5      5      .��5      � ���#F0F0F0$��20q�6    .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $��	20,00,0,0q�6a   .+�5      �� -   5         ��Name$ 
btnAirline��5      $��Airline��6)   $��50��5      �� 5       -   5        $ 
btnAirport��5       $��Airport��6)   $��50��5!      �� 5"      -   5        $ 	btnLogout��5"      $��Logout��6(   $��
600,10,0,0q�5#      $��50��5$      5%      �� 5(   
   -   5         ��Name$ 	lblpercen��5(      $)��#Increased 10% compared to yesterday��6#   $
��Left=�6Q   $��	20,80,0,0q�6l   $	��Top=�6   $
��Bold"�6�   $��16(�6�   ���	#FF2DD228$��10q�6�   
�������$��1q�6�   #  LiveCharts.Wpf.CartesianChart  5+   
   &   LiveCharts.Wpf.Charts.Base.Chart	   LegendLocation$	 Right=�6A   $��20,130,20,100q�6X   
   Series
 6   �� *SeriesCollection+   AxisY 5-        LiveCharts.Wpf.Axis     Title$ Quantity��6      LabelFormatter 6,   �� *
YFormatter+   AxisX 50        $ Time/Day��6      Labels 6,   �� *Labels+52      �� 55   
   $G��AThe graph shows the number of flight bookings today and yesterday��6   $
��Left=�6\   $��Bottom=�6w   $��50��6�   $	��792��6�   $
��Bold"�6�   $��22(�6�   $��	20,0,0,20q�6�   56      57      