   M S B A M L   `   `   `  ����E  AsaveThePig, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:saveThePig
saveThePig  5   	       saveThePig.intro   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:saveThePig     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ intro��5	   	   $	��810��6   $
��1200��6$    � 	Resources 5       �� Source�� 5   
   $ Dictionary.xaml?�6   %    .��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $	��300 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5!      $��* �6   �� 5#      $��* �6   .+�5(   
   �� $0��*/Img/complete_intro_background_no_logo.png��6   $��3��6D   $��0��6X   $��0��6h   $��5��6u   $��-126,-20,-132,-144q�6�   �� 5*   
   $��1��6   $��3��6"   $��329,0,317,10q�66   $��2��6L   .+�5+      �� -   5        $��
funkyArrow��5+      $��Img/LOGO_SAVE_THE_PIG.png��6&   $
��15,0q�6I    J� RenderTransformOrigin$ 0.5,0.5&�6W   z�5,      �� 5-      -   5        scaleTransform�� �� ScaleX$
 0.98Q�5-   =    �� ScaleY$
 1.02Q�6K   	 � Triggers	 5/      :� 50      
 :� RoutedEvent$
 Image.Loaded��6#   .[�51      �� .��52      �� .��53   "   W�  �� 
TargetName$ scaleTransform��62    �� TargetProperty$ ScaleX�54   *    W� From$
 0.98X�55   *   	 W� To$
 1.02X�66    g� Duration$ 0:0:0.5D�6@    g� AutoReverse .  g� RepeatBehavior$ Forever��56   =   W� 57   "   $ scaleTransform��62   $ ScaleY�58   *   $
 0.98X�59   *   $
 1.02X�66   $ 0:0:0.5D�6@    . $ Forever��5:   =   5;      5<      5=      5?      5@      �� 5D   
   $��Enter your Name:��5E      
���   �
������ $��2��5H      $��28(�5I      $��
UltraBlack"�5J      $��Center=�5K      $��Center=�5L      $��371,62,72,85q�5M      $��AR CENA)�5N      $	��352��6"   $��55��6.   $��2��6:   $��2��6N    J� Effect 5P      3  -System.Windows.Media.Effects.DropShadowEffect  5Q         ShadowDepth$ 6Q�5R         	Direction$	 170Q�5S         Color$ White��5T         Opacity$	 0.9Q�5U         
BlurRadius$ 2Q�5V      5X      �� 5[   
   -   5        $��playerTextBox��5[   /   $��2��6   $��1��6   $��167,53,357,97q�6D   $��2��6[   $��2��6o   
�����_�$��4q�6�   �� 5^   
   -   5        $��button1��5^   g   
������ $��0q�6+   $��96��6?   $
��Left=�6K   $	��Top=�6v   $	��285��6�   $��	53,22,0,0q�6�   $��3��6�   $��1��6�   $��2��6�   .��5_      �� $��Img/join_btn.png��6   60   5`      5b      5c      