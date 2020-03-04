using Lesson1;
using System;

namespace Homework
{
    class Lesson1
    {
        static void Main(string[] args)
        {
            DataTypes dataTypes = new DataTypes();
            dataTypes.Run();
          
            Calculation calculation = new Calculation();
            calculation.Calculations();
    
            Operations operation = new Operations();
            operation.Operation();
        }
    }
}
