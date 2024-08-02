// See https://aka.ms/new-console-template for more information


#region String metodlar


//Substring stringin içindən kəsib götürməyə kömək edir.


/*string word = "Hayallerim guzel benim";
Console.WriteLine(word.Substring(0, 8));*/


/*string word = "Hayallerim guzel benim";
Console.WriteLine(word.Substring(0, 8) + "...");*/


/*string word = "Hayallerim guzel benim";
Console.WriteLine(word.Substring(0, 8) + "..." + "-For read more.click 5");
string number = Console.ReadLine();
if(number=="5")
{
    Console.WriteLine(word);
}*/



/*string[] students = { "Nizami",  "Fuad" ,  "Oruc" ,  "Ferid" ,  "Mehemmed" ,  "Turan" ,  "Kutaisi"  };
string names = string.Join("_", students);
Console.WriteLine(names);*/

//Type-ni bilmək üçün bundan istifadə edə bilərik.
/*string names = "word";
Console.WriteLine(names.GetType());*/

//Stringin sonunun hansı sözlə bitdiyini doğrulayır.Bool-dur .True ve ya false verir.


/*string word = "Hayallerim guzel benim";
Console.WriteLine(word.EndsWith("benim"));*/


//Charları və ya sözləri əvəz etmək üçün .


/*string word = "Hayallerim guzel benim";
var res = word.Replace("guzel", "muhtesem");
Console.WriteLine(res);*/



//Mətindəki sözün neçənci indeksdə olduğunu göstərir.
/*string word = "Hayallerim guzel benim";
Console.WriteLine(word.IndexOf("guzel"));*/

//Mətndəki axırıncı gözəl sözünün indeksini tapır.

/*string word = "Hayallerim cok cok cok guzel guzel guzel benim";
Console.WriteLine(word.LastIndexOf("guzel"));*/


/*static int GetCountOfStrWithCondition(string[] words)
{
    int count = 0;
    foreach(var item in words)
    {
        if(item.StartsWith("ar"))
        {
            count++;
        }
    }
    return count;
}
string[] words = { "artest", "aryes", "salamar", "testtest" };
Console.WriteLine(GetCountOfStrWithCondition(words));*/



/*static int GetCountOfStrWithCondition(string[] words,string pattern)
{
    int count = 0;
    foreach (var item in words)
    {
        if (item.ToLower().StartsWith(pattern.ToLower()))
        {
            count++;
        }
    }
    return count;
}
string[] words = { "artest", "Aryes", "salamar", "testtest" };
Console.WriteLine(GetCountOfStrWithCondition(words,"ar"));*/

//toplu şəkildə datalardan istifadə etmək üçün Arraylardan istifadə olunur.
//Arrayın adı,Type,Length -si mütləq sürətdə olmalıdır.
//Arrayın 3 növ təyin olunma qaydası var.

//1-ci təyin olunma yolu.

//int[] nums1 = { 1,7, 2, 3, 4, 5 };
// int -in defaul valyusu sifirdir.
//int[] nums2 = new int[5];
//burada 5 dənə item var və hamısıda sıfırdır.Çoxluğun length-si 5 təyin olunub.
// element təyin olunmadığına görə 5-ninde yerinə sıfır yazılır.Çünki,defaul sıfırdır.
//int[] nums3 = new int[5] { 1, 2, 3, 4, 5, };
//Burada çoxluğun lengt-si 5 olduğu üçün çoxluğun içərisinə də 5 dənə element yazılmalıdır.
//Əks halda error verəcək.



//Arrayın indeksinə görə ona müraciət etmək olur.

/*Console.WriteLine(nums1.Length);
Console.WriteLine(nums1[2]);
Console.WriteLine(nums1[nums1.Length - 1]);*/

//Arrayın neçə ölçülü olduğu Rank vasitəsilə tapılır.Burada Arrayın içində arraylar var.Deməli iki dənə array var.

/*int[,] nums4 = { { 1, 2, 3 }, { 2, 3, 4 }, { 5, 6, 7 } };
Console.WriteLine(nums4.Rank);*/

//Sort  void metod olduğu üçün heçnə qaytarmır.Buna görədə onu heçnəyə asaind edə bilmərəm.
/*Array.Sort(nums1);
foreach(var item in nums1)
{
    Console.WriteLine(item);
}*/


