   M S B A M L   `   `   `  ����I  EAprendeJugando, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AprendeJugandoAprendeJugando  5           AprendeJugando.PageAjustes   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      (localclr-namespace:AprendeJugando  5        N� Title$  PageAjustes��5
      .��5      �� -   5         ��Name$ fondo��5      ��5   
   �� 5       �� ImageSource$N HD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\fondo.jpg��6   .+�5   
   �� -   5        $	��187��5      $	��173��6   
������ $��0q�6C   $
��Left=�5      $	��Top=�6     � ToolTip$$ Volver a la pantalla principal��5       �� Left$ 33��5      
������  J� RenderTransformOrigin$ 0.5,0.5&�6F   
 �� Top$ 13��6f   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$
 5.59Q�6&   T� 5      5      ��5      �� 5       �� 
TargetType" ��6   .�5      �� 	 �� Property	 � ��
 �� Value
 5       �� 5!       �� 
TargetType" ��6.   .R�5"   "   � $ 0.5,0.5&�6'   .+�5$   &   �� $S��MD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\botonVacio.png��6,   $	��270��5%   '   $	��212��63   $
��Left=�5&   '   $	��Top=�6B   $��-24,-46,0,0q�6Z   $ 0.5,0.5&�6o   z�5'   *   V� 5(   .   .~�5)   2   �� �� 5*   2   �� 5+   2   $ 1.011Q�6B   T� 5,   2   5-   /   5/   '   '  !MaterialDesignThemes.Wpf.PackIcon  50   &     Name$ botonVolver��6>      Kind$
 Undo=�6S   $��77��51      $	��113��6(   
���   �$ 0.5,0.5&�52      $��	40,16,0,0q�6=   z�53   *   V� 54   .   .~�55   2   �� �� 56   2    �� AngleY$ -9.08Q�6@   �� 57   2   $ 43.415Q�6B   T� 58   2    T� X$ 3.065Q�6E    T� Y$ -12.578Q�6O   59   /   5;   '   5<   #   5=      5?       �� Triggers 5@      P� 5A       P� Property �@J�IsMouseOver P� Value$
 True��69   . �5B      �� 	 �@J�Opacity$	
 0.7Q�68   5C      P� 5D       �@J�IsMouseOver$ False��69   . �5E      �� 	 �@J�Opacity$
 1Q�68   5F      5H      5J      �� 5M   
   $	��616��6   $	��810��6   ���#f2ca47 �� CornerRadius$ 20��6?    �� Padding$ 20q�5N      $	 652��6   $	 135��60   ._�5P      �� .+�5R      ��  �� Orientation$ 
Horizontal=�6   $	��312��66   $��	0,0,300,0q�6B   .+�5S        -   5        $ VolumenIcon��5S   .   $ 
VolumeHigh=�6C   $	��101��6U   $��84��6a   
���   �$��
-20,0,20,0q�6�   5T      �� 5V      -   5         ��Name$ VolumeSlider��5V      $	��500��6/    � Minimum$ 0Q�6;    � Maximum$	 100Q�6G    � Value$ 50Q�6U    �� TickFrequency$ 1Q�5W   	    �� IsSnapToTickEnabled$
 True��6   $��60��66   $��6,40,5,0q�5X   2    �� Orientation$ 
Horizontal=�5Y   	   ��5Z      �� 5[      " ��6    .�5\      �� 	 � ��
 5]   "   �� 5^   &   " ��66   .R�5_   *   � .+�5`   .   �� $��6��68   
