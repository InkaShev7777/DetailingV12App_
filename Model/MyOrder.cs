namespace DetailingV12App.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MyOrder
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string NameServices { get; set; }

        public double Price { get; set; }

        public DateTime Date { get; set; }
    }
}
