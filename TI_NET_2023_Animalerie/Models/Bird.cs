using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_Animalerie.Models
{
    public class Bird : Animal
    {

        public Bird(string name, double weight, int height, GenderType gender, int age, DateTime arrival, string color, bool isPrisoneer) : base(name, weight, height, gender, age, arrival)
        {
            Color = color;
            IsPrisoneer = isPrisoneer;
        }

        public string Color { get; set; }
        public bool IsPrisoneer { get; set; }
        public override double DeathProbability => .03;
        //public override double DeathProbability { get { return 0.03; } }
        public override string ToString()
        {
            return base.ToString() +
                $"Couleur : {Color}\n" +
                $"_____________________________________________\n";
        }
    }
}
