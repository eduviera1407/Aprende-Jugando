   M S B A M L   `   `   `  ����   AprendeJugando    WpfApp1.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     _ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  /wpfGif"http://wpfanimatedgif.codeplex.com  -     � Title$  Aprende Jugando��$
��1080��$
��1920�� � WindowState$ 	Maximized=� � WindowStyle$
 None=� � Topmost$
 True�� � Icon$< 6D:\CLASES\PROYECTO DAM\Prueba2\WpfApp1\Images\LOGO.png�� � 	Resources  
  Flotar �� TargetProperty W� From	 W� To	 g� Duration
 g� AutoReverse g� RepeatBehavior  CargarAnimacion  EscalarLogo��%�  &	        &	 U     &	 �     �� .��W� $ (Canvas.Top)� 414 424$	 0:0:1D�$

 True��$ Forever���� .��W� $9 3(UIElement.RenderTransform).(RotateTransform.Angle)� 0 360$	 0:0:2D�$ Forever���� .��W� $9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)� 1 1.05$	 0:0:1D�$

 True��$ Forever��W� $9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)� 1 1.05$	 0:0:1D�$

 True��$ Forever��.���� -    ��Name$ fondo�� � LayoutTransform �� -   MainScaleTransform������  �� ImageSource$N HD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\fondo.jpg��.+��� -    ��Name$ personajeSonriente��$	��308�� �� Left$
 1019��
 �� Top$	 703��$	��460��$Y��SD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\Personaje\alegre.png���� -   $
 logo��$	��375��$	 579��$ 79��$	��762��z��� -   LogoScaleTransform������  �� 	UriSource$D >D:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\LOGO.png?��� -    ��Name$ botonIniciar��$	 501��$	 414��$	��420��$	��332��$��0q�
������ $|�False������  �� 
TargetType" ��.���  �� Property � �� �� Value ��  �� 
TargetType" ��.R�� .+��� $U��OD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\botonIniciar.png�� �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  �@J�Opacity$	 0.7Q�P�  �@J�IsMouseOver$ False��. ���  �@J�Opacity$ 1Q��� -   $ botonAjustes��$	 960��$	 414��$	��420��$	��332��$��0q�
������ $|�False��$
��Left=�$��Center=����� " ��.���  � �� �� " ��.R�� .+��� $U��OD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\ajustesBoton.png�� P�  �@J�IsMouseOver$
 True��. ���  �@J�Opacity$	 0.7Q�P�  �@J�IsMouseOver$ False��. ���  �@J�Opacity$ 1Q� � -	     �Name$ 	MainFrame��$ 0��$ 0��$
��1920��$
��1080��  � NavigationUIVisibility$ Hidden=