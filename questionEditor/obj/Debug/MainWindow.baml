   M S B A M L   `   `   `  ����I  EquestionEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:questionEditorquestionEditor  5   	       questionEditor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:questionEditor     5   	     � Title$  questionEditor��5   	   $	��345��6    $��693.759��6-    � 
ResizeMode$ CanMinimize=�6=   .��5	      � .+�5
   
   �� -   5        $
��Left=�5
      $��24��60   $��	10,-1,0,0q�6<   $	��Top=�6O   $	��365��6g   .@�5      �� $��Уровень 1��6   .��5      � ���	#FFE5E5E56   5      �� 5      $��Уровень 2��6   .��5      � ���	#FFE5E5E56   5      �� 5      $��Уровень 3��6   .��5      � ���	#FFE5E5E56   5      5      �� 5   
   -   5         ��Name$ questionsList��5      $��	0,21,0,36q�6*    �� View 5      �� 5      .P�5      ��  �� Width$	 400��6M    �� DisplayMemberBinding 6%   �� *mTitle+.��6Y   Вопрос6a   �� 5      $	 200��6N    6%   �� *	mAnswer+.��6Z   Вариант ответа6j   �� 5      $ 70��6O    6%   �� *
_mRezult+.��6Z   
Ответ6a   5      5      �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��
10,282,0,0q�6?   $	��Top=�6S   $	��167��6k   6w   �� 5   
   -   5        $��Удалить��5      $
��Left=�6#   $��208,282,0,0q�6>   $	��Top=�6S   $	��167��6k   6w   5"      5#      