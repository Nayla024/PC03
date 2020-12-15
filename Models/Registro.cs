using System.ComponentModel.DataAnnotations;

namespace PC03.Models
{
    public class Registro
    {
       
        public int Id { get; set; }
        [Required]
        public string Producto { get; set; }
      
        public string Url { get; set; }
    
        public string Descripcion { get; set; }

        public string Precio { get; set; }

        public int Cantidad { get; set; }

        public int Celular { get; set; }

        public string Lugar { get; set; }

        public string Nombre { get; set; }


    }
}