//Arrayın müəyyən elementlərindən sonra digər Arrayın elementlərini yazdırmaq üçün aşağıdakı üsuldan istifadə et.

//Diqqətli ol arrayın neçə parametri varsa,o qədərdə parametri qalır.Yəni arrayın parametr sayı dəyişmir.
//Əgər yazdığın rəqəm arrayın parametr sayını aşsa,error verir.Diqqətli ol Kutaisi!
//int[] array = { 1, 2, 3, 4, 5, 6, 7 };
//int[] newarray = { 8, 9, 10, 11, 12, 13, 14 };

/*Array.Copy(array, 1, newarray, 1, 3);
foreach(var item in newarray)
{
    Console.WriteLine(item);
}*/



/*Array.Copy(array, newarray, 3);
foreach(var item in newarray)
{
    Console.WriteLine(item);
}*/


//Yuxarıdakı array daşması problemini həll etmək üçün müəllim aşağıdakı şəkildə dəyişiklik etdi.
//Yəni Arrayın length-sini artırdı.

/*Array.Resize(ref newarray, newarray.Length + 2);
Array.Copy(array, 2, newarray, 6, 3);
foreach(var item in newarray)
{
    Console.WriteLine(item);
    
}*/

//Buradakı 2 copy ediləcək arrayın neçənci indeksden başlayarak copy ediləcəyini göstərir.
//Buradakı 6 newarrayın ilk elementinden başlayaraq,6 elementini götürəcəyimizi ifadə edir.
//Buradakı 3 copy ediləcək arraydan 3 ədəd element götürüləcəyini ifadə edir.
//Əgər copy etmeye element tapmasa yerine default yəni sıfır verir.


//Bool qaytarır.Arrayın içində 5 elementi olub-olmadığını yoxlayır.True və ya False.
//int[] nums5 = { 1, 2, 3, 4, 5, 6, 7 };
/*Console.WriteLine(nums5.Contains(5));*/

//Arraya niyə referans type deyilir?Class olduğu üçün referans type dir ve heapda yerləşir.
//Bu heapları soruş qarışdırırsan!

//Elementin hansı indeksdə dayandığını tapmaq üçün aşağıdakı kimi kod yazılır.

/*Console.WriteLine(Array.IndexOf(nums5, 5));*/



//Arrayın içindın istənilən şərtə uyğun olanı göstərmək üçün aşağıdakı kimi kod yazılır.
//Sadəcə 1 dənə data qaytarır.Şərtə uyğun çox data olduqda şərtə uyğun olan ilk datanı console yazdıracaq.
//Burada var yerinə int də yazıla bilər.Çünki,arrayındakı elementlər rəqəmlərdir.

/*var data = Array.Find(nums5, m => m == 2);
Console.WriteLine(data);*/


//Əgər toplu sayda elementləri geri qaytarmağını istəyirsənsə,onda FindAll istifadə et!
//Əgər şərt ödənilmirsə,default verir.Yeni sıfır.
/*var datas = Array.FindAll(nums5, m => m > 3);
foreach(var item in datas)
{
    Console.WriteLine(item);
}*/

/*string[] students = { "Nizami", "Fuad", "Oruc", "Ferid", "Mehemmed", "Turan", "Kutaisi" };

static string[] Search(string[]students)
{
    return Array.FindAll(students, m => m.Contains("n"));
}
string[] names = { "Reshad", "Sebine", "Nigar", "Elnare", "Gulay", "Mehriban","Nicat" };
var datas = Search(names);
foreach(var item in datas)
{
    Console.WriteLine(item);
}*/

//Qısa şəkildə yazmaq üçün anonim arraydan istifadə edirik.Yəni adı yoxdur.Bunu etmə səbəbimiz bu arrayı
//artıq çağırmayacağımızdır.Array sadəcə bir yerdə istifadə edilirsə,yaradıla bilər.Lakin
//başqa yerdə arrayı çağırıb istifadə edəcəksənsə,ad verməlisən.Ad verməsən necə çağıracaqsan Kutaisi?!

/*static string[] Search(string[] students) => Array.FindAll(students, m => m.Contains("n"));

foreach(var item in Search(new string[]{ "Reshad", "Sebine", "Nigar", "Elnare", "Gulay", "Mehriban", "Nicat" }))
{
    Console.WriteLine(item);
}*/

