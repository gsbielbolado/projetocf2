using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using projetocf2.Models;

namespace projetocf2.Pages
{
    public class AgendamentoModel : PageModel
    {
        // Lista em memória (simples e rápido)
        public static List<Agendamento> ListaAgendamentos = new List<Agendamento>();

        [BindProperty]
        public List<Agendamento> NovoAgendamento { get; set; } = new();

        // Carrega a página
        public void OnGet()
        {
        }

        // Quando clicar no botão "Agendar"
        // public IActionResult OnPost(int Id , string NomeCliente,int Data, int Hora, string Servico)
        // {
        //     // Adiciona na lista
        //     NovoAgendamento.Add(NovoAgendamento);

        //     // Limpa o formulário
        //     ModelState.Clear();

        //     return Page();
        // }
    }
}