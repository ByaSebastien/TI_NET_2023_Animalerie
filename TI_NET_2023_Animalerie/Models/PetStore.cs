using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_Animalerie.Models
{
    public class PetStore
    {
        public List<Animal> Animals { get; }
        public PetStore()
        {
            Animals = new List<Animal>();
        }

        public void AddAnimal()
        {
            Console.WriteLine("1 : Chat\n2 : Chien\n3 : Oiseau");
            int animalType;
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out animalType) || !(animalType >= 1 && animalType <= 3));
            Console.Write("Nom : ");
            string name = Console.ReadLine() ?? "Roger";
            Console.Write("Poids : ");
            double weight;
            do
            {
            } while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0);
            Console.Write("Taille : ");
            int height;
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out height) || height <= 0);
            foreach (GenderType genderType
                in Enum.GetValues<GenderType>())
            {
                Console.WriteLine($"{(int)genderType + 1} : {genderType}");
            }
            int genderChoice;
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out genderChoice) || !(genderChoice >= 1 && genderChoice <= Enum.GetValues<GenderType>().Length));
            GenderType gender = (GenderType)(genderChoice - 1);
            Console.WriteLine("Age : ");
            int age;
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out age) || age < 0);
            Console.WriteLine("Date d'arrivée ( jour-mois-année ) : ");
            DateTime arrival;
            do
            {
            } while (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out arrival));

            switch (animalType)
            {
                case 1:
                    foreach (PersonalityType personalityType in Enum.GetValues<PersonalityType>())
                    {
                        Console.WriteLine($"{(int)personalityType + 1} : {personalityType}");
                    }
                    int personalityChoice;
                    do
                    {
                    } while (!int.TryParse(Console.ReadLine(), out personalityChoice) || !(personalityChoice >= 1 && personalityChoice <= Enum.GetValues<PersonalityType>().Length));
                    PersonalityType personality = (PersonalityType)(personalityChoice - 1);
                    Console.WriteLine("Giffes coupées ?");
                    bool haveClawTrim = YesOrNo();
                    Console.WriteLine("Poil long ?");
                    bool isLongHair = YesOrNo();

                    Animals.Add(new Cat(name, weight, height, gender, age, arrival, personality, haveClawTrim, isLongHair));
                    break;
                case 2:

                    Console.Write("Couleur du collier : ");
                    string collarColor = Console.ReadLine() ?? "Rouge";
                    Console.WriteLine("Est il éduqué ?");
                    bool isEducate = YesOrNo();
                    Console.Write("Race : ");
                    string race = Console.ReadLine() ?? "Batard";

                    Animals.Add(new Dog(name, weight, height, gender, age, arrival, collarColor, isEducate, race));
                    break;
                case 3:

                    Console.Write("Couleur : ");
                    string color = Console.ReadLine() ?? "Jamaïque";
                    Console.WriteLine("Avez vous envie de l'emprisoner?");
                    bool isPrisoneer = YesOrNo();
                    Animals.Add(new Bird(name, weight, height, gender, age, arrival, color, isPrisoneer));
                    break;
            }
        }

        public bool YesOrNo()
        {
            Console.WriteLine("1 : Oui");
            Console.WriteLine("2 : Non");
            int choice;
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 1 && choice <= 2));
            return choice == 1;
        }

        public void ShowAll()
        {
            Animals.ForEach(a => Console.WriteLine(a));
        }

        public void ShowAmount()
        {
            int catAmount = 0;
            int dogAmount = 0;
            int birdAmount = 0;

            //catAmount = Animals.Count(a => a is Cat);
            //dogAmount = Animals.Count(a => a is Dog);
            //birdAmount = Animals.Count(a => a is Bird);

            foreach (Animal a in Animals)
            {
                switch (a)
                {
                    case Cat:
                        catAmount += 1;
                        break;
                    case Dog:
                        dogAmount += 1;
                        break;
                    case Bird:
                        birdAmount += 1;
                        break;
                }
            }
            Console.WriteLine($"Nombre de chat : {catAmount}");
            Console.WriteLine($"Nombre de chien : {dogAmount}");
            Console.WriteLine($"Nombre d'oiseau : {birdAmount}");

        }

        public void GoToSleep()
        {
            Random r = new Random();
            List<Animal> dieAnimals = new List<Animal>();
            foreach (Animal a in Animals)
            {
                if (r.Next(100 - (int)(100 * a.DeathProbability)) == 0)
                {
                    dieAnimals.Add(a);
                }
            }

            if (dieAnimals.Count > 0)
            {

                Console.WriteLine("Carnet de décès : ");

                foreach (Animal a in dieAnimals)
                {
                    Animals.Remove(a);
                    Console.WriteLine(a);
                }

            }
            Console.WriteLine(dieAnimals.Count > 0 ? "😿" : "🥰");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Animal a in Animals)
            {
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }
    }
}
