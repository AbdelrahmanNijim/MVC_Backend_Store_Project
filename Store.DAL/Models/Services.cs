using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL.Models
{
    public class Services
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public string ImageName { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedTime { get; set; }

    }
}
