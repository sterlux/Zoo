namespace Zoo{
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
    }
}