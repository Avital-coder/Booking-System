   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	       PLWPF.HostWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	     � Title$  
HostWindow��5   	   $	��400��6   $	��550��6)    � 	Resources 5
         myLabelStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6'   .�5      ��  � ��$ Segoe Print)�5      �� 5       � ��$ 16(�5      �� 5       � ��$ Light"�5      5      5      .��5      � -   5         �Name$ HostGrid��5       � RowDefinitions 5   
   �� 5      $	��67* �6   �� 5      $	��20* �6   �� 5      $	��25* �6   �� 5      $	��47* �6   �� 5      $	��34* �6   �� 5      $	��47* �6   �� 5      $	��48* �6   �� 5      $	��81* �6    � ColumnDefinitions 5!   
   �� 5"      $	��98* �6   �� 5#      $	��45* �6   �� 5$      $
��242* �6   �� 5%      $	��49* �6   �� 5&      $
��108* �6   ��5(   
   �� 5)       �� ImageSource$� zPictures\47967113-cozy-winter-still-life-mug-of-hot-tea-and-warm-woolen-knitting-on-vintage-windowsill-against-snow-la.jpg��6   6�   .+�5+   
   �� #��[  6   $ ��Please enter your password��66   $
��Left=�6[   $��
4.8,37,0,0q�6v   $	��Top=�6�   $��2��6�   $��45��6�   $	��238��6�   $��3��6�   $��3��6�   �� 5,   
   -   5        	 ��Name$	 signUp��5,      $��Sign up��6!   $��20(�63   $
��Left=�6A   $��129.8,5.2,0,0q�6\   $	��Top=�6s   $��99��6�   $��30��6�   
�������$��2��6�   $��7��6�   �� 5-   
   -   5        
 ��Name$

 myID��5-      $��2��66   $
��Left=�6F   $��31��6a   $��	12,10,0,0q�6m   $��3��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��217��6�   ��6    �� *myID+6�   �� 5.   
   -   5        $	 logIn��5.      $��Log in��6    $��20(�61   $��2��6?   $
��Left=�6O   $��11.8,5.2,0,0q�6j   $��7��6�   $	��Top=�6�   $��92��6�   $��31��6�   
�������6�   �� 5/   
   #��[  6   $��Please enter your ID��66   $
��Left=�6U   $��24.8,7.8,0,0q�6p   $	��Top=�6�   $	��174��6�   $��2��6�   $��1��6�   $��38��6�   $��3��6�   G� 50   
   -   5         G�Name$
 pass��50      $��2��6$   $
��Left=�64    G� PasswordChar$ *��6P    G� 	MaxLength$ 8��6a   $��12,5,0,0q�6o   $��5��6�   $	��Top=�6�   $	��217��6�   $��28��6�   �� 51   
   -   5        $��4��51   +   $
��Left=�6;   $��	75,10,0,0q�6V   $	��Top=�6i   .��52      �� $��Pictures\xIcon.png��6   $��20��60   $��20��6<   6I   53      �� 54   
   -   5         ��Name$ robot��54      $��I am not a robot��6"   $��2��6=   $
��Left=�6d   $��66.8,19.2,0,0q�6   $��6��6�   $	��Top=�6�   $��2��6�   $	��198��6�   55      56      