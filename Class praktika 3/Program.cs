// See https://aka.ms/new-console-template for more information

using Class_praktika_3.Data;
/*AppDbContext context = new();
var datas = context.GetAllEmployee();
foreach(var item in datas)
{
    Console.WriteLine(item.fullName);
}*/


using Class_praktika_3.Services;
EmployeeService service = new();
//servis.GetAll();*/
service.GetById(2);


//Console.WriteLine("Hello, World!");

