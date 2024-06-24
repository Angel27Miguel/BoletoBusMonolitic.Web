using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Models
{
    public class BusModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdBus { get; set; }  
        public string Nombre { get; set; }
        public Boolean disponible  { get; set; }
        

    
    }
}
