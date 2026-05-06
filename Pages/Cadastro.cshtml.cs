


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using projetocf2.Data;
using projetocf2.Models;

public class cadastroModels(UsuarioRepositorio repositorio):PageModel
{
    public IActionResult OnPost ( string nome,string email,int senha)

    {
        var usuario = new Usuario
        {
            nome = nome,
            email = email,
            senha = senha,
        };
        repositorio.adicionar(usuario);

        return RedirectToPage("/index");
    }
}