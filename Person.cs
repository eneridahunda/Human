using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Person
    {
        private int  age;
        private string fName;
        private string lName;
        private double height;
        private double weight;
    }

    public Person (int age, string fName, string lName, double height, double weight) //Constructor
    {
        //Validation
        this.Age = age;
        this.FName = fName;
        this.LName = lName;
        this.Height = height;
        this.Weight = weight;

    }

    public int Age
    {

        get { return age; }

        set {

            if (value > 0)
            {
                age = value;
            }
            else
            {
                throw new Exception("Age must be more than 0");
            }
        }
    }

    public int FName
    {

        get { return fName; }

        set {

            if (value.minLength = 2 && value.maxLength = 10 )
            {
                fName = value;
            }
            else
            {
                throw new Exception("First name must have min 2 char and max 10 char.");
            }

        }
    }
    public int LName
    {

        get { return lName; }

        set {
  
            if (value.minLengthL = 3 && value.maxLengthL = 15)
            {
                lName = value;
            }
            else
            {
                throw new Exception("Last name must have min 3 char and max 15 char.");
            }

        }
    }
    public int Height
    {

        get { return height; }

        set { height = value; }
    }

    public int Weight
    {

        get { return weight; }

        set { weight = value; }
    }

    
   



}
