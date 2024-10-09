using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlCommand cmd;
            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;Database=sapateiro;Uid=root;Pwd''");
            try
            {
                conexao.Open();
                Console.WriteLine("Conexao bem sucedida...");
            }
            catch (Exception ex)
            { 
            Console.WriteLine(ex.Message);
            }
            string sql;
            sql = "select * from usuario";
            cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();

            while (rdr.Read()) { 
            Console.WriteLine("Id Usuario:" + rdr["id"] + "\n");
                Console.WriteLine("Usuario" + rdr ["usuario"] + "\nSenha:" );
            
            }
            Console.ReadKey();
        }
    }
}
