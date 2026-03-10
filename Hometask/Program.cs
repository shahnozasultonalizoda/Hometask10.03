//task1

// void Print(int n)
// {
//     if (n == 0)
//     {
//         return ;
//     }

//      Print(n-1);

//     System.Console.Write(n + " ");
 
// }

// Print(10);

// task2

// void Print(int n)
// {
//     if(n == 0)
//     {
//         return;
//     }

//     System.Console.Write(n+" ");
//     Print(n-1);
// }

// Print(10);

//task3

// int Sum(int n)
// {
//     if (n == 1)
//     {
//         return 1;
//     }

//     else return n + Sum(n-1);
// }
// System.Console.WriteLine(Sum(10));

//task4

// void Print( int n)
// {
//     if (n == 0)
//     {
//         return;
//     }

//     Print(n/10);

//     System.Console.WriteLine(n%10);
// }
// Print(1234);

//task5

// int cnt =0;
// void Count(int n)
// {
//     if (n == 0)
//     {
//         return;
//     }
//     cnt++;
//     Count(n/10);
    
// }
// Count(1234982398);
// System.Console.WriteLine(cnt);

//task6
// void Even(int a , int b)
// {
//     if(a > b)
//     {
//         return ;
//     }

//     if (a % 2 == 0)
//     {
//         System.Console.Write(a+ " ");
//     }

//     Even(a+1 , b);

// }

// void Odd(int a, int b)
// {
//     if (a > b)
//     {
//         return;
//     }

//     if (a % 2 == 0)
//     {
//         Console.Write(a+" ");

//     }
//     Odd(a+1, b);
// }
// System.Console.WriteLine($"All even numbers from 1 to 20 are : ");
// Even(1,20);
// System.Console.WriteLine();
// System.Console.WriteLine("All odd numbers from 1 to 20 are : ");
// Odd(1,20);

// Even(20);

// int a = 1;
// int b = 20;
// for(int i=a; i<=b; i++)
// {
//     if (i % 2 == 0)
//     {
//         System.Console.WriteLine(i);
//     }
// }

