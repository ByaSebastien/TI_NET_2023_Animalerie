using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_Animalerie.Models
{
    public abstract class Animal
    {
        protected Animal(string name, double weight, int height, GenderType gender, int age, DateTime arrival)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Gender = gender;
            Age = age;
            Arrival = arrival;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public GenderType Gender { get; set; }
        public int Age { get; set; }
        public int HumanAge => Age * 7;
        public DateTime Arrival { get; set; }
        public abstract double DeathProbability { get; }

        public override string ToString()
        {
            return
                $"_____________________________________________\n" +
                $"Nom : {Name}\n" +
                $"Genre : {Gender}\n" +
                $"Age : {Age} mois\n" +
                $"Date d'arrivée {Arrival.ToShortDateString()}\n";
        }
    }
}

