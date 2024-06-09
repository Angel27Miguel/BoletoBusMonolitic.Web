using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Exeptions;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;

namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class EmpleadoDb : IEmpleados
    {
        private readonly BoletoBusContext context;
        private readonly EmpleadosException exception;

        public EmpleadoDb(BoletoBusContext context, EmpleadosException exception)
        {
            this.context = context;
            this.exception = exception;
        }
        public void EditarEmpleados(EmpleadosEditarModel empleadosEditar)
        {
            throw new NotImplementedException();
        }

        public void EliminarEmpleados(EmpleadosEliminarModel empleadosEliminar)
        {
            throw new NotImplementedException();
        }

        public EmpleadosModel GetEmpleados(int IdEmpleado)
        {
            throw new NotImplementedException();
        }

        public List<Empleados> GetEmpleadosList()
        {
            throw new NotImplementedException();
        }

        public void GuardarEmpleado(EmpleadosGuardarModel empleadosGuardar)
        {
            throw new NotImplementedException();
        }
    }
}
//Angel Miguel de la Rosa