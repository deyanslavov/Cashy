   M S B A M L   `   `   `  ����D  @Cashy.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Cashy.App	Cashy.App  5      a ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes 5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   
HeaderText  BaseTextBlockStyle �� BasedOn �� Property  ForegroundMainBrush �� Value  TextBoxPlaceholder  	BaseStyle  CashyBlueBrush  FontSizeLarge  LatoRegular �� 
TargetType ��Name J� SnapsToDevicePixels ��Name ��Name	 J� IsHitTestVisible

 � Tag  LatoThin �� Padding 	 ForegroundVeryDarkBrush �� Triggers �� Binding �� RelativeSource �� Value �� Triggers P� Property P� Value �� 
TargetName 
 PasswordBoxStyle�    �Cashy.App.BaseAttachedProperty`2[[Cashy.App.MonitorPasswordProperty, Cashy.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]] �� 	Converter1   +Cashy.App.BooleanToVisibilityValueConverter  SpinningText  FontAwesome �� 	Resources  Key �� TargetProperty W� From	 W� To g� Duration g� RepeatBehavior �� Self �� Path N� EnterActions ��Name  Spin N� ExitActions  �� BeginStoryboardName  MainPageText5  /Microsoft.Windows.Themes.SystemDropShadowChrome!   Color"   CornerRadius# �� Padding$ �� CornerRadius  TooltipBorderBrush  TooltipBackgroundBrush  FontSizeSmall�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      !localclr-namespace:Cashy.App  5      RmwtJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero  5      ,s&clr-namespace:System;assembly=mscorlib  5      %�  &	        7  7  &	 �     7  7  7  7  7  7 	 &	
 �    7  7  7  7  7  7 	 &	 
    7  7  7  &	 �    7  7  '_� �    7  7  7  7 	 �� 5      "  ��6   8   .�5   
   ��  � ��8  6'   �� 5	   
    � ��$ Center=�6.   �� 5
   
    � ��$ Center=�60   �� 5   
    � ��$	 0 6q�6#   5      �� 5      "  ��6'   8   .�5   
   ��  � ��8  6(   �� 5   
    � ��$ 0 0 0 1q�6,   �� 5   
    � ��8  6%   �� 5   
    � ��8  6'   �� 5   
    � ��$ 10q�6$   �� 5   
    � ��$ 0 5 0 5q�6#   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      � .+�5      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5      �� 5      $ placeholder��5!   $   	 .  #��z
 5    $   8�� # z��5#   $   $��Center=�5$   $   #��z��5%   $   8�� ��5'      �� 5(   "   "  ��6(   .�5)   &   ��  � y�$ 	Collapsed=�6C    5*   &   �� 5+   *    66   �� *Text+ �� *TemplatedParent+  6�   .a�5,   .   ��  � y�$ Visible=�6K   5-   +   5/   #   51      52       53      P� 54       � {� .  . �55      �� $ border��68    �@J�Opacity$
 0.56Q�6L   56      P� 57       �@J�IsMouseOver . . �58      �� $ border��6<    � �� �	#FF7EB4EA6P   59      P� 5:       �@J�IsKeyboardFocused . . �5;      �� $ border��6<    � �� �	#FF569DE56P   5<      5>      5@      5A      �� 5D      "  G�6%   8   .�5E   
   ��  � ��8  6(   �� 5F   
    � ��$ 0 0 0 1q�6,   �� 5G   
    � ��8  6%   �� 5H   
    � ��8  6'   �� 5I   
    � ��$ 10q�6$   �� 5J   
    � ��$ 0 5 0 5q�6#   �� 5K   
    �@  Value . 6@   �� 5M   
    � �� 5N      �� 5O      " G�6"   .R�5P      � .+�5Q      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5R      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5S      �� 5U      $ placeholder��5W   $   	 .  #��z
 5V   $   8�� # z��5Y   $   $��Center=�5[   $   #��z��5\   $   8�� y�5Z   $   �� *local:HasTextProperty.Value+   5_      5`       5a      P� 5b       � {� .  . �5c      �� $ border��68    �@J�Opacity$
 0.56Q�6L   5d      P� 5e       �@J�IsMouseOver . . �5f      �� $ border��6<    � �� �	#FF7EB4EA6P   5g      P� 5h       �@J�IsKeyboardFocused . . �5i      �� $ border��6<    � �� �	#FF569DE56P   5j      5l      5n      5o      �� 5r      "  ��6   8   .�5s   
   ��  � ��8  6'   �� 5t   
    � ��$	 ��6!   �� 5u   
    �@J�RenderTransformOrigin$ 0.5, 0.5&�62   �� 5v   
    � z� 5w      �� 5x      6$   5z       5|   
   ���� 5}      Spin .��5~      W� $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5      $ 0X�5�      $	 360X�5�      $ 0:0:2D�5�      $ Forever��5�      5�      5�       5�   
   �� 5�       6   �� # Z $ 	IsVisible� True6l    5�      �� 5�      $ SpinStoryboard��6&   8�� 6<    5�      �� 5�      $  SpinStoryboard��6'   5�      5�      �� 5�      "  ��6!   8   .�5�   
   ��  � ��$ 18(�6%   �� 5�   
    � ��8  6'   �� 5�   
    � ��$ 
ExtraBlack"�6'   �� 5�   
    � ��
 � d �6'   �� 5�   
    � ��$ Center=�60   �� 5�   
    � ��$ Center=�6.   5�      �� 5�      "  _�6   .�5�   
   ��  �@�OverridesDefaultStyle . 62   �� 5�   
    �@_�HasDropShadow . 6*   �� 5�   
    � �� 5�      �� 5�      " _�6"   .R�5�        $
��Shdw��6Z   $! 	#00FFFFFF��61   $" 2,2,2,2��6C    . ._�5�      �� $��Border��6!   $��1q�5�   '   ## z��5�   '   $$ 4��5�   '   8��  8�� #��z��5�   '   #��z��5�   '   ._�5�      �� .+�5�   "   �� #��z��6,   $
��Wrap=�6M   $��5q�6a   8�� 8�� 6�   5�      5�      5�       5�      P� 5�       �@^�HasDropShadow. �5�      �� $
 Shdw��6H    � �� 5�   "   u�5�   &   0,0,5,5q�69   5�      �� 5�      $
 Shdw��6Q    �@ Color 5�   "   ��5�   &   	#71000000��67   5�       5�      ��5�   "   True��62   5�      5�      5�      5�      5�      