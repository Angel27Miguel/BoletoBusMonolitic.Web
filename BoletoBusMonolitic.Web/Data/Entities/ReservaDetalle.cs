using BoletoBusMonolitic.Web.Data.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMonolitic.Web.Data.Entites
{
    public class ReservaDetalle : BaseEntity
    {
		#region "Atributos"
		[Key]
        public int IdReservaDetalle { get; set; }
        public int IdReserva { get; set; }
        public int IdAsiento { get; set; }

		#endregion

	}
}
//Angel Miguel de la Rosa