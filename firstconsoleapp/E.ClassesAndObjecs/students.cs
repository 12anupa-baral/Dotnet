using System;

class Student{
public string name;
public byte rollnumber;    //here field is used
public string address{get; set;} //auto implemented property

public DateTime Dob;

public int MyProperty { get; set; }

public Student(){     //by default this contruction is called ( default construction of class Student)
                    // default constructor
}

public Student(string n , byte rn){    //parameterized constructor
name = n;
Rollnumber = rn; 
}

public Student(string n , byte rn ,DateTime dob){    //parameterized constructor
name = n;
Rollnumber = rn; 
Dob  =dob ;//property is used not field
}

public byte Rollnumber{

    get{
        return rollnumber;
    }                                  // full  property as it has get and set
    set                                 //auto implemented propeerty
    {
        if (value <= 100)
        {
            rollnumber = value;
        }
    }
}

public virtual void DisplayInfo()
{
    Console.WriteLine($"Student Name: {name}");
    Console.WriteLine($"Student Name: {rollnumber}");     //method of the class Student
    Console.WriteLine($"Student Name: {address}");
    Console.WriteLine($"Student Name: {Dob}");

}

// public DateTime Dob {get;}   //read only property it cannot write

}
