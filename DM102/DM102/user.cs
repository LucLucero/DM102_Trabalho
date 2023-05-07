using System;

public class User
{
	private string name;
	private string email;
	private string password;


	public User(string name, string email, string password)
	{

		this.name = name;
		this.email = email;
		this.password = password;

	}

	public bool Login(User user)
    {
		string pass = "senha123";
		string emailright = "luciano-bob@hotmail.com";
		//Autenticação Usuário
		if ((user.email == emailright) && (user.password == pass))
        {

			Console.WriteLine("Login Efetuado");
			return true;
        }
        else
        {

			Console.WriteLine("Login Recusado");
			return false;

		}  
    }




}
