using System;
using System.Collections.Generic;
using System.Text;

namespace Penetration
{

     public class NineMMBullet
    {
        //muzzle energy in ft/lb to to samo co muzzle velocity in ft/sec

        // mass is in grains, velocity in ft/s, enerfy in jules
        #region 9mmTypeA
        private  float nineMMtypeAmass = 115;
        private  float nineMMtypeAvelocity = 1180;
        private float nineMMtypeAenergy = 481;

        public float NineMMtypeAmass { get => nineMMtypeAmass; set => nineMMtypeAmass = value; }
        public float NineMMtypeAvelocity { get => nineMMtypeAvelocity; set => nineMMtypeAvelocity = value; }
        public float NineMMtypeAenergy { get => nineMMtypeAenergy; set => nineMMtypeAenergy = value; }
        #endregion

        #region 9mmTypeB
        private float nineMMtypeBmass = 124;
        private float nineMMtypeBvelocity = 1225;
        private float nineMMtypeBenergy = 560;

        public float NineMMtypeBenergy { get => nineMMtypeBenergy; set => nineMMtypeBenergy = value; }
        public float NineMMtypeBvelocity { get => nineMMtypeBvelocity; set => nineMMtypeBvelocity = value; }
        public float NineMMtypeBmass { get => nineMMtypeBmass; set => nineMMtypeBmass = value; }
        #endregion

        #region 9mmTypeC
        private float nineMMtypeCmass = 124;
        private float nineMMtypeCvelocity = 1250;
        private float nineMMtypeCenergy = 588;

        public float NineMMtypeCmass { get => nineMMtypeCmass; set => nineMMtypeCmass = value; }
        public float NineMMtypeCvelocity { get => nineMMtypeCvelocity; set => nineMMtypeCvelocity = value; }
        public float NineMMtypeCenergy { get => nineMMtypeCenergy; set => nineMMtypeCenergy = value; }
        #endregion
    }
}
