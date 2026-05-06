using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using projetocf2.Data;
using projetocf2.Models;

namespace projetocf2.Pages;



public class agendaModels (AgendamentoRepositorio repositorio): PageModel
{

    public IActionResult OnPost ( string NomeCliente,string Servico,int data, string Hora)

    {
        var agendamento = new Agendamento
        {
            NomeCliente = NomeCliente,
            Servico = Servico,
            data = data,
            Hora =  Hora,


        };
        repositorio.adicionar(agendamento);
        return RedirectToPage("/index");
    }
}