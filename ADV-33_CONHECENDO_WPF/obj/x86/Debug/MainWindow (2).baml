   M S B A M L   `   `   `  ����P  LADV-33_CONHECENDO_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ADV_33_CONHECENDO_WPFADV_33_CONHECENDO_WPF  5   	   &     ADV_33_CONHECENDO_WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   4inst#clr-namespace:ADV_33_CONHECENDO_WPF     5   	   -   5          � Title$  Conhecendo WPF��5   	   $	��350��6    $	��525��6-    � 	Resources 5      %  ADV_33_CONHECENDO_WPF.Instrutor   objInstrutor  Erro �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path  
ContexMenu  
TexBoxMenu  ContextMenu m� Icon  lblTitutloStyle 	 chkds  	lblRotulo 	 combo 	 rdbs 	
 Grupo��%  &	        &	      &	 �     &	     7  &	 �    &	 #    &	 c    &	 �    &		 -    &	
 m      5   
   6   �� 5   
   " ��6    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 5      �� #	 Z $)
 #(validation.Errors)[0].ErrorContent�5      5      �� 5   
   .�5      ��  � ��
 �   �67   5      �� 5   
   8��  .@�5      m� $��clearTxt��65   -   5        $��Limpa caixa de texto��5       5      �� 5      $��wand.png��6   5      5       �� 5#   
   .�5$      ��  � ��
 �����61   �� 5%       � ��$ 14(�63   5&      �� 5*   
   .�5+      ��  � ��
 �����64   5,      �� 5/   
   .�50      ��  � ��$ 12(�6/   �� 51       � ��
 �����61   52      �� 55   
   .�56      ��  � ��
 �  ��64   �� 57       � ��
 �����64   58      �� 5<   
   .�5=      ��  � ��
 �����67   5>      �� 5A   
   .�5B      ��  � ��
 �����64   5C      5E   	   .��5F      � $	��525��6   $	��350��6   .+�5G   
   �� -   5        $��btnHello��5G   \   $��Hellow��6   $��23��6"   $
��Left=�6.   $��	12,40,0,0q�6I   $	��Top=�6l   $��75��6�   6�   �� 5I   
   -   5        $��imgBG��5I      $��0,-4,0,4q�6   $
��fill=�61   ��5J      �� 5K       �� 	UriSource$ 	bgWpf.jpg?�6   5M      �� 5N   
   -   5        $��	lblTitulo��5N   J   $��28��6   $
��Left=�6   $��	12,64,0,0q�67   $	��Top=�6[   $	��143��6s   ���	#FF272424$��seleção de instrutor ��6�   #��[ 6�   �� 5O   
   -   5        $��label2��5O   Y   $
��nome��6   $��25��6   $
��Left=�6+   $��	22,98,0,0q�6F   $	��Top=�6g   $��62��6   �� 5P   
   -   5        $��label4��5P   e   $��instrutor de : ��6   $��26��6*   $
��Left=�66   $��
30,181,0,0q�6Q   $	��Top=�6s   $��76��6�   }�.  ��5Q      �� 5R      5T      �� 5X   
   -   5        $��TxtNome��5X   L   $��23��6   $
��Left=�6   $��	71,75,0,0q�69   $	��Top=�6[   $	��180��6s   .��6�   ��5Y   
   �� 5Z       �� Source# [  6   $

 Nome�6A    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�5[   7    �� ValidationRules 5\      5  /System.Windows.Controls.ExceptionValidationRule  5]      5_      .��5`      5a      �� 5b   
   -	   5        $��chkFormadoSim��5b   o   $��tem formação superior ��6   $��16��64   $
��Left=�6@   $��
329,95,0,0q�6[   $	��Top=�6�   #��[ 6�    � DataContext 6�   �� 6�   �� 5c   
   -
   5        $��	cmbCursos��5c   N   $��38��6   $
��Left=�6   $��
30,206,0,0q�6:   $	��Top=�6_   $	��175��6w   #��[ 6�   �� 5d   
   -   5        $��grpExemperiencia��5d   f   $��Experiencia ��6   $	��128��6)   $
��Left=�66   $��287,163,0,0q�6Q   $	��Top=�6~   $	��206��6�   .��5e      	� -   5        $��radioButton5��5e   B   $��de 5  ate 9 anos ��6   $��15��66   $��91��6V   #��[	 6a   5f      � 5g   
   -   5        $��grpExperiencia��5g      #��[
 6%   $��503,267,-182,-56q�6D   .+�5h      	� -   5        $��radioButton1��5h   j   $��RadioButton��6   $��16��60   $
��Left=�6<   $��	78,15,0,0q�6W   $	��Top=�6~   	� 5i      -   5        $��radioButton2��5i   j   $��RadioButton��6   $��16��60   $
��Left=�6<   $��	29,44,0,0q�6W   $	��Top=�6~   	� 5j      -   5        $��radioButton3��5j   j   $��RadioButton��6   $��16��60   $
��Left=�6<   $��	46,67,0,0q�6W   $	��Top=�6~   	� 5k      -   5        $��radioButton4��5k   j   $��RadioButton��6   $��16��60   $
��Left=�6<   $��	49,99,0,0q�6W   $	��Top=�6~   � 5l      -   5        $��grdItensExperiencia��5l   ,   $	��122��6   $	��149��6    6,   5m      	� 5n   
   -   5        $��radioButton6��5n   m   $��10 ou mais anos ��6   $��16��61   $
��Left=�6=   $��375,254,0,0q�6X   $	��Top=�6�   #��[	 6�   	� 5o   
   -   5        $��radioButton7��5o   m   $��de 1 ate 4 anos ��6   $��16��61   $
��Left=�6=   $��376,206,0,0q�6X   $	��Top=�6�   #��[	 6�   	� 5p   
   -   5        $��radioButton8��5p   f   $��	ate 1 ano��6   $��16��6*   $
��Left=�66   $��376,181,0,0q�6Q   $	��Top=�6z   #��[	 6�   ]� 5r   
   $��30��6   $��Stretch=�6    $��0q�6>   $	��Top=�6I   .+�5t      o� -   5        $��
mmnuOpcoes��5t      $��23��6   $
��Auto��61   $	��Top=�6>   $	��Top=�6S   .@�5v      m� $��Arquivo��6   .@�5w      m� -   5        $��itemMenuSave��5w   +   $��Salvar��6    5x      �� 5y      $��disk.png��6    5{      m� 5|      -   5        $��itemOpenFile��5|   *   $��Abrir��6    5}      �� 5~      $��folder_explore.png��6    5�      m� 5�      -   5        $��	itemClose��5�   )   $
��Sair��6    5�      �� 5�      $��
Cancel.png��6    5�      5�      m� 5�      $��Ajuda��6   .@�5�      m� -   5        $��
itemVersao��5�   *   $��Versão��6    5�      �� 5�      $��lightbulb.png��6   5�      5�      5�      5�      5�      5�      