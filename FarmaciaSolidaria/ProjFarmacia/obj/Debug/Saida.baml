   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    ProjFarmacia   ProjFarmacia.Saida   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Saida��5   	   $��480.227��6   $��494.094��6(   .��5	      � $��
-1,0,0,-15q�6    J� RenderTransformOrigin$ 0.5,0.5&�6    � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      $
��145* �6   �� 5      $��4* �6   z�5   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.044Q�6"   T� 5      5      .+�5   
   �� -   5         ��Name$ txtQtd��5      $
��Left=�6"   $��23��6=   $��169,270,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��259��6�   6�   �� 5   
   -   5         ��Name$ 
label_Copy��5      $��Nome do Remédio:��6$   $
��Left=�6?   $��
43,240,0,0q�6Z   $	��Top=�6n   $��25��6�   �� 5   
   -   5        $ label_Copy1��5      $��
Quantidade��6%   $
��Left=�6:   $��
43,270,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $ label_Copy3��5      $��Data de Saida��6%   $
��Left=�6=   $��
43,302,0,0q�6X   $	��Top=�6l   $��25��6�   �� 5   
   -   5         ��Name$ btnAtualizar��5      $��	Atualizar��6'   $
��Left=�6;   $��111,391,0,0q�6V   $	��Top=�6k   $��75��6�   6�   �� 5   
   -   5        $ 	btnLimpar��5      $��Limpar��6$   $
��Left=�65   $��291,391,0,0q�6P   $	��Top=�6e   $��75��6}   6�   o� 5    
   -   5        	 o�Name$
	 Menu��5       $
��Left=�6   $��28��68   $	��Top=�6D   $	��382��6\   .@�5!      m� $��	Adicionar��6   .@�5"      m� -   5        
 m�Name$
 	miRemedio��5"      $��Remédio��6.   6?   m� 5#      -	   5        $
 miDoador��5#      $��Doador��6-   6=   m� 5$      -
   5        $
 miInstituicao��5$      $��Instituição��62   6G   5%      m� 5&      $��Estoque��6   .@�5'      m� -   5        $
 miConsultar��5'      $��	Consultar��60   6C   5(      m� 5)      -   5        $��Doar remédio��5)      6-   5*      �� 5+   
   -   5         ��Name$ ComboBoxRemedio��5+      $
��Left=�6,   $��169,239,0,0q�6G   $	��Top=�6\   $	��259��6t   6�   (  "System.Windows.Controls.DatePicker  5,   
   -   5          Name$ 	dateSaida��5,      $
��Left=�6(   $��169,301,0,0q�6C   $	��Top=�6X   $	��259��6p   6|   �� 5-   
   -   5        $ label��5-      $��Instituição��6   $
��Left=�65   $��
43,332,0,0q�6P   $	��Top=�6d   $ 0.505,0.508&�6|   �� 5.   
   -   5        $ ComboBoxInstituicao��5.      $
��Left=�60   $��169,332,0,0q�6K   $	��Top=�6`   $	��259��6x   6�   �� 5/   
   -   5        $ btnSair��5/      $��LOG OFF��6"   $��0,0,-7,0q�64   $	��Top=�6F   $��29��6^   $��8(�6j   ���	#FF2DB5E8���	#FF2DB5E8$��Right=�6�   $��52��6�   �� 50   
   $��110,168,0,0q�6   $9��336063748_1940821539542727_8216732737483046912_n.png��6%   $
��Fill=�6b   $
��Left=�6q   $	��267��6�   $��38��6�   $	��Top=�6�   �� 51   
   $��
181,33,0,0q�6   $��LogoPNG.png��6$   $
��Fill=�69   $
��Left=�6H   $	��130��6c   $	��130��6o   $	��Top=�6|   53      54      