//Дан текст из строных латинсвких букв, за которыми следует точка
//Напечатать в алфавитном порядке все буквы, которые входят в этот текст по одному разу
//Без использования цикла for, linq, встроенных функций
try
{
    string text = "ABCDEFAAAA.";
    //Перевод строки в лист чаров
    List<char> Listed(string text)
    {
        List<char> list = new List<char>();
        int a = 0;
        while (a != text.Length - 1)
        {
            list.Add(text[a++]);
        }
        return list;
    }
    var list = Listed(text);

    //Сортировка списка по алфавитному порядку (пузырьковая)
    List<char> Sort(List<char> list)
    {
        int a = 0;
        char temp;
        while (a != list.Count)
        {
            int b = a + 1;
            while (b != list.Count)
            {
                if (list[a] > list[b])
                {
                    temp = list[a];
                    list[a] = list[b];
                    list[b] = temp;
                }
                b++;
            }
            a++;
        }
        return list;
    }
    list = Sort(list);

    //Удаление из списка элементов, которые входят в него не один раз
    List<char> Delete(List<char> text)
    {
        List<char> list = new List<char>();
        int a = 0;
        while (a != text.Count())
        {
            int b = 0;
            int c = 0;
            while (c != text.Count())
            {
                if (text[a] == text[c])
                {
                    b++;
                }
                c++;
            }
            if (b < 2)
            {
                list.Add(text[a]);
            }
            a++;
        }
        return list;
    }
    list = Delete(list);

    Console.WriteLine("Входная строка \t\t" + text);
    Console.WriteLine("Полученные буквы \t" + string.Join(",", list));
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}


