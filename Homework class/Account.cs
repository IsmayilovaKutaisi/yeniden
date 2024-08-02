using System;
//2) Account adinda class yaradib, onun icinde Login methodu yazin.
// Hemin login methoduna username ve password gelecek.
//Username cavid123 ve password Cavid1993 -e beraberdirse ekrana giriw ugurludur yazilsin,
//eks halda email ve ya password sehvdir cixsin.


namespace Homework_class
{
	internal class Account
	{


		static void Login(string username,string password)
		{
if(username=="cavid123"&&password=="Cavid1993")
			{
				Console.WriteLine("giriw ugurludur");
				SendEmail("Email succes");
			}
			else
			{
				Console.WriteLine("email ve ya password sehvdir");
				SendEmail("Email error");
			}
		}
		static void SendEmail(string message)
		{
			Console.WriteLine(message);
		}
       

    }
}

 

