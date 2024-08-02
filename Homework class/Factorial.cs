//3) Factorial adinda class yaradin
//, hemin clasin icinde reqem qebul edib hemin reqemin factorialini hesablayan method yazin.
using System;
namespace Homework_class
{
	internal class Factorial
	{
		private int a;
		public Factorial(int a)
		{
			this.a = a;
		}
	static int Factor (int a)
		{
			int product = 1;
			for(int i=1;i<=a;i++)
			{
				product *= i;
			}
			return product;
        Console.WriteLine(product);
    }
	
	}
}

