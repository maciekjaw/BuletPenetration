using System;
using System.Collections.Generic;


namespace Penetration
{
    
    //Projectile speed through air depends on a number of factors such as barometric pressure, humidity, air temperature, and wind speed

     //cartridge, grain, velocity
    class Glock15Gen4Data
    {
        private static float grain = 7.5f;
        private static int muzzleVelocityInMeters = 410;
        private static double feetUnit = 3.29;

        //drop in inches
        //distance in inches
        //energy
        //wind
        public static double ConvertFromMetersToFeets(double velocity) => muzzleVelocityInMeters * feetUnit;
    }

    public class BallisticTrajectoryCalculator
    {
        public double CalculateTravelTime(float velocity, float distanceFromObject)
        {
            float time = distanceFromObject / velocity;
            return time;
        }

        public List<double> CalculateBulletDrop()
        {
            List<double> time = new List<double> { 0.1, 0.2 };

            double standardGravity = 9.80665; //m/s^2

            List<double> listOfDropUnitPerDistance = new List<double>();
            {
                int i = 0;
                foreach (var item in time)
                {
                    var timeSquared = time[i] * time[i];
                    double distanceToObject = standardGravity / 2 * timeSquared;

                    listOfDropUnitPerDistance.Add(distanceToObject);
                    i++;
                };
            }

            return listOfDropUnitPerDistance;
        }

        /* 
        public float CalculateMuzzleVElocity(Glock15Gen4Data g)
        {
            //https://www.sciencefocus.com/science/how-fast-does-a-bullet-accelerate-as-it-leaves-a-gun-barrel/

        }

        public float CalculateBulletVelocityAtImpact(float bullletWeight, float velocityBulletAtImpact)
        {

        }

        public float CalculateBulletVelocityDrop()
        {

        }
    */
   
        public double CalculateBallisticCoefficientImperial(double velocity0, double velocity1, double distance, double airDensity)
        {
            //https://www.physicsforums.com/threads/calculating-a-ballistic-coefficient-bc-from-two-velocities.958802/
            var sqrtVel0 = Math.Sqrt(velocity0);
            var sqrtVel1 = Math.Sqrt(velocity1);

            var val = sqrtVel0 - sqrtVel1;
            var sec = airDensity * distance;
            var BC = airDensity * distance / (sqrtVel0 - sqrtVel1);

            return BC;
        }

        public double CalculateBallisticCoefficientMetric(double velocity0, double velocity1, double distance, double airDensity)
        {
            //https://www.physicsforums.com/threads/calculating-a-ballistic-coefficient-bc-from-two-velocities.958802/
            var sqrtVel1 = Math.Sqrt(velocity0);
            var sqrtVel2 = Math.Sqrt(velocity1);
            //0.0052834
            var BC = (airDensity * distance) / (sqrtVel1 - sqrtVel2);

            return BC;
        }
    }
    //751,265


}
