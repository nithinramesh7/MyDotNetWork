   M S B A M L   `   `   `  ����G  CInterestCalc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:InterestCalcInterestCalc  5   	       InterestCalc.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:InterestCalc     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ShowGridLines .  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��2* �6   .+�5   
   �� $��Interest Calculator��6    �� TextAlignment$ Center=�5      $��20(�5      $
��Bold"�5      $��0��5      $��4��5      �� 5    
   -   5         ��Name$ statusLabel��5    +   
�������$��Ready��6@   �� 5$   
   $��	Principal��6   $ Center=�6%   $��1��6<   �� 5%   
   -   5         ��Name$ principalTextBox��5%      $��1��6,   $��1��69   �� 5'   
   $��	Rate (pa)��6   $ Center=�6%   $��2��6<   �� 5(   
   -   5        $ rateTextBox��5(      $��2��6'   $��1��64   �� 5*   
   $��Period (months)��6   $ Center=�6+   $��3��6B   �� 5+   
   -   5        $ periodTextBox��5+      $��3��6)   $��1��66   �� 5-      �� 5.   
   -   5        $��	Calculate��5.   +   $��4��6?   �� 50   
   $��Interest��6   $ Center=�6$   $��5��6;   �� 51   
   -   5        $ interestTextBox��51       �� 
IsReadOnly . $��5��6=   $��1��6J   �� 53   
   $��Amount��6   $ Center=�6"   $��6��69   $��Center=�6F   �� 54   
   -   5        $ amountTextBox��54       . $��6��6;   $��1��6H   5;      5<      