   M S B A M L   `   `   `  ����A  =MyGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyGameMyGame  5          MyGame.BullsAndCows   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:MyGame     5      -   5          � Title$  BullsAndCows��5	      $	��500��6   $	��500��6)    � Icon$&  /MyGame;component/Images/Cow.png��65   .��5
      � -   5        $��GameGrid��5
      .+�5   
   �� $.��(/MyGame;component/Images/BackGround2.png��6   $��-155,-10,-153,-20q�6B   �� 5   
   $'��!/MyGame;component/Images/Cow1.png��6   $��-35,65,317,285q�6;   �� 5   
   -   5        $
��Cow2��5   ;   $'��!/MyGame;component/Images/Cow2.png��6   $��-15,65,327,275q�6G    J� Opacity$ 0Q�6_   �� 5   
   -   5        $��
OpacityBtn��5      $ 0Q�6#   $��25,70,377,300q�6/   6G   �� 5   
   $)��#/MyGame;component/Images/Stand1.png��6   $��135,400,257,-5q�6=   �� 5   
   $)��#/MyGame;component/Images/Stand1.png��6   $��15,400,377,-5q�6=   �� 5   
   $)��#/MyGame;component/Images/Stand1.png��6   $��250,400,142,-5q�6=   �� 5   
   $)��#/MyGame;component/Images/Stand1.png��6   $��370,400,22,-5q�6=   o� 5   
   $��16(�6   $��10q�6   $��
0,0,-3,415q�6*   .@�5      m� -   5        $��New game��5      6)   m� 5      -   5        $��Progress��5      6*   m� 5      -   5        $��	Reference��5      6+   5         MyGame.ImageOfBall  5   
   -   5          Name$ B3��5         MyGame.ImageOfBall   Drop$ Target��6�   $,��&/MyGame;component/Images/red-ball0.png��6(   $��270,385,162,30q�6X    J� 	AllowDrop . $ 0Q�6�      number$ -1��6�     5   
   -	   5        $ B4��5      $ Target��6�   $,��&/MyGame;component/Images/red-ball0.png��6(   $��385,385,42,30q�6X    . $ 0Q�6�   $ -1��6�     5   
   -
   5        $ B2��5      $ Target��6�   $,��&/MyGame;component/Images/red-ball0.png��6(   $��155,385,277,30q�6X    . $ 0Q�6�   $ -1��6�     5   
   -   5        $ B1��5      $ Target��6�   $,��&/MyGame;component/Images/red-ball0.png��6(   $��35,380,397,25q�6X    . $ 0Q�6�   $ -1��6�     5!   
   -   5        $ Ball2��5!      $ Target��6�   $,��&/MyGame;component/Images/red-ball2.png��6+   $��415,225,12,180q�6[   $ 2��6s    .    initialSourse$, &/MyGame;component/Images/red-ball2.png��6�      initialNumber$ 2��6�     5"   
   -   5        $ Ball4��5"      $ Target��6�   $,��&/MyGame;component/Images/red-ball4.png��6+   $��415,115,12,285q�6[   $ 4��6s    . $, &/MyGame;component/Images/red-ball4.png��6�   $ 4��6�     5#   
   -   5        $ Ball0��5#      $ Target��6�   $,��&/MyGame;component/Images/red-ball0.png��6+   $��355,120,72,290q�6[   $ 0��6s    . $, &/MyGame;component/Images/red-ball0.png��6�   $ 0��6�     5$   
   -   5        $ Ball6��5$      $ Target��6�   $,��&/MyGame;component/Images/red-ball6.png��6+   $��355,65,72,345q�6[   $ 6��6r    . $, &/MyGame;component/Images/red-ball6.png��6�   $ 6��6�     5%   
   -   5        $ Ball8��5%      $ Target��6�   $,��&/MyGame;component/Images/red-ball8.png��6+   $��230,65,197,345q�6[   $ 8��6s    . $, &/MyGame;component/Images/red-ball8.png��6�   $ 8��6�     5&   
   -   5        $ Ball1��5&      $ Target��6�   $,��&/MyGame;component/Images/red-ball1.png��6+   $��415,285,12,120q�6[   $ 1��6s    . $, &/MyGame;component/Images/red-ball1.png��6�   $ 1��6�     5'   
   -   5        $ Ball3��5'      $ Target��6�   $,��&/MyGame;component/Images/red-ball3.png��6+   $��415,170,12,230q�6[   $ 3��6s    . $, &/MyGame;component/Images/red-ball3.png��6�   $ 3��6�     5(   
   -   5        $ Ball5��5(      $ Target��6�   $,��&/MyGame;component/Images/red-ball5.png��6+   $��415,65,12,345q�6[   $ 5��6r    . $, &/MyGame;component/Images/red-ball5.png��6�   $ 5��6�     5)   
   -   5        $ Ball7��5)      $ Target��6�   $,��&/MyGame;component/Images/red-ball7.png��6+   $��295,65,132,345q�6[   $ 7��6s    . $, &/MyGame;component/Images/red-ball7.png��6�   $ 7��6�     5*   
   -   5        $ Ball9��5*      $ Target��6�   $,��&/MyGame;component/Images/red-ball9.png��6+   $��165,65,262,345q�6[   $ 9��6s    . $, &/MyGame;component/Images/red-ball9.png��6�   $ 9��6�   �� 5,   
   -   5        $��TableOfResults��5,      $��120,175,140,100q�6(   	 �� 
IsReadOnly	 . "
 �� VerticalScrollBarVisibility$

 Auto=�6S    �� TextWrapping$
 Wrap=�6v    �� TextDecorations$  {�6�   
��� d �
��� ������	#FFBCDCA5 �� TextAlignment$ Center=�6�   $��14(�6�    � Cursor$  ��6  $
��Bold"�6  �� 5-   
   $*��$/MyGame;component/Images/Kolokol.png��6   $��100,160,352,250q�6@   �� 5.   
   $*��$/MyGame;component/Images/Kolokol.png��6   $��100,340,352,70q�6@   �� 5/   
   $*��$/MyGame;component/Images/Kolokol.png��6   $��325,340,127,70q�6@    J� RenderTransformOrigin$ 0.958,0.477&�6X   z�50      V� 51      .~�52      �� �� 53      �� 54       �� Angle$ -46.094Q�6&   T� 55       T� X$ -7.933Q�6)    T� Y$ -13.773Q�64   56      58      �� 59   
   $*��$/MyGame;component/Images/Kolokol.png��6   $��325,160,127,250q�6@   $ 0.958,0.477&�6Y   z�5:      V� 5;      .~�5<      �� �� 5=      �� 5>      $ -47.526Q�6&   T� 5?      $ -7.933Q�6)   $ -13.773Q�64   5@      5B      5D      5E      