using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPLab4._3
{
    class Bot
    {
        private string name;
        private int weight;
        private int health;

        public void setValues(string name, int weight, int health)
        {
            this.name = name;
            this.weight = weight;
            this.health = health;
        }
        
        public void printValues()
        {
            Console.WriteLine("Name is: " + this.name);
            Console.WriteLine("Weight is: " + this.weight);
            Console.WriteLine("Health is: " + this.health);
        }
    }

    class BotWithWings : Bot
    {
        public void Wings()
        {
            Console.WriteLine("This bot has wings");
        }
    }

    class BotWithLazer : Bot
    {
        public void Lazer()
        {
            Console.WriteLine("This bot has lazer");
        }
    }

    class BotWithBomb : Bot
    {
        public void Bomb()
        {
            Console.WriteLine("This bot has bomb");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of bot do you want to create?");
            Console.WriteLine("1 - default");
            Console.WriteLine("2 - with wings");
            Console.WriteLine("3 - with lazer");
            Console.WriteLine("4 - with bomb");
            int selectBot = int.Parse(Console.ReadLine());
            switch (selectBot)
            {
                case 1:
                    Bot bot = new Bot();
                    Console.WriteLine("Enter bot's name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter bot's weight");
                    int weight = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter bot's health");
                    int health = int.Parse(Console.ReadLine());
                    bot.setValues(name, weight, health);
                    bot.printValues();
                    break;
                case 2:
                    BotWithWings botWithWings = new BotWithWings();
                    Console.WriteLine("Enter bot's name");
                    string Wname = Console.ReadLine();
                    Console.WriteLine("Enter bot's weight");
                    int Wweight = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter bot's health");
                    int Whealth = int.Parse(Console.ReadLine());
                    botWithWings.setValues(Wname, Wweight, Whealth);
                    botWithWings.printValues();
                    botWithWings.Wings();
                    break;
                case 3:
                    BotWithLazer botWithLazer = new BotWithLazer();
                    Console.WriteLine("Enter bot's name");
                    string Lname = Console.ReadLine();
                    Console.WriteLine("Enter bot's weight");
                    int Lweight = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter bot's health");
                    int Lhealth = int.Parse(Console.ReadLine());
                    botWithLazer.setValues(Lname, Lweight, Lhealth);
                    botWithLazer.printValues();
                    botWithLazer.Lazer();
                    break;
                case 4:
                    BotWithBomb botWithBomb = new BotWithBomb();
                    Console.WriteLine("Enter bot's name");
                    string Bname = Console.ReadLine();
                    Console.WriteLine("Enter bot's weight");
                    int Bweight = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter bot's health");
                    int Bhealth = int.Parse(Console.ReadLine());
                    botWithBomb.setValues(Bname, Bweight, Bhealth);
                    botWithBomb.printValues();
                    botWithBomb.Bomb();
                    break;
            }
            



        }
    }
}
