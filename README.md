
Вариант 18
В строке (a+a)xb знак "x" в таблице был интерпретирован как скалярное произведение
Оператор (||) является неперегружаемым оператором,поэтому было использован близкий к нему оператор (|),ссылка на источник:
https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/operator-overloading
| Класс  | Члены Класса                          | Методы                             | Операторы перегрузки                                                                                      | Исходные Данные              | Результаты                                                     |
|--------|---------------------------------------|------------------------------------|-----------------------------------------------------------------------------------------------------------|------------------------------|----------------------------------------------------------------|
| Вектор | 3 прямоугольные декартовые координаты | Конструктор, метод вывода вектора  | Сложение(+), скалярное(%) и векторное(*) произведения векторов, проверка коллинеарности(\|\|)2-х векторов | a={ax,ay,az}<br>b={bx,by,bz} | c=(a+a)%b<br>d=ab<br>проверить на коллинеарность векторы a и b |
