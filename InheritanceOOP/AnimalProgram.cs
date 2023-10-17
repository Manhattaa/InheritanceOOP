using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class AnimalProgram
    {
        static void Main(string[] args)
        {
            bool isMulticolored = false;
            Lion lion = new Lion("Simba", 8, "Savanna", 200, "Gazelle", "Male", true, false, true);
            Cow blinda = new Cow("Blinda", 12, "Farm", 250, "Grass", "Female", true, false, true);
            Dog fido = new Dog("Fido", 5, "Your house", 20, "Anything, especially couches", "Male", true, false, true);
            Rabbit big_chungus = new Rabbit("Big Chungus", 7, "Woods", 15, "memes", "Male", false, true, false);
            
            //Tarantula
            Tarantula aragog = new Tarantula("Aragog", 5, "Forbidden Forest", 1, "Hogwarts Students", "Male", true, true, true);

            // Skapa 5 reptiler
            Crocodile tick_tock = new Crocodile("Tick-Tock", 50, "Swamp", 1000, "Fish", "Female", true, false, true);
            Reptile snek = new Reptile("Sir Hiss", 5, "Kingdom of England", 10, "Rodents", "Male", 0, 30, false, false, true);
            Reptile donatello = new Reptile("Donatello", 30, "Sewers", 100, "Pizza", "Male", 4, 150, false, true, false);
            Reptile iggy = new Reptile("Iggy", 4, "Dense Jungle", 5, "Insects", "Male", 4, 15, true, true, false);
            Reptile karma = new Reptile("Karma", 2, "Rainforest", 0.2, "Insects", "Female", 4, 10, true, true, false);

            // Skapa 5 insekter
            Butterfly absolem = new Butterfly("Absolem", 1, "Wonderland", 0.01, "Nectar", "Male", false, true, false);
            Insect dot = new Insect("Dot", 1, "Anthill", 1, "Sugar", "Female", 6, 1, false, false, false);
            Insect barry_benson = new Insect("Barry Benson", 1, "The Hive", 1, "Pollen", "Male", 6, 1, true, true, false); 
            Insect quito = new Insect("Quito", 1, "Swamp", 0.001, "Blood", "Male", 6, 1, false, true, true);
            Insect hopper = new Insect("Hopper", 1, "Grassland", 1, "Grass", "Female", 6, 1, false, false, false);

            // Skapa 5 blommor
            Plant rose = new Flower("Basic Rose", 2, "Garden", 0.1, "Water", true);
            Flower daisy = new Flower("Daisy", 1, "Meadow", 0.05, "Sunlight", false);
            Flower tulip = new Flower("Tulip", 1, "Garden", 0.02, "Rain", true);
            Orchid orchid = new Orchid("Orchid", 3, "Rainforest", 0.1, "Humidity", true);
            Flower sunflower = new Flower("Sunflower", 1, "Field", 0.1, "Sunlight", true);

            // Använd dina skapade objekt här
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            lion.MakeSound();
            blinda.MakeSound();
            absolem.MakeSound();
            fido.MakeSound();
            aragog.MakeSound();
            barry_benson.MakeSound();
            dot.MakeSound();

            tick_tock.MakeSound();
            snek.MakeSound();
            donatello.MakeSound();
            iggy.MakeSound();
            karma.MakeSound();
            
            rose.Grow();
            daisy.Grow();
            tulip.Grow();
            orchid.Grow();
            sunflower.Grow();

            big_chungus.MakeSound();

            Console.WriteLine("\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣧⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣧⠀⠀⠀⢰⡿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡟⡆⠀⠀⣿⡇⢻⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠀⣿⠀⢰⣿⡇⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡄⢸⠀⢸⣿⡇⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⡇⢸⡄⠸⣿⡇⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⢸⡅⠀⣿⢠⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣥⣾⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⡿⡿⣿⣿⡿⡅⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠉⠀⠉⡙⢔⠛⣟⢋⠦⢵⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣄⠀⠀⠁⣿⣯⡥⠃⠀⢳⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⡇⠀⠀⠀⠐⠠⠊⢀⠀⢸⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⡿⠀⠀⠀⠀⠀⠈⠁⠀⠀⠘⣿⣄⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⣠⣿⣿⣿⣿⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣷⡀⠀⠀⠀\r\n⠀⠀⠀⠀⣾⣿⣿⣿⣿⣿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣧⠀⠀\r\n⠀⠀⠀⡜⣭⠤⢍⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⢛⢭⣗⠀\r\n⠀⠀⠀⠁⠈⠀⠀⣀⠝⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠄⠠⠀⠀⠰⡅\r\n⠀⠀⠀⢀⠀⠀⡀⠡⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠔⠠⡕⠀\r\n⠀⠀⠀⠀⣿⣷⣶⠒⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠘⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠰⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠈⢿⣿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠊⠉⢆⠀⠀⠀⠀\r\n⠀⢀⠤⠀⠀⢤⣤⣽⣿⣿⣦⣀⢀⡠⢤⡤⠄⠀⠒⠀⠁⠀⠀⠀⢘⠔⠀⠀⠀⠀\r\n⠀⠀⠀⡐⠈⠁⠈⠛⣛⠿⠟⠑⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠉⠑⠒⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        }
    }
}