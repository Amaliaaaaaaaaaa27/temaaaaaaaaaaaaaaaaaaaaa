// FACTORIALUL UNUI NUMAR
//
//using System;

//namespace ConsoleApp2;

//class factorial
//{

//    static void Main(string[] args)
//    {

//        int numar; // decalarearea unei variabile de la tastatura 

//        TextPrintUsers(); // afisare text

//        numar = int.Parse(Console.ReadLine()); // citirea ei 



//        Factorial(numar); // apelarea funtiei 

//    }
//    static void TextPrintUsers() // functie text 
//    {

//        Console.WriteLine(" type the number");


//    }

//    static void Factorial(int numar)
//    {

//        int factorial = 1; // declararea si initializarea unei variabile locale cu rol de a stocare a valori factoriale 

//        for (int index = 1; index <= numar; index++) // indexul incepe de la unu daca acesta este mai mic decat numarul tastat de catre utilizator creste cu o unitate;
//        {
//            factorial = factorial * index;
//            //        =    1      *  2    = 2  
//            //        =    2       * 3    = 6
//            //        =    6       *  4   = 24
//            //        =    24      * 5    = 120;
//            Console.WriteLine(factorial); // 2,6, 24,120 => factorial este 120


//        }
//    }
//}







//using System;

//namespace ConsoleApp2;

//class mediaaritmeticaanumerelorpare
//{
//static void Main(string[] args )
//    {
//        int numar;

//        TextPrintText();

//        numar = int.Parse(Console.ReadLine());



//        MediaAritmetica(numar);

//    }

//static void TextPrintText()
//    {

//        Console.WriteLine(" Tastati valorile de la tastatura ");





//    }


//    static void MediaAritmetica (int numar )
//    {
//        int sum = 0;

//        int index = 0;

//        int mediaaritmetica = 0; 


//        while (index <=  numar )
//        {

//            int x = numar % 10;

//            if (x % 2 == 0)
//            {

//                sum = sum + x;

//            }


//            numar = numar / 10;

//            index++;

//            mediaaritmetica = sum / index;

//        }

//        Console.WriteLine("suma numerelor este" + sum);

//        Console.WriteLine(" numarul contine " + index + "cifre");

//        Console.WriteLine(" media aritmetica a numerelor este = " + mediaaritmetica);






//    }






//    }

//using System;

//namespace ConsoleApp2;


//class polidrom
//{

//    static void Main(string[] args)
//    {
//        int numberRead;

//        TextPrintUsers();

//        numberRead = int.Parse(Console.ReadLine());

//        Palindrome(numberRead);

//    }
//    static void TextPrintUsers()
//    {

//        Console.WriteLine("type the number ");
//    }
//    static void Palindrome(int numberRead)
//    {
//        int reverse = 0;

//        while (numberRead != 0) {

//            reverse = reverse * 10 + numberRead % 10;

//            numberRead = numberRead / 10;
//        }

//        Console.WriteLine(reverse);

//        if (numberRead == reverse)
//        {

//            Console.WriteLine("the number is palindrome");
//        }
//        else if(numberRead != reverse)
//        {

//            Console.WriteLine("the number is not a palindrome");
//        }

//    }





//1 . maximul a trrei numere ;


//using System;
//using System.Security.AccessControl;

//namespace ConsoleApp2;

//class math
//{

//    static void Main(string[] args)
//    {

//        int firstNumber;

//        int secondNumber;

//        int thirdNumber;

//        TextPrintUsers();


//        Console.WriteLine("type the first number");
//        firstNumber = int.Parse(Console.ReadLine());

//        Console.WriteLine(" type the second number ");
//        secondNumber = int.Parse(Console.ReadLine());

//        Console.WriteLine(" type the third number ");
//        thirdNumber = int.Parse(Console.ReadLine());


//        Console.WriteLine(" max value is = ");
//        Maxim(firstNumber, secondNumber, thirdNumber);


//    }

//    static void TextPrintUsers()
//    {

//        Console.WriteLine(" type the numbers ");

//    }
//    static void Maxim(int firstNumber, int secondNumber, int thirdNumber)
//    {
//        int maxValue =0;


//        if (firstNumber > secondNumber)
//        {
//        firstNumber = maxValue;
//        }
//        if (firstNumber > thirdNumber)
//        {
//           firstNumber = maxValue;
//        }
//        if (secondNumber > firstNumber)
//        {
//            firstNumber = maxValue;
//        }
//        if (secondNumber > thirdNumber)
//        {
//            secondNumber = maxValue;
//        }
//        if (thirdNumber > firstNumber)
//        {
//            thirdNumber = maxValue;
//        }
//        if (thirdNumber > secondNumber)
//        {
//            thirdNumber = maxValue;
//        }
//        Console.WriteLine(maxValue);


//    }



//}


// Scrieti un program care va citi de la tastatura un nr intreg pozitiv si va afisa valoarea acestuia ini baza 2 .
// Exemplu : se citeste 42 si se afiseaza 101010;




// Scrieti un program care determina daca un numar natural n citit de la tastatura este patrat perfect ;

//using System;

//namespace ConsoleApp2;

//class patratperfect {

//    static void Main(string[] args)
//    {
//        int numberRead;

//        TextPrintUsers();

//        numberRead = int.Parse(Console.ReadLine());


//        PatratPerfect(numberRead);


//    }
//    // Math.Sqrt
//    static void TextPrintUsers()
//    {

//        Console.WriteLine("Type the number");
//    }

//    static void PatratPerfect(int numberRead)
//    {

//        Console.WriteLine(Math.Sqrt(numberRead));

//    }

//}



//using System;

