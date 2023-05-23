using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColletionView.Model
{
    public class Boletos
    {
        public int IdBoletos { get; set; }
        public DateTime HoraPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public double ValorParcela { get; set; }
        public int QtdParcelas { get; set; }
        public string Parcelas { get; set; }

    }
}
