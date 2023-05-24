using WebApp_manha.Entidades;

namespace WebApp_manha.Models
{
    public class NovoProdutoModelView : Produtos
    {

        public NovoProdutoModelView()
        {
            ListaCategorias = new List<Categorias>();
        }
        public List<Categorias> ListaCategorias {  get; set; }
    }
}
