using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OgrenciDers : IEntity
    {
        [Key]
        public int OgrenciDersId { get; set; }
        public int OgrenciId { get; set; }
        public int DersId { get; set; }
        public float Not { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
        public virtual Ders Ders { get; set; }

    }
}
