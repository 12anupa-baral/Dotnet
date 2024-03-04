//LINQ -Language Integrated Query
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
class LINQLearner{
    void Learn()
    {
        int[] numbers =[3,4,5,6,12,34,36,56,78,89,98,123];
        List <string> names = ["seema","Rita" ,"sapana","smriti" ,"Anjana"];
        var s1 = new Student("seema" ,20 ,new DateTime(2001 ,12, 20));
        var s2 = new Student("Bishnu" ,22 ,new DateTime(2002 ,11, 30));
        var s3 = new Student("sapana" ,23 ,new DateTime(2003 ,10, 31));
        var s4 = new Student("smriti" ,24 ,new DateTime(2004 ,9, 32));
        var s5 = new Student("anjana" ,25 ,new DateTime(2004 ,9, 32));
        

        List <Student> students =[s1 ,s2,s3,s4,s5];

        //Get all name initials
        var initials= names.Select(name=>name[0]);//['S' ,'R','S','S','A']

        //order name in ascending order
        var namesOrdered = names.OrderBy(x=>x);

        //get odd numbers from "numbers"
        var oddNumbers = numbers.Where(number => number % 2 ==1);//lambda expression

        //get square of all items in "numbers"
        var squares = numbers.Select(x => x*x);

        //get square of even only 

        //Method Syntax
        var evenSquares = numbers.Where(number => number % 2 ==0).Select(y=>y*y);

        //query syntax
        evenSquares = from x in numbers
                      where x % 2 == 0
                      select x*x;

        //Find students with name starting with "B"
        var bStudents =students.Where(students => students.name.ToLower().StartsWith("b"));//name not found

        //group students by birth month
        var dobGroups = students.GroupBy(students => students.Dob.Month);

        //get youngest 
        var youngest =students.OrderByDescending(x => x.Dob).First();
         youngest = students.MaxBy(x=>x.Dob);
    

        Console.WriteLine("oddNumbers");

    }
}