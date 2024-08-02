


//internal classlara əlçatanlığı təmin etmək üçün istifadə olunur.Ayrı mövzudu çok axtarış etme!
//class referans type-dir.
//normalda programda təyin etdiyimiz vareable ,classın içində təyin olunanda field adlanır.
//public string name;		/
//public string surname;    / bunlar clasın body-si adlanır.
//public int age;			/
//Clasın body-sine metodlar,fieldler daxil olur.
//Proqram.cs ortaqdır.Başqa yerlərdə codu və ya classı yazıb,gəlib burada çağırıb istifadə edirik.
//Classın ramda yer ayırmağı üçün onda obyekt yaradırıq.Obyektin yaradılmağıda proqram instance(misal) etmek demekdir.

namespace String_metodlari_praktika
{
	internal class Student
	{
		public string name;
		public string surname;
		public int age;

		public string GetFullName()
		{
			return name + " " + surname+" "+age;
		}
		public string GetFullData()
		{
			return $"Name:{name},Surname:{surname},Age:{age}";
		}

	}
}

