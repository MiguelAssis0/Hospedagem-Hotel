using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemDeHotel.Models
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}