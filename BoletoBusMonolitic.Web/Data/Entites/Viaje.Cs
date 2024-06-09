using BoletoBusMonolitic.Web.Data.Core;
using System;

namespace BoletoBusMonolitic.Web.Data.Entites;


public class Viaje : BaseEntity
{

    #region "Atributos"

    public int IdViaje { get; set; }
    public int IdBus { get; set; }
    public string? Bus { get; set; }
    public int IdRuta { get; set; }
    public int IdPasajero { get; set; }
    public string? Pasajero { get; set; }
    public string? Ruta { get; set; }
    public DateTime FechaSalida { get; set; }
    public TimeSpan HoraSalida { get; set; }
    public DateTime FechaLlegada { get; set; }
    public TimeSpan HoraLlegada { get; set; }
    public double Precio { get; set; }
    public int TotalAsiento { get; set; }
    public int AsientosDisponibles { get; set; }
    public DateTime FechaCreacion { get; set; }

    #endregion



}
//Angel Miguel de la Rosa