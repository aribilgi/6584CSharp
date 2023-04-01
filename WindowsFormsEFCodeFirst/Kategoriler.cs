namespace WindowsFormsEFCodeFirst
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Kategoriler")]
    public partial class Kategori
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string KategoriAdi { get; set; }
    }
}
