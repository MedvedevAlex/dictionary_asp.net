using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebDictionary.Models
{
    public class Car
    {
        [Key]
        [ForeignKey("Driver")]
        public int Id { get; set; }
        public string Name { get; set; }
        public float EngineLiter { get; set; }
        public int Power { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public virtual Driver Driver { get; set; }
    }
}