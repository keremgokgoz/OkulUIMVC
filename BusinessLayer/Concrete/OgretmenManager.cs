using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OgretmenManager
    {
        GenericRepository<Ogretmen> repo = new GenericRepository<Ogretmen>();

        public List<Ogretmen> GetAll()
        {
            return repo.List();
        }
        public void OgretmenAddBl(Ogretmen ogretmen)
        {
            if (ogretmen.OgretmenIsım!=""&& ogretmen.OgretmenSoyad!="")
            {
                repo.Insert(ogretmen);
            }
            else
            {
                Console.WriteLine("Boş olamaz");
            }
        }
    }
}
