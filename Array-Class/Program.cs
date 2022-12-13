
#region String.Text;

//string name = "Pervin";
//name = "Ferid";


//StringBuilder stringBuilder = new StringBuilder("Pervin");

//stringBuilder.Append("Per");
//stringBuilder.Append("vin");

#endregion


#region Array

//int[] arr1 = { 1, 2, 3, 4, 5, 6 };
//int[] arr2 = new int[10];
//int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };

//Console.WriteLine(arr1[0] );
//Console.WriteLine(arr1.Length);
//Console.WriteLine(arr1.FirstOrDefault());


//Array.Resize{ref arr1,10 };

//arr1[8] = 100;

//Console.WriteLine(arr1[8]);

//Console.WriteLine(arr1.Length);


//var newArr = arr1.Clone();

//int[] arr4 = { 1, 2, 3 };
//arr1.CopyTo(arr4, 2);


//Array.Reverse(arr1);


//foreach (var item in arr1)
//{
//    Console.WriteLine(item);
//}


//int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
//Console.WriteLine(array2D[0,1]);








//string name = "Chinare";

//var test = name.Reverse().ToArray();

//string res = " ";

//foreach (var item in test)
//{
//    res += item;

//}

//Console.WriteLine(res
//


//string name = "Chinare";
//static string  ReverseStr(string str)
//{
//    var reversedArray = str.Reverse().ToArray();

//    string res = " ";
//    foreach (var item in  reversedArray)
//    {
//        res += item;
//    }
//    return res;

//}

//var res = ReverseStr("Chinare");

//Console.WriteLine(res);




//static void  ConsoleWriteLine(string text)
//{
//    Console.WriteLine(text);
//}


//ConsoleWriteLine("salam Roya");
//ConsoleWriteLine("sagol Konul");
//ConsoleWriteLine("Hello Chinare");

//Test(new int[] { 1,100, 2, 3, 4, 5 });

//var testArr == new int[] { 1, 100, 3, 4, 5 };
//foreach (var item in testArr)
//{
//	Console.WriteLine(item);
//}





//static void Test(int[] array)
//{
//	foreach (var item in array)
//	{
//		if (item == 100)
//		{
//			return;
//		}
//	}

//	Console.WriteLine("salalm");
//}





#endregion


#region Object

//string name1 = "Cavid";
//string surname1 = "Ismayilzade";
//int age1 = 22;


//string name2 = "Aqshin";
//string surname2 = "Hummetov";
//int age2 = 27;


//string name3 = "Mirze";
//string surname3 = "Bashirzade";
//int age3 = 26;


//string name4 = "Cahandar";
//string surname4 = "Velibeyli";
//int age4 = 26;

////Console.WriteLine($"{name1} {surname1} {age1}");


//var stu1 = new
//{
//    name = "Cavid",
//    surname = "Ismayilzade",
//    age = 22
//};


//var stu2 = new
//{
//    name = "Aqshin",
//    surname = "Hummetov",
//    age = 27
//};

//Console.WriteLine(  stu1.name.ToUpper() + " " + stu1.surname);









#endregion


#region Student_Class

//using Array_Class;




//Student student1 = new Student();
//student1.name = "Cavid";
//student1.surname = "Ismayilzade";
//student1.age = 22;
//student1.address = "Sulutepe";
//student1.phone = "12345";
//student1.zipCode = 777;



//Student student2 = new Student();
//student2.name = "Roya";
//student2.surname = "Meherremova";
//student2.age = 26;
//student2.address = "Sumqayit";
//student2.phone = "123456";



//Console.WriteLine($" {student1.name} {student1.name} {student1.age} {student1.address} {student1.phone}");

//Console.WriteLine($" {student2.name} {student2.name} {student2.age} {student2.address} {student2.phone}");



//Console.WriteLine(student1.GetFullName());

//Console.WriteLine(student2.GetFullData());
#endregion

#region Book_Class
//using Array_Class;

//Book book = new Book();

//book.name = "Xosrov ve Shirin

//using Array_Class;

//Book book = new Book("Xosrov ve Shirin", "Nizami");



//Console.WriteLine(" book name: {0} book author: {1}" , book.name , book.author );


//using Array_Class;

//Book book1 = new Book("hello" ,100 );

//Book book2 = new Book("hello");

//Book book3 = new Book();
#endregion

#region Account_Class

using Array_Class;


//1) Account adinda class yaradib, onun icinde Login methodu yazin. 
//  Hemin login methoduna username ve password gelecek.
//  Username cavid123 ve password Cavid1993 -e beraberdirse ekrana giriw ugurludur yazilsin, 
//  eks halda email ve ya password sehvdir cixsin.


using Array_Class;

Account login1 = new Account("Cavid123", "Cavid1993");


login1.Login();

#endregion

#region Factorial_Class

//2) Factorial adinda class yaradin , hemin clasin icinde reqem qebul edib hemin reqemin factorialini hesablayan method yazin. 


Factorial result = new Factorial();

result.FactorialNum(5);
#endregion
