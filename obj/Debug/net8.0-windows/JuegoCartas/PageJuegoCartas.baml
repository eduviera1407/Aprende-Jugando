   M S B A M L   `   `   `  ����I  EAprendeJugando, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AprendeJugandoAprendeJugando  5      $    AprendeJugando.PageJuegoCartas   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:AprendeJugando     5      _ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  PageJuegoCartas��5
      .��5      �� -   5         ��Name$ fondo��5      ��5   
   �� 5       �� ImageSource$X RD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\fondoSinArboles.jpg��6   .+�5   
   �� -   5        $	��187��5      $	��173��6   
������ $��0q�6C   $
��Left=�5      $	��Top=�6,    � ToolTip$$ Volver a la pantalla principal��5       �� Left$ 33��5      
������  J� RenderTransformOrigin$ 0.5,0.5&�6S   
 �� Top$ 13��6s   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$
 5.59Q�6&   T� 5      5      ��5      �� 5       �� 
TargetType" ��6   .�5      �� 	 �� Property	 � ��
 �� Value
 5       �� 5!       �� 
TargetType" ��6.   .R�5"   "   � $ 0.5,0.5&�6'   .+�5$   &   �� $S��MD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\botonVacio.png��6,   $	��270��5%   ,   $	��212��68   $
��Left=�5&   ,   $	��Top=�6G   $��-24,-46,0,0q�6_   $ 0.5,0.5&�6t   z�5'   *   V� 5(   .   .~�5)   2   �� �� 5*   2   �� 5+   2   $ 1.011Q�6B   T� 5,   2   5-   /   5/   '   '  !MaterialDesignThemes.Wpf.PackIcon  51   &     Name$ botonVolver��6>      Kind$
 Undo=�6S   $��77��52   >   $	��113��6I   
���   �$ 0.5,0.5&�53   >   $��	40,16,0,0q�6^   z�54   *   V� 55   .   .~�56   2   �� �� 57   2    �� AngleY$ -9.08Q�6@   �� 58   2   $ 43.415Q�6B   T� 59   2    T� X$ 3.065Q�6E    T� Y$ -12.578Q�6O   5:   /   5<   '   5=   #   5>      5@       �� Triggers 5A      P� 5B       P� Property �@J�IsMouseOver P� Value$
 True��69   . �5C      �� 	 �@J�Opacity$	
 0.7Q�68   5D      P� 5E       �@J�IsMouseOver$ False��69   . �5F      �� 	 �@J�Opacity$
 1Q�68   5G      5I      5K      �� 5O   
   -   5         ��Name$ CartaVacia1��5O      $	 537��5Q   
   $	 136��5R   
   
 � Tag$ 0��5S   
   $	��270��5V   
   $	��404��5W   
   $
��Left=�6   $��Center=�62   ��5X      �� 5Y      " ��6   .�5Z      �� 	 � ��
 5[      �� 5\      " ��6.   .R�5]   "   � .+�5_   &   �� $��Center=�67   $��Center=�6T   5`   #   5a      5c       5f      P� 5g       �@J�IsMouseOver$
 True��69   . �5h      �� 	 �@J�Opacity$	
 0.7Q�68   5i      P� 5j       �@J�IsMouseOver$ False��69   . �5k      �� 	 �@J�Opacity$
 1Q�68   5l      5n      ��5r      �� 5s      $Z��TD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\Cartas\cartaVacia.png��6   $��UniformToFill=�5t      5v      �� 5x   
   -   5        $ CartaVacia2��5x      $ 2��5z      $	 537��5}   	   $	 545��6   $	��404��6,   $	��270��69   $
��Left=�6E   $��Center=�6`   ��5~      �� 5      " ��6   .�5�      �� 	 � ��
 5�      �� 5�      " ��6.   .R�5�   "   � .+�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
 True��69   . �5�      �� 	 �@J�Opacity$	
 0.7Q�68   5�      P� 5�       �@J�IsMouseOver$ False��69   . �5�      �� 	 �@J�Opacity$
 1Q�68   5�      5�      ��5�      �� 5�      $Z��TD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\Cartas\cartaVacia.png��6   $��UniformToFill=�5�      5�      �� 5�   
   -   5        $ CartaVacia3��5�      $
 1084��5�   	   $	 136��5�   	   $	��270��5�   	   $ 1��5�   	   $	��404��5�   	   $
��Left=�6   $��Center=�61   ��5�      �� 5�      " ��6   .�5�      �� 	 � ��
 5�      �� 5�      " ��6.   .R�5�   "   � .+�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
 True��69   . �5�      �� 	 �@J�Opacity$	
 0.7Q�68   5�      P� 5�       �@J�IsMouseOver$ False��69   . �5�      �� 	 �@J�Opacity$
 1Q�68   5�      5�      ��5�      �� 5�      $Z��TD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\Cartas\cartaVacia.png��6   $��UniformToFill=�5�      5�      �� 5�   
   -   5        $ CartaVacia4��5�      $ 3��5�   	   $
 1084��5�   	   $	 540��6   $	��404��6-   $	��270��6:   $
��Left=�6F   $��Center=�6a   ��5�      �� 5�      " ��6   .�5�      �� 	 � ��
 5�      �� 5�      " ��6.   .R�5�   "   � .+�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      5�       5�      P� 5�       �@J�IsMouseOver$
 True��69   . �5�      �� 	 �@J�Opacity$	
 0.7Q�68   5�      P� 5�       �@J�IsMouseOver$ False��69   . �5�      �� 	 �@J�Opacity$
 1Q�68   5�      5�      ��5�      �� 5�      $Z��TD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\Cartas\cartaVacia.png��6   $��UniformToFill=�5�      5�      �� 5�   
   -   5        $ CartaVacia5��5�      $
 1251��5�      $	 136��5�      $	��270��5�      $ 1��5�      $y�	Collapsed=�5�      $	��404��5�      $
��Left=�6   $��Center=�65   ��5�      �� 5�      " ��6   .�5�      �� 	 � ��
 5�      �� 5�      " ��6.   .R�5�   "   � .+�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      5�       5     P� 5      �@J�IsMouseOver$
 True��69   . �5     �� 	 �@J�Opacity$	
 0.7Q�68   5     P� 5      �@J�IsMouseOver$ False��69   . �5     �� 	 �@J�Opacity$
 1Q�68   5     5
     .��5     �� $Z��TD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\Cartas\cartaVacia.png��6   $��UniformToFill=�5     5     �� 5  
   -   5        $ CartaVacia6��5     $
 1251��5     $	 545��5     $	��270��5     $ 1��5     $y�	Collapsed=�5     $	��404��5     $
��Left=�6   $��Center=�65   ��5     �� 5     " ��6   .�5     �� 	 � ��
 5     �� 5     " ��6.   .R�5  "   � .+�5!  &   �� $��Center=�67   $��Center=�6T   5"  #   5#     5%      5(     P� 5)      �@J�IsMouseOver$
 True��69   . �5*     �� 	 �@J�Opacity$	
 0.7Q�68   5+     P� 5,      �@J�IsMouseOver$ False��69   . �5-     �� 	 �@J�Opacity$
 1Q�68   5.     50     .��54     �� $Z��TD:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Images\Imagenes\Cartas\cartaVacia.png��6   $��UniformToFill=�55     56     5=     5>     