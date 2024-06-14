using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class EmpleadoDb : IEmpleados
    {
        private readonly BoletoBusContext context;
  

        public EmpleadoDb(BoletoBusContext context)
        {
            this.context = context;
            
        }
        public void EditarEmpleados(EmpleadosEditarModel empleadosEditar)
        {
            var empleado = this.context.Empleado.Find(empleadosEditar.IdEmpleado); // Buscar por Id

            if (empleado == null)
            {
                throw new ArgumentException("Empleado no encontrado");
            }

            empleado.Nombre = empleadosEditar.Nombre;
            empleado.Cargo = empleadosEditar.Cargo;

            this.context.Empleado.Update(empleado);
            this.context.SaveChanges();
        }



        public void EliminarEmpleados(EmpleadosEliminarModel empleadosEliminar)
        {
            var empleadoMobelEliminar = this.context.Empleado.Find(empleadosEliminar.IdEmpleado);
            if (empleadoMobelEliminar == null)
            {
                throw new ArgumentException("Empleado no encontrado");
            }



            empleadoMobelEliminar.IdEmpleado = empleadosEliminar.IdEmpleado;

            this.context.Remove(empleadoMobelEliminar);
            this.context.SaveChanges();
        }

        public void EliminarEmpleados(int id)
        {
            throw new NotImplementedException();
        }

        public EmpleadosModel GetEmpleado(int IdEmpleado)
        {
            var empleados = this.context.Empleado.Find(IdEmpleado);

            ArgumentNullException.ThrowIfNull(empleados,"Empleado no encontrado");

            EmpleadosModel empleadosModel = new EmpleadosModel()
            {
                IdEmpleado = empleados.IdEmpleado,
                Nombre = empleados.Nombre,
                Cargo = empleados.Cargo
            };
            return empleadosModel;
        }

        public List<EmpleadosModel> GetEmpleados()
        {
            return this.context.Empleado.Select(cd => new EmpleadosModel()
            {
              IdEmpleado = cd.IdEmpleado,
              Nombre = cd.Nombre,
              Cargo = cd.Cargo

            }).ToList();
        }

        public void GuardarEmpleado(EmpleadosGuardarModel empleadosGuardar)
        {
            Empleados empleados = new ()
            {

                Nombre = empleadosGuardar.Nombre,
                Cargo = empleadosGuardar.Cargo

            };
            this.context.Empleado.Add(empleados);
            this.context.SaveChanges();
        }
    }
}
//Angel Miguel de la Rosa