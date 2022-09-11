using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Estacionamento.Models
{
    public class Veiculo
    {
        public string Placa { get; private set; }

        public string Proprietario { get; private set; }

        public string Porte { get; private set; }

        public Veiculo(string placa, string proprietario, string porte)
        {
            Placa = placa;
            Proprietario = proprietario;
            Porte = porte;
        }
    }
}
