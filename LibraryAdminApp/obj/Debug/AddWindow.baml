   M S B A M L   `   `   `  ����J  FLibraryAdminApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LibraryAdminAppLibraryAdminApp  5   	       LibraryAdminApp.AddWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:LibraryAdminApp     5   	     � Title$  	AddWindow��5   	   $	��475��6   $	��350��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��290 �6   6+   �� 5      6   ��5   
   �� 5       �� Color$ #E6E6FA��6   60   .+�5   
   �� $��0��6   $	��Top=�6"   .+�5      �� $��26(�6   $
��Bold"�6&   $��10q�68   
����+��$��Center=�6\   available author6�   �� 5      $
��10,0q�6   $��16(�6'   $
��Bold"�65   
����+��Author's id:6m   �� 5      -   5         ��Name$ Authors_id_TBox��5      $��	10,0,10,0q�6/   $��18(�6B   6R   �� 5      $
��10,0q�6   $��16(�6&   $
��Bold"�64   
����+��Title:6f   �� 5      -   5        $ 
Title_TBox��5   )   $��	10,0,10,0q�6   $��18(�6=   6M   �� 5      $
��10,0q�6   $��16(�6&   $
��Bold"�64   
����+��Count of books:6o   �� 5      -   5        $ 
Count_TBox��5   *   $��	10,0,10,0q�6   $��18(�6>   6N   �� 5      $
��10,0q�6   $��16(�6&   $
��Bold"�64   
����+��Price:6f   �� 5      -   5        $ 
Price_TBox��5   )   $��	10,0,10,0q�6   $��18(�6=   6M   5      �� 5   
   -   5        $��0��5   (   $��40��65   $	��100��6A   $��14(�6M   
�������$
��Bold"�6u   
����+��$��Right=�6�   $��Bottom=�6�   $��0,0,10,0q�6�   .��6�   
Add book6�   �� 5    
   $��1��6   .+�5!      �� $��26(�6   $
��Bold"�6&   $��10q�68   
����+��$��Center=�6\   
new author6�   �� 5"      $
��10,0q�6   $��16(�6&   $
��Bold"�64   
����+��Author's fullname:6r   �� 5#      -   5        $ Fullname_author_TBox��5#   )   $��	10,0,10,0q�6   $��18(�6G   6W   5$      �� 5%   
   -   5        $��1��5%      $��40��6   $	��100��6*   $��14(�66   
�������$
��Bold"�6w   
����+��$��Right=�6�   $��Bottom=�6�   $��0,0,10,0q�6�   .��6�   
Add author6�   5&      5'      