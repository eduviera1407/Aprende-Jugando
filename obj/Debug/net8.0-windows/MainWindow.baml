   M S B A M L   `   `   `  ����  AprendeJugando    WpfApp1.MainWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      /wpfGif"http://wpfanimatedgif.codeplex.com  5      -   5          � Title$  Aprende Jugando��5      $
��1080��6   $
��1920��6+    � WindowState$ 	Maximized=�5       � WindowStyle$
 None=�6    � Topmost$
 True��60    � Icon$< 6D:\CLASES\PROYECTO DAM\Prueba2\WpfApp1\Images\LOGO.png��5	       � 	Resources 5       
  Flotar �� TargetProperty W� From	 W� To	 g� Duration
 g� AutoReverse g� RepeatBehavior  Flotar2  CargarAnimacion  EscalarLogo��%�  &	        &	 �     &	 L    &	 �    �� 5   
   .��5      W� $ (Canvas.Top)�5       4145       4245      $	 0:0:1D�5      $

 True��5      $ Forever��5      5      �� 5   
   .��5      W� $ (Canvas.Top)�5   
    6385   
    6485   
   $	 0:0:1D�5   
   $

 True��5   
   $ Forever��5   
   5      �� 5   
   .��5       W� $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5!       05"       3606   $	 0:0:2D�6   $ Forever��60   5#      �� 5%   
   .��5&      W� $9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�5'       15(       1.056   $	 0:0:1D�6    $

 True��5)      $ Forever��6    W� 5*      $9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�5+       15,       1.056   $	 0:0:1D�6    $

 True��5-      $ Forever��6    5.      5/      .��51      �� -   5         ��Name$ fondo��51       � LayoutTransform 53   
   �� 54      -   5        MainScaleTransform��54      ��57   
   �� 58       �� ImageSource$N HD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\fondo.jpg��6   .+�5;   
   �� -   5         ��Name$ personajeSonriente��5;      $	��308��6,    �� Left$
 1019��69   
 �� Top$	 703��6L   $	��460��6]   $Y��SD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\Personaje\alegre.png��5<      �� 5?   
   -   5        $
 logo��5?      $	��375��6   $	 579��6+   $ 79��6=   $	��762��6M   z�5@      �� 5A      -   5        LogoScaleTransform��5A   !   ��5D      �� 5E       �� 	UriSource$D >D:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\LOGO.png?�6   5G      �� 5J   
   -   5         ��Name$ botonIniciar��5J      $	 501��6'   $	 414��69   $	��420��5K   ,   $	��332��68   $��0q�5L      
������ $|�False��5M      ��5N      �� 5O       �� 
TargetType" ��6   .�5P      ��  �� Property � �� �� Value 5Q      �� 5R       �� 
TargetType" ��6.   .R�5S   "   � .+�5T   &   �� $U��OD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\botonIniciar.png��6,   5U   #   5V      5X       �� Triggers 5Y      P� 5Z       P� Property �@J�IsMouseOver P� Value$
 True��69   . �5[      ��  �@J�Opacity$	 0.7Q�68   5\      P� 5]       �@J�IsMouseOver$ False��69   . �5^      ��  �@J�Opacity$ 1Q�68   5_      5a      5c      �� 5e   
   -   5        $ botonAjustes��5e      $	 960��6'   $	 414��69   $	��420��5f   ,   $	��332��68   $��0q�5g      
������ $|�False��5h      $
��Left=�6#   $��Center=�6>   ��5i      �� 5j      " ��6   .�5k      ��  � �� 5l      �� 5m      " ��6.   .R�5n   "   � .+�5o   &   �� $U��OD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\ajustesBoton.png��6,   5p   #   5q      5s       5t      P� 5u       �@J�IsMouseOver$
 True��69   . �5v      ��  �@J�Opacity$	 0.7Q�68   5w      P� 5x       �@J�IsMouseOver$ False��69   . �5y      ��  �@J�Opacity$ 1Q�68   5z      5|      5~      �� 5   
   -	   5        $ 
botonSalir��5      $	 750��6%   $	 638��67   $	��420��5�   "   $	��332��6.   $��0q�5�   	   
������ $|�False��5�   	   $
��Left=�6   $	��Top=�66   ��5�      �� 5�      " ��6   .�5�      ��  � �� 5�      �� 5�      " ��6.   .R�5�   "   � .+�5�   &   �� $S��MD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\botonSalir.png��6,   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
 True��69   . �5�      ��  �@J�Opacity$	 0.7Q�68   5�      P� 5�       �@J�IsMouseOver$ False��69   . �5�      ��  �@J�Opacity$ 1Q�68   5�      5�      5�       � 5�   
   -
   5          �Name$ 	MainFrame��5�      $ 0��6#   $ 0��63   $
��1920��6B   $
��1080��6O     � NavigationUIVisibility$ Hidden=�5�      6'   5�      5�      