   M S B A M L   `   `   `  ����N  JCustomerInformation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DataManagementDataManagement  5   	       DataManagement.NewWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DataManagement     5   	   -   5          � Title$  
MainWindow��5      $	��450��6   $	��450��6(    � AllowsTransparency . 
������  � WindowStyle$
 None=�5	   <    � 
ResizeMode$ NoResize=�5
   	   .��5      � .+�5   
   ��  �� CornerRadius$ 10��6   $��2��6#   ��5   
   �� 5      .��5      �  � Color$ #F47B8F��6    � Offset$	 0.0Q�6/   � 5      $ #51AEAE��6   $ 1Q�6/   5      5      �� 5   
   $��25(�6   $��Center=�6   .��6<   CustomerDetails6M   �� 5   
   $��50q�6   .+�5      �� $��
helivatica)�6   $��18(�6.   .��6<   Customer Id:6J   �� 5      -   5        $��Customer_id��5      $��
helivatica)�6)   $��18(�6B   �� 5      $��
helivatica)�6   $��18(�6.   .��6<   Name:6C   �� 5      -   5        $��	Full_name��5      $��
helivatica)�6(   $��18(�6A   �� 5      �� 5      $��
helivatica)�6   $��18(�6-   .��6;   Email:6C   �� 5      -   5        $��Email��5      $��
helivatica)�6$   $��18(�6=   �� 5      $��
helivatica)�6   $��18(�6.   .��6<   Date of Birth6L   (  "System.Windows.Controls.DatePicker  5       -   5        $	��Dob��5       $
��Left=�6$   $��0,0,0,0q�6?   $	��350��6Q   �� 5!      �� 5"      $��
helivatica)�6   $��18(�6.   .��6<   
Address:6F   �� 5#      -   5        $��Address��5#      $��
helivatica)�6&   $��18(�6?   �� 5$      �� 5%      5&      �� 5'   
   -   5        $��
0,320,0,20q�5'      $	��100��6%   $��30��61   $��UPDATE��6=   $��18(�6]   $��
helivatica)�6l   �� 5(   
   -   5        $��0,320,250,20q�5(      $	��100��6'   $��30��63   $��PREVIOUS��6?   $��18(�6c   $��
helivatica)�6r   �� 5)   
   -	   5        $��250,320,0,20q�5)      $	��100��6'   $��30��63   $
��NEXT��6?   $��18(�6[   $��
helivatica)�6i   �� 5*   
   -
   5        $��	0,380,0,0q�5*      $	��100��6$   $��30��60   $��Close��6<   $��18(�6Z   $��
helivatica)�6h   5+      5,      