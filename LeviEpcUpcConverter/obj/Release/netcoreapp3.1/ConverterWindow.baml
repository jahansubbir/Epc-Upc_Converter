   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  N JLeviEpcUpcConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:LeviEpcUpcConverter.UIComponents LeviEpcUpcConverter.UIComponents )   #LeviEpcUpcConverter.ConverterWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     9System&clr-namespace:System;assembly=mscorlib     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @local.clr-namespace:LeviEpcUpcConverter.UIComponents     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962a@material1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Levi's EPC-UPC Converter��$	��620��$	��800�� � 
ResizeMode$ NoResize=� � 	Resources    theWidth  
leftMargin��%-   &	        &	      X�550Q�X�20Q�.��� $	��790��.+�� $	��Top=�$
��Left=�$	��750����u�  u� Left# [ 
 u� Top$ 5Q�.+�#  MaterialDesignThemes.Wpf.Card  $��40��$	��740��
����·�.��� .+��� $��maerskLogo.png��$	��150��$
��Left=�� $	��100��$	��Top=�$
��Left=�#��[  ��u� $ 50Q�# [ .+�  $	��Top=�$
��Left=�#��[  $	��100��.��� -   $��SummaryGrid��#��[  
����·�.+��� $��Summary File��$	��Top=�$
��Left=���u� # [ $ 30Q��� -   $��SummmaryTextBox��$
��Left=�$	��Top=�$	��250��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Summary File��.����u� $	 130Q�$ 30Q�.���� -   $��BrowseSummaryButton��$	��Top=�$
��Left=�$��Browse��
�����F� � ToolTip$
 Icon����u� $	 410Q�$ 30Q�� $	��410��$	��Top=�$
��Left=���u� $	 160Q�# [ .+�  $	��Top=�$
��Left=�#��[  $	��410��.��� -    �Name$ EpcGrid��#��[  
����·�.+�2  ,LeviEpcUpcConverter.UIComponents.FileBrowser  -     Name$ 
EpcBrowser��$
��Left=�$	��Top=���u� $ 10Q�$ 0Q��� -   $��AddMoreButton��$
��Left=�$	��Top=�$��40��$��40��$ Add More�� + 'MaterialDesignFloatingActionLightButton#���  $��+��
�������$��20(�$��Arial Black)���u� $ 70Q�$	 405Q�� $	��Top=�$
��Left=�$	��550��$	��190����u� $ 50Q�$	 580Q�.+�  $	��180��$	��520��$	��Top=�
����·�.��� $	��Top=�.+��� -   $��
CheckDigit��$
��Left=�$	��Top=�  MaterialDesignComboBox#���  ��u� $ 30Q�$ 15Q��� -   $��ConvertButton��$��Right=�$��Convert��
�����F���u� 	 u� Right$	 10Q�$ 30Q