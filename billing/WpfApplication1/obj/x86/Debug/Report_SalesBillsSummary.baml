   M S B A M L   `   `   `  ����  WpfApplication1.    (WpfApplication1.Report_SalesBillsSummary   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Report_SalesBillsSummary��5   	   $	��900��6*   $	��900��67   .��5      � .+�5   
   �� $;��5/WpfApplication1;component/Ima/download%20%281%29.jpg��6   $��UniformToFill=�6O   6i   �� 5   
   $
�� 900��6   $��84��6&   $�� 2000��62   
����� �$	��Top=�6U   $��	0,0,-22,0q�6m   .+�5      �� -   5        $��
textBlock1��5   G   
�������$��50(�6-   $	��426��6;   $��Sales Bill Summary��6Y   5	      &   System.Windows.Controls.DataGrid  5
   
   -   5        $��dgTargetAllocation��5
   G      AutoGenerateColumns .  $
��Auto=�5      $	��250��61      
IsReadOnly . $��Center=�5      $	��650��6      RowHeaderWidth$ 30Q�6-      CanUserResizeRows .     CanUserResizeColumns .     CanUserReorderColumns .     CanUserSortColumns .     CanUserAddRows . $��Bottom=�5   3   $��2��6N   $
��1000��6_   $��1��6l   ��5
      �� ��5   y   Z� 	   Columns	 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Userid��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 150* 69      
IsReadOnly .    
Visibility$ Hidden=�6X      CellTemplate 5      �� 5      .R�5      �� $��	txtUserid��6e      txtBoxMedium#���   6&   {�. ��6M   �� *UserId+6�   5      5        5      $

 User��6)   $
 200* 67    .  5      �� 5      .R�5      �� $��txtUser��6g   #���   6&   {�.  ��6M   �� *
UserName+6�   5      5        5       $
 DesignationId��6)   $
 150* 6@    . $ Hidden=�6_    5!      �� 5"      .R�5#      ��  �� Orientation$ 
Horizontal=�6)   .+�5$   "   �� $��	txtdesgid��6m   #���   6*   {�. ��6Q   �� *
UserDesgId+6�   5%      5&      5)        5*      $
 Designation��6)   $
 150* 6>    .  5+      �� 5,      .R�5-      �� $ 
Horizontal=�6)   .+�5.   "   �� $��txtdesg��6n   #���   6*   {�.  ��6Q   �� *Designation+6�   5/      50      53        55      $
 Month��6)   $
 130* 68    .  56      �� 57      .R�58      �� $��Cmbmonth��62   -   5        $��2q�58   '   ��6o   �� .@�59   "   �� $��Select Month��6/    �� 
IsSelected . 6F   �� 5:   "   $	��Jan��6/   �� 5;   "   $	��Feb��6/   �� 5<   "   $	��Mar��6/   �� 5=   "   $	��Apr��6/   �� 5>   "   $	��May��6/   �� 5?   "   $	��Jun��6/   �� 5@   "   $	��Jul��6/   �� 5A   "   $	��Aug��6/   �� 5B   "   $
��Sept��6/   �� 5C   "   $	��Oct��6/   �� 5D   "   $	��Nov��6/   �� 5E   "   $	��Dec��6/   5F      5J      5L        5O      $
 End Date��6)   $	 180 6;    . $ Hidden=�6Y    5P      �� 5Q      .R�5R      (  "System.Windows.Controls.DatePicker  $��dtpDateTimeenddategrd��6]   $��Center=�6)   $��25��6z   $	��150��6�   $
��Left=�6�   $��10,0,0,0q�6�      SelectedDateFormat$ 	MonthYear=�6�      Text 6D   �� *	EndDate+6�   5S      5V        5Y      $
 Revenue Target��6)   $
 150* 6A    .  5[      �� 5\      .R�5]      �� $��txtrevtarget��62   $	��100��6&   {�.  �� 	MaxLength$ 7��6Y   6j   5^      5`        5b      $
 Vehicle Checking Target��6)   $
 180* 6J    .  5c      �� 5d      .R�5e      �� $��txtVehChkTarget��62   $	��100��6&   {�. $ 7��6[   6l   5f      5h        5i      $
 Target Achieved��6)   $
 120* 6B    .  5j      �� 5k      .R�5l      �� $��txtTargetAchieved��62   $	��100��6&   {�.  ��6]   �� *AchievedTarget+6�   5m      5o        5q      $
 Vehicle Checked��6)   $
 120* 6B    .  5r      �� 5s      .R�5t      �� $��txtVehChekd��62   $	��100��6&   {�.  ��6W   �� *VehicleChecked+6z   5u      5w      5|      5      5�      