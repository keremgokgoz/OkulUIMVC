using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ogrenci : IEntity
    {
        [Key]
        public int OgrenciId { get; set; }
        public int? BolumId { get; set; }

        [StringLength(50)]
        public string OgrenciAd { get; set; }
        [StringLength(50)]
        public string OgrenciSoyad { get; set; }
        [StringLength(50)]
        public string DogumYeri { get; set; }
        public virtual Bolum Bolum { get; set; }
        public ICollection<OgrenciDers> OgrenciDersler { get; set; }


    }
}
