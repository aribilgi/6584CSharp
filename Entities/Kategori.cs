namespace Entities
{
    public class Kategori : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Urun>? Urunler { get; set; } // 1 kategorinin 1 den çok ürünü olabilir. Buna 1 e çok ilişki denir. ? işareti ile bu listeyi nullable yani boş da olabilir hale getirmiş oluruz.
    }
}
