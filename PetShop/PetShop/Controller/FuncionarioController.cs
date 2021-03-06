﻿using System;
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

        public List<Funcionario> ListarTodosFuncionarios()
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            return contexto.Funcionarios.ToList();
        }

        public Funcionario BuscarPorId(int id)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            return contexto.Funcionarios.Find(id);
        }

        public Funcionario BuscarPorNome(String nome)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();
            return contexto.Funcionarios.Find(nome);
        }

        public List<Funcionario> PesquisarPorFirstName(string firstName)
        {
            DataBasePetShopContainer contexto = new DataBasePetShopContainer();


            var lista = from p in contexto.Funcionarios
                        where p.Nome == firstName
                        select p;

            return lista.ToList();
        }

        void Excluir(int id)
        {
            Funcionario pExcluir = BuscarPorId(id);

            if (pExcluir != null)
            {
                DataBasePetShopContainer contexto = new DataBasePetShopContainer();
                contexto.Funcionarios.Remove(pExcluir);
                contexto.SaveChanges();
            }
        }

    }
}
