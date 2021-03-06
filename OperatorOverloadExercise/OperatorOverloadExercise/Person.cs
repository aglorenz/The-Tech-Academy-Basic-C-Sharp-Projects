﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadExercise
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()  // declaring this as virtual, allows the Employee class to override the method definition.
        {
            // must have a full declaration here using  { }.   but don't have to implement it.  Implement it in Employee class
        }

    }
}
