namespace Entities_Layer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            Inventario = new HashSet<Inventario>();
        }

        public int id { get; set; }

        public int id_marca { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }

        public double precio { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_vencimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string codigo { get; set; }

        public int id_categoria { get; set; }

        public virtual Categorias Categorias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventario> Inventario { get; set; }

        public virtual Marcas Marcas { get; set; }
    }
}
