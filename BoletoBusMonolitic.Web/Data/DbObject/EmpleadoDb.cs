using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Entities;
using BoletoBusMonolitic.Web.Data.Exeptions;
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

		private Empleados GetEmpleadoId(int idEmpleado)
		{
			var empleado = this.context.Empleado.Find(idEmpleado);
			if (empleado == null)
			{
				throw new EmpleadosException("Empleado no encontrado");
			}
			return empleado;
		}

		public void EditarEmpleados(EmpleadosEditarModel empleadosEditar)
		{
			var empleado = GetEmpleadoId(empleadosEditar.IdEmpleado);

			empleado.Nombre = empleadosEditar.Nombre;
			empleado.Cargo = empleadosEditar.Cargo;

			this.context.Empleado.Update(empleado);
			this.context.SaveChanges();
		}

		public void EliminarEmpleados(EmpleadosEliminarModel empleadosEliminar)
		{
			var empleado = GetEmpleadoId(empleadosEliminar.IdEmpleado);

			this.context.Remove(empleado);
			this.context.SaveChanges();
		}

		public EmpleadosModel GetEmpleado(int idEmpleado)
		{
			var empleado = GetEmpleadoId(idEmpleado);

			return new EmpleadosModel()
			{
				IdEmpleado = empleado.IdEmpleado,
				Nombre = empleado.Nombre,
				Cargo = empleado.Cargo
			};
		}

		public List<EmpleadosModel> GetEmpleados()
		{
			return this.context.Empleado.Select(Em => new EmpleadosModel()
			{
				IdEmpleado = Em.IdEmpleado,
				Nombre = Em.Nombre,
				Cargo = Em.Cargo
			}).ToList();
		}

		public void GuardarEmpleado(EmpleadosGuardarModel empleadosGuardar)
		{
			Empleados empleado = new()
			{
				Nombre = empleadosGuardar.Nombre,
				Cargo = empleadosGuardar.Cargo
			};

			this.context.Empleado.Add(empleado);
			this.context.SaveChanges();
		}
	}
}

//Angel Miguel de la Rosa