using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_Animalerie.Models
{
    public class App
    {
        private PetStore _petStore;
        private bool _isRunning;
        public App()
        {
            _petStore = new PetStore();
            _isRunning = true;
        }
        public void Start()
        {
            Console.WriteLine("Welcome on board!");
            do
            {
                Console.Clear();
                int choice = MainMenu();

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye have a great time");
                        _isRunning = false;
                        return;
                    case 1:
                        _petStore.AddAnimal();
                        break;
                    case 2:
                        //Console.WriteLine(_petStore);
                        _petStore.ShowAll();
                        Console.ReadKey(true);
                        break;
                    case 3:
                        _petStore.ShowAmount();
                        Console.ReadKey(true);
                        break;
                    case 4:
                        _petStore.GoToSleep();
                        Console.ReadKey(true);
                        break;
                }
            } while (_isRunning);
        }

        private int MainMenu()
        {
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("1 : Ajouter un animal");
            Console.WriteLine("2 : Lister les animaux");
            Console.WriteLine("3 : Info");
            Console.WriteLine("4 : Passer la nuit");
            Console.WriteLine("0 : Quitter");
            Console.WriteLine("__________________________________________________");
            int choice;
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 0 && choice <= 4));
            return choice;
        }
    }
}
