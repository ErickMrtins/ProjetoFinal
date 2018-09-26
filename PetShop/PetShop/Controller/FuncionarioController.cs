using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Controller
{
    class FuncionarioController
    {
        public void inserir(Funcionario funcionario)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            contexto.Funcionarios.Add(funcionario);
            contexto.SaveChanges();
            
        }

        public List<Funcionario> ListarTodosPerson()
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            return contexto.Funcionarios.ToList();
        }

        public Funcionario BuscarPorId(int id)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            return contexto.Funcionarios.Find(id);
        }

        public List<Funcionario> PesquisarPorFirstName(string firstName)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();

            // LINQ (https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b)

            //var lista = from p in contexto.Person
            //            select p; // SELECT * FROM Person

            var lista = from p in contexto.Funcionarios
                        where p.Nome == firstName
                        select p;

            return lista.ToList();
        }

    }
}
