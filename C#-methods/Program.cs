











//Sinifde yazilan kodlar

//1------------------

//static string Test(int num1,string name,int num2 = 100)
//{
//    return num1 + name + num2;
//}

//Console.WriteLine(Test(5,"Nurlan"));







//2-------------------

//static void Test(int a,params int[] nums)
//{
//    foreach (int item in nums)
//    {
//        Console.WriteLine(item);
//    }
//}

//Test(1, 2, 3, 4, 5, 6);




//3---------------------


//static void Test(int a,params int[] numbers)
//{
//    int sum = 0;
//    foreach (int item in numbers)
//    {
//        sum += item;    
//    }

//    int result = sum * a;

//    Console.WriteLine(result);
//}

//Test(1, 2, 3, 4, 4, 5);



//4-----------------------


//using MethodOverloading;


//Class1.Test(5);


//5-------------------


//int a = 20;

//int b = a;

//b = 200;


//Console.WriteLine(a);
//Console.WriteLine(b);

//-------------------------------

//string name = "Nurlan";

//string surname = name;

//surname = "Musayev";

//Console.WriteLine(name);
//Console.WriteLine(surname);


//--------------------------------


//int[] arr1 = { 2, 3, 4, 5 };

//int[] arr2 = arr1;

//arr2[0] = 100;

//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);










//2) Parametr olaraq string qebul eden metod yazmalisiz. Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin


//static string reverStr(string name)
//{
//    string result = "";
//    for (int i = name.Length - 1; i >= 0; i--)
//    {
//        result += name[i];
//    }
//    return result;
//}


//Console.WriteLine(reverStr("Nurlan"));















//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın


//static string divideNumber(int num)
//{
//    if(num % 3 == 0 && num % 7 == 0)
//    {
//        return "Eded 3 ve 7 e bolunur";
//    }
//    else
//    {
//        return "Eded 3 ve 7 e bolunmur";
//    }
//}


//Console.WriteLine(divideNumber(21));






//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın


//static int checkEvenNumber(int a, int b)
//{
//    int sum = a + b;
//    if (a % 2 == 0 && b % 2 == 0)
//    {
//        return sum;
//    }
//    else
//    {
//        return 0;
//    }
//}


//Console.WriteLine(checkEvenNumber(6, 10));





//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin



//static int chechOddNumber(int n,int m)
//{
//    int count = 0;
//    for (int i = n; i <= m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }
//    }return count;  
//}


//Console.WriteLine(chechOddNumber(3,8));





//4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin


//static int findOddNumber(int n,int m)
//{
//    int sum = 0;
//    for(int i = n; i <= m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum += i;
//        }

//    }
//    return sum;
//}


//Console.WriteLine(findOddNumber(3,8));





//5)Verilmish arrayin icindeki tek ededlerin cemini tapin


//static int findArrOddnum(int[] nums)
//{
//    int sum = 0;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] % 2 == 1)
//        {
//            sum += nums[i];
//        }
//    }
//    return sum;
//}


//int[] nums = {2,3,4,5,6,7};

//Console.WriteLine(findArrOddnum(nums));





//6)Verilmish arrayin icindeki cut ededlerin sayini tapin


//static int findEvenNum(int[] nums)
//{
//    int count = 0;
//    for(int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] % 2 == 0)
//        {
//            count++;
//        }
//    }
//    return count;
//}


//int[] nums = { 2, 12, 4, 5, 6, 7, 8 };


//Console.WriteLine(findEvenNum(nums));




//7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin

//static string checkNums(int a)
//{
//    int count = 0;

//    for(int i = 1; i <= a; i++)
//    {
//        if(a%i == 0)
//        {
//            count++;
//        }
//    }if(count > 2)
//    {
//        return "Eded murekkebdir";
//    }
//    else
//    {
//        return "Eded sadedir";
//    }

//}


//Console.WriteLine(checkNums(7));






//8) n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın








//9)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq


//static int multNum(int[] nums)
//{
//    int multipl = 1;
//    for(int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i]>1 && nums[i] <20)
//        {
//            multipl *= nums[i]; 
//        }
//    }
//    return multipl; 
//}


//int[] nums = {2,3,-1,4,5,23,24,25};

//Console.WriteLine(multNum(nums));





//10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq


//static int powEvenNum(int[] nums)
//{
//    int sum = 0;

//    for (int i = 0; i < nums.Length; i++)
//    {

//        if (nums[i] % 2 == 0)
//        {
//            sum += nums[i];
//        }
//    }

//    return sum * sum;
//}



//int[] nums = { 2, 3, 4, 5 };


//Console.WriteLine(powEvenNum(nums));

