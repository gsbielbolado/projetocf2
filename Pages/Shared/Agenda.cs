using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using projetocf2.Data;
using projetocf2.Models;

namespace projetocf2.Pages;



public class agendaModels : PageModel 
{

    public IActionResult OnPost ( string NomeCliente,string Servico,int data, int Hora)

    {
        var usuario = new Usuario
        {
            NomeCliente = NomeCliente,
            


        };
        UsuarioRepositorio.Adiciona(usuario);

        return RedirectToPage("/agenda");
    }
}