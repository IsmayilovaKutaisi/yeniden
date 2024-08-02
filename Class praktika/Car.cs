using System;
/*namespace Class_praktika
{
	internal class Car
	{
		public string Name;
		public string Color;
		public string Speed;
		public Car()
		{
			Console.WriteLine("ctor1");
		}
		public Car(int a)
		{
            Console.WriteLine("ctor2");
        }
		public Car(int a, string b)
		{
            Console.WriteLine("ctor3");
        }
	}
}*/

/*namespace Class_praktika
{
    internal class Car
    {
        public string Name;
        public string Color;
        public string Speed;
        public Car()
        {
            Console.WriteLine("ctor1");//Bu zaman  thisin köməyi ilə boş construktorada keçid edir.thisdən əvvəl iki nöqtəni unutma
        }
        public Car(int a)
        {
            Console.WriteLine("ctor2");
        }
        public Car(int a, string b):this()
        {
            Console.WriteLine("ctor3");
        }
    }
}*/

//this construktorlar arasında hərəkət etdirmək üçündür.
/*namespace Class_praktika
{
    internal class Car
    {
        public string Name;
        public string Color;
        public string Speed;
        public Car(string name):this(5)
        {
            Console.WriteLine(name);
        }
        public Car(int b)
        {
            Console.WriteLine(b);
            Console.WriteLine(b++);
            Console.WriteLine(b);
        }
        public Car(int a, string b):this(b)
        {
            Console.WriteLine("ctor3");
        }
    }
}*/
