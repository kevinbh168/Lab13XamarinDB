using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lab14_XamarinDB.Models
{
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int Dni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string fechaNacimiento { get; set; }
    }
}
