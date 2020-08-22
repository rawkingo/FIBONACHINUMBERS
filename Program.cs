using System;  
  public class Fibonacci  
   {  
     public static void Main(string[] args)  
      {  
         int a=0,b=1,c,i,n;    
         Console.Write("Write the needed numbers of Fibonacci: ");    
         n = int.Parse(Console.ReadLine());  
         Console.Write(a+" "+b+" ");    
         for(i=2;i<n;++i)     
         {    
          c=a+b;    
          Console.Write(c+" ");    
          a=b;    
          b=c;    
         }    
      }  
   }  