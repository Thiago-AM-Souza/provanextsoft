using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ex2.Models
{
    public class Familia
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int ApartamentoId { get; set; }
        [JsonIgnore]
        public Apartamento Apartamento { get; set; }

        public List<Morador> Moradores { get; set; }
    }
}
