# finaltest
# Контрольная работа по первой четверти

1.	Необходимо создать репозиторий на GitHub
2.	Нарисовать блок-схему алгоритма
3.	Снабдить репозиторий оформленный текстовым описанием решения. (Файл Readme.md)
4.	Написать программу, решающую поставленную задачу.
5.	Использовать контроль версий в работе над этим проектом.
	Не должно быть так, что всё залито одним коммитом. Как минимум эта git remote add origin https://github.com/kam17ale/finaltest.git 2, 3 и 4 должны быть расположен в разных коммитах. 
***
	
## ЗАДАЧА:
Написать программу, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше или равна трем символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
***
### ***ПРИМЕРЫ:***
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234","1567", "-2", "computer science"] -> ["-2"]
["Russia", "Demmark", "Kazan"] -> []
***


## РЕШЕНИЕ ЗАДАЧИ

### ***Описание алгоритма решения:***
Сначала объявляется два массива (изначальный и вторый такой же длины). Затем метод, в котором цикл имеет размер длины массива.
В самом цикле выполняется проверка условия меньше или равно трем (<=3). 
Если условие выполняется, то элемент первого массива заносится в переменную count элемента второго массива.
Переменная count создаётся для того, чтобы поочередно заносить данные элементов из первого массива во второй массив.
После присвоения переменная count увеличивается на 1 и возвращается к циклу for в котором i увеличивается на 1.
Ну и далее проверяем данные до конца.
