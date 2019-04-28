using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Code30Days
{
    public class InheritanceProblem
    {
        public class Person
        {
            protected string firstName;
            protected string lastName;
            protected int id;

            public Person() { }
            public Person(string firstName, string lastName, int identification)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = identification;
            }
            public void printPerson()
            {
                Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            }
        }


        public class Student : Person{
            private int[] testScores;           

            /*	
            *   Class Constructor
            *   
            *   Parameters: 
            *   firstName - A string denoting the Person's first name.
            *   lastName - A string denoting the Person's last name.
            *   id - An integer denoting the Person's ID number.
            *   scores - An array of integers denoting the Person's test scores.
            */
            // Write your constructor here
            public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
            {
                testScores = scores;
            }

            /*	
            *   Method Name: Calculate
            *   Return: A character denoting the grade.
            */
            // Write your method here
            public char Calculate()
            {
                int sum = 0;
                for (int i = 0; i < testScores.Length; i++)
                {
                    sum += testScores[i];
                }

                int avgSum = sum / testScores.Length;
                if (avgSum < 40)
                    return 'T';
                if (avgSum >= 40 && avgSum < 55)
                    return 'D';
                if (avgSum >= 55 && avgSum < 70)
                    return 'P';
                if (avgSum >= 70 && avgSum < 80)
                    return 'A';
                if (avgSum >= 80 && avgSum < 90)
                    return 'E';
                if (avgSum >= 90 && avgSum <= 100)
                    return 'O';

                throw new Exception("Unsupported avgSum: " + avgSum);
            }
        }


    }
}
