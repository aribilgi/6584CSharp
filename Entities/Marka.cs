namespace Entities
{
    public class Marka : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public List<Urun>? Urunler { get; set; }
    }
}
