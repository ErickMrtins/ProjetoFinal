using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Controller
{
    class ClienteController
    {

        public void inserir(Cliente cliente)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }

        public List<Cliente> listarTodosClientes()
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            return contexto.Clientes.ToList();
        }

        public Cliente buscarPorId(int id)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            return contexto.Clientes.Find(id);
        }

        public List<Cliente> PesquisarName(string Name)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();


            var lista = from p in contexto.Clientes
                        where p.Nome == Name
                        select p;

            return lista.ToList();
        }

        void Excluir(int id)
        {
            Cliente pExcluir = this.buscarPorId(id);

            if (pExcluir != null)
            {
                DataBasePetShopContainer contexto = new DataBasePetShopContainer();
                contexto.Clientes.Remove(pExcluir);
                contexto.SaveChanges();
            }
        }


    }
}
