using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
             * Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. 
             * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
             * Создать  несколько экземпляров класса, параметризированного различными типам. 
             * Заполнить его поля и вывести информацию об экземпляре класса на печать.*/

            //Пробы применения различных типов для обобщенного типа в классе Account

            Account<int> acc1 = new Account<int>(); //Инициализируем класс с обобщенным типом, с применением int
            acc1.NumAccount = 13;
            acc1.vWrite();
            acc1.vRead();
            Console.WriteLine("\n");
            Account<double> acc2 = new Account<double>();//Инициализируем класс с обобщенным типом, с применением double
            acc2.NumAccount = 13.13;
            acc2.vWrite();
            acc2.vRead();
            Console.WriteLine("\n");
            Account<string> acc3 = new Account<string>();//Инициализируем класс с обобщенным типом, с применением string
            acc3.NumAccount = "Тринадцать";
            acc3.vWrite();
            acc3.vRead();
            Console.WriteLine("\n");
                   
            Console.ReadKey();
        }
    }

    class Account<T> // Класс со счетом
    {
        T numAccount; //Переменные класса
        double balAccount;
        string nameOwner;

        public T NumAccount //Параметры
        {
            get
            {
                return numAccount;
            }
            set
            {
                numAccount = value;
            }
        }
        public double BalAccount
        {
            get
            {
                return balAccount;
            }
            set
            {
                balAccount = value;
            }
        }
        public string NameOwner
        {
            get
            {
                return nameOwner;
            }
            set
            {
                nameOwner = value;
            }
        }
        public void vWrite() //Метод для записи данных
        {
            Console.WriteLine("Введите ФИО владельца счета");
            nameOwner = Console.ReadLine();
            Console.WriteLine("Введите баланс счета");
            balAccount = Convert.ToDouble(Console.ReadLine());
            
        }
        public void vRead() //Метод для вывода на экран записанных данных
        {
            Console.WriteLine("Номер счета: {0}", numAccount);
            Console.WriteLine("Баланс счета: {0}", balAccount);
            Console.WriteLine("Владелец: {0}", nameOwner);
        }

    }

}
