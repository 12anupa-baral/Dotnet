using System;
class CyberSecurityStudent : CSstudent{
     public CyberSecurityStudent(string name, byte rn, string pTitle, string certifcation)   //Example of multiple inheritance
           : base(name,rn,pTitle){
            SecurityCertification = certifcation;
           }


    public string EthicalHackingCourseTitle { get; set; }

    public string SecurityCertification { get; set; }

    public string CertifiedDate { get; set; }

    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"certification :{SecurityCertification}");
        Console.WriteLine($"certification :{SecurityCertification}");

    }
}