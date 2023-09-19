using Clean_Zone;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace Clean_Zone.Model;

public class User
{
	public string? Username {  get; set; }
   
	public User(string username)
	{
		if (username.Length <= 8 && username != null)
		{
            this.Username = username;
            Console.WriteLine("Username registrado com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.ReadKey();
        }
        else
		{
            Console.WriteLine("A quantidade total de caracteres deverá ser igual ou inferior a 8.\nVoltando ao menur Principal...\n");			
            Thread.Sleep(2000);
            Console.Clear();
            Console.ReadKey();
           
        }		

	}

}
