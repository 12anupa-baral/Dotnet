using System;
Console.WriteLine("I am anupa");
DataTypes dt= new();
dt.Learn();
Methods m = new Methods();
m.Greet("Hi");
m.CalculateBMI(233.3f,343.34f);
var highest = m.GetMax(3.4 ,5.6 ,78.4 ,23.4 );


Generics g = new();
g.Display<string>("fnefn");
g.Display<int>(788);

Student anupa = new Student("anupa" ,1 , new DateTime(2001 ,12,31));
Student seema = new Student("seema" ,2,new DateTime(2001 ,12,31));
// smriti.DOB = DateTime.Now();

var  Anupa = new CSstudent("Anupa Baral" ,22 ,"Library Management System");
Anupa.DisplayInfo();

var abc = new CyberSecurityStudent("Anupa Baral" ,22 , "Library Management System" ,"Redhat");
abc.DisplayInfo();

//F.Linq