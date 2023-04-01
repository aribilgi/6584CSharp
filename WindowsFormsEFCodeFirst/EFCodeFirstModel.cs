using System.Data.Entity;

namespace WindowsFormsEFCodeFirst
{
    public partial class EFCodeFirstModel : DbContext
    {
        public EFCodeFirstModel()
            : base("name=EFCodeFirstModel")
        {
        }

        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
