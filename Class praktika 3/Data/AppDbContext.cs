using System;
namespace Class_praktika_3.Data
{
	internal class AppDbContext
	{
		public Moduls.Employee[] GetAllEmployee()
		{
			Moduls.Employee emp1 = new()
			{
                id=1,
				fullName="Sebine Agayeva",
				address="Nizami",
				age=27,
				email="sebine@code.edu.az"
            };
            Moduls.Employee emp2 = new()
            {
                id=2,
                fullName = "Reshad Xanmemmedli",
                address = "Nesimi",
                age = 31,
                email = "reshad@code.edu.az"
            };
            Moduls.Employee emp3 = new()
            {
                id=3,
                fullName = "Ziya Sadiq",
                address = "Sumqayit",
                age = 20,
                email = "ziya@code.edu.az"
            };
            Moduls.Employee emp4 = new()
            {
                id=4,
                fullName = "Gulay Mehreliyev",
                address = "Elmler",
                age = 18,
                email = "gulay@code.edu.az"
            };
            Moduls.Employee emp5 = new()
            {
                id=5,
                fullName = "Elnare Efendiyeva",
                address = "Sumqayit",
                age = 19,
                email = "elnare@code.edu.az"
            };
            Moduls.Employee emp6 = new()
            {
                id=6,
                fullName = "Nigar Qedirova",
                address = "Nerimanov",
                age = 19,
                email = "nigar@code.edu.az"
            };
            Moduls.Employee emp7 = new()
            {
                id=7,
                fullName = "Mehriban Bagizade",
                address = "Suraxani",
                age = 19,
                email = "sebine@code.edu.az"
            };
            Moduls.Employee emp8 = new()
            {
                id=8,
                fullName = "Gulgez Pasayev",
                address = "Nizami",
                age = 27,
                email = "gulgez@code.edu.az"
            };
            Moduls.Employee emp9 = new()
            {
                id=9,
                fullName = "Kutaisi Ismayilova",
                address = "Zerdab",
                age = 26,
                email = "kutaisi@code.edu.az"
            };
            Moduls.Employee[] employees = { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9 };
            return employees;
        }
		
		
	}
}

