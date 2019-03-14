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
        private List<FuncDelegate> listMissions = new List<FuncDelegate>();
        private event EventHandler<double> OnCalculate; 
        
        public ComposedMission(string mission)
        {
            myMissionName = mission;
        }
        
        String Name { get => myMissionName;}
        String Type { get => "Composed"; }

        public ComposedMission Add(FuncDelegate func) {
            listMissions.Add(func);
            return this;
        }
        
        public double Calculate(double value)
        {
            double tempResult = value;
            foreach (var f in listMissions) {
                tempResult = f(tempResult);
            }
            OnCalculate?.Invoke(this,  tempResult);
            return tempResult;
        }
        
    }
}
