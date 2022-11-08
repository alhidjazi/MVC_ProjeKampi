using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        //ilişkili tablolarda silme işlemi kullanmadan onun yerine aktif yada pasif yapma işlemini tercih edilmesi söz konusudur.
        public bool CategoryStatus { get; set; }

        //Heading bire-çok ilişki işlemidir
        public ICollection<Heading> Headings { get; set; }
    }
}
