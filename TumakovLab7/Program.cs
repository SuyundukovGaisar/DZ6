using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab7
{
    public enum AccountType
    {
        Current,
        Saving
    }
    public class Account
    {
        private static int nextAccountNumber;
        private int AccountNumber;
        private int Balance;
        private AccountType Accounttype;

        public Account()
        {
            AccountNumber = GenerateAccountNumber();

        }

        private int GenerateAccountNumber()
        {
            Random rand = new Random();
            nextAccountNumber = rand.Next();
            return nextAccountNumber;
        }

        public static int GetNextAccountNumber()
        {
            return ++nextAccountNumber;
        }

        public Account GetAccount()
        {
            Account account = new Account();
            account.Balance = 15000;
            account.Accounttype = AccountType.Current;
            return account;
        }
        public int TakeoffAccount(int amount)
        {

            if (amount <= Balance)
            {
                Balance -= amount;
                return Balance;
            }
            else
            {
                return -1;
            }
        }

        public void PutonAccount(int amount)
        {

            Balance += amount;
        }

        public void PrintNewBalance()
        {
            Balance = 15000;
            Console.WriteLine("Снять или пополнить?(после ввода нажмите enter)");
            string str = Console.ReadLine();
            str = str.ToLower();
            if (str == "снять")
            {
                Console.WriteLine("Введите сумму для снятия(после ввода нажмите enter):");
                int amount = int.Parse(Console.ReadLine());
                int newBalance = TakeoffAccount(amount);
                if (newBalance == -1)
                {
                    Console.WriteLine("Недостаточно средств на счете");
                }
                else
                {
                    Console.WriteLine($"Новый баланс: {newBalance}");
                }
            }
            else if (str == "пополнить")
            {
                Console.WriteLine("Введите сумму для пополнения(после ввода нажмите enter):");
                int amount = int.Parse(Console.ReadLine());
                PutonAccount(amount);
                Console.WriteLine($"Новый баланс: {Balance}");
            }
        }

        public void Print()
        {
            Console.WriteLine($"Номер: {AccountNumber}");
            Console.WriteLine($"Баланс: {Balance}");
            Console.WriteLine($"Тип счета: {Accounttype}");
        }

    }
    class Building
    {
        private static int nextBuildingNumber;
        private int BuildingNumber;
        private int Height;
        private int Floors;
        private int Floats;
        private int entrances;
        private int HeightFloor;
        private int FloatsEntrance;
        private int FloatsFloor;

        public Building GetBuilding()
        {
            Building building = new Building();
            building.BuildingNumber = GenerateBuildingNumber();
            building.Height = 40;
            building.Floors = 10;
            building.Floats = 40;
            building.entrances = 1;
            return building;

        }
        public int GenerateBuildingNumber()
        {
            Random random = new Random();
            nextBuildingNumber = random.Next();
            return nextBuildingNumber;
        }

        public static int NextBuildingNumber()
        {
            return ++nextBuildingNumber;
        }
        public void Print()
        {
            Console.WriteLine($"Номер здания: {BuildingNumber}");
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Кол-во этажей: {Floors}");
            Console.WriteLine($"Кол-во квартир: {Floats}");
            Console.WriteLine($"Кол-во подъездов: {entrances}");
            Console.WriteLine($"Следующий номер здания: {nextBuildingNumber = NextBuildingNumber()}");
        }
        public void CalculateHeightFloor()
        {
            HeightFloor = Height / Floors;
        }

        public void CalculateFloatsEntrance()
        {
            FloatsEntrance = Floats / entrances;
        }

        public void CalculateFloatsFloor()
        {
            FloatsFloor = Floats / Floors;
        }
        public void PrintCalculaions()
        {
            Console.WriteLine($"Высота этажа: {HeightFloor}");
            Console.WriteLine($"Кол-во квартир в подъезде: {FloatsEntrance}");
            Console.WriteLine($"Кол-во квартир на этаже: {FloatsFloor}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 7.1 - 7.3(Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета)");
            Account BankAccount = new Account().GetAccount();
            BankAccount.Print();
            Console.WriteLine($"Следующий номер счета: {Account.GetNextAccountNumber()}");
            Console.WriteLine();
            Account BankAccount1 = new Account();
            BankAccount1.PrintNewBalance();
            Console.WriteLine();

            Console.WriteLine("Домашнее задание 7.1(Реализовать класс для описания здания)");
            Building building = new Building().GetBuilding();
            building.Print();
            Console.WriteLine();
            building.CalculateHeightFloor();
            building.CalculateFloatsEntrance();
            building.CalculateFloatsFloor();
            building.PrintCalculaions();
            Console.WriteLine();
        }
    }
}
