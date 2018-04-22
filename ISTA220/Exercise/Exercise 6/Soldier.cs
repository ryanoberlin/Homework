using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    abstract class Soldier
    {

        public virtual string Describe()
        {
            return "E4 Mafia";
        }

    }

    class Enlisted : Soldier
    {
        public override string Describe()
        {
            return "I do all the work!";
        }
    }

    class Officer : Soldier
    {

    public override string Describe()
    {
        return "I tell them to do all the work!";
    }
    }   

    class Warrant : Soldier
    {
        public override string Describe()
        {
            return "I am not here to do any of the work!"; 
        }
    }
