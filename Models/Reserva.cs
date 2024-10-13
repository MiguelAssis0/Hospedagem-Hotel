using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemDeHotel.Models
{
    public class Reserva
    {
        List<Pessoa> Hospedes = new List<Pessoa>();
        Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(hospedes.Count > Suite.Capacidade)
            {
                throw new Exception("Quantidade de hospedes ultrapassou a capacidade da suite");
            }
            Hospedes=hospedes;
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if(DiasReservados >= 10)
            {
                return Suite.ValorDiaria = Suite.ValorDiaria * DiasReservados - (Suite.ValorDiaria * 10 / 100);
            }
            return Suite.ValorDiaria = Suite.ValorDiaria * DiasReservados;
        }
    }
}