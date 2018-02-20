using System;

namespace MvcPrueba.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Cylinders { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Make { get; set; }
        public decimal Model{ get; set; }

        //public int MakeId
        //public virtual Make Make
    }
}