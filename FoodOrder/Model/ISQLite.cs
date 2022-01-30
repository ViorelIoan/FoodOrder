using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder.Model
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
