//Дан текст из строных латинсвких букв, за которыми следует точка
//Напечатать в алфавитном порядке все буквы, которые входят в этот текст по одному разу
//Без использования цикла for, linq, встроенных функций
using trpo2._4;

try
{
    string text = "BABCDEFAAAAC.";
    Symbols symb = new Symbols();

    //Перевод строки в лист чаров
    var list = symb.Listed(text);

    //Сортировка списка по алфавитному порядку (пузырьковая)
    list = symb.Sort(list);

    //Удаление из списка элементов, которые входят в него не один раз
    list = symb.Delete(list);

    Console.WriteLine("Входная строка \t\t" + text);
    Console.WriteLine("Полученные буквы \t" + string.Join(",", list).ToUpper());
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}


