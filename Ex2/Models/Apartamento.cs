using System.Text.Json.Serialization;

namespace Ex2.Models
{
    public class Apartamento
    {
        public int Id { get; set; }
        public int Numero { get; set; }

        public int CondominioId { get; set; }
        [JsonIgnore]
        public Condominio Condominio { get; set; }

        //Exercicio3
        public double AreaTotal { get; set; }   
        
        public double FracaoIdeal { get; set; }       
        public double ValorProporcionalIptu { get; set; }
    }
}