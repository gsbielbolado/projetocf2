
using System.Security.Cryptography.X509Certificates;
using projetocf2.Models;
using SQLitePCL;


namespace projetocf2.Data;
public class AgendamentoRepositorio


{
   private readonly APPDBcontex _context;


   public AgendamentoRepositorio(APPDBcontex context)

   {
      _context = context;
   }

   public List<Agendamento> puxarAgendamento()
   {
      return _context.agendamentos.ToList();
   }

      public void  adicionar(Agendamento agendamento)
   {
      _context.agendamentos.Add(agendamento);
      _context.SaveChanges();
   }
   

}