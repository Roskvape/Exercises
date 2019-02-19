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
        public int CurrentCrew { get; set; }
        public int CrewCapacity { get; set; }
        public int CargoCapacity { get; set; }
        public int CurrentRations { get; set; }

        public Spacecraft(string _make, string _model, int _currentCrew = 0, int _crewCapacity = 5, int _cargoCapacity = 1, int _currentRations = 0)
        {
            Make = _make;
            Model = _model;
            CurrentCrew = _currentCrew;
            CrewCapacity = _crewCapacity;
            CargoCapacity = _cargoCapacity;
            CurrentRations = _currentRations;
        }
    }
}
