   M S B A M L   `   `   `  ����D  @WpfAppITP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfAppITP.VistasWpfAppITP.Vistas  5      #    WpfAppITP.Vistas.VistaAlumnos   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WpfAppITP.Vistas     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� .+�5      �� $��3q�6   $��Nombre:��6   $��25(�5      
���   �$��Arial)�5      �� 5      -   5         ��Name$	 nom��5      $��3q�5      $
��Auto��6!   $��45��5      $��25(�6"    �� 	IsEnabled .  � Language$ es-ES�5       � ToolTip$  Ingrese el nombre completo��5      ��5      �� *Nombre+5      �� 5      $��3q�6   $��Correo:��6   $��25(�5      
���   �$��Arial)�5      �� 5      -   5        $	 cor��5"      $��3q�5      $
��Auto��6!   $��45��5      $��25(�6"    . $ es-ES�5      $# Ingrese el correo electronico��5       ��5!      �� *Correo+5"      �� 5$      $��3q�6   $��	Telefono:��6   $��25(�5%      
���   �$��Arial)�5&      �� 5'      -   5        $	 tel��5-      $��3q�5'      $
��Auto��6!   $��45��5(      $��25(�6"    . $ es-ES�5*      $ Ingrese el Telefono��5+      ��5,      �� *
Telefono+5-      �� 5.       �� Orientation$ 
Horizontal=�6   .+�5/      �� $��Envia��6   $	��180��6)   $
��Left=�50      $��3q�51      $��10q�52      �� 53      $��Consulta��6   $	��180��6,   $��Right=�54      $��3q�55      $��10q�56      57      �� 58      $ 
Horizontal=�6   .+�59      �� -   5        $��Modifica��59      $	��180��6,   $
��Left=�5:      $��3q�5;      $��10q�5<      5=      �� 5>      $��Elimina��6   $	��180��6+   $��Right=�5?      $��3q�5@      $��10q�5A      5B      5C      �� 5D   
   $��1��6   $��0��5E      .+�5F      �� -   5         ��Name$ ListaAlumnos��5F         PlantillaAlumnos#��[  5H      ��5G      �� *	Alumnos+5L      5M      5N      5O      