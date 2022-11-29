using InspectorLib;

namespace PlaskinaInspectorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp functionInsp = new FunctionInsp();

            functionInsp.GetInspector("Васильев Василий Иванович");//Вывод главного инспектора
            functionInsp.GetСarInspection("Автоинспекция г. Чита");//Вывод названия автоинспекции
            functionInsp.SetInspector("");//Изменение ФИО главного инспектора
            functionInsp.GenerateNumber(7, 'F');//Вывод госномера
            functionInsp.GetWorker();//Вывод списка сотрудников автоинспекции
            functionInsp.AddWorker();//Добавление сотрудника автоинспекции
        }
    }
}
