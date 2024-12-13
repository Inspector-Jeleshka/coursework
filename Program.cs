namespace coursework
{
    internal static class Program
    {
        static void login()
        {
            Console.WriteLine("Войдите в систему");
            Console.WriteLine("1-Войти как сотрудник организации");
            Console.WriteLine("2-Войти как складской работник");
            
            int operatorType = Convert.ToInt32(Console.ReadLine());
            if (operatorType == 1)
                employeeMenu();
            else
                warehouseMenu();
        }
        static void employeeMenu()
        {
            while (true)
            {
                Console.WriteLine("1-Операции с клиентами");
                Console.WriteLine("2-Операции с заказами клиентов");
                Console.WriteLine("3-Операции с заказами поставщикам");

                int operationType = Convert.ToInt32(Console.ReadLine());
                switch (operationType)
                {
                    case 1:
                        operateClients();
                        break;
                    case 2:
                        //operateClientOrders();
                        break;
                    case 3:
                        //operateSupplierOrders();
                        break;
                }
            }
        }
        static void operateClients()
        {
            while (true)
            {
                Console.WriteLine("1-Вывести список клиентов");
                Console.WriteLine("2-Добавить клиента");
                Console.WriteLine("3-Изменить данные клиента");
                Console.WriteLine("4-Удалить клиента");

                int operationType = Convert.ToInt32(Console.ReadLine());
                switch (operationType)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
        }
        static void warehouseMenu()
        {

        }
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
