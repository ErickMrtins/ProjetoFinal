using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Controller
{
    class AnimaisController
    {
        public void Inserir(Animal animal)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            contexto.Animais.Add(animal);
            contexto.SaveChanges();
        }

        public List<Animal> ListarTodosAnimais()
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            return contexto.Animais.ToList();
        }

        public Animal BuscarPorId(int id)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            return contexto.Animais.Find(id);
        }

        public List<Animal> PesquisarPorName(string Name)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();


            var lista = from p in contexto.Animais
                        where p.Nome == Name
                        select p;

            return lista.ToList();
        }

        void Excluir(int id)
        {
            Animal pExcluir = BuscarPorId(id);

            if (pExcluir != null)
            {
                DataBasePetShopContainer contexto = new DataBasePetShopContainer();
                contexto.Animais.Remove(pExcluir);
                contexto.SaveChanges();
            }
        }
    }
}
