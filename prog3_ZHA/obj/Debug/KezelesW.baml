   M S B A M L   `   `   `  ����D  @prog3_ZHA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:prog3_ZHA	prog3_ZHA  5   	       prog3_ZHA.KezelesW   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:prog3_ZHA     5   	     � Title$  KezelesW��5   	   $��484.621��6   $	��300��6+   .��5	      �  � 	Resources 5
   
      prog3_ZHA.TAJConverter   
TajKonvert��%   &	          5      6!   5      .+�5   
   �� -   5         ��Name$ label��5      $��Beteg neve:��6   $
��Left=�65   $��	19,10,0,0q�6P   $	��Top=�6c   �� 5   
   -   5        $ label1��5      $
��Left=�68   $��	96,10,0,0q�6S   $	��Top=�6f   ��6    �� *Nev+6f   �� 5   
   -   5        $ label2��5      $��	Életkor:��6    $
��Left=�63   $��	19,36,0,0q�6N   $	��Top=�6a   �� 5   
   -   5        $ label3��5      $
��Left=�6<   $��	96,36,0,0q�6W   $	��Top=�6j   ��6    �� *	Eletkor+6j   �� 5   
   -   5        $ label4��5      $��
TAJ szám:��6    $
��Left=�64   $��	19,67,0,0q�6O   $	��Top=�6b   �� 5   
   -   5        $ label5��5      $
��Left=�6c   $��
96,0,0,356q�6~   $��Bottom=�6�   ��6    �� *	TAJSzam+ �� 	Converter# [  6�   �� 5   
   -   5        $ label6��5      $��Régebbi kezelések:��6    $
��Left=�6=   $��	19,98,0,0q�6X   $	��Top=�6k   �� 5   
   -   5         ��Name$ listBox��5      $
��Left=�6#   $	��100��6>   $��
10,124,0,0q�6K   $	��Top=�6_   $	��272��6w   ��6�   �� *	Kezelesek+��5      �� 5      .R�5      �  � RowDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6    ��6-   �� *BNOKod+�� 5      $��1��6    ��6-   �� *	Jegyzet+5      5      5!      �� 5"   
   -	   5        $ label7��5"      $��	BNO kód:��6    $
��Left=�63   $��
10,239,0,0q�6N   $	��Top=�6b   �� 5#   
   -
   5         ��Name$ BNOcomboBox��5#      $
��Left=�6(   $��
76,243,0,0q�6C   $	��Top=�6W   $	��120��6o   �� 5$   
   -   5        $ label8��5$      $��Jegyzet:��6    $
��Left=�63   $��
19,281,0,0q�6N   $	��Top=�6b   �� 5%   
   -   5         ��Name$ textBox��5%      $
��Left=�6#   $	��106��6>   $��
11,312,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��271��6�   �� 5&   
   -   5        	 ��Name$	 button��5&      $��Mentés��6!   $
��Left=�62   $��107,424,0,0q�6M   $	��Top=�6b   $��75��6z   6�   5(      5)      