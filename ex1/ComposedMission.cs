using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private string myMissionName;
        private FuncDelegate myFunc;
        private List<SingleMission> listMissions = new List<SingleMission>();
        
        public ComposedMission(FuncDelegate function, string mission)
        {
            myMissionName = mission;
            myFunc = function;
        }
        
        String Name { get => myMissionName;}
        String Type { get => "Composed"; }

        public void Add(SingleMission mission) {
            listMissions.Add(mission);
        }
        
        public double Calculate(double value)
        {
            return myFunc(value);
        }
    }
}
