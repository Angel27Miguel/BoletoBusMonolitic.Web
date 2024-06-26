using BoletoBusMonolitic.Web.Data.Context;
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
            if (clienteModel == null)
            {
                throw new ArgumentNullException(nameof(clienteModel), "El modelo de cliente no puede ser nulo.");
            }

            try
            {
                Cliente cliente = new Cliente()
                {
                    Nombre = clienteModel.Nombre,
                    Telefono = clienteModel.Telefono,
                    Email = clienteModel.Email,
                };

                this.context.Cliente.Add(cliente);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrió un error al guardar el cliente: {ex.Message}");
                throw;
            }
        }

        public void ActualizarClientes(ClienteUpdateModel updateModel)
        {
            {

                Cliente ClienteToUpdate = this.context.Cliente.Find(updateModel.ClienteID);

               ClienteToUpdate.Nombre = updateModel.Nombre;
               ClienteToUpdate.Telefono = updateModel.Telefono;
               ClienteToUpdate.Email = updateModel.Email;

                this.context.Cliente.Update(ClienteToUpdate);
                this.context.SaveChanges();
            }



         }

    

        public void EliminarCliente()
        {

        }


        public List<ClienteModel> GetClienteModel()
        {
            return this.context.Cliente.Select(cliente => new ClienteModel()
            {
                IdCliente= cliente.IdCliente,
                Nombre = cliente.Nombre,
                Telefono = cliente.Telefono,
                Email = cliente.Email

            }).ToList();
        }

        public ClienteModel GetCliente(int IdCliente)
        { 

         var cliente = this.context.Cliente.Find(IdCliente);

                ClienteModel clienteModel = new ClienteModel()
                {
                    IdCliente= cliente.IdCliente,
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono,
                    Email = cliente.Email
                };
              
                return clienteModel;

            }

        }
    }

       

        
    
