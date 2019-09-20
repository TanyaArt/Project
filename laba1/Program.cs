using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void prim()
        {
            Console.WriteLine("Введите ваше имя");
            string str = Console.ReadLine();
            Console.WriteLine("Привет " + str + "!!!");
            Console.WriteLine("Введите  один символ с клавитуры");
            int kod = Console.Read(); char sim = (char)kod;
            Console.WriteLine("Код символа  " + sim + " = " + kod);
            Console.WriteLine("Код символа  {0} = {1}", sim, kod);

            int s1 = 255; int s2 = 32;
            Console.WriteLine(" \n{0,5}\n+{1,4}\n-----\n{2,5}", s1, s2, s1 + s2);
            Console.WriteLine(" \n{1,5}\n+{0,4}\n-----\n{2,5}", s1, s2, s1 + s2);

            string name = "Tom";
            int age = 33;
            bool isEmployed = false;
            double weight = 78.65;

            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {isEmployed}");

            Console.ReadKey();
        }

        static void type()
        {
            //1
            int i = 5; //целое число от -2147483648 до 2147483647, занимает 4 байта, System.Int32
            bool b = true; //System.Boolean
            char c = 'C'; //хранит одиночный символ в кодировке Unicode и занимает 2 байта, System.Char
            string s = "Hello A.T."; //System.String
            float fl = 9f; //System.Single
            double d = 10.5; //var dd = 15.3; //System.Double
            byte by = 2; //целое число от 0 до 255, занимает 1 байт, System.Byte
            sbyte sb = 1; //целое число от -128 до 127, занимает 1 байт, System.SByte
            short sh = 3; //целое число от -32768 до 32767, занимает 2 байта, System.Int16
            ushort ush = 4; //целое число от 0 до 65535, занимает 2 байта, System.UInt16
            uint ui = 6; //целое число от 0 до 4294967295, занимает 4 байта, System.UInt32
            long l = 7; //целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807, занимает 8 байт, System.Int64
            ulong ul = 8; //целое число от 0 до 18 446 744 073 709 551 615, занимает 8 байт, System.UInt64
            decimal m = 11; //десятичное дробное число, может хранить 28 знаков после запятой, занимает 16 байт, System.Decimal

            object oi = 22; //значение любого типа данных 
            object of = 3.14; //занимает 4 байта на 32 - разрядной платформе и 8 байт на 64 - разр.
            object os = "hello code"; //System.Object, 

            int ib = 0b101;  // бинарная форма 5
            int ix = 0xFF;   // шестнадцатеричная форма 255

            // 2
            float k = i; // Неявное преобразование
            double dou = k;
            int ini = by;
            int y = sh;
            double doub = fl;


            int n = (int)fl; // Явное преобразование
            byte byt = (byte)ini;
            float flo = (float)dou;
            short shor = (short)fl;
            int t = (int)d;

            //3
            int chi = 15;
            object ob = chi; // упаковка - перемещение значения из области стека в кучу, тип присваивается к ссылочному
            int vt = (int)ob; // распоковка - из кучи в стек, ссылочный к любому типу

            //4
            var a1 = 5; var ch = "Число: ";
            var a2 = a1 + 10;
            Console.WriteLine(ch + a2);

            //5

            int? z1 = 5;
            bool? enabled1 = null;
            Double? d1 = 3.3;

            Nullable<int> z2 = 5;
            Nullable<bool> enabled2 = null;
            Nullable<System.Double> d2 = 3.3;

            //свойства: Value, которое представляет значение объекта
            // HasValue проверяет наличие значения
            //структура Nullable применяется только для типов значений
            int? x = 7;
            Console.WriteLine(x.Value); // 7
            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("x is equal to null");
            /*
            int? nu = null;
            Console.WriteLine(nu.Value); //ошибка 
            */
            //структура Nullable позволяет использовать значение по умолчанию 
            int? figure = null;
            Console.WriteLine(figure.GetValueOrDefault()); // по умолчанию 0
            Console.WriteLine(figure.GetValueOrDefault(10)); // по умолчанию 10

            int? x1 = null;
            int? x2 = null;
            if (x1 == x2)
                Console.WriteLine("объекты равны");
            else
                Console.WriteLine("объекты не равны");

            //преобразования
            int? x3 = null;
            if (x3.HasValue)
            {
                int x4 = (int)x3;
                Console.WriteLine(x4);
            }

            int x5 = 4;
            int? x6 = x5;
            Console.WriteLine(x6);

            long? x7 = x5;
            Console.WriteLine(x7);

            long x8 = 4;
            int? x9 = (int?)x8;

            long? x10 = 4;
            int? x11 = (int?)x10;

            int x12 = (int)x10;

            Console.ReadKey();
        }

        static void stroki()
        {

            Console.WriteLine("Компания \"Рога и копыта\"");
            Console.WriteLine("Привет \n\tмир");

            char[] letters = { 'A', 'B', 'C' };
            string alphabet = new string(letters);
            Console.WriteLine(alphabet);

            var temp = "I'm still a strongly-typed System.String!";
            Console.WriteLine(temp);

            System.String greeting = "Hello World!";
            Console.WriteLine(greeting);

            string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";
            Console.WriteLine(newPath);

            string message3 = System.String.Empty;
            Console.WriteLine(message3);

            string message2 = null;
            Console.WriteLine(message2);

            //1
            //сравнение
            string str1 = " Hello ";
            string str2 = " Привет ";
            string str3 = " 2019 ";
            if (str1 == str2)
                Console.WriteLine("\nСтроки равны");
            else Console.WriteLine("\nСтроки не равны");

            // или
            int result = String.Compare(str1, str2);
            if (result < 0)

                Console.WriteLine("Строка 1 перед строкой 2\n");
            else if (result > 0)
            {
                Console.WriteLine("Строка 1 стоит после строки s\n");
            }
            else
            {
                Console.WriteLine("Строки 1 и 2 идентичны\n");
            }
            // Если первая строка по алфавиту стоит выше второй,
            //то возвращается число меньше нуля

            //или String.CompareOrdinal(str1, str2);


            //2
            // соединение/сцепление
            string str4 = str2 + str3;
            Console.WriteLine(str4);

            str4 = String.Concat(str1, "!!!");
            Console.WriteLine(str4);

            string[] st = new string[] { str1, "и", str2, str3 };//статический метод Join
            str4 = String.Join(" ", st); //параметры: строка-разделитель(пробел) и массив строк
            Console.WriteLine(str4);

            //копирование _________________________________!!!!!!!!!!!!!!!!!!
            string strS = "changed";
            char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ',
                'a', 'r', 'r', 'a', 'y' };
            //Console.WriteLine(destination);

            strS.CopyTo(0, destination, 4, strS.Length);
            Console.WriteLine(destination);

            //strS = "A different string";
            //strS.CopyTo(2, destination, 3, 9);
            //Console.WriteLine(destination);

            // разделение строки на слова
            string[] words = str4.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // надо удалить все пустые подстроки
            foreach (string s in words)
            {
                Console.WriteLine("\t" + s);
            }

            //вставка подстроки в заданную позицию
            string sub = " замечательный";
            str4 = str4.Insert(19, sub);
            Console.WriteLine(str4 + "!!!");

            //удаление заданной подстроки
            int ind = str4.IndexOf(sub);
            int ind2 = str4.LastIndexOf("й");
            str4 = str4.Remove(ind, ind2 - ind + 2); // (позиция, кол-во)
            Console.WriteLine(str4 + "!!!");

            // удаление можно заменить Заменой
            string text = "хороший день";

            text = text.Replace("хороший", "плохой");
            Console.WriteLine(text);

            text = text.Replace("о", "");
            Console.WriteLine(text);

            string hello = "Hello world!";

            //смена регистра
            Console.WriteLine(hello.ToUpper()); // HELLO WORLD!
            Console.WriteLine(hello.ToLower()); // hello world!

            //выделение подстроки  _____________________!!!!!!!!!!!!!!!!!!

            /*text = text.Substring(2);
            Console.WriteLine(text);
            text = text.Substring(0, text.Length - 2);
            Console.WriteLine(text);*/

            //3

            if ("hybhn" == string.Empty)
                Console.WriteLine("Да");
            else Console.WriteLine("нет");

            string b = null;
            Console.WriteLine(b);


            //4
            StringBuilder a = new StringBuilder(" Ужас начался ");
            Console.WriteLine("Длина строки " + a + " - " + a.Length);
            Console.WriteLine("Ёмкость строки " + a + " - " + a.Capacity);
            a.Replace("а", "@");
            a.Append("!");
            a.Insert(0, "Tanya");
            Console.WriteLine(a);
            a.Remove(0, 5);
            Console.WriteLine(a);

        }

        static void masiv()
        {
            int[] m1 = new int[4];
            // int[] m2 = new int[4] { 1, 2, 3, 5 };
            // int[] m3 = new int[] { 1, 2, 3, 5 };
            // int[] m4 = new[] { 1, 2, 3, 5 };
            // int[] m5 = { 1, 2, 3, 4 };
            m1[0] = 5;
            Console.WriteLine(m1[0]);

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in numbers) //только для чтения
            {
                //Console.WriteLine("\t"+i);
            }

            for (int i = 0; i < numbers.Length; i++) // можем выбирать элемент и изменять
            {
                numbers[i] = numbers[i] * 2;
                // Console.WriteLine(numbers[i]);
            }
            // int[,] nums1;
            // int[,] nums2 = new int[2, 3];
            // int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            // int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            // int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] m2 = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };  // двумерный

            int[,,] m3 = new int[2, 3, 4];  // трёхмерный

            // foreach (int a in m2)  //длина массива-кол-во элементов
            //Console.Write($"{a} ");
            Console.WriteLine();

            int rows = m2.GetUpperBound(0) + 1; // кол-во строк таблицы
            int columns = m2.Length / rows; //кол-во элементов в каждой строке
            Console.WriteLine(rows + " " + columns);
            // или так
            // int columns = mas.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{m2[i, j]} \t");
                }
                Console.WriteLine();
            }
            //2
            string[] st = { "Привет ", "мой ", "мир ", "!" };

            foreach (string s in st)
            {
                Console.WriteLine("\t" + s);
            }
            Console.WriteLine(st.Length);

            st[3] = ":)";
            Console.WriteLine(st[3] + "\n");

            //________________________
            int[][] nums = new int[3][]; // в первой указываем размер главного массива, вторая всегда пуста
            nums[0] = new int[2] { 1, 2 };          // выделяем память для первого подмассива
            nums[1] = new int[3] { 1, 2, 3 };       // выделяем память для второго подмассива
            nums[2] = new int[5] { 1, 2, 3, 4, 5 }; // выделяем память для третьего подмассива

            int[][,] nums2 = new int[3][,]
                {
                    new int[,] { {1,2}, {3,4} },
                    new int[,] { {1,2}, {3,6} },
                    new int[,] { {1,2}, {3,5}, {8, 13} }
                };

            foreach (int[] row in nums)
            {
                foreach (int num in row)
                {
                    Console.Write($"{num} \t");
                }
                Console.WriteLine();
            }

            // перебор с помощью цикла for
            /*for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write($"{nums[i][j]} \t");
                }
                Console.WriteLine();
            }*/

            Console.WriteLine("\n\n");

            //double[][] d = new double[2][];
            //d[0] = new double[1];
            //d[1] = new double[3];
            //for (int i = 0; i < d.Length; i++)
            //{
            //    for (int j = 0; j < d[i].Length; j++)
            //    {
            //       d[i][j] = Convert.ToDouble(Console.ReadLine());
            //        //Console.WriteLine(d[i][j]);
            //    }
            //}
            //Console.WriteLine();

            //foreach (double[] row in d)
            //{
            //    foreach (double num in row)
            //    {
            //        Console.Write($"{num} \t");
            //    }
            //    Console.WriteLine();
            //}

            //4

            var arr1 = new[] { 1, 2, 3 };
            Console.WriteLine("Тип массива arr1 - {0}", arr1.GetType());

            var arr2 = new[] { "One", "Two", "Three" };
            Console.WriteLine("Тип массива arr2 - {0}", arr2.GetType());

            // Объявляем и инициализируем массив объектов
            object[] arrByObject = { true, 10, "Привет", 13.7m };

            // Выведем в консоль тип каждого члена массива
            foreach (object me in arrByObject)
                Console.WriteLine("Тип {0} - {1}", me, me.GetType());

            var jagged = new[]
              { //ступенчатый массив неявно типизированный
                 new[] { 1, 2, 3, 4 },
                 new[] { 9, 8, 7 },
                 new[] { 11, 12, 13, 14, 15 }
              };
            var strr = "Охо-хо";

        }
        static void karteg()
        {
            (int, int) a = (3, 5);
            var b = ("H", "e", "l", "l", "o");
            //Console.WriteLine("Тип b" +b.GetType());

            var sm = 12.5;
            var cou = 5;
            var accumulation = (cou, sm);

            Console.WriteLine(a.Item1);
            Console.WriteLine(a.Item2);
            a.Item1 += 26;
            Console.WriteLine(a.Item1);

            var tuple = (count: 5, sum: 10);//название полей
            Console.WriteLine(tuple.count);

            var (name, age) = ("Tom", 23); // с полями кортеджа можно работать как с переменными
            Console.WriteLine(name);


            (int, string, char, ulong) c = (10, "можно", 'x', 100);

            // возвращение из ф-ции более двух значений
            var temp = GetValues();
            Console.WriteLine(temp.Item1);

            var t = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine(tuple.count);

            //кортеж может передаваться в качестве параметра в метод
            var (imya, god) = GetTuple(("Tom", 23), 12);
            Console.WriteLine(imya);

            (double su, var o, var p) = (34, 'r', "qwerty and ytrewq");

            //2
            var rrr = ("Althea", "Goodwin");
            if (("Althea", "Goodwin") == rrr)
                Console.WriteLine(rrr);
            Console.WriteLine(c);
            //3
            int k = god;

            //4
            var left = (a: 5, b: 10);
            var right = (a: 5, b: 10);
            (int a, int b)? nullableTuple = right;
            Console.WriteLine(left == nullableTuple);
            //в сравнении может быть неявное преобразование от меньшего к большему
            // при разных названиях полей может что- то произойти

            //могут быть вложенные кортежи
            (int, (int, int)) nestedTuple = (1, (2, 3));
            Console.WriteLine(nestedTuple == (1, (2, 3)));
            /*
            var left = (a: 5, b: 10);
            var right = (a: 5, b: 10);
            (int a, int b)? nullableTuple = right;
            Console.WriteLine(left == nullableTuple);*/

            Console.WriteLine();
        }
        //________________ к кортежам (не нужно)
        private static (int, int) GetValues() //может возвращать 2 значения
        {
            var result = (100, 300);
            return result;
        }

        private static (int sum, int count) GetNamedValues(int[] numbers)
        {
            var result = (sum: 0, count: 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
            }
            return result;
        }

        private static (string name, int age) GetTuple((string n, int a) tuple, int x)
        {
            var result = (name: tuple.n, age: tuple.a + x);
            return result;
        }
        //_________________

        static void Main(string[] args)
        {
            //prim();
            //type();
            // stroki();
            // masiv();
            //karteg();

            /* Func<int[], string, Tuple<int, int, int, char>> fun = (arr, str) => arr.Aggregate(Tuple.Create(Int32.MinValue, Int32.MaxValue, 0, str[0]), (y, x) => Tuple.Create(Math.Max(y.Item1, x), Math.Min(y.Item2, x), y.Item3 + x, y.Item4));
             Console.WriteLine(fun(new int[] { 1, -2, 3, -4, 5, -6, 7, -8, 9, 0 }, "Abracadabra"));
            */
            int[] a = { 2, 10, 23, 0, 4 };
            string b = "что-то странное";

            ValueType LocalFunc(int[] c, string d) // Локальная функция
            {
                int max = c.Max(), min = c.Min(), sum = c.Sum();
                char y = b[0];

                (int, int, int, char) k = (max, min, sum, y);
                return k;
            }

            var g = LocalFunc(a, b); // Вызов локальной функции
            Console.WriteLine(g);


            Console.ReadKey();
        }
    }
}
