using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        
        public static void Load(){
             Console.Clear();
            Console.WriteLine("Atualizando uma tag");
            Console.WriteLine("-----------");
            Console.Write("Id: ");
            var id = Console.ReadLine();
            Console.Write("Nome: ");
             var name = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            Update(new Tag{Id = int.Parse(id), Name = name, Slug = slug});
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(Tag tag){
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
            repository.Update(tag);
            Console.WriteLine("Tag alterada com sucesso");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Não foi possivel alterar a tag");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}