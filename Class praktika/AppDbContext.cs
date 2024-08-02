using System;
//clasın içinde class yaradıb program.cs de çağırıb işlətmək üçün bunu yazıram.
namespace Class_praktika.Data
{
	internal class AppDbContext
	{
		public Employee[]GetAllEmployee()
		{
			Employee emp1 = new()
			{
				fullName = "Sebine Agayeva",
				address = "Nizami",
				AggregateException = 27,
				email = "sebine@code.edu.az"

			};
            Employee emp2 = new()
            {
                fullName = "Reshad Xanmemmedli",
                address = "Nesimi",
                AggregateException = 31,
                email = "reshad@code.edu.az"

            };
            Employee emp3 = new()
            {
                fullName = "Ziya Sadiq",
                address = "Sumqayit",
                AggregateException = 20,
                email = "ziya@code.edu.az"

            };
            Employee emp4 = new()
            {
                fullName = "Nicat Orucov",
                address = "Sumqayit",
                AggregateException = 18,
                email = "nicat@code.edu.az"

            };
            Employee emp5 = new()
            {
                fullName = "Gulay Mehreliyeva",
                address = "Elmler",
                AggregateException = 18,
                email = "gulay@code.edu.az"

            };
            Employee emp6 = new()
            {
                fullName = "Elnare Efendiyeva",
                address = "Sumqayit",
                AggregateException = 19,
                email = "elnare@code.edu.az"

            };
            Employee emp7 = new()
            {
                fullName = "Nigar Qedirova",
                address = "Nerimanov",
                AggregateException = 19,
                email = "nigar@code.edu.az"

            };
            Employee emp8 = new()
            {
                fullName = "Mehriban Bagizade",
                address = "Suraxani",
                AggregateException = 19,
                email = "mehriban@code.edu.az"

            };
            Employee emp9 = new()
            {
                fullName = "Kutaisi Ismayilova",
                address = "Zerdab",
                AggregateException = 26,
                email = "kutaisi@code.edu.az"

            };
        }
	}
}

