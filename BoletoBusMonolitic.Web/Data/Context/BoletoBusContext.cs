﻿using BoletoBusMonolitic.Web.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BoletoBusMonolitic.Web.Data.Context
{
    public class BoletoBusContext : DbContext
    {
        public BoletoBusContext(DbContextOptions<BoletoBusContext> options) : base(options) { }
        #region"DB Sets de Angel Miguel"
            public DbSet<Viaje> Viajes { get; set; }
            public DbSet<Empleados> Empleados { get; set; }
            public DbSet<Reserva> Reservas { get; set; }
            public DbSet<ReservaDetalle> ReservaDetalles { get; set; }
            #endregion

    
    }
    }
