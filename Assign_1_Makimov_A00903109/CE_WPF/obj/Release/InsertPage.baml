   M S B A M L   `   `   `  ���� A  =CE_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CE_WPFCE_WPF      CE_WPF.InsertPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:CE_WPF     -     � Title$  
InsertPage��$	��400��$	��600�� � 	Resources    studentViewSource  coursViewSource��%   &	        &	      �� �� .��� .+��� $
��Left=�$��
133,55,0,0q�$
��Wrap=�$��Student��$	��Top=�� -    �Name$ grid1�� � DataContext# [  $
��Left=�$��	21,87,0,0q�$	��Top=� � ColumnDefinitions �� $
��Auto ��� $
��Auto � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��First Mid Name:��$��0��$
��Left=�$��3q�$��1��$��Center=��� -    ��Name$ firstMidNameTextBox��$��1��$
��Left=�$��23��$��3q�$��1��$��Center=�$	��120������ *FirstMidName+ �� Mode$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . �� $��
Last Name:��$��0��$
��Left=�$��3q�$��3��$��Center=��� -   $ lastNameTextBox��$��1��$
��Left=�$��23��$��3q�$��3��$��Center=�$	��120������ *
LastName+$ TwoWay=� . 	 . � -   $ grid2��# [ $
��Left=�$��
292,86,0,0q�$	��Top=� �� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��Title:��$��0��$
��Left=�$��3q�$��2��$��Center=��� -   $ titleTextBox��$��1��$
��Left=�$��23��$��3q�$��2��$��Center=�$	��120������ *Title+$ TwoWay=� . 	 . �� $��Credits:��$��0��$
��Left=�$��3q�$��0��$��Center=��� -   $ creditsTextBox��$��1��$
��Left=�$��23��$��3q�$��0��$��Center=�$	��120������ *	Credits+$ TwoWay=� . 	 . �� $��Grade:��$��0��$
��Left=�$��166,175,0,72.667q�$��0��$��Center=��� -   $ gradeTextBox��$
��Left=�$��23��$��220,177,0,73.667q�$��0��$��Center=�$	��120������ *Grade+$ TwoWay=� . 	 . �� $
��Left=�$��
363,55,0,0q�$
��Wrap=�$��Course��$	��Top=��� -	   
 ��Name$
 	insertBtn��$��Insert��$
��Left=�$��474,315,0,0q�$	��Top=�$��75��