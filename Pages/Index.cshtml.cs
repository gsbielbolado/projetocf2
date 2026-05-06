using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace projetocf2.Pages;



using projetocf2.Data;
using projetocf2.Models;

public class IndexModel : PageModel
{
    private readonly UsuarioRepositorio repositorio ;

    public List<Usuario> UsuarioUnico {get;set;} = new();

    public IndexModel(UsuarioRepositorio repositorios)
    {
        repositorio = repositorios;
    }
    public void OnGet()
    {
        UsuarioUnico =repositorio.puxarProduto();


    }
}
