   M S B A M L   `   `   `  ����C  ?Sprint 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Sprint_2Sprint_2  5   	       Sprint_2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Sprint_2     5   	   -   5          � WindowState$  	Maximized=�5   	   $	��400��5	   	   $	��600��5
   	    � Title$ 
MainWindow��5   	   $	��600��6   $	��800��6)   .��5      �� -   5         ��Name$ canvas��5      
���   �.+�5   
   �� -   5        $ mainMenu��5      $y�Visible=�6#   .+�5      �� -   5         ��Name$ selectTrack��5      
���   �
�������$��Select Track��6f   $��17��6}   $��Bottom=�6�    �� Left$	 225��6�   
 �� Top$	 124��6�   �� 5      -   5        $ 	startGame��5      
���   �
�������$	 225��6f   $	 146��6x   .��6�   
Start Game6�   5      �� 5   
   -   5        $ 
gameScreen��5      .+�5      �� -   5         ��Name$ lblangle��5      
�������$y�Hidden=�69   .��6M   	Angle : 06X   �� 5      -   5        $ lblcomputedangle��5      
�������$ 26��6A   $y�Hidden=�6Q   .��6e   	Angle : 06p   5      �� 5   
   -	   5         ��Name$ instructions��5      $ 87��6+   $ 26��6<   $y�Hidden=�6L   .+�5      �� -
   5        $ paused��5      
�������$��75(�6;   $	��276��6I   $��PAUSED��6U   �� 5      -   5        $ lblinstruct��5      
�������$��28(�6A   $ 88��6O   $	 111��6`   $��PRESS SPACE TO UNPAUSE��6q   5      5      5      