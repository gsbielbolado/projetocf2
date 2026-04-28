using Microsoft.EntityFrameworkCore;
using projetocf2.Models;

namespace projetocf2.Data;

public class APPDBcontex: DbContext
{
    
    // contrutor padrão - recebe as opções de configuração ( qual bancop usar, etc.)

    public APPDBcontex(DbContextOptions<AppContext> options) : base(options) { }
    // esta linha diz : "existe uma tabela chamada produtos que armazena objetos produtos"

    public DbSet<Usuario> usuarios{get; set; } 

    
}