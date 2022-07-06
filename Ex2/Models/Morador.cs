using System.Text.Json.Serialization;

namespace Ex2.Models
{
    public class Morador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public int FamiliaId { get; set; }
        [JsonIgnore]
        public Familia Familia { get; set; }
    }
}