namespace DetailingV12App.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderList")]
    public partial class OrderList
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? ServicesID { get; set; }

        public DateTime Date { get; set; }

        public virtual List List { get; set; }

        public virtual Service Service { get; set; }
    }
}
