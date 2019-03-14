using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private string myMissionName;
        private FuncDelegate myFunc;

        public SingleMission(FuncDelegate function, string mission) 
        {
            myMissionName = mission;
            myFunc = function;
        }
        
        String Name { get => myMissionName;}
        String Type { get => "Single"; }
        
        public double Calculate(double value)
        {
            return myFunc(value);
        }
    }
}
