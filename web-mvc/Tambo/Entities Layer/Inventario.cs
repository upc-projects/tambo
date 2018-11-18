namespace Entities_Layer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventario")]
    public partial class Inventario
    {
        public int id { get; set; }

        public int id_tienda { get; set; }

        public int id_producto { get; set; }

        public int stock { get; set; }

        public virtual Productos Productos { get; set; }

        public virtual Tiendas Tiendas { get; set; }
    }
}
