using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //практические задания примерные
/*1. Структурное программирование.
Даны натуральные числа n и k. Составить программу вычисления выражения 1k
+ 2k +...+ nk.
Разработать меню программы. Пункты меню: ввод данных, обработка, просмотр
результатов, выход. 
using System;

public class SumOfPowers
{
    public static void Main()
    {
        int n = 0, k = 0;
        int choice = 0;
        bool exit = false;

        do
        {
            Console.WriteLine("1. Ввод данных");
            Console.WriteLine("2. Обработка");
            Console.WriteLine("3. Просмотр результатов");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите пункт меню: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введите n: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Введите k: ");
                    k = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    long sum = 0;

                    for (int i = 1; i <= n; i++)
                    {
                        sum += (long)Math.Pow(i, k);
                    }

                    Console.WriteLine("Сумма: " + sum);
                    break;
                case 3:
                    Console.WriteLine("n = " + n);
                    Console.WriteLine("k = " + k);
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }

            Console.WriteLine();

        } while (!exit);
    }
}
*/
/*2.Одномерные массивы.
Дан целочисленный массив размера N. Проверить, чередуются ли в нем четные
и нечетные числа. Если чередуются, то вывести 0, если нет, то вывести
порядковый номер первого элемента, нарушающего закономерность.
using System;

public class CheckArray
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int n = arr.Length;
        int i = 0;

        while (i < n - 1 && ((arr[i] % 2 == 0 && arr[i + 1] % 2 == 1) || (arr[i] % 2 == 1 && arr[i + 1] % 2 == 0)))
        {
            i++;
        }

        if (i == n - 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(i + 1);
        }
    }
}
*/
/*3.Методы сортировки
Создать матрицу вещественных элементов А(n,n) и выполнить сортировку
элементов, расположенных под главной диагональю методом «пузырька».
Отсортированную последовательность вывести на экран. 
using System;

class Program
{
    static void Main(string[] args)
    {
        // Создание матрицы и заполнение ее случайными вещественными числами
        int n = 5;
        double[,] A = new double[n, n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = rand.NextDouble() * 100;
                Console.Write(A[i, j] + "t");
            }
            Console.WriteLine();
        }

        // Сортировка элементов, расположенных под главной диагональю методом пузырька
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (j < i + 1) continue; // пропуск элементов на главной диагонали и выше
                if (A[j, i] > A[j + 1, i])
                {
                    // обмен элементов
                    double temp = A[j, i];
                    A[j, i] = A[j + 1, i];
                    A[j + 1, i] = temp;
                }
            }
        }

        // Вывод отсортированной последовательности на экран
        Console.WriteLine("Отсортированная последовательность:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j < i + 1) Console.Write("t"); // пропуск элементов на главной диагонали и выше
                else Console.Write(A[j, i] + "t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
*/
/* 4. Двумерные массивы.
Дана квадратная матрица A[N, N]. Записать на место отрицательных элементов
матрицы нули, а на место положительных — единицы. Вывести на печать
нижнюю треугольную матрицу в общепринятом виде.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Создание квадратной матрицы и заполнение ее случайными числами
        int n = 5;
        int[,] A = new int[n, n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = rand.Next(-10, 10);
                Console.Write(A[i, j] + "t");
            }
            Console.WriteLine();
        }

        // Замена отрицательных элементов на нули и положительных на единицы
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i, j] < 0) A[i, j] = 0;
                else A[i, j] = 1;
            }
        }

        // Вывод нижней треугольной матрицы в общепринятом виде
        Console.WriteLine("Нижняя треугольная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j <= i) Console.Write(A[i, j] + " ");
                else Console.Write("  ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
*/
/*5. Строки.
С клавиатуры вводятся строки S, S1, S2. Заменить в строке S все вхождения
строки S1 на строку S2.
 using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод строк S, S1 и S2 с клавиатуры
        Console.Write("Введите строку S: ");
        string S = Console.ReadLine();
        Console.Write("Введите строку S1: ");
        string S1 = Console.ReadLine();
        Console.Write("Введите строку S2: ");
        string S2 = Console.ReadLine();

        // Замена вхождений строки S1 на строку S2 в строке S
        S = S.Replace(S1, S2);

        // Вывод результирующей строки S на экран
        Console.WriteLine("Результат замены: " + S);

        Console.ReadKey();
    }
}
*/
/*6. Работа с файлами
Исходная информация содержится в файле. Определить, сколько слов текста
имеют длину 1,2,3,…, 10 и более 10 символов. Вывести эти слова в
последовательности возрастания их длины. Слова очередной длины вывести с
новой строки.
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Открыть файл с текстом для чтения
        using (StreamReader sr = new StreamReader("text.txt"))
        {
            // Считать текст из файла
            string text = sr.ReadToEnd();

            // Разбить текст на слова
            string[] words = text.Split(new char[] { ' ', 't', 'n', 'r' },
                StringSplitOptions.RemoveEmptyEntries);

            // Создать словарь для хранения количества слов каждой длины
            Dictionary<int, int> wordCounts = new Dictionary<int, int>();

            // Посчитать количество слов каждой длины
            foreach (string word in words)
            {
                int length = word.Length;

                if (wordCounts.ContainsKey(length))
                {
                    wordCounts[length]++;
                }
                else
                {
                    wordCounts[length] = 1;
                }
            }

            // Отсортировать словарь по длине слов
            SortedDictionary<int, int> sortedWordCounts = new SortedDictionary<int, int>(wordCounts);

            // Вывести слова и их количество для каждой длины
            foreach (KeyValuePair<int, int> pair in sortedWordCounts)
            {
                Console.Write(pair.Key + " символов: ");

                for (int i = 0; i < pair.Value; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
*/
/*7. Методы
В программе обработку данных оформить в качестве метода. Дана символьная
строка и символ. Слово - последовательность символов между пробелами, не
содержащая пробелы внутри себя. Определить количество слов в строке,
оканчивающихся на заданный символ.
using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "Эта строка содержит несколько слов, которые оканчиваются на букву а.";
        char ch = 'а';

        int count = CountWordsEndingWith(text, ch);

        Console.WriteLine($"Количество слов, оканчивающихся на букву '{ch}': {count}");
    }

    static int CountWordsEndingWith(string text, char ch)
    {
        int count = 0;

        // Разбить строку на слова
        string[] words = text.Split(new char[] { ' ', 't', 'n', 'r' },
            StringSplitOptions.RemoveEmptyEntries);

        // Посчитать количество слов, оканчивающихся на заданный символ
        foreach (string word in words)
        {
            if (word.EndsWith(ch.ToString()))
            {
                count++;
            }
        }

        return count;
    }
}
*/
/*
 * 8. Структуры
Разработать программу, реализующую работу со структурой Аптека. В
программе необходимо создать базу данных (массив структур) из N записей (N
– определяется при работе программы), выполнить просмотр и поиск записи по
заданному критерию (вводится при работе программы). Поля структуры:
название лекарства, дата изготовления, срок годности.
using System;

struct Аптека
{
    public string Название;
    public DateTime Дата_изготовления;
    public TimeSpan Срок_годности;

    public Аптека(string название, DateTime дата_изготовления, TimeSpan срок_годности)
    {
        Название = название;
        Дата_изготовления = дата_изготовления;
        Срок_годности = срок_годности;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество записей в базе данных: ");
        int n = int.Parse(Console.ReadLine());

        // Создать массив структур Аптека
        Аптека[] база_данных = new Аптека[n];

        // Заполнить массив данными
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите название лекарства {i + 1}: ");
            string название = Console.ReadLine();

            Console.Write($"Введите дату изготовления лекарства {i + 1} в формате ДД.ММ.ГГГГ: ");
            DateTime дата_изготовления = DateTime.Parse(Console.ReadLine());

            Console.Write($"Введите срок годности лекарства {i + 1} в формате ДД.ММ.ГГГГ: ");
            TimeSpan срок_годности = TimeSpan.Parse(Console.ReadLine());

            база_данных[i] = new Аптека(название, дата_изготовления, срок_годности);
        }

        Console.WriteLine();

        // Вывести все записи в базе данных
        Console.WriteLine("Все записи в базе данных:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Лекарство {i + 1}: {база_данных[i].Название}, " +
                $"дата изготовления: {база_данных[i].Дата_изготовления}, " +
                $"срок годности: {база_данных[i].Срок_годности}");
        }

        Console.WriteLine();

        // Поиск записей по заданному критерию
        Console.Write("Введите критерий для поиска записей в базе данных: ");
        string критерий = Console.ReadLine();

        Console.WriteLine($"Найденные записи в базе данных по критерию '{критерий}':");

        for (int i = 0; i < n; i++)
        {
            if (база_данных[i].Название.Contains(критерий))
            {
                Console.WriteLine($"Лекарство {i + 1}: {база_данных[i].Название}, " +
                    $"дата изготовления: {база_данных[i].Дата_изготовления}, " +
                    $"срок годности: {база_данных[i].Срок_годности}");
            }
        }
    }
}
*/
/*9. Динамические списки
Разработать программу, реализующую работу с линейным списком. В
программе необходимо создать базу данных (список) из N записей (N –
определяется при работе программы), выполнить просмотр, поиск записи по
заданному критерию. Картинная галерея. Ведётся учёт экспонатов галереи:
наименование картины, художник, цена.
using System;
using System.Collections.Generic;

class Painting
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public decimal Price { get; set; }
}

class Gallery
{
    private List<Painting> paintings = new List<Painting>();

    public void AddPainting(Painting painting)
    {
        paintings.Add(painting);
    }

    public void ViewPaintings()
    {
        foreach (Painting painting in paintings)
        {
            Console.WriteLine("Name: {0}, Artist: {1}, Price: {2}", painting.Name, painting.Artist, painting.Price);
        }
    }

    public void SearchPaintings(string searchCriteria)
    {
        foreach (Painting painting in paintings)
        {
            if (painting.Name.Contains(searchCriteria) || painting.Artist.Contains(searchCriteria))
            {
                Console.WriteLine("Name: {0}, Artist: {1}, Price: {2}", painting.Name, painting.Artist, painting.Price);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Gallery gallery = new Gallery();

        Console.Write("Enter the number of paintings: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Painting painting = new Painting();

            Console.Write("Enter the name of painting {0}: ", i + 1);
            painting.Name = Console.ReadLine();

            Console.Write("Enter the artist of painting {0}: ", i + 1);
            painting.Artist = Console.ReadLine();

            Console.Write("Enter the price of painting {0}: ", i + 1);
            painting.Price = decimal.Parse(Console.ReadLine());

            gallery.AddPainting(painting);
        }

        Console.WriteLine("All paintings:");
        gallery.ViewPaintings();

        Console.Write("Enter search criteria: ");
        string searchCriteria = Console.ReadLine();

        Console.WriteLine("Paintings matching search criteria:");
        gallery.SearchPaintings(searchCriteria);

        Console.ReadKey();
    }
}
*/
/* 10. Классы
Разработать класс для определения одномерных массивов строк
фиксированной длины. В классе определить методы создания массива,
просмотра и поиска.
using System;

class StringArray
{
    private string[] array;

    public StringArray(int length)
    {
        array = new string[length];
    }

    public void SetElement(int index, string value)
    {
        array[index] = value;
    }

    public string GetElement(int index)
    {
        return array[index];
    }

    public void ViewArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Element {0}: {1}", i, array[i]);
        }
    }

    public int Search(string value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                return i;
            }
        }

        return -1;
    }
}

class Program
{
    static void Main()
    {
        StringArray array = new StringArray(5);

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter element {0}: ", i);
            string value = Console.ReadLine();
            array.SetElement(i, value);
        }

        Console.WriteLine("Array elements:");
        array.ViewArray();

        Console.Write("Enter search value: ");
        string searchValue = Console.ReadLine();

        int index = array.Search(searchValue);

        if (index != -1)
        {
            Console.WriteLine("Search value found at index {0}", index);
        }
        else
        {
            Console.WriteLine("Search value not found");
        }

        Console.ReadKey();
    }
}
*/


}
}
}
