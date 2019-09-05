using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Pleope.Models;

namespace Pleope
{
    class PeronRepositoryCRUD
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public PeronRepositoryCRUD(string dbPath)
        {
            // Creamos la conexion.
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Person>();
            

        }
    }
}
