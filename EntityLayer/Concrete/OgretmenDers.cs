using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OgretmenDers: IEntity
    {
        [Key]
        public int OgretmenDersId { get; set; }
        public int OgretmenId { get; set; }
        public int DersId { get; set; }

        public virtual Ogretmen Ogretmen { get; set; }
        public virtual Ders Ders { get; set; }

    }
}
