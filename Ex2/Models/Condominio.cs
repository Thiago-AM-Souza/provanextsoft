using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ex2.Models
{
    public class Condominio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Bairro { get; set; }
        
        public List<Apartamento> Apartamentos { get; }

        //Exercicio 3
        public double AreaTotal { get; set; }
        public double ValorIptu { get; set; }
    }
}
