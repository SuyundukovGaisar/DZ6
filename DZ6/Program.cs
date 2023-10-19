using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    abstract class Detective
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Investigate();

        public virtual void DisplayInfo()
        {
            Console.WriteLine("ФИО: " + Name);
            Console.WriteLine("Возраст: " + Age);
        }
    }
    class MainDetective : Detective
    {
        public string Rank { get; set; }
        public string FieldOfWork { get; }
        public MainDetective(string name, int age, string rank) : base()
        {
            Name = name;
            Age = age;
            Rank = rank;
            FieldOfWork = "Криминалистика и уголовные дела";
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Звание: " + Rank);
            Console.WriteLine("Область работы: " + FieldOfWork);
        }
        public override void Investigate()
        {
            Console.WriteLine("Главный следователь " + Name + " расследует преступления");
        }
        public void CollectEvidence()
        {
            Console.WriteLine("Главный следователь " + Name + " собирает улики");
        }
    }
    class DetectiveSupport : Detective
    {
        public string Specialization { get; }
        public string Rank { get; set; }
        public DetectiveSupport(string name, int age, string rank) : base()
        {
            Name = name;
            Age = age;
            Specialization = "мелкие преступления, кражи, административные дела";
            Rank = rank;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Звание: " + Rank);
        }
        public override void Investigate()
        {
            Console.WriteLine("Помощник " + Name + " помогает главному следователю расследовать преступления");
        }
        public void Specializate()
        {
            Console.WriteLine("Специализация: " + Specialization);
        }
        public void InterrogateSuspect()
        {
            Console.WriteLine("Помощник " + Name + " допрашивает подозреваемых");
        }

    }
    class Judge
    {
        public string Name { get; set; }
        public int Age { get; }
        public string Rank { get; }
        public Judge(string name, int age, string rank)
        {
            Name = name;
            Age = age;
            Rank = rank;
        }
        public void PrintInfo()
        {
            Console.WriteLine("ФИО: " + Name);
            Console.WriteLine("Возраст: " + Age);
            Console.WriteLine("Должность: " + Rank);
        }
        public void Inviolability()
        {
            Console.WriteLine(Rank + " " + Name + " имеет неприкосновенность");
        }
        public void Interaction()
        {
            Console.WriteLine(Rank + " " + Name + " взаимодействует с главным следователем и его помощником");
        }
        public void Punishes()
        {
            Console.WriteLine("Мировой судья " + Name + "избирает меру наказания для нарушителей");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MainDetective maindetective = new MainDetective("Борисов Андрей Георгиевич", 40, "Главный следователь");
            DetectiveSupport support = new DetectiveSupport("Петров Александр Федорович", 29, "Помощник следователя");
            Judge judge = new Judge("Алексеев Игорь Сергеевич ", 55, "Мировой судья");
            maindetective.DisplayInfo();
            maindetective.CollectEvidence();
            maindetective.Investigate();
            Console.WriteLine();
            support.DisplayInfo();
            support.Specializate();
            support.InterrogateSuspect();
            support.Investigate();
            Console.WriteLine();
            judge.PrintInfo();
            judge.Interaction();
            judge.Inviolability();
            judge.Punishes();
        }
    }
}
