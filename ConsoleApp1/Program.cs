string username;
string password;


for (int i = 0; i < 3; i++)
{
	username = Console.ReadLine();
    password = Console.ReadLine();
	if (username=="görkem" && password=="123")
	{
		Console.WriteLine("Giriş Başarılı");
		break;
	}
	else
	{
		if (i==2)
		{
			Console.WriteLine("bloke");
			break;
		}
		Console.WriteLine("tekrar dene");
	}	
}
