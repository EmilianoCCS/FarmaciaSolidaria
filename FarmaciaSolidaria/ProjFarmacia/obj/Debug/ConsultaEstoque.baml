   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    ProjFarmacia"   ProjFarmacia.ConsultaEstoque   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Consulta��5   	   $��666.087��6   $��609.051��6+   .��5	      � -   5         �Name$ btnSair��5	      .+�5   
   o� -   5         o�Name$
 Menu��5      $��29��6   $	��Top=�6)   $��0,0,42,0q�6A   .@�5      m� $��	Adicionar��6   $��Center=�6*   .@�5      m� -   5         m�Name$ 	miRemedio��5      $��Remédio��6.   6?   m� 5      -   5        $ miDoador��5      $��Doador��6-   6=   m� 5      -   5        $ miInstituicao��5      $��Instituição��62   6G   5      m� 5      $��Estoque��6   .@�5      m� -   5        $ miConsultar��5      $��	Consultar��60   6C   5      m� 5      -   5        $��Doar remédio��5      6-   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgTudo��5      $��
9,332,9,13q�6$      CanUserAddRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6<   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *Id+6<     5      $ Doador��6G   	 6%   �� *Doadores.Nome+6G     5      $ Instituição��6K   	 6%   �� *Instituicoes.Nome+6K     5      $ Remédio��6G   	 6%   �� *Remedios.Nome+6G     5      $ Data de saida��6k   	 6%   �� *	DataSaida+
 �� ConverterCulture$
 pt-BR�� �� StringFormat$ d��6k     5      $ Quantidade restante��6M   	 6%   �� *Remedios.Quantidade+6M   5!      �� 5"   
   -	   5         ��Name$ txtPesquisar��5"      $��23��6(   $��173,269,0,0q�64    �� TextWrapping$
 Wrap=�6I   $	��Top=�6]   $
��Left=�6�   $	��202��6�   �� 5#   
   -
   5         ��Name$ label��5#      $��Pesquisar Remédio:��6   $
��Left=�6<   $��
60,266,0,0q�6W   $	��Top=�6k   �� 5$   
   -   5         ��Name$ btnPesquisar��5$      $��	Pesquisar��6'   $��402,269,0,0q�6;   $	��Top=�6P   $
��Left=�6�   $��75��6�   �� 5%   
   -   5        $ btnSair1��5%      $��LOG OFF��6#   $	��Top=�65   $��29��6M   $��8(�6Y   ���	#FF2DB5E8���	#FF2DB5E8$��Right=�6�   $��52��6�   �� 5&   
   $��158,164,0,0q�6   $9��336063748_1940821539542727_8216732737483046912_n.png��6%   $
��Fill=�6b   $
��Left=�6q   $	��267��6�   $��38��6�   $	��Top=�6�   �� 5'   
   $��
229,29,0,0q�6   $��LogoPNG.png��6$   $
��Fill=�69   $
��Left=�6H   $	��130��6c   $	��130��6o   $	��Top=�6|   5)      5*      