//pattern köməyi ilə sadəcə bir hərf olanları deyil,sözləri hətta bir neçə hərfidə axtarış edib console yazdıra bilərsən.

/*static string[] Search(string[] students,string pattern) => Array.FindAll(students, m => m.Contains(pattern));

foreach (var item in Search(new string[] { "Reshad", "Sebine", "Nigar", "Elnare", "Gulay", "Mehriban", "Nicat" },"ic"))
{
    Console.WriteLine(item);
}*/




//tipini bilmirsənsə,var type işlət.Amma bilirsənsə,əlini pişik yeməyib yaz !
//Məsələn burada array stringdən ibarət olduğu üçün string yaza bilərsən!

/*static bool ExistData(string[] students, string pattern)
{
    var data = Array.Find(students, m => m==pattern);
    if(data==null)
    return false;

    return true;
}

var exist = ExistData(new string[] { "Reshad", "Sebine", "Nigar", "Elnare", "Gulay", "Mehriban", "Nicat" }, "Gulayy");

Console.WriteLine(exist);*/


//Hazır şəkildə bundan istifadə edə bilərsən!

//Console.WriteLine(Array.Exists(new string[] { "Reshad", "Sebine", "Nigar", "Elnare", "Gulay", "Mehriban", "Nicat" }, m => m == "Gulay"));


//string[] datas = { "Reshad", "Sebine", "Nigar", "Elnare", "Gulay", "Mehriban", "Nicat" };
//var result = datas.OrderBy(m => m);
//var result = datas.OrderByDescending(m => m);
//var result = datas.Where(m => m.Contains("n")).ToArray();
/*var result = datas.FirstOrDefault(m => m == "Gulay");
Console.WriteLine(result);*/
//foreach(var item in result)
//{
//Console.WriteLine(item);
//}





#endregion



#region Metod Class

//imperatatr dillərdə bir başa olaraq maşın dilinə çevrilir.
//Compaylr dillərdə isə ilk öncə assemblr dilinə sonra maşın dilinə çevrilir.
// Bu metoda returnsuz və ya returnu void olan metodda deyə bilərik.Yəni səssiz metoddur.


/*static void Test(int a,string b)
{
    Console.WriteLine("Method 1");
}

//Method signature(Method siqnice) Methodun imzasıdır.Bura Mehtodun adı (YƏNİ Test),parametrlərin sayı(YƏNİ a və b 2 dənə olması),parametrlərin tipləri(YƏNİ int və string) daxildir.
//return type (YƏNİ void və yerinde yazılan int ,string və s) metod signatureye daxil deyil.


//Eyni adda metod təyin edə bilmərik.Lakin classda bu mümkündür,parametrləri fərqli olmaq şərti ilə.
//Metod signature fərqli olduğu üçün yəni parametrləri fərqli olduğu üçün classda eyni adda 3 method yarada bildik.
//Method overloading (overloding) Methodun həddən artıq yüklənməsi.Yəni biz eyni adda metodları hazırlayırıq.Sistem daxil etdiyimiz
//arqumentə görə bu methodlardan birini seçib istifadə edir.Loru dildə biz metoda bir dən çox vəzifə yükləyib,onu overloading(həddən atrıq yükləyirik.) edirik.
/*namespace Class_İnheritance
{
    internal class Book
    {
        public void Test()
        {
            Console.WriteLine("Method 1");
        }
        public void Test(int a)
        {
            Console.WriteLine("Method 1");
        }
        public void Test(string a)
        {
            Console.WriteLine("Method 1");
        }
    }
}


namespace Class_Inheritance
{
    internal class Book
    {
        public void Sum(int a,int b)
        {
            int res = a + b;
            Console.WriteLine(res);
        }
        public void Sum(int a, int b,int c)
        {
            int res = a + b + c;
            Console.WriteLine(res);
        }
        public void Sum(int a, int b,int c,int d)
        {
            int res = a + b + c + d;
            Console.WriteLine(res);
        }
    }
}
// Seçim edende ilk arqumentin sayı ilə parametrin sayını,sonra typeni nezere alıb,ən uyğun variantı seçir.Eger hecne gondermirikse,default getirir.
namespace Class_Inheritance
{
    internal class Book1
    {
        public void Sum1(int a, int b)
        {
            int res = a + b;
            Console.WriteLine(res);
        }
        public void Sum1(int a, int b, int c)
        {
            int res = a + b + c;
            Console.WriteLine(res);
        }
        public void Sum1(int a, int b, int c, int d)
        {
            int res = a + b + c + d;
            Console.WriteLine(res);
        }
        public void Sum1(params int[]nums)
        {
       
            Console.WriteLine("tek paramsli");
        }
        public void Sum1(int a, params int[]nums)
        {
           
            Console.WriteLine("int a ve paramsli");
        }
    }
}*/



