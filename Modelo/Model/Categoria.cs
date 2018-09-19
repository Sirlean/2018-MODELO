using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //adicionar o modificador 
    // public na classe
    public class Categoria
    {
        //atributos
        private int idCategoria;
        private string nomeCategoria;
        private string descCategoria;
        private string statusCategoria;

        //Método construtor
        public Categoria()
        {
        }

        public Categoria(int idCategoria, string nomeCategoria, string descCategoria, string statusCategoria)
        {
            this.IdCategoria = idCategoria;
            this.NomeCategoria = nomeCategoria;
            this.DescCategoria = descCategoria;
            this.StatusCategoria = statusCategoria;
        }
        /*
         * 
         *  Categoria cat = new Categoria();
         * 
         *  
         *  cat.NomeCategoria = 'RPG'
         * 
         * Categoria cat1 = new Categoria(1,'tiro em 1º pessoa'
         * ,'muita violencia','A');
         * 
         */

        //Métodos getters e setters --> ações rápidas --> encapsular campos
        public int IdCategoria
        {
            get
            {
                return idCategoria;
            }

            set
            {
                idCategoria = value;
            }
        }

        public string NomeCategoria
        {
            get
            {
                return nomeCategoria;
            }

            set
            {
                nomeCategoria = value;
            }
        }

        public string DescCategoria
        {
            get
            {
                return descCategoria;
            }

            set
            {
                descCategoria = value;
            }
        }

        public string StatusCategoria
        {
            get
            {
                return statusCategoria;
            }

            set
            {
                statusCategoria = value;
            }
        }


    }

}
