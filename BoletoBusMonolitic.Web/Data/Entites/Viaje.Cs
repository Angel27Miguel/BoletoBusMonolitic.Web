using BoletoBusMonolitic.Web.Data.Core;
using System;

namespace BoletoBusMonolitic.Web.Data.Entites;


public class Viaje : BaseEntity
{

    //Atributos de la entidad 

    private int IdBus;
    private int IdRuta;
    private DateTime FechaSalida;
    private TimeSpan HoraSalida;
    private DateTime FechaLlegada;
    private TimeSpan HoraLlegada;
    private double Precio;
    private int TotalAsiento;
    private int AsientosReservados;
    private int AsientosDisponibles;
    private Boolean Completo;
    private DateTime FechaCreacion;


    public Viaje(int idViaje,int IdBus, int IdRuta, DateTime FechaSalida, TimeSpan HoraSalida, DateTime FechaLlegada, 
        TimeSpan HoraLlegada, double Precio, int TotalAsiento, int AsientosReservados, int AsientosDisponibles, Boolean Completo, DateTime FechaCreacion) : base(idViaje)
    {
        this.IdBus = IdBus;
        this.IdRuta = IdRuta;
        this.FechaSalida = FechaSalida; 
        this.HoraSalida = HoraSalida;   
        this.FechaLlegada = FechaLlegada;
        this.HoraLlegada = HoraLlegada;
        this.Precio = Precio;
        this.TotalAsiento = TotalAsiento;
        this.AsientosReservados = AsientosReservados;
        this.AsientosDisponibles = AsientosDisponibles;
        this.Completo = Completo;
        this.FechaCreacion = FechaCreacion;

    }
}
//Angel Miguel de la Rosa