namespace InspectorLib
{
    public class FunctionInsp
    {
        string[] FIO = { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };//Список сотрудников
        string[] leaderFIO = { "Васильев Василий Иванович" };//ФИО главного инспектора

        public void GetInspector(string name)//1 метод возращающий ФИО главного автоинспектора
        {
            Console.WriteLine($"Главный инспектор – {name}");//Вывод имени главного автоинспектора
        }

        public void GetСarInspection(string name1)//2 метод возращающий названия автоинспекции
        {
            Console.WriteLine($"Название – {name1}");//Вывод названия автоинспекции
        }

        public string SetInspector(string fullName)//3 метод позволяет изменить ФИО главного автоинспектора
        {
            Console.WriteLine("Выберите имя главного инспектора (Введите число от 1 до 4)");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                fullName = FIO[0];
                FIO = leaderFIO;
                Console.WriteLine($"Главный инспектор - {fullName}");
                return fullName;
            }
            else if (a == 2)
            {
                fullName = FIO[1];
                FIO = leaderFIO;
                Console.WriteLine($"Главный инспектор - {fullName}");
                return fullName;
            }
            else if (a == 3)
            {
                fullName = FIO[2];
                FIO = leaderFIO;
                Console.WriteLine($"Главный инспектор - {fullName}");
                return fullName;
            }
            else if (a == 4)
            {
                fullName = FIO[3];
                FIO = leaderFIO;
                Console.WriteLine($"Главный инспектор - {fullName}");
                return fullName;
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 4");//Вывод в консоль ошибки
                return fullName;
            }
        }

        public string GenerateNumber(int number, char symbol, int code = 75) //4 метод возвращает сгенерированный госномер
        {
            string result = symbol + "";
            result = result.ToUpper() + "-" + number + "-" + code;
            Console.WriteLine("Госномер:" + result);//Вывод полученного госномера в консоль
            return result;//Возращение переменной result
        }

        public void GetWorker()//5 метод возращает список сотрудников
        {
            string[] FullName = new string[] { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };//Объявляем массив
            Span<string> FullNameSpan = FullName;//Преобразуем массив в Span

            foreach (var staff in FullNameSpan)
            {
                Console.WriteLine("Список сотрудников автоинспекции: " + staff);
            }
        }

        public void AddWorker()//6 метод добавляет нового сотрудника
        {
            Console.WriteLine("Введите ФИО нового сотрудника");
            string worker = Console.ReadLine();//Вводим ФИО сотрудника
            Array.Resize(ref FIO, FIO.Length + 1);
            FIO[FIO.Length - 1] = worker;//Изменяем размер массива
            Console.WriteLine($"Сотрудник {worker} успешно добавлен");
        }
    }
}