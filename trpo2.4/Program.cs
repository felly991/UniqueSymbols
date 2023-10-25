//Дан текст из строчных латинских букв, за которыми следует точка
//Напечатать в алфавитном порядке все буквы, которые входят в этот текст по одному разу
//Без использования цикла for, linq, встроенных функций
using trpo2._4;
try
{
    string text = "ABFFCDEFAA.";
    List<char> errors = new List<char>() { '!', ',', '<', '>',
                                           '1', '2', '3', '4',
                                           '5', '6', '7', '8',
                                           '9', '0', '[', ']',
                                           '{', '}', '"', ':'};
    Methods symb = new Methods();

    //Проверка на лишние символы и точку в конце
    if (!symb.Errors(text, errors) || !symb.IsPoint(text))
    {
        throw new Exception();
    }
    //Перевод строки в лист чаров
    var list = symb.Listed(text);

    //Сортировка списка по алфавитному порядку (пузырьковая)
    list = symb.Sort(list);

    //Удаление из списка элементов, которые входят в него не один раз
    list = symb.Delete(list);

    Console.WriteLine("Входная строка \t\t" + text);
    Console.WriteLine("Полученные буквы \t" + string.Join(",", list).ToUpper());
}
catch
{
    Console.WriteLine("Неверный ввод данных");
}


