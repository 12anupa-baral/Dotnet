// single inheritance
using System.ComponentModel.DataAnnotations;

class CSstudent /*child */: Student /*parent*/ , IGradable          //mutiple inheritance
{
    public CSstudent(string name, byte rn, string pTitle): 
          base(name, rn )  //base is used to call parent class
    {
        ProjectTitle = pTitle;
    }
    public string ProjectTitle { get; set; }

    public string Internwork { get; set; }

    public double GetGrade() => 35.6;
}
//ctor => shortcut for constructor