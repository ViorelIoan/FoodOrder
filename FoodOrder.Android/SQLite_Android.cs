using System;
using System.IO;
using FoodOrder.Model;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(FoodOrder.Droid.SQLite_Android))]
namespace FoodOrder.Droid
{
    class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;
        }
    }
}