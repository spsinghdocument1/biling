   M S B A M L   `   `   `  ����  WpfApplication1!    WpfApplication1.SalesReturn   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  SalesReturn��5   	   $	��900��6   $	��900��6*   .��5      � .+�5   
   �� $;��5/WpfApplication1;component/Ima/download%20%281%29.jpg��6   $��UniformToFill=�6O   6i   �� 5   
   $
�� 900��6   $��84��6&   $�� 2000��62   
����� �$	��Top=�6U   $��	0,0,-22,0q�6m   .+�5      �� -   5        $��
textBlock1��5   F   
�������$��50(�6,   $	��286��6:   $��Sales Return��6X   5	      �� 5
   
   $	��900��6   $
��2000��6%   $��Center=�65   $��0,90,0,9q�6T   $	��778��6f   .+�5      �� -   5        $��label1��5   o   $��Company Name :��6   $��20(�6-   
�������$��42��6N   $��
-700,0,0,0q�6Z   $
�� 165��6}   �� 5      -   5        $��label2��5   1   $��Label��6   $��28��6%   $	��104��6@   $��-390,-45,0,0q�6L   �� 5      -   5        $��label3��5   p   $��Customer Name :��6   $��20(�6.   
�������$��42��6O   $�� -700,0,0,0q�6[   $
�� 165��6~   �� 5      -   5        $��textBox1��5   C   $��20(�6   
�������$��30��67   $��-170,-50,0,0q�6S   $	��331��6i   �� 5      -   5        $��button1��5   G   $��Search��6   $��250,-48,0,0q�6&   $��35��6;   $��75��6V   5      �� 5   
   $	��900��6   $
��2000��6$   $��Center=�64   $��-10,198,-22,201q�6Q   $	��900��6j   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5   r   $	��900��6   $
��2000��6'   $�� 0,0,0,0q�67      AutoGenerateColumns .  $	��432��6e   $	��900��6�   5      �� 5   
   $	��900��6   $
��2000��6%   $��Center=�65   $��	30,0,20,0q�6T   $��Bottom  =�6h   $	��201��6�   $	��900��6�   .+�5      �� -   5        $��label4��5   i   $��Total Amount   :��6   $��20(�6/   
�������$��42��6P   $
�� 165��6\   $��
 250,0,0,0q�6w   �� 5      -	   5        $��label5��5   i   $��Discount       :��6   $��20(�6/   
�������$��42��6P   $
�� 165��6\   $��
 250,0,0,0q�6w   �� 5      -
   5        $��label6��5   h   $��Other Charges :��6   $��20(�6.   
�������$��42��6O   $
�� 165��6[   $��
 250,0,0,0q�6v   �� 5      -   5        $��label7��5   e   $��Net Amount :��6   $��20(�6+   
�������$��42��6L   $
�� 165��6X   $��
 250,0,0,0q�6s   �� 5      -   5        $��textBox2��5   "   $��23��6   $	��187��62   $�� 650,-300,0,0q�6>   �� 5      -   5        $��textBox3��5   "   $��23��6   $	��187��62   $��  650,-210,0,0q�6>   �� 5      -   5        $��textBox4��5   "   $��23��6   $	��187��62   $��  650,-125,0,0q�6>   �� 5      -   5        $��textBox5��5   "   $��23��6   $	��187��62   $��  650,-43,0,0q�6>   �� 5      -   5        $��button12��5   R   $��23��6   $
��Left=�6#   $��	358,3,0,0q�6?   $	��Top=�6b   $��75��6z   ��5       �� 5!       �� Orientation$ 
Horizontal=�6!   .+�5"      �� -   5        $-��'/WpfApplication1;component/Ima/save.jpg��5"       6s   5#      5%      �� 5&      -   5        $��button8��5&   T   $��23��6   $
��Left=�6#   $��450,-23,0,0q�6?   $	��Top=�6c   $��75��6{   ��5'      �� 5(      $ 
Horizontal=�6!   .+�5)      �� -   5        $.��(/WpfApplication1;component/Ima/clear.jpg��5)       6v   5*      5,      �� 5-      -   5        $��button9��5-   T   $��23��6   $
��Left=�6#   $��545,-23,0,0q�6?   $	��Top=�6c   $��75��6{   ��5.      �� 5/      $ 
Horizontal=�6!   .+�50      �� -   5        $/��)/WpfApplication1;component/Ima/delete.jpg��50       6w   51      53      �� 54      -   5        $��button3��54   T   $��23��6   $
��Left=�6#   $��645,-23,0,0q�6?   $	��Top=�6c   $��75��6{   ��55      �� 56      $ 
Horizontal=�6!   .+�57      �� -   5        $-��'/WpfApplication1;component/Ima/View.jpg��57       6u   58      5:      �� 5;      -   5        $��button4��5;   T   $��23��6   $
��Left=�6#   $��745,-23,0,0q�6?   $	��Top=�6c   $��75��6{   ��5<      �� 5=      $ 
Horizontal=�6!   .+�5>      �� -   5        $1��+/WpfApplication1;component/Ima/Untitled.jpg��5>       6w   5?      5A      5B      5C      5D      