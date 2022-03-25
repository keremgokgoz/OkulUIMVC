using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ders : IEntity
    {
        [Key]
        public int DersId { get; set; }

        public int? BolumId { get; set; }

        [StringLength(100)]
        public string DersAdi { get; set; }

        [StringLength(100)]
        public string DersKodu { get; set; }

      
        public int Kredi { get; set; }

        public virtual Bolum Bolum { get; set; }
        public ICollection<OgretmenDers> OgretmenDersler { get; set; }
        public ICollection<OgrenciDers> OgrenciDersler { get; set; }


    }
}