���   �$��Center=�6P   ]� 5b   .    ]�Name$ 
PART_Track��64    ]� Thumb 5c   2   n� 5d   6     n�Name$  
PART_Thumb��6<   $��20��6P   $��20��6[   
���   �6g   5g   /   5h   +   5i   '   5k      5l      5n      5r      5s      �� 5t   
   $��Volumen��6   
���   �$��45(�66   $	 761��6D   $	 175��6V   $D��>D:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Assets/#LazyDog)�6g   $
��Left=�6�   $��Center=�6�   $	��297��6�   $��	10,0,20,0q�6�   �� 5v   
   -   5        ! ��Name$! botonAcerdade��5v      $	��425��6(   $	��112��64   
������ $��0q�6Z   
������ $	 652��5w   :   $	 381��6L   $��Center=�5x   	   $	��Top=�6&   $��22(�6>   ��5z      �� 5{      " ��6   .�5|      �� 	 � ��
 5}      �� 5~      " ��6.   .R�5   "   � .+�5�   &   �� -   5        $ 
Horizontal=�5�   1   $��	0,0,-82,0q�6`   .+�5�   *     $ AcerdaDeIco��6B   $ Information=�6W   $��70��6j   $��70��6u   ���	#FF010301$��
10,20,20,0q�6�   �� 5�   *   $�� Acerca del juego��64   
���   �$��45(�6`   $��Center=�6n   $D��>D:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Assets/#LazyDog)�5�   )   $	��395��6u   5�   '   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
 True��69   . �5�      �� 	 �@J�Opacity$	
 0.7Q�68   5�      P� 5�       �@J�IsMouseOver$ False��69   . �5�      �� 	 �@J�Opacity$
 1Q�68   5�      5�      5�      �� 5�   
   -   5        $! btnPantallaCompleta��5�      $	��581��6D   $	��120��6P   
������ $��0q�6v   $
��Left=�5�   
   $	��Top=�6%   $	 648��6=   $	 522��6O   
������ $  Cambiar tamaño de ventana��5�   F   ��5�      �� 5�      " ��6   .�5�      �� 	 � ��
 5�      �� 5�      " ��6.   .R�5�   "   � .+�5�   &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6g   $	��120��6�   $	��581��6�   .+�5�   *     $ 
Fullscreen=�6B   $��70��6T   $��70��6_   
���   �$��Center=�6~   $��	10,0,20,0q�6�   �� 5�   *   " ��Name$" txtPantallaCompleta��64   $��Pantalla Completa��6Q   ���	#FF010301$��45(�6�   $D��>D:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Assets/#LazyDog)�6�   $��Center=�6�   $��	20,0,20,0q�6�   5�   '   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
 True��69   . �5�      �� 	 �@J�Opacity$	
 0.7Q�68   5�      P� 5�       �@J�IsMouseOver$ False��69   . �5�      �� 	 �@J�Opacity$
 1Q�68   5�      5�      5�      �� 5�   
   -   5        $! btnPantallaVentana��5�      $	��581��6C   $	��120��6O   
������ $��0q�6u   $��Center=�5�   
   $	��Top=�6'   $	 652��6?   $	 647��6Q   
������ $  Cambiar tamaño de ventana��5�   E   ��5�      �� 5�      " ��6   .�5�      �� 	 � ��
 5�      �� 5�      " ��6.   .R�5�   "   � .+�5�   &   �� $ 
Horizontal=�61   $��Center=�6J   $��Center=�6g   $	��120��6�   $	��581��6�   .+�5�   *     $ 
DockWindow=�6B   $��70��6T   $��70��6_   
���   �$��Center=�6~   $��	15,0,20,0q�6�   $ 	0.2,0.491&�6�   �� 5�   *   $" txtPantallaVentana��64   $��Ventana��6P   ���	#FF010301$��45(�6v   $D��>D:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Assets/#LazyDog)�6�   $��Center=�6�   $��	20,0,20,0q�6�   5�   '   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
 True��69   . �5�      �� 	 �@J�Opacity$	
 0.7Q�68   5�      P� 5�       �@J�IsMouseOver$ False��69   . �5�      �� 	 �@J�Opacity$
 1Q�68   5�      5�      5�      �� 5�   
   -	   5        # ��Name$# personajeSonriente��5�      $	��449��6,   $	 253��69   $	 519��6K   $	��588��6\   $W��QD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\Personaje\duda.png��5�      $ 0.5,0.5&�6c   z�5�      V� 5�      .~�5�      �� �� 5�      $ 3.765Q�6$   �� 5�      T� 5�      $ 17.934Q�6)   5�      5�      5�      5�      