//namespace ConsoleApp2;

//class patratperfect
//{

//    static void Main(string[] args)
//    {
//        int numberRead;

//        TextPrintUsers();

//        numberRead = int.Parse(Console.ReadLine());

//        TextPrintUsers();

//        Perfect_square(numberRead);

//    }

//    static void TextPrintUsers()
//    {

//        Console.WriteLine("Type the number");

//    }

//    static void Perfect_square(int numberRead)
//    {
//        int index = 1;

//        int x = 1;

//        while(index <= numberRead)
//        {

//           Console.WriteLine ( index++);

//          x =  numberRead % index = index;


//        }

//    }

// se citesc numere de la tastatura pana la aparitia lui 0.Sa se determine suma lor .


//using System;

//namespace ConsoleApp2;


//class sumofnumbers
//{
//    static void Main(string[] args)
//    {
//        int number;

//        TextPrintUsers();

//        number = int.Parse(Console.ReadLine());

//        Sum(number);

//    }
//    static void TextPrintUsers()
//    {

//        Console.WriteLine(" type the number ");


//    }
//    static void Sum(int number)
//    {
//        int sum = 0;
//        int index = 1;

//        while (number != 0)
//        {
//            sum = sum + index;
//            index++;

//        }
//        Console.WriteLine(sum);

//    }


//}

// se citesc numere de la tastatura pana cand se introduc doua numere consecutive egale, sa se determine suma lor .


//namespace ConsoleApp2;

//class sumofnumbers
//{
//    static void Main(string[] args)
//    {
//        int firstNumber;

//        int secondNumber;

//        TextPrintUsers();

//        Console.WriteLine(" type the first number");
//        firstNumber = int.Parse(Console.ReadLine());

//        Console.WriteLine(" type the second number");
//        secondNumber = int.Parse(Console.ReadLine());


//        Sum(firstNumber, secondNumber);


//    }
//    static void TextPrintUsers()
//    {

//        Console.WriteLine("type the numbers ");

//    }
//    static void Sum(int firstNumber, int secondNumber)
//    {
//        int sum = 0;
//        int index = 1;

//        if (firstNumber == secondNumber - 1)
//        {
//            Console.WriteLine(" the numbers are consecutive and the program is not executed");
//        }
//        else
//        {
//         while (firstNumber != secondNumber - 1)
//            {
//                sum = sum + index;

//                index++;



//            }
//            Console.WriteLine(sum);




//        }





//    }

//}










//}

// scrieti un program care va determina daca un numar natural n este prim , n fiind citit de la tastatura .Daca este numar prim  va afisa textul prim .In caz
// contrar  va afisa numarul cu care este divizibil ;



//using System;

//namespace ConsoleApp2;


//class numberisprimeornot
//{

//    static void Main (string[] args)
//    {

//        int numberRead;

//        TextPrintUsers();

//        numberRead  = int.Parse(Console.ReadLine());


//        NrPrim(numberRead);
//    }
//    static  void TextPrintUsers()
//    {

//        Console.WriteLine("type the number");


//    }
//    static void NrPrim (int numberRead )
//    {
//        int index = 2;

//        while (index < numberRead )
//        {

//            if (numberRead % 2 == 0)

//                index = index + 2;

//            else
//            {
//                Console.WriteLine(" the number is prime");
//            }


//        }





//    }


// 




// Se citesc doua numere de la tastatura .Scrieti un program ce va calcula cel mai mare divizor comun .




// Scrieti un program care afiseaza numere de la 1 la N .Daca numarul este multiplu de 3 se afiseaza Fizz ,  daca e multiplu de 5 sa se afiseze Buzz , daca este multiplu 
// si de 3 si de 5 ( nex 15)  sa se afiseze FIzzBuzz , in restul cazurilor sa se afiseze numarul .




//using System;
//using System.Diagnostics.CodeAnalysis;

//namespace ConsoleApp2;


//class multipleofnumbers
//{

//    static void Main(string[] args)
//    {

//        int numberRead;

//        TextPrintUsers();

//        numberRead = int.Parse(Console.ReadLine());

//        Multiple(numberRead);


//    }
//    static void TextPrintUsers()
//    {

//        Console.WriteLine(" type the number ");


//    }

//    static void Multiple(int numberRead)
//    {

//        int sum = 0;


//        while (numberRead != 0)
//        {

//            int x = numberRead % 10;

//            sum = sum + x;

//            numberRead = numberRead / 10;

//            if ( sum % 3 == 0 )
//            {

//                Console.WriteLine(" fizz");


//            }
//            if (numberRead % 5 == 0)
//            {
//                Console.WriteLine(" buzz");

//            }
//            if (sum % 3 == 0 && numberRead % 5 == 0)
//            {
//                Console.WriteLine(" fizzbuzz");
//            }



//        }







//    }









//}



// Scrieti un program care citind de la tastatura lungimea si latimea unui dreptunghic va afisa diagonala acestuia .


//using System;



//namespace ConsoleApp2;


//class diagonalofarectangle
//{

//    static void Main (string[] args)
//    {
//        int width;

//        int length;

//        TextPrintUsers();

//        Console.WriteLine(" type the width");
//        width = int.Parse(Console.ReadLine());


//        Console.WriteLine(" type the lenght");
//        length = int.Parse(Console.ReadLine());


//        Diagonalofrectangle(width, length);

//    }

//    static void TextPrintUsers()
//    {

//        Console.WriteLine(" types the values");

//    }
//    static void  Diagonalofrectangle(int  width , int length)
//    {



//       double  diagonal = Math.Sqrt(width * width + length * length);

//        Console.WriteLine(diagonal);
//    }




// 

















//}