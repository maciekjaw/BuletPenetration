using System;
using System.Collections.Generic;
using System.Text;

namespace Penetration
{
    public class Glock17Gen4
    {
        //data in american metric fps or yards
        //range fire in yards

        private float muzzleVelocity = 1230;
        private float effectiveRangeFire = 55;
        private float barrelLenght = 4.49F;

        public float MuzzleVelocity { get => muzzleVelocity; set => muzzleVelocity = value; }
        public float EffectiveRangeFire { get => effectiveRangeFire; set => effectiveRangeFire = value; }
        public float BarrelLenght { get => barrelLenght; set => barrelLenght = value; }

        string[] ammoTypeforGlock17Gen4 =
        {
            "9mm","10mmAuto",".45.ACP",".40 S&W",".380APC",".375SIG", ".40GAP"
        };

    }
}
