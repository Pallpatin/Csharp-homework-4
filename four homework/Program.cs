using System.ComponentModel.DataAnnotations;
using System.IO.IsolatedStorage;
using System.Runtime.Intrinsics.Arm;
using System.Data;
internal class Program
{
    private static void Main(string[] args)
    {
        int TaskNumber = 1;
        goto here;
        Console.WriteLine("Задание № " + TaskNumber++);
        Console.WriteLine("Создайте приложение калькулятор для перевода числа \r\nиз одной системы исчисления в другую. Пользователь с помощью меню выбирает направление перевода. Например, \r\nиз десятичной в двоичную. После выбора направления, \r\nпользователь вводит число в исходной системе исчисления. \r\nПриложение должно перевести число в требуемую систему. Предусмотреть случай выхода за границы диапазона, \r\nопределяемого типом int, неправильный ввод");
        Task1();
        Console.WriteLine("нажмите любую клавишу для продолжения");
        Console.ReadKey(true);
        Console.WriteLine("Задание № " + TaskNumber++);
        Console.WriteLine("Пользователь вводит словами цифру от 0 до 9. Приложение должно перевести слово в цифру. Например, если \r\nпользователь ввёл , приложение должно вывести на \r\nэкран 5.");
        Task2();
        Console.WriteLine("нажмите любую клавишу для продолжения");
        Console.ReadKey(true);

        Console.WriteLine("Задание № " + TaskNumber++);
        Console.WriteLine("Создайте класс «Заграничный паспорт».Вамнеобходимо \r\nхранить информацию о номере паспорта, ФИО владельца, \r\nдате выдачи и т.д. Предусмотреть механизмы для инициализации полей класса. Если значение для инициализации \r\nневерное, генерируйте исключение.");
        Console.WriteLine("введите фио");
        Passport passport = new Passport(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
        Console.WriteLine("нажмите любую клавишу для продолжения");
        Console.ReadKey(true);
        here:
        Console.WriteLine("Задание № " + TaskNumber++);
        Console.WriteLine("Пользователь вводит в строку с клавиатуры логическое \r\nвыражение. Например, 3>2 или 7<3. Программа должна \r\nпосчитать результат введенного выражения и дать резуль\u0002тат true или false. В строке могут быть только целые числа \r\nи операторы: <, >, <=, >=, ==, !=. Для обработки ошибок \r\nввода используйте механизм исключений.");
        Task4();
        Console.WriteLine("нажмите любую клавишу для продолжения");
        Console.ReadKey(true);
    }
    public static void Task1()
    {
        /*Создайте приложение калькулятор для перевода числа 
из одной системы исчисления в другую. Пользователь с помощью меню выбирает направление перевода. Например, 
из десятичной в двоичную. После выбора направления, 
пользователь вводит число в исходной системе исчисления. 
Приложение должно перевести число в требуемую систему. Предусмотреть случай выхода за границы диапазона, 
определяемого типом int, неправильный ввод*/
        Console.WriteLine("Из какой системы исчисления вы хотите конвертировать число 2,8,10");
        int from;
        do
        {
            from = int.Parse(Console.ReadLine());
        } while (from != 2 && from != 8 && from != 10);
        Console.WriteLine("В какую систему исчисления вы хотите конвертировать число 2,8,10,16");
        int to;
        do
        {
            to = int.Parse(Console.ReadLine());
        } while (from != 2 && from != 8 && from != 10 && from != 16);
        Console.WriteLine("введите число");
        string value = Console.ReadLine();
        if (long.Parse(value) > int.MaxValue || long.Parse(value) < int.MinValue)
        {
            Console.WriteLine("неправильный ввод");
        }
        Console.WriteLine("Ответ " + Convert.ToString(Convert.ToUInt32(value, from), to));


    }
    enum Numbereng
    {
        zero, one, two, three, four, five, six, seven, eight, nine, ten
    }
    enum Numberrus
    {
        ноль, один, два, три, четыре, пять, шесть, семь, восемь, девять
    }
    public static void Task2()
    {
        /*Пользователь вводит словами цифру от 0 до 9. Приложение должно перевести слово в цифру. Например, если 
пользователь ввёл , приложение должно вывести на 
экран 5.*/
        Console.WriteLine("Введите цифру буквами");
        string word = Console.ReadLine().ToLower();
        if (Enum.TryParse(word, true, out Numbereng resulteng))
        {
            Console.WriteLine(" Ответ "+ (int)resulteng);
        }
        else if (Enum.TryParse(word, true, out Numberrus resultrus))
        {
            Console.WriteLine(" Ответ " + (int)resultrus);
        }
        else { Console.WriteLine("неверный ввод"); }
    }
    class Passport
    {
        /*Создайте класс «Заграничный паспорт».Вамнеобходимо 
хранить информацию о номере паспорта, ФИО владельца, 
дате выдачи и т.д. Предусмотреть механизмы для инициализации полей класса. Если значение для инициализации 
неверное, генерируйте исключение.*/

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _Lastname;

        public string Lastname
        {
            get { return _Lastname; }
            set { _Lastname = value; }
        }
        private string _familyname;

        public string Familyname 
        {
            get { return _familyname; }
            set { _familyname = value; }
        }

        private DateOnly _DateOnly;
        public Passport(string name,string surname,string fazername)
        {
            _DateOnly = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (string.IsNullOrEmpty(name) ) { throw new Exception(); }
            Name = name;
            if (string.IsNullOrEmpty(surname)) { throw new Exception(); }
            Lastname = surname;
            if (string.IsNullOrEmpty(fazername)) { throw new Exception(); }
            Familyname = fazername;
        }

    }
    public static void Task4()
    {
        /*Пользователь вводит в строку с клавиатуры логическое 
выражение. Например, 3>2 или 7<3. Программа должна 
посчитать результат введенного выражения и дать результат true или false. В строке могут быть только целые числа 
и операторы: <, >, <=, >=, ==, !=. Для обработки ошибок 
ввода используйте механизм исключений.*/
        Console.WriteLine("введите логическое выражение");
        string str = Console.ReadLine();
        DataTable dt = new DataTable();
        bool result = (bool)dt.Compute(str, "");
        Console.WriteLine(result);
    }
}
