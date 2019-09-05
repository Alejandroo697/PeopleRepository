using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Pleope.Models
{
    [Table("T_People")]
  public  class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
