   M S B A M L   `   `   `  ����D  @prog3_ZHB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:prog3_ZHB	prog3_ZHB  5   	       prog3_ZHB.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:prog3_ZHB     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � 	Resources 5
   
      prog3_ZHB.ArConvert   	ArKonvert   prog3_ZHB.GrammConvert  GrammKonvert!   prog3_ZHB.MaxSzallitConvert  
MaxKonvert    prog3_ZHB.MinSzallitConver  
MinKonvert��%t   &	        &	      &	 &     &	 9       5      6     5      6!     5      6&     5      6%   5      .+�5   
   �� -   5         ��Name$ label��5      $)��#Szállítási mód:                ��6   $
��Left=�5      $��	25,18,0,0q�6-   $	��Top=�6@   �� 5   
   -   5         ��Name$ listBox��5      $
��Left=�6#   $	��238��6>   $��	25,49,0,0q�6K   $	��Top=�6^   $	��482��6v   ��6�   �� *
FutarSzolg+��5      �� 5      .R�5      � $	��455��6    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� 
�������$��0��6J   ��6    �� *Nev+6J   �� 5      $��1��6k   ��6    �� *MinSzallitasNap+ �� 	Converter# [ 6k   �� 5      $��2��6k   ��6    �� *MaxSzallitasNap+# [ 6k   �� 5       $��3��6a   ��6    �� *AlapAr+# [  6a   �� 5!      $��4��6e   ��6    �� *	GrammAr+# [ 6e   5"      5#      5%      �� 5&   
   -   5         ��Name$ button��5&      $��Küldemény...��6!   $
��Left=�68   $��229,292,0,0q�6S   $	��Top=�6h   $��75��6�    �� IsCancel . 6�   5(      5)      