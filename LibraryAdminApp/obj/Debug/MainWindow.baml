   M S B A M L   `   `   `  ����J  FLibraryAdminApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LibraryAdminAppLibraryAdminApp  5   	        LibraryAdminApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:LibraryAdminApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� .@�5      �� $��books��6   .��5      �  � RowDefinitions 5      �� 5      6*   �� 5      $��40 �6(   66   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	BooksGrid��5   >   $��0��6      
IsReadOnly .    HorizontalGridLinesBrush
 �����   RowBackground
 ��ح�   AlternatingRowBackground
 �����5      �� 5      -   5         � Cursor$
 Hand��5      $��14(�6+   
�������$
��Bold"�6S   
����+��$��1��6}   $	��100��6�   $��Right=�6�   .��6�   	Refresh6�   5      5      �� 5      $��add book��6   .��5      � ���#E6E6FA � ColumnDefinitions 5      �� 5      6-   �� 5      6-   .+�5      �� $��Center=�6!   $��0��6<   .+�5      �� $��26(�6$   $
��Bold"�62   $��10q�6D   
����+��$��Center=�6h   Add new book6�   �� 5       -   5        $
 Hand��5    "   $	��150��6B   $	��160��6N   ���#E6E6FA
������ .��5!      �� $(��"C:\Users\ASUS\Downloads\knigga.png��6$   6R   5"      5#      �� 5$      $��Center=�6!   $��1��6<   .+�5%      �� $��26(�6$   $
��Bold"�62   $��10q�6D   
����+��$��Center=�6h   
Edit books6�   �� 5&      -   5        $
 Hand��5&   !   $	��150��6/   $	��160��6P   ���#E6E6FA
������ .��5'      �� $&�� C:\Users\ASUS\Downloads\pero.jpg��6$   6P   5(      5)      5*      5+      5,      5-      5.      