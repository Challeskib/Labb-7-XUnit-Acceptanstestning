using Labb_7___XUnit___Acceptanstestning.Models;
using Labb_7___XUnit___Acceptanstestning.Services;

namespace Labb_7___XUnit___Acceptanstestning
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunMenu();
        }

        public static void RunMenu()
        {
            Calculator calculator = new Calculator();

            int num1;
            int num2;

            bool exitMenu = false;

            while (!exitMenu)
            {
                
                Console.WriteLine("Press Key to Continue");
                Console.ReadKey();
                Console.Clear();
                ShowMenuOptions();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        GetNumbersFromUser(out num1, out num2);
                        int sum = calculator.Add(num1, num2);
                        SaveCalculations(IntToString(num1, num2, "+", sum));
                        break;
                    case "2":
                        GetNumbersFromUser(out num1, out num2);
                        int dif = calculator.Subtract(num1, num2);
                        SaveCalculations(IntToString(num1, num2, "-", dif));

                        break;
                    case "3":
                        GetNumbersFromUser(out num1, out num2);
                        int qoute = calculator.Multiply(num1, num2);
                        SaveCalculations(IntToString(num1, num2, "*", qoute));

                        break;
                    case "4":
                        GetNumbersFromUser(out num1, out num2);
                        int product = calculator.Divide(num1, num2);
                        SaveCalculations(IntToString(num1, num2, "/", product));

                        break;
                        case "5":
                        GetCalculations();
                        break;
                    default:
                        exitMenu = true;
                        break;
                }
            }
        }

        private static void GetCalculations()
        {
            DataContext context = new DataContext();

            foreach (var item in context.CalculatorLogs)
            {
                Console.WriteLine($"{item.Id} : {item.Log}");
            }

        }

        public static string IntToString(int a, int b, string mathOperator, int total)
        {
            string num1 = a.ToString();
            string num2 = b.ToString();
            string saveTotal = total.ToString();

            string everything = num1 + " " + mathOperator + " " + num2 + " = " + saveTotal;

            return everything;

        }

        public static void SaveCalculations(string input)
        {
            DataContext context = new DataContext();

            CalculatorLog log = new CalculatorLog();
            log.Log = input;
            context.CalculatorLogs.Add(log);
            context.SaveChanges();
        }



        public static void GetNumbersFromUser(out int num1, out int num2)
        {
            Console.WriteLine("Enter number 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            num2 = int.Parse(Console.ReadLine());
        }

        public static void ShowMenuOptions()
        {
            Console.WriteLine("Welcome to the Calculator Menu!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add two numbers");
            Console.WriteLine("2. Subtract two numbers");
            Console.WriteLine("3. Multiply two numbers");
            Console.WriteLine("4. Divide two numbers");
            Console.WriteLine("5. Get Calculations");
            Console.WriteLine("Enter your choice (1-5):");
        }
    }
}