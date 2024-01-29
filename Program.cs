using System.ComponentModel;

namespace _esercizio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person gigi = new Person();



            gigi.Height = 100;
            gigi.Greet();

            Person simona = new Person();
            simona.Height = 180;
            simona.EyeColor = "blue";
            simona.Greet();

            Atlete Sinner = new Atlete();
            Sinner.Name = "Jannik";
            Sinner.Sport = "tennis";
            Sinner.Age = 22;
            Sinner.Nationality = "Italy";
            Sinner.Presentation();

            Employee Marco = new Employee();
            Marco.Name = "Marco";
            Marco.MonthlyPay = 1000;
            Marco.YearlyPay();

            Animal Pig = new Animal();
            Pig.Specie = "Maiali";
            Pig.Legs = 4;
            Pig.Number = 12;
            Pig.TotalLegs();

            Vehicle Car = new Vehicle();
            Car.Type = "Auto";
            Car.Model = "Punto";
            Car.Brand = "Fiat";
            Car.Price = 2000;
            Car.Year = 2005;
            Car.Summary();



        }
    }
    public class Person
    {
        public int Height = 180;
        public string EyeColor = "brown";
        public string PoliticalParty = "PCI";

        public void Greet()
        {
            Console.WriteLine("Il mio colore degli occhi è " + EyeColor + " " + Height.ToString());
        }
    }

    public class Atlete
    {
        public string Name;
        public string Sport;
        public int Age;
        public string Nationality;

        public void Presentation()
        {
            Console.WriteLine("Sono " + Name + " Gioco a " + Sport + " ho " + Age + " anni, e vengo da " + Nationality);
        }
    }
    
    public class Employee
    {
        public string Name;
        public int MonthlyPay;

        public void YearlyPay()
        {
            Console.WriteLine(Name + " ha guadagnato " + MonthlyPay * 12 + " euro in un anno.");
        }
    }

    public class Animal
    {
        public string Specie;
        public int Legs;
        public int Number;

        public void TotalLegs()
        {
            Console.WriteLine($"In un gruppo di {Number} {Specie} ci sono {Legs * Number} zampe.");
        }
    }

    public class Vehicle
    {
        public string Type;
        public string Model;
        public int Price;
        public int Year;
        public string Brand;

        public void Summary () {
            Console.WriteLine($"Questa è una {Type}, modello {Model}, anno {Year}, prodotta da {Brand} e costa {Price} euro.");
        }
    }
}

