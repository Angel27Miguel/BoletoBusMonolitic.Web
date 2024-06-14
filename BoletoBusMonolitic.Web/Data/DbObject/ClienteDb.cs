using BoletoBusMonolitic.Web.Data.Context;
using BoletoBusMonolitic.Web.Data.Entites;
using BoletoBusMonolitic.Web.Data.Interfaces;
using BoletoBusMonolitic.Web.Data.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;



namespace BoletoBusMonolitic.Web.Data.DbObject
{
    public class ClienteDb : ICliente
    {
        private readonly BoletoBusContext context;
        


        public ClienteDb(BoletoBusContext context)
        {
            this.context = context;
        }

        public void GuardarCliente(ClienteSaveModel clienteModel)
                {
                 Cliente cliente = new Cliente() {

                 Nombre = clienteModel.Nombre,
                 Telefono = clienteModel.Telefono,
                 Correo= clienteModel.Email,

                };
               this.context.Cliente.Add(cliente);
               this.context.SaveChanges();

        }
        public void ActualizarClientes(ClienteUpdateModel updateModel)
        {
            Cliente clientetouptade = this.context.Cliente.Find(updateModel.ClienteID);

            clientetouptade.Nombre = updateModel.Nombre;
            clientetouptade.Telefono = updateModel.Telefono;
            clientetouptade.Correo = updateModel.Email;

            this.context.Cliente.Update(clientetouptade);
            this.context.SaveChanges();

        }

        public void EliminarCliente(ClienteDeleteModel clienteDelete)
        {
            var clienteModelEliminar = this.context.Cliente.Find(clienteDelete.IdCliente);
            if (clienteDelete == null)
            {
              
            }

            clienteModelEliminar.IdCliente = clienteDelete.IdCliente;

            this.context.Remove(clienteModelEliminar);
            this.context.SaveChanges();
        }


        public List<ClienteModel> GetCliente()
        {
            return this.context.Cliente.Select(cliente => new ClienteModel()
            {
                Nombre = cliente.Nombre,
                Telefono = cliente.Telefono,
                Correo = cliente.Correo,

            }).ToList();
        }

        public ClienteModel GetCliente(int IdCliente)
        { 

         var cliente = this.context.Cliente.Find(IdCliente);

                ClienteModel clienteModel = new ClienteModel()
                {
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono,
                    Correo = cliente.Correo,
                };
              
                return clienteModel;

            }

        }
    }

       

        
    
