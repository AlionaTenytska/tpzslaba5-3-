using System;

namespace tpzslaba5_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Корабль: ");
            Ship A = new Ship("Алые паруса", "балкер", 125, 569, "дизель");
            Console.WriteLine("");
            Console.WriteLine("Авианосец: ");
            Aircraft_carrier B = new Aircraft_carrier("Руслан", "авианосец", 235, 5869, "дизель", "Туполев Ту-134 ", 5);
            Console.WriteLine("");
            Console.WriteLine("Ракетоносец: ");
            Missile_carrier C = new Missile_carrier("Интерпрайз", "рактоносец", 368, 4783, "дизель", "земля-земля", 2);
            Console.ReadKey();
        }
    }

    class Ship
    {
        private string name;
        private string purpose;
        private int water_tonnage;
        private int dvigun_tighter;
        private string type_of_fue;
        public Ship(string name, string purpose, int water_tonnage, int dvigun_tighter, string type_of_fue)
        {
            this.name = name;
            this.purpose = purpose;
            this.water_tonnage = water_tonnage;
            this.dvigun_tighter = dvigun_tighter;
            this.type_of_fue = type_of_fue;
            Console.WriteLine("Название: "+name);
            Console.WriteLine("Предназначение: " + purpose);
            Console.WriteLine("Водотонажность: " + water_tonnage);
            Console.WriteLine("Мощность двигателя: " + dvigun_tighter);
            Console.WriteLine("Вид топлева: " + type_of_fue);
        }
    }

    class Aircraft_carrier: Ship
    {
        private string aircraft_name;
        private int number;
        public Aircraft_carrier(string name, string purpose, int water_tonnage, int dvigun_tighter, string type_of_fue, string aircraft_name, int number): base( name,  purpose,  water_tonnage,  dvigun_tighter,  type_of_fue)
        {
            this.aircraft_name = aircraft_name;
            this.number = number;
            Console.WriteLine("Название самолета: " + aircraft_name);
            Console.WriteLine("Количество: " + number);


        }

    }
    class Missile_carrier: Ship
    {
        private string missile_type;
        private int number_r;
        public Missile_carrier(string name, string purpose, int water_tonnage, int dvigun_tighter, string type_of_fue, string missile_type, int number_r): base(name, purpose, water_tonnage, dvigun_tighter, type_of_fue)
        {
            this.missile_type = missile_type;
            this.number_r = number_r;
            Console.WriteLine("Тип ракет: " + missile_type);
            Console.WriteLine("Количество: " + number_r);

        }
    }
}
