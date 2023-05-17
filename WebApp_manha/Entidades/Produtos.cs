namespace WebApp_manha.Entidades
{
    public class Produtos
    {
        public int Id { get; set; }
        public string DESCRICAO { get; set;}

        public decimal VALOR { get; set;}

        public bool ATIVO { get; set;}

        public int CATEGORIAId { get; set;}

        public Categorias Categorias { get; set;}
    }
}
