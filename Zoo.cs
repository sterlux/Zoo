namespace Zoologico{
    public class Zoo{
        public List<Habitat> Habitats { get; set; }
        
        public Zoo(){
            Habitats = new List<Habitat>();
        }

        // Recibimos un nuevo objeto como parametro
        public void AddHabitat (Habitat newHabitat){
            // La lista tiene el metodo Add y recibe el nuevo objeto
            Habitats.Add(newHabitat);

        }

        // Este metodo no necesita regresar nada, 
        // solamente borra el habitat que encuentra por su nombre
        public void RemoveHabitat (string name){
            // buscamos el habitat que el nombre sea = al que recibimos como parametro
            Habitat byehabitat = Habitats.First(h => h.Name == name); // lo guardamos en byehabitat
            Habitats.Remove(byehabitat); // la misma lista tiene el metodo remove y le mandamos el habitat que encontramos
            
        }

        public void PrintInfo (){
            foreach (var habitat in Habitats){
                Console.WriteLine($"Habitat: {habitat.Name}");
                Console.WriteLine($"Capacidad: {habitat.Capacity}");
                Console.WriteLine($"Tipo de Animales: {habitat.Type}");
             foreach (var animal in habitat.Stinkys){
                Console.WriteLine($"Nombre Animal: {animal.Name}");
                Console.WriteLine($"Edad: {animal.Age}");
                Console.WriteLine($"Peso: {animal.Weight}");
                Console.WriteLine($"Tipo: {animal.Type}");
                Console.WriteLine($"Tiene hambre? {animal.IsHungry}");
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