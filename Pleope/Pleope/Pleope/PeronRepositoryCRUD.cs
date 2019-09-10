using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Pleope.Models;

namespace Pleope
{
    public class PeronRepositoryCRUD
    {
        SQLiteConnection conn;
        // conn = new SQLiteConnection
        public string StatusMessage { get; set; }
        // Construtor

        public PeronRepositoryCRUD(string dbPath)
        {
            // Creamos la conexion.
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Person>();
            // PersonRepositoryCRUD Repo =  new PersonRepositoryCRUD("c:\dev\datos");*/
        }

        public void CreaterPerson(Person newPerson)
        {
            int result = 1;
            result = conn.Insert(newPerson);
            if (result == 1)

            {
                StatusMessage =
                    $"{result}registro agregado [Nombre]:" +
                    $"{newPerson.Name}, ID {newPerson.Id}";
                // "1 registro agregado [Nombre: juan, ID:1]
            }
            else
            { }
       StatusMessage =
            " Registro no insertado!";
        
    
        }
        // CRUD OPERATIONS
        //cREAR
    }
}
