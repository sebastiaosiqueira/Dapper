// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
using System.Runtime.InteropServices;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace Blog{

    class Program{
        private const string CONNECTION_STRING = @"Data Source=ADMDTI19; Initial Catalog=Blog;Integrated Security=True;TrustServerCertificate=True;";
        static void Main(string[] args){
           Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();
       Console.ReadKey();
        Database.Connection.Close();
        }

        private static void Load(){
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de Tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatorios");

            var option =short.Parse(Console.ReadLine());
            switch(option){
                case 4:
                MenuTagScreen.Load();
                break;
               default: Load(); break;
            }
        }
    }
}


