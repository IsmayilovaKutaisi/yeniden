using System;
namespace Class_praktika_3.Services
{
	internal class EmployeeService
	{
		public void GetAll()
		{
			Data.AppDbContext context = new();
			var datas = context.GetAllEmployee();
			foreach(var item in datas)
			{
				Console.WriteLine(item.fullName + " " + item.email);
			}
		}
		public void GetById(int id)
		{
            Data.AppDbContext context = new();
            var datas = context.GetAllEmployee();
			var data = datas.FirstOrDefault(m => m.id == id);
			Console.WriteLine(data.fullName + " " + data.email);
        }
	}
}

