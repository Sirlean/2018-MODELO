﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FabricaConexao
    {

        private static SqlConnection cn ;

        private static string stringConexao = @"Server=P3L4MPROFESSOR\SQLEXPRESS;
            Database=Banco_asp;User Id= sa; Password=123456"; 


        public static SqlConnection getConexao()
        {
            try
            {
                cn = new SqlConnection(stringConexao);
                return cn;

            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

    }
}
