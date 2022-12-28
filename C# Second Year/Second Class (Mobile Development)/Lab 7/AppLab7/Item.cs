using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AppLab7
{
    class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }

        //Add more here for the lab.
    }
}
