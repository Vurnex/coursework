using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AppLab7
{
    public interface IDatabase
    {
        SQLiteConnection ConnectToDB();
    }
}
