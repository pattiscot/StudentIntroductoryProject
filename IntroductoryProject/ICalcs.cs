using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductoryProject
{
    interface ICalcs
    {
        /// <summary>
        /// This calculates the discriminent of ax^2+bx+c
        /// </summary>
        /// <param name="a">leading coefficient</param>
        /// <param name="b">coefficient of the x term</param>
        /// <param name="c">constant of the polynomial</param>
        /// <returns></returns>
        double Discriminent(double a, double b, double c);

        /// <summary>
        /// This calculates the quadratic formula and, if the answers exist, 
        /// returns the answers as a string[] of length 2. The first solution 
        /// should be solution[0]=[-b+sqrt(b^2-4ac)]/2a while the second solution is
        /// solution[1]=[-b-sqrt(b^2-4ac)]/2a. If the solution does not exist,
        /// then return solution[0]="No Solution" and solution[1]="No Solution".
        /// Note that two things can cause us to not have a solution: 1) a=0 which would
        /// cause a division by zero error. 2) b^2-4ac<0 which causes an error when
        /// taking the square root. You need to check for both of these in your program.
        /// If there is only one solution, then return this same value in both parts
        /// of the solution string as a repeated solution.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        string[] Quadratic(double a, double b, double c);
    }
}
