﻿Данная программа на языке программирования C#, хранит информацию о телепрограммах на день, 
добавляет телепередачи, состоящие из названия, жанра и время показа телепередачи. 
По запросу выводит информацию о хранящихся телепередачах.
С целью более удобного проектирования, настройки, и разделения отдельных исполняемых операций, 
данная программа построена на модулях, которые в свою очередь построены на классах взаимодействующих между собой. 
Использование модулей и классов дает улучшенное понимание кода, 
а значит настройку и последующую модификацию исходного кода программы. 
Данная программа состоит из следующих модулей:
1)	Program – главная точка входа в приложение игры.
2)	Form1 – основная форма программы.
3)	Person – обработка и сохранение в течении сеанса введенных пользователем данных
Основной модуль формы Form1 содержит следующие основные функции соответствующие основным кнопкам на форме:
1)	кнопка добавить – добавляет и хранит телепередачи;
2)	кнопка вывести – выводит информацию о хранящихся телепередачах;
3)	кнопка очистить – очищает окна ввода.
Модуль Person является классом основного модуля формы Form1 и содержит свою единственную основную функцию 
обработки и сохранения в течении сеанса введенных пользователем данных.