/*string name1="Kutaisi";
string surname1 = "Ismayilova";
int age = 26;


string name2 = "Nizami";
string surname2 = "Tagiyev";
int age2 = 18;

string name3 = "Turan";
string surname3 = "Muradov";
int age3 = 21;*/

//OP(obyekt yönümlü proqramlaşdırma)
// OP 4 dənə prinsipi var.Opnin prinsipləri düzgün şəkildə strukturlu green codlar yazmaq üçün istifadə edilir.
//proramlaşdırma deməkdir. OOP dillərdə kod yazmaq üçün bir çox prinsiplərə əməl etmək lazımdır.
//OOP-nin əsas 4 təməl prinsipi var. OOP-nin prinsipləri aşağıdakılardır.
//Inheritance(varislik)
//Encapsulation(kapsullama)
//Abstraction(Mücərrədlik)
//Polymorphism(Polimorfizm, Çox formalılıq)
//Inheritance - bunu bir DNA kimi fikirləşin. Atadan oğula ötürülən özəllik kimi.
//Bu Siniflərdə də eynidir. Necə ki insanda valdeyn-övlad əlaqəsi var siniflərdə də bu inheritance adlanır.
//Yəni bir sinif digərini özünə varis qəbul edir.


//Bu usul verilenleri kompaktlasdirmaq ucun istifade olunur.
/*var stu1 = new
{
    name = "Kutaisi",
    surname = "Ismayilova",
    age = 26
};

var stu2 = new
{
    name = "Nizami",
    surname = "Tagiyev",
    age = 18
};
var stu3 = new
{
    name = "Turan",
    surname = "Muradov",
    age = 21
};


Console.WriteLine(stu1.name + " " + stu1.surname + " " + stu1.age);*/

/*using String_metodlari_praktika;
Student stu1 = new Student();

stu1.name = "Kutaisi";
stu1.surname = "ismayilova";
stu1.age = 26;


Student stu2 = new()
{
    name = "Fuad",
    surname = "Sultanli",
    age = 21
};
Student stu3 = new()
{
    name = "Oruc",
    surname = "Novruzov",
    age = 16
};*/

/*Console.WriteLine(stu1.name);*/

//Bütün tələbələrin bütün datalarını ekranda göstərmək üçün ilk studentleri arraya qoyub,sonra onu loop-a salmalıyam.

/*Student[] students = { stu1, stu2, stu3 };
foreach (var item in students)
{
    Console.WriteLine(item.name);
}
//Student[] students = { stu1, stu2, stu3 };
foreach (var item in students)
{
    Console.WriteLine($"{item.name} {item.surname} - {item.age}");
}*/


/*using String_metodlari_praktika;

Student stu3 = new()
{
    name = "Oruc",
    surname = "Novruzov",
    age = 16
};

Console.WriteLine(stu3.GetFullName());
Console.WriteLine(stu3.GetFullData());*/




//Adinda ve ya soyadinda a herfi olan telebelerin gosterilmesi ucun.

using String_metodlari_praktika;
Student stu1 = new Student();

stu1.name = "Kutaisi";
stu1.surname = "ismayilova";
stu1.age = 26;


Student stu2 = new()
{
    name = "Fuad",
    surname = "Sultanli",
    age = 21
};
Student stu3 = new()
{
    name = "Oruc",
    surname = "Novruzov",
    age = 16
};


Student[] students = { stu1, stu2, stu3 };
/*foreach(var item in students)
{
    Console.WriteLine(item.GetFullData());
}*/
Search(students, "a");
static void Search(Student[]students,string searchText)
{
    var datas = Array.FindAll(students, m => m.name.Contains(searchText)|| m.surname.Contains(searchText));
    foreach(var item in datas)
    {
        Console.WriteLine(item.GetFullData());
    }
}











Console.WriteLine("Hello, World!");

#endregion