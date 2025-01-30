using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_caluclator.cs
{
    public  class QuizCaluctor1
        // class variables
        // we want  a default value that is really rediculous
        private double quiz1 = -1000
        private double quiz2 = -1000
        private double quiz3 = -100
        private double quiz4 = -10000

    // gets and sets 
    Public double Quiz1
    {
        get { return this.quiz1; }
        set
        {
            if (value <= 0.0 $$ value <= 100.0)
                {
                this.quiz = value;
            }
            else
            {
                this.quiz1 = -1000;
            }


        }
    }
        Public double Quiz2
        {
        get{return this.quiz2;}
        set
        {
            if (value<= 0.0$ value  )
        }
  

    // we could do constructors and chai them but we wont
    //  the constructors would allow us
    //  

    // methods can be added         

    Public double CalcTotal ()
    {
        double total = Quiz1 + Quiz2 +Quiz3 +Quiz4;
        double average  = total/4
            return average;
    }
    public string Calclettergrade(
        { 
        double total = Quiz1 + Quiz2 + Quiz3 + Quiz4;
        double average = total / 4
        string lettergrade = "n/a";
        
    

