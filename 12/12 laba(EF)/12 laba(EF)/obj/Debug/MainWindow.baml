   M S B A M L   `   `   `  ����F  B12 laba(EF), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:_12_laba_EF__12_laba_EF_  5   	       _12_laba_EF_.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:_12_laba_EF_     5   	   MCustom@http://schemas.microsoft.com/winfx/2006/xaml/presentation/ribbon  5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)   .��5
      � .+�5   
   �� -   5         ��Name$ TeamName��5      $
��Left=�6$   $��23��6?   $��	24,38,0,0q�6K   $��Team name here��6^   $	��Top=�6t   $	��120��6�    J� RenderTransformOrigin$ 
0.242,0.13&�6�   �� 5   
   -   5        $ 	TeamColor��5      $
��Left=�6%   $��23��6@   $��
171,38,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $��
Color here��6t   $	��Top=�6�   $	��111��6�   4  .Microsoft.Windows.Controls.Ribbon.RibbonButton  5   
   -   5          Name$ AddTeam��5      $��5q�6/   
������   Label$ Add this team��6S   $	��100��6i   $��30��6u   $��313,33,104,256q�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	TeamsGrid��5   /      AutoGenerateColumns .  $
��Left=�6B   $	��201��6]   $��	24,78,0,0q�6j   $	��Top=�6}   $	��483��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	Team name��6B   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 110 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
TeamName+6U     5      $	 Color��6@   $
 70 6O    6%   �� *TColor+6O   5        5   
   -   5        $ DeleteT��5      
�������$ Delete��6F   $	��100��6U   $��25��6a   $��10,284,407,10q�6m   6�     5   
   -   5        $ Update��5      
�������$ Update��6E   $	��100��6T   $��25��6`   $��407,284,10,10q�6l   6�     5   
   -   5        $ _selectColor��5      $ tr��64   $��20��6?   $��25��6J   
�������$��418,36,79,258q�6m   6�     5   
   -   5        $
 _sql��5      $	 sql��6,   $��30��68   $��25��6C   
�������$��456,36,31,258q�6b   6y   5      5      