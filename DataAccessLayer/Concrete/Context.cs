using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgrenciDers> OgrenciDers { get; set; }
        public DbSet<Ogretmen> Ogremenler { get; set; }
        public DbSet<OgretmenDers> OgretmenDers { get; set; }
    }
}
