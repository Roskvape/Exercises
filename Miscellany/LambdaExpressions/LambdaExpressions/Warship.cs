using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Warship : Spacecraft
    {
        public int Lasers { get; set; }
        public int MissileCapacity { get; set; }
        public int MissilesStocked { get; set; }

        public Warship(string _make, string _model, int _lasers = 2, int _missileCapacity = 0, int _missilesStocked = 0) : base(_make, _model)
        {
            Lasers = _lasers;
            MissileCapacity = _missileCapacity;
            MissilesStocked = _missilesStocked;
        }
    }
}
