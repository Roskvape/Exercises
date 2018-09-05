using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Spacecraft
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int CrewCapacity { get; set; }
        public int CargoCapacity { get; set; }
        public int CurrentRations { get; set; }

        public Spacecraft(string _make, string _model, int _crewCapacity = 1, int _cargoCapacity = 1, int _currentRations = 0)
        {
            Make = _make;
            Model = _model;
            CrewCapacity = _crewCapacity;
            CargoCapacity = _cargoCapacity;
            CurrentRations = _currentRations;
        }
    }
}
