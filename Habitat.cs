namespace Zoo{
    public class Habitat{
        public string Name { get; set; }
        public int Capacity { get; set; }
        public AnimalType Type { get; set; }

        public List<Animal> Stinkys { get; set; }

        public Habitat(){
            Stinkys = new List<Animal>();
        }
        
     }
}