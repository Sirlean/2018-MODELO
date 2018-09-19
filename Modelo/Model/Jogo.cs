using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Jogo
    {
        //atributos
        private int idJogo;
        private string nomeJogo;
        private string descJogo;
        private string urlJogo;
        private double precoJogo;
        private string statusJogo;
        private int idCategoria;
        private string nomeCategoria;
        private string descCategoria;

        //metodo(s) construtor
        public Jogo()
        {
        }

        public Jogo(int idJogo, string nomeJogo, string descJogo, string urlJogo, double precoJogo, string statusJogo, int idCategoria, string nomeCategoria, string descCategoria)
        {
            this.idJogo = idJogo;
            this.nomeJogo = nomeJogo;
            this.descJogo = descJogo;
            this.urlJogo = urlJogo;
            this.precoJogo = precoJogo;
            this.statusJogo = statusJogo;
            this.idCategoria = idCategoria;
            this.nomeCategoria = nomeCategoria;
            this.descCategoria = descCategoria;
        }


        //metodos getters e setters
        public int IdJogo
        {
            get
            {
                return idJogo;
            }

            set
            {
                idJogo = value;
            }
        }

        public string NomeJogo
        {
            get
            {
                return nomeJogo;
            }

            set
            {
                nomeJogo = value;
            }
        }

        public string DescJogo
        {
            get
            {
                return descJogo;
            }

            set
            {
                descJogo = value;
            }
        }

        public string UrlJogo
        {
            get
            {
                return urlJogo;
            }

            set
            {
                urlJogo = value;
            }
        }

        public double PrecoJogo
        {
            get
            {
                return precoJogo;
            }

            set
            {
                precoJogo = value;
            }
        }

        public string StatusJogo
        {
            get
            {
                return statusJogo;
            }

            set
            {
                statusJogo = value;
            }
        }

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

  
    }
}


/*
 * FabricaConexao obj = new fabricaConexao();
 * obj.getConexao();
 * 
 * 
 * 
 * SqlConnection conn = FabricaConexao.getConexao();
 * 
 */ 