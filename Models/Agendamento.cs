namespace projetocf2.Models;

    public class Agendamento
    {
        public int Id { get; set; }

        public string NomeCliente { get; set;}="";

        public  int data { get; set;}

        public string Hora { get; set;}="";

        public string Servico { get; set;}="";
    }
