   M S B A M L   `   `   `  ����F  BAssignment3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment3Assignment3  5   	       Assignment3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment3     5   	     � Title$  XML Setialization��5   	   $	��650��6#   $	��500��60   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $	��150��6.   �� 5      $��* �6   .+�5   
   �� -   5        $��iDLabel��5      $��0��6!   $��0��6.   $��25, 15q�6@   .��6R   Employee ID:6`   �� 5   
   -   5        $��iDText��5      $��0��6"   $��1��6/   $��25, 15q�6A   ��5   
   �� *
EmployeeID+ �� Mode$ TwoWay=��� 5   
   -   5        $��FirstNameLabel��5      $��1��6(   $��0��65   $��25, 15q�6G   .��6Y   First Name:6f   �� 5   
   -   5        $��FirstNameText��5      $��1��6)   $��1��66   $��25, 15q�6H   ��5    
   �� *	FirstName+$ TwoWay=��� 5"   
   -   5        $��LastNameLabel��5"      $��2��6'   $��0��64   $��25, 15q�6F   .��6X   
Last Name:6d   �� 5#   
   -   5        $��LastNameText��5#      $��2��6(   $��1��65   $��25, 15q�6G   ��5$   
   �� *
LastName+$ TwoWay=��� 5&   
   -   5        $��HomePhoneLabel��5&      $��3��6(   $��0��65   $��25, 15q�6G   .��6Y   Home Phone:6f   �� 5'   
   -   5        $��HomePhoneText��5'      $��3��6)   $��1��66   $��25, 15q�6H   ��5(   
   �� *	HomePhone+$ TwoWay=��� 5*   
   -	   5        $��
NotesLabel��5*      $��4��6$   $��0��61   $��25q�6C   .��6Q   Notes:6Y   �� 5+   
   -
   5        $��	NotesText��5+       �� TextWrapping$
 Wrap=�6%    �� AcceptsReturn . " �� VerticalScrollBarVisibility$
 Auto=�6N   $��4��6q   $��1��6~   $��25q�6�   ��5,   
   �� *Notes+$ TwoWay=��� 5.   
   -   5        $��	SubsLabel��5.      $��5��6#   $��0��60   $��25, 15q�6B   .��6T   Subordinates:6c   �� 5/   
   -   5        $��SubsText��5/      $��5��6$   $��1��61   $��25, 15q�6C   ��50   
   �� *NoOfSubordinates+$ TwoWay=��� 52   
   -   5         ��Name$ CheckBoxXml��52      $��6��6*   $��2��67   $��25, 15q�6K   .��53      �� -   5         ��Name$ 
CheckLabel��53      $��Arial Black)�6*   $"��Open serialized XML Document��6C   54      �� 56   
   $��7��6   $��0��6"   $��2��62   	 �� Padding$	 0,15,0,0q�6F   �� 57      -   5        $��	Serialize��57      $	��190��6B   $��35,0,0,0q�6N    �� 58      -   5        $��Deserialize��58      $	��190��6E   $��40,0,0,0q�6Q   59      5;      5<      