   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   N JLeviEpcUpcConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:LeviEpcUpcConverter.UIComponents LeviEpcUpcConverter.UIComponents 5      )   #LeviEpcUpcConverter.ConverterWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:LeviEpcUpcConverter.UIComponents     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962a@material1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Levi's EPC-UPC Converter��5
   	   $	��620��6*   $	��800��67    � 
ResizeMode$ NoResize=�6C    � 	Resources 5         theWidth  
leftMargin��%I   &	        &	      X�5   
   550Q�6.   X�5   
   20Q�6/   5      .��5      � $	��790��6   .+�5   
   � $	��Top=�6   $
��Left=�6'   $	��750��6B   ��5      u� 5       u� Left# [ 6   
 u� Top$ 5Q�6?   6I   .+�5      #  MaterialDesignThemes.Wpf.Card  $��40��6   $	��740��6(   
����·�.��5      � .+�5      �� $��maerskLogo.png��6   $	��150��64   $
��Left=�6@   6]   5      5      5      � 5   
   $	��100��6   $	��Top=�6   $
��Left=�65   #��[  6P   ��5      u� 5      $ 50Q�6   # [ 6%   6J   .+�5        $	��Top=�6   $
��Left=�64   #��[  6O   $	��100��6q   .��5      � -   5        $��SummaryGrid��5   9   #��[  6   
����·�.+�5       �� $��Summary File��6   $	��Top=�63   $
��Left=�6K   ��5!      u� 5"      # [ 6(   $ 30Q�6K   6V   5$      �� 5%      -   5        $��SummmaryTextBox��5%   Q   $
��Left=�6   $	��Top=�69   $	��250��6h   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Summary File��5&      .��6F   ��5'      u� 5(      $	 130Q�6(   $ 30Q�63   6>   .��5)   *   5*      �� 5+      -   5        $��BrowseSummaryButton��5+   P   $	��Top=�6   $
��Left=�65   $��Browse��6�   
�����F� � ToolTip$
 Icon��5,      ��5-      u� 5.      $	 410Q�6(   $ 30Q�63   6>   51      53      54      56      � 57   
   $	��410��6   $	��Top=�6   $
��Left=�65   ��58      u� 59      $	 160Q�6   # [ 6&   6K   .+�5;        $	��Top=�6   $
��Left=�64   #��[  6O   $	��410��6q   .��5=      � -   5         �Name$ EpcGrid��5=      #��[  6(   
����·�.+�5?      2  ,LeviEpcUpcConverter.UIComponents.FileBrowser  -   5          Name$ 
EpcBrowser��5?   (   $
��Left=�6<   $	��Top=�6W   ��5@      u� 5A      $ 10Q�6(   $ 0Q�62   6<   5C      �� 5D      -   5        $��AddMoreButton��5E   �   $
��Left=�5D      $	��Top=�6:   $��40��6R   $��40��6]   $ Add More��6i    + 'MaterialDesignFloatingActionLightButton#���  5E      $��+��6a   
�������$��20(�6�   $��Arial Black)�6�   ��5F      u� 5G      $ 70Q�6(   $	 405Q�61   6>   5I      5J      5K      5L      � 5M   
   $	��Top=�6   $
��Left=�6'   $	��550��6B   $	��190��6O   ��5N      u� 5O      $ 50Q�6   $	 580Q�6%   62   .+�5Q   
     $	��180��6   $	��520��6$   $	��Top=�61   
����·�.��5R   
   � $	��Top=�6   .+�5T   
   �� -   5        $��
CheckDigit��5T   F   $
��Left=�6   $	��Top=�6.     MaterialDesignComboBox#���  6X   ��5U      u� 5V      $ 30Q�6   $ 15Q�6%   61   5X      �� 5Y   
   -   5        $��ConvertButton��5Y   -   $��Right=�6   $��Convert��6B   
�����F���5Z      u� 5[      	 u� Right$	 10Q�6   $ 30Q�6(   63   5]      5^      5_      5`      5a      5b      