   M S B A M L   `   `   `  ����I  EFase_III_SERAJ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Fase_III_SERAJ.Resources.Modules.Alumnos(Fase_III_SERAJ.Resources.Modules.Alumnos  5      5    /Fase_III_SERAJ.Resources.Modules.Alumnos.Create   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:Fase_III_SERAJ.Resources.Modules.Alumnos     5        N� Title$  Create��5	      .��5      � .+�5   
   � $��10q�6   
������� � ColumnDefinitions 5      �� 5      �� 5       � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� $��2��6   $��30(�6(   $
��Bold"�66   $��Nuevo Registro��6H   $��Center=�6a   $��Center=�6~   
��� ���6�   �� 5       �� Orientation$ 
Horizontal=�6   $��0��62   $��1��6B   .+�5      �� $��Center=�6   $	��100��63   $��20(�6?   .��6M   Name6S   �� 5      -   5         ��Name$ textbox_name��5   �   $	��280��6   $��40��6&   $
��Left=�62   $��Center=�6T   $��20(�6v   ��6�   �� *Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5      $ 
Horizontal=�6   $��1��62   $��1��6B   .+�5      �� $��Center=�6   $	��100��63   $��20(�6?   .��6M   
Nacimiento6Y   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DatePicker_dateofBird��5      $	��280��6<   $��40��6H   $��20(�6T      SelectedDate 6b   �� 	 �� Path$	 DateOfBirth�$ TwoWay=�$ PropertyChanged=�6�   5       �� 5!      $ 
Horizontal=�6   $��0��62   $��2��6B   .+�5"      �� $��Center=�6   $	��100��63   $��20(�6?   .��6M   	Matricula6X   �� 5#      -   5        $ textbox_idNum��5#   �   $	��280��6   $��40��6&   $
��Left=�62   $��Center=�6T   $��20(�6v   ��6�   �� $	 IdSERAJ�$ TwoWay=�$ PropertyChanged=�5$      �� 5%      $��1��6   $��2��6)   $ 
Horizontal=�66   .+�5&      �� $��Center=�6   $	��100��63   $��20(�6?   .��6M   	Direccion6X   �� 5'      -   5        $ textbox_direction��5'   �   $	��280��6   $��40��6'   $
��Left=�63   $��Center=�6U   $��20(�6w   ��6�   �� $	 Address�$ TwoWay=�$ PropertyChanged=�5(      �� 5)      $ 
Horizontal=�6   $��0��62   $��3��6B   .+�5*      �� $��Center=�6   $	��100��63   $��20(�6?   .��6M   
Estudios6W   �� 5+      -   5        $ textbox_degree��5+   �   $	��280��6   $��40��6&   $
��Left=�62   $��Center=�6T   $��20(�6v   ��6�   �� $	 StudyDegree�$ TwoWay=�$ PropertyChanged=�5,      �� 5-      $��1��6   $��3��6)   $ 
Horizontal=�66   .+�5.      �� $��Center=�6   $	��100��63   $��20(�6?   .��6M   	Programas6X   �� 5/      -   5        $ textbox_program��5/   �   $	��280��6   $��40��6&   $
��Left=�62   $��Center=�6T   $��20(�6v   ��6�   �� $	 Program�$ TwoWay=�$ PropertyChanged=�50      �� 52      -   5        
 ��Name$
 button_cancel��52   �   $��4��6   $��0��6"   $��50��62   $	��190��6>   $��Limpiar��6J   
���  ��
�������$��20(�6�   6�   �� 53      -   5        $
 button_save��53   �   $��4��6   $��1��6"   $��50��62   $	��190��6>   $��Guardar��6J   
��� d �
�������$��20(�6�   6�   54      55      56      