﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Person
    {
        public string firstName;
        public string lastName;

        public virtual void SayName()
        {
            string fullName = firstName + " " + lastName;
        }
    }
}
