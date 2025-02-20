namespace Zoologico{
    public class Zoo{
        public List<Habitat> Habitats { get; set; }
        
        public Zoo(){
            Habitats = new List<Habitat>();
        }

        public void AddHabitat (Habitat newHabitat){
            Habitats.Add(newHabitat);

        }

        public void RemoveHabitat (string name){
            Habitat byehabitat = Habitats.First(h => h.Name == name);
            Habitats.Remove(byehabitat);
            
        }

        public void PrintInfo (){
            foreach (var habitat in Habitats){
                Console.WriteLine($"{habitat.Name}");
                Console.WriteLine($"{habitat.Capacity}");
                Console.WriteLine($"{habitat.Type}");
             foreach (var animal in habitat.Stinkys){
                Console.WriteLine($"{animal.Name}");
                Console.WriteLine($"{animal.Age}");
                Console.WriteLine($"{animal.Weight}");
                Console.WriteLine($"{animal.Type}");
                Console.WriteLine($"{animal.IsHungry}");
             }   

            }
        }
        public void FeedHabitat (){
            Console.WriteLine("Selecciona el habitat a alimentar");
            int i=1;
            foreach (Habitat habitat in Habitats){
                Console.WriteLine ($"{i}: {habitat.Name}");
            }
            var habitatName = Console.ReadLine ();
            Habitat byehunger = Habitats.First(h => h.Name == habitatName);
            foreach (Animal Stinky in byehunger.Stinkys){
                Stinky.refill();
            }
        }
    }
}