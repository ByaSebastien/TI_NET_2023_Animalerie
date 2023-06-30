using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_Animalerie.Models
{
    public class Dog : Animal
    {

        public Dog(string name, double weight, int height, GenderType gender, int age, DateTime arrival, string collarColor, bool isEducate, string race) : base(name, weight, height, gender, age, arrival)
        {
            CollarColor = collarColor;
            IsEducate = isEducate;
            Race = race;
        }

        public string CollarColor { get; set; }
        public bool IsEducate { get; set; }
        public string Race { get; set; }
        public override double DeathProbability => .01;

        public override string ToString()
        {
            return base.ToString() +
                $"Couleur de son collier : {CollarColor}\n" +
                $"_____________________________________________\n";
        }
    }
}
