using System;
/*namespace Class_praktika
{
	internal class book
	{
		public string name;
		public string author;
		public DateTime Date;

		public book(string name,string author,DateTime date)    //class adı ve construktor adı mütləq eyni olmalıdır.
		{
			Console.WriteLine(name+" "+author+" "+date);
		}
	}
}*/

namespace Class_praktika
{
    internal class book
    {
        public string name;
        public string author;
        public DateTime Date;

        public book(string name, string author, DateTime date)    
        {
            this.name = name;
            this.author = author;
            this.Date = date;
        }
    }
}