using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ogretmen : IEntity
    {
        [Key]
        public int OgretmenId { get; set; }
        public int? BolumId { get; set; }

        [StringLength(50)]
        public string OgretmenIsım { get; set; }

        [StringLength(50)]
        public string OgretmenSoyad { get; set; }

        [StringLength(50)]
        public string DogumYeri { get; set; }
        public virtual Bolum Bolum { get; set; }
        public ICollection<OgretmenDers> OgretmenDersler { get; set; }

    }
}
