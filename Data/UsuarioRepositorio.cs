
using System.Security.Cryptography.X509Certificates;
using projetocf2.Models;
using SQLitePCL;

namespace projetocf2.Data;
public class UsuarioRepositorio


{
   private readonly APPDBcontex _context;


   public UsuarioRepositorio(APPDBcontex context)

   {
      _context = context;
   }

   public List<Usuario> puxarProduto()
   {
      return _context.usuarios.ToList();
   }

      public void  adicionar(Usuario usuario)
   {
      _context.usuarios.Add(usuario);
      _context.SaveChanges();
   }
   

}