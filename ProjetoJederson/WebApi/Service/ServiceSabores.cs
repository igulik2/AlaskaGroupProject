﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Model;

namespace WebApi.Service
{
    public class ServiceSabores
    {
        private DaoSabores dao;
       
        public ServiceSabores(Contexto db)
        {
            dao = new DaoSabores(db);
           
        }

        public List<Sabores> Delete(long id)
        {
            Sabores objeto = SearchId(id);

            if (objeto != null)
            {
                dao.Delete(objeto);
                return ListaTodos();
            }
            else
            {
                throw new Exception("Erro ao deleter. Id já deletado");
            }
        }
        public Sabores Record(Sabores objeto)
        {
            if (string.IsNullOrEmpty(objeto.Name))
            {
                throw new Exception("Nome não pode estar em branco");
            }


            
            return dao.Record(objeto);
        }

        public List<Sabores> ListaTodosAtivos()
        {
            return dao.ListaTodosAtivos();
        }

        public List<Sabores> ListaTodos()
        {
            return dao.ListaTodos();
        }

        public List<Sabores> Search(string texto)
        {
            return dao.Search(texto);
        }

        public Sabores SearchId(long id)
        {
            return dao.SearchId(id);
        }

        public List<Sabores> ListaTodosAtivosEmEstoque()
        {
            List<Sabores> retorno = new List<Sabores>();
            foreach (var item in ListaTodosAtivos())
            {
                if (dao.saldoSabores(item.Id) > 0)
                {
                    retorno.Add(item);
                }

            }

            return retorno;
        }
    }
}
