using System;
using System.Collections.Generic;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CategoriaDAL : SQLHelper<Categoria>
    {

        private SqlConnection con;
        private SqlCommand comando;


        public CategoriaDAL()
        {
            this.con = FabricaConexao.getConexao();
        }

        public void abrirConexao()
        {
            if(this.con.State == ConnectionState.Closed)
            {
                this.con.Open();
            }
        }

        public void create(Categoria obj)
        {
            string sqlCreate = "INSERT INTO CATEGORIA " +
           "(NOME_CATEGORIA ,DESC_CATEGORIA ,STATUS_CATEGORIA)" +
     "VALUES (" + obj. + ")";

        }

        public void delete(Categoria obj)
        {
            throw new NotImplementedException();
        }

        public bool find(Categoria obj)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> findAll()
        {
            throw new NotImplementedException();
        }

        public void update(Categoria obj)
        {
            throw new NotImplementedException();
        }
    }
}
