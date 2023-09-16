//static void CheckMarried(bool isMarried,int age)
//{
//    if (isMarried)
//    {
//        Console.WriteLine("evlidir -" + age);
//    }
//    else
//    {
//        Console.WriteLine("Subaydir -" + age);
//    }
//}

//static void GetAge(int age)
//{
//    bool isMarried = false; 
//    CheckMarried(isMarried,age);
//}


//int age = 35;

//GetAge(age);





//static int GetNumber()
//{
//    int number = 100;
//    return number;  
//}


//int result = GetNumber();

//if(result > 10)
//{
//    Console.WriteLine(GetNumber());
//}



//static string GetTemp(int temp)
//{
//    if(temp > 20)
//    {
//        return "hot";
//    }
//    else
//    {
//        return "cold";
//    }
//}


//string result = GetTemp(30);

//Console.WriteLine(result);






//static bool IsSuccess(string employeeName)
//{
//    string[] employees = { "Semed", "Tunzale", "Metanet", "Meryem", "Haci", "Aqshin" };

//    foreach(var employee in employees)
//    {
//        if(employee == employeeName)
//        {
//            return true;
//        }
//    } 
//    return false;
//}

//Console.WriteLine("Ad daxil edin :");
//string name = Console.ReadLine();

//bool result = IsSuccess(name);

//if (result)
//{
//    Console.WriteLine("Ugurludur");
//}
//else
//{
//    Console.WriteLine("ugurlu deyil");
//}



//static int GetSumOddNumbers(int a,int b)
//{
//    int sum = 0;
//    for(int i = a; i <= b; i++)
//    {
//        if(i%2 == 1)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}


//int result = GetSumOddNumbers(5, 10);

//Console.WriteLine(result);






//static bool login(string username, string password)
//{
//    if(username == "nurlan111" && password =="nurlan123")
//    {
//        return true;
//    }

//    return false;
//}



//Console.WriteLine("username daxil edin :");

//string username = Console.ReadLine();


//Console.WriteLine("password daxil edin :");

//string password = Console.ReadLine();


//if (login(username, password))
//{
//    Console.WriteLine("Login success");
//}
//else
//{
//    Console.WriteLine("username or passowrd is incorrect");
//}



//static bool Search(string studentName)
//{
//    string[] students = { "Rufet", "Semed", "Oruc", "Aqsin", "Haci" };
//    foreach(var student in students)
//    {
//        if(student == studentName)
//        {
//            return true;
//        }
//    }
//    return false;
//}


//Console.WriteLine("Adi daxil edin :");

//string name = Console.ReadLine();

//bool result = Search(name);


//if (result)
//{
//    Console.WriteLine("Student is found");
//}
//else
//{
//    Console.WriteLine("Not found");
//}

