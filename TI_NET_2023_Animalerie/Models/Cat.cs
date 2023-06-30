using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_Animalerie.Models
{
    public class Cat : Animal
    {

        public Cat(string name, double weight, int height, GenderType gender, int age, DateTime arrival, PersonalityType personality, bool haveClawTrim, bool isLongHair) : base(name, weight, height, gender, age, arrival)
        {
            Personality = personality;
            HaveClawTrim = haveClawTrim;
            IsLongHair = isLongHair;
        }

        public PersonalityType Personality {  get; set; }
        public bool HaveClawTrim { get; set; }
        public bool IsLongHair { get; set; }
        public override double DeathProbability => .005;

        public override string ToString()
        {
            return base.ToString() +
                $"Personalité : {Personality}\n" +
                $"_____________________________________________\n";
        }
    }
}
