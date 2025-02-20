namespace Zoologico{

    public class Animal{

        public string Name { get ; set; }

        public int Age { get ; set; }

        public double Weight { get ; set ; }

        public AnimalType Type { get; set; }

        public bool IsHungry { get ; set ;}
        
       public void refill (){
        IsHungry = false;
        Console.WriteLine ($"{Name} ya devorò");
       }

    }
}