﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double FuncDelegate(double x);
    public class FunctionsContainer
    {
       
        private Dictionary<string, FuncDelegate> functionsDictionary = new Dictionary<string, FuncDelegate>();

        public FuncDelegate this[string funcName]
        {
            get
            {
                if (!functionsDictionary.ContainsKey(funcName))
                {
                    functionsDictionary[funcName] = val => val;
                }

                return functionsDictionary[funcName];
            }
            set { functionsDictionary[funcName] = value; }
        }

        public List<IMission> getAllMissions()
        {
            for ()
        }
    }
}