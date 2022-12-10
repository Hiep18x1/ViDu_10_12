namespace PokemonReviewApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  ICollection<Owner> Owners { get; set; }
        public Reviewer Reviewer { get; set; }
        public Pokemon Pokemon { get; set; } 
    }
}
