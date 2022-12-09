string[] array1 = new string[4] {"1234", "1567", "-2", "computer sciense"}; // задаем изначальный массив строк
string[] array2 = new string[array1.Length];

int StringSelection(string[] array1, string[] array2) // функция для отбора строк и записи их в массив
{
    int n = 0; // счетчик строк, подходящих под условие

    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length < 4) // проверяем, меньше ли четырех символов строка
        {
            array2[n] = array1[i];
            n++;
        }
    }

    return n;
}
