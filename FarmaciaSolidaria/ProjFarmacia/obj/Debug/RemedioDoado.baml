   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    ProjFarmacia   ProjFarmacia.RemedioDoado   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Doação de remédios��5   	   $��917.984��6$   $��834.688��65   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ label��5      $��Nome Remedio:��6   $
��Left=�67   $��
10,222,0,0q�6R   $	��Top=�6f   �� 5   
   -   5         ��Name$ txtNomeRemedio��5      $��23��6*   $��115,222,83,0q�66    �� TextWrapping$
 Wrap=�6L   $	��Top=�6`   �� 5   
   -   5        $ txtPrincipioAtivo��5      $��23��6-   $��115,254,83,0q�69   $
 Wrap=�6O   $	��Top=�6c   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DateVencimento��5      $��533,284,83,0q�6-   $	��Top=�6C   6[     5   
   -   5        $ DateEntrada��5      $
��Left=�6*   $��115,285,0,0q�6E   $	��Top=�6Z   $	��290��6r    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.052Q�6&   T� 5      5      5      �� 5   
   -   5        $ txtQuantidade��5      $��23��6)   $��115,315,83,0q�65   $
 Wrap=�6K   $	��Top=�6_   6w   �� 5   
   -   5         ��Name$ ComboBoDoador��5      $��115,346,83,0q�6*   $	��Top=�6@   	 �� DisplayMemberPath	 6X   �� *Nome+6{   �� 5   
   -   5        
 ��Name$
 btnCadastrar��5      $��	Cadastrar��6'   $��316,395,0,0q�6;   $	��Top=�6P   $��36��6h   $
��Left=�6�   $	��212��6�   �� 5   
   -	   5        $
 btnAtualizar��5      $��Atualizar Dados��6'   $
��Left=�6A   $��115,395,0,0q�6\   $	��Top=�6q   $	��112��6�   $��36��6�   �� 5   
   -
   5        $
 	btnLimpar��5      $��Limpar��6$   $
��Left=�65   $��616,395,0,0q�6P   $	��Top=�6e   $��36��6}   $	��112��6�   6�   o� 5!   
   -   5         o�Name$
 Menu��5!      $��30��6   $	��Top=�6)   $��0,0,14,0q�6A   .@�5"      m� $��	Adicionar��6   .@�5#      m� -   5         m�Name$ 	miRemedio��5#      $��Remédio��6.   6?   m� 5$      -   5        $ miDoador��5$      $��Doador��6-   6=   m� 5%      -   5        $ miInstituicao��5%      $��Instituição��62   6G   5&      m� 5'      $��Estoque��6   .@�5(      m� -   5        $ miConsultar��5(      $��	Consultar��60   6C   5)      m� 5*      -   5        $ miSaida��5*      $��Doar remédio��6(   6>   5+      �� 5,   
   -   5        $ label1��5,      $��Data Vencimento:��6    $
��Left=�6;   $��424,284,0,0q�6V   $	��Top=�6k   �� 5-   
   -   5        $ label2��5-      $��Nome Doador��6    $
��Left=�66   $��
10,346,0,0q�6Q   $	��Top=�6e   �� 50   
   -   5        $ label3��50      $��Data Entrada:��6    $
��Left=�68   $��
10,285,0,0q�6S   $	��Top=�6g   �� 52   
   -   5        $ label4��52      $��
Quantidade��6    $
��Left=�65   $��
10,315,0,0q�6P   $	��Top=�6d   �� 54   
   -   5        $ label5��54      $��Principio Ativo:��6    $
��Left=�6;   $��
10,254,0,0q�6V   $	��Top=�6j   $ -0.139,0.913&�6�   &   System.Windows.Controls.DataGrid  56   
   -   5          Name$ 	dgRemedio��56      $��10,516,27,20q�6&      CanUserAddRows .     AutoGenerateColumns .     Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ Id�6A     59      $ Nome do Doador��6L    6%   �� $ Doadores.Nome�6L     5:      $ Nome do Remedio��6C    6%   �� $
 Nome�6C     5;      $ Principio Ativo��6M    6%   �� $ PrincipioAtivo�6M     5<      $ 
Quantidade��6I    6%   �� $ 
Quantidade�6I     5=      $ Data de Validade��6r    6%   �� $ Validade� �� ConverterCulture$ pt-BR�� �� StringFormat$ d��6r     5>      $ Data de entrada��6q    6%   �� $ Entrada�$ pt-BR��$ d��6q   5B      �� 5E   
   -   5        $
 btnPesquisar��5E      $��	Pesquisar��6'   $��436,461,0,0q�6;   $	��Top=�6P   $
��Left=�6�   $��89��6�   �� 5F   
   -   5        $ txtPesquisar��5F      $��23��6(   $��
10,462,0,0q�64   $
 Wrap=�6H   $	��Top=�6\   $��8��6t   $��Pesquise pelo ID��6�   $
��Left=�6�   $	��396��6  �� 5G   
   -   5        $
 btnSair��5G      $��LOG OFF��6"   $	��Top=�64   $��29��6L   $��8(�6X   ���	#FF2DB5E8$��Right=�6|   $��60��6�   6�   �� 5H   
   $��275,170,0,0q�6   $9��336063748_1940821539542727_8216732737483046912_n.png��6%   $
��Fill=�6b   $
��Left=�6q   $	��267��6�   $��38��6�   $	��Top=�6�   �� 5I   
   $��
346,35,0,0q�6   $��LogoPNG.png��6$   $
��Fill=�69   $
��Left=�6H   $	��130��6c   $	��130��6o   $	��Top=�6|   5K      5L      