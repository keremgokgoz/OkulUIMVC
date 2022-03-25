using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bolum : IEntity
    {
        [Key]
        public int BolumId { get; set; }
       

        [StringLength(100)]
        public string BolumAdi { get; set; }
        [StringLength(100)]
        public string Aciklama { get; set; }
        [StringLength(100)]
        public string Eposta { get; set; }

        public ICollection<Ogrenci> Ogrenciler { get; set; }
        public ICollection<Ders> Dersler { get; set; }
        public ICollection<Ogretmen> Ogretmenler { get; set; }

    }
}
