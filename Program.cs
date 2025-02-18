using Zoologico;
Zoo zoo = new Zoo();

Console.WriteLine("Bienvenido al Zoológico POO");

while(true){
    int option=0;

    Console.WriteLine("[1] Detener");
    Console.WriteLine("[2] Ver la informacion del zoologico");
    Console.WriteLine("[3] Agregar habitat");
    Console.WriteLine("[4] Remover habitat");

    option= Convert.ToInt32(Console.ReadLine());

    if(option==1)
        break;

    switch(option){

        case 2: zoo.PrintInfo();
        break;

        case 3: AddHabitat();
        break; 


    }
}
void AddHabitat(){
    Habitat Newhome = new Habitat();
    Console.WriteLine("Nombre del Habitat:");
    Newhome.Name= Console.ReadLine();


    Console.WriteLine("Capacidad de habitat:");
    Newhome.Capacity = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Selecciona el tipo de animal:");
    Console.WriteLine($"1: {AnimalType.Reptile}");
    Console.WriteLine($"2: {AnimalType.Bird}");
    Console.WriteLine($"3: {AnimalType.Acuatic}");
    Console.WriteLine($"4: {AnimalType.Feline}");
    Console.WriteLine($"5: {AnimalType.Polars}");

    Newhome.Type = (AnimalType)Convert.ToInt32(Console.ReadLine());

    for (int i=0; i<Newhome.Capacity; i++){
        Animal newstinky = new Animal();
        Console.WriteLine("Nombre del Animal:");
        newstinky.Name= Console.ReadLine();
        Console.WriteLine("Edad del Animal:");
        newstinky.Age= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Peso del Animal:");
        newstinky.Weight= Convert.ToDouble(Console.ReadLine());
        newstinky.Type = Newhome.Type;
        newstinky.IsHungry = true;
    }

}