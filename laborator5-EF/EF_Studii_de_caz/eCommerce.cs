using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Studii_de_caz
{
    [Table("eCommerce", Schema = "dba")]
    public class eCommerce : Business
    {
        public string URL { get; set; }
    }
}
