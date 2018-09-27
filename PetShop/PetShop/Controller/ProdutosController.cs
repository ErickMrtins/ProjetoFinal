using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Controller
{
    class ProdutosController
    {

        public void Inserir(Produto produto)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        public List<Produto> ListarTodosProdutos()
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            return contexto.Produtos.ToList();
        }

        public Produto BuscarPorId(int id)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            return contexto.Produtos.Find(id);
        }

        public List<Produto> PesquisarPorName(string Name)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();


            var lista = from p in contexto.Produtos
                        where p.Descricao == Name
                        select p;

            return lista.ToList();
        }

        void Excluir(int id)
        {
            Produto pExcluir = BuscarPorId(id);

            if (pExcluir != null)
            {
                DataBasePetShopContainer contexto = new DataBasePetShopContainer();
                contexto.Produtos.Remove(pExcluir);
                contexto.SaveChanges();
            }
        }
    }
}
