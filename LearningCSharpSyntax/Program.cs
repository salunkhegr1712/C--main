// inside this code i will try to learn about more things about the C Sharp Syntax
// in c sharp the semicolon after statement is mandatory 
// variable can be called as identifier inside the c#  

// double slash is used in order to add comments inside the C Sharp


// declaration of integer varible a 
int a;

// this is value assignment 
// int c sharp we use camelcase in order to label the variables 
a=10;

Console.WriteLine("value of a is \n"+a);

Console.WriteLine("enter your age : ");

// ReadLine only take string as entry 
// string age=Console.ReadLine();

int age=99;
Console.WriteLine("Your entered age is : "+age);
Console.WriteLine("Bye!");

// c sharp is case sensitive that means abc and ABC are different 


// Built in types inside the C sharp 
// C Sharp is strongly typed Language that means every variable has one type 
// type of a variable will remain same throughout lifetime


//in c sharp each datatype has own memory limit
// depending on type the variable will get stored in heap or in stack


// in csharp we have predefined datatype + user defined datatypes so according to needs we can change it 

// Built in DT or primitive datatypes
// 1) bool
// 2) int --> byte 8 bit integer, short 16 bit integer 
// 3) float
// 4) double
// 5) decimal 
// 6) char 
// string----
//           |---> built in but not primitive
// object----

// like java and c we cant change datatype after declaration 

Console.WriteLine("start of learning of primitive datatype");

byte m=33;

// we use const keyword prior of type declaration so that 
// no one can change value once declared
// you can use const prior to any datatyoe there is no restriction to it

const int aaa=1000;

double kl=2310.13123;
// for float we must to use F as suffix 
const float bb=342.44F;
const string klpd="fsdfdsg";


// lets declare one function inside the C#
// void is function which do not return anything
static void function1(int a){
      int b=0;
      // while loop example
      while (b<a)
      {
            Console.WriteLine("value of b is : "+b);
      b++;
      }
}


// function1(100);
// function1(11);
// function1(12);

// function to get the fibonacci series value using recursive way 
static int getFibonacciElement(int a){

      // if else if else ladder 
      if(a==0)
            return 0;
      else if(a==1)
            return 1;
      else
            return getFibonacciElement(a-1)+getFibonacciElement(a-2);
      
}

Console.WriteLine(getFibonacciElement(5));

// for loop example
for (int i = 0; i < 20; i++)
{
      Console.WriteLine((i+1)+" th element is : "+getFibonacciElement(i+1));
}

// non recursive way to find out perticular element of fibonacci series
static int fibonacciElementNonRecursive(int a){

      // complex code containing multiple conditional statement and loops 
      if (a==0)
            return 0;
      else if (a==1)
            return 1;
      
      int ii=0,j=1,k=0;

      for (int i = 0; i < a-1; i++)
      {
            k=ii+j;
            ii=j;
            j=k;
      }
      return k;
}

Console.WriteLine(fibonacciElementNonRecursive(20));

// function to find out is a number is isPrimeOrNot or not 
static bool isPrimeOrNot(int number){

      // complex if else if else ladder along with loop
      if(number==0 || number==1 || number<0)
            return false;
      else if (number==2)
            return true;
      else{
            int k=2;

            while(number/2  >= k){
                  if(number%k == 0)   
                        return false;
                  k++;
            }
            return true;
      }
}

// logging the output value 
Console.WriteLine(" "+isPrimeOrNot(-61));