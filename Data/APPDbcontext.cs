using Microsoft.EntityFrameworkCore;
using projetocf2.Models;

namespace projetocf2.Data;

public class APPDBcontex: DbContext
{
    
    // construtor padrão - recebe as opções de configuração ( qual banco usar, etc.)

    public APPDBcontex(DbContextOptions<APPDBcontex> options) : base(options) { }
    // esta linha diz : "existe uma tabela chamada produtos que armazena objetos produtos"

    public DbSet<Usuario> usuarios{get; set; } 
    public DbSet<Agendamento> agendamentos{get; set; } 


    
}
