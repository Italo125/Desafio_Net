namespace Desafio_Net.Models
{
    public class ProdutoModel
    {
       public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string brand { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }
        
    }
}
