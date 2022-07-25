using System;
using System.Collections.Generic;
using System.Text;


namespace Penetration
{

    class Program
    {
        static void Main(string[] args)
        {
            BallisticTrajectoryCalculator b = new BallisticTrajectoryCalculator();
            b.CalculateBulletDrop();
            BallisticTrajectoryCalculator c = new BallisticTrajectoryCalculator();
            c.CalculateBallisticCoefficientImperial(3000, 2772, 100, 0.0052834);
            c.CalculateBallisticCoefficientMetric(914.4, 838, 109.36, 0.0052834);


        }
    }
}
