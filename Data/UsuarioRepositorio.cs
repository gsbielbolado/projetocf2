
using projetocf2.Models;

namespace projetocf2.Data;
public class UsuarioRepositorio


{//cirando a lista de classes para registro

   static List<Usuario> usuarios =new List<Usuario>();

   //realiszando  o registro dentro da lista

   static UsuarioRepositorio()

   {
      usuarios.Add(new Usuario{ email="@gmail.com",nome="Mauricinho Jamaicano",senha=0123});
   }

   public List<Usuario> puxarUsuario()
   {
      return usuarios;
      
   }
   public static void Adiciona(Usuario usuario)
   {
       usuarios.Add(usuario);
   }



  


    
    
}