using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AppLab7
{
    class TripInfo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(15)]
        public string Ticket { get; set; }

        [MaxLength(15)]
        public string Expense { get; set; }

        //Add more here for the lab.
    }
}

