using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //ATRIBUTOS

        private Genero Genero {get; set;}

        private string Titulo {get; set;}

        private string Descricao {get; set;}

        private int Ano {get; set;}

        //METODOS

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public Serie()
        {
        }

        public override string ToString()
        {
            {
                //Environment interpreta como usuario ta usando para uma nova linha sem a necessidade do /n etc.
                string retorno = "";
                retorno += "Gênero: "+ this.Genero + Environment.NewLine;
                retorno += "Titulo: " + this.Titulo + Environment.NewLine;
                retorno+= "Descrição: " + this.Descricao + Environment.NewLine;
                retorno+= "Ano lançado: "+ this.Ano + Environment.NewLine;
                return retorno;

            }
        }

            public string retornaTitulo()
            {
                return this.Titulo;
            }

            public int retornaId()
            {
                return this.Id;
            }
        }


    }