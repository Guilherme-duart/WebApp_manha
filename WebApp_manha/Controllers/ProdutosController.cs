using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp_manha.Entidades;
using WebApp_manha.Models;
using Microsoft.AspNetCore.Hosting;

namespace WebApp_manha.Controllers
{
    public class ProdutosController : Controller
    {

        private Contexto db;
        private IwebHostEnvironment webHostEnvironment;

        public ProdutosController(Contexto contexto ,IwebHostEnvironment _web )
        {
            db = contexto;
            webHostEnvironment = _web;
        }
        public IActionResult Lista()
        {
            List<Produtos> model = new List<Produtos>();
            model = db.Produtos.Include(a => a.Categoria).ToList();
            return View(model);
        }

        public IActionResult Cadastro()
        {
            NovoProdutoModelView model = new NovoProdutoModelView();
            model.ListaCategorias = db.Categorias.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult SalvarDados(Produtos dados , IformFile imagem)
        {
            if(imagem.Lenght > 0)
            {
             string caminho = webHostEnvironment.WebRootPath + "\\upload//";

              if(Directory.Exists(caminho))
            {
                Directory.CreateDiretory(caminho);

            }
            using(var stream = System.IO.file.Create(caminho+imagem.FileName))
            {
                 imagem.CopyToAsync(stream);
            }
            dados.CaminhoImagem = imagem.FileName;

            }
           

          using (var)
          db.Produtos.Add(dados);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
