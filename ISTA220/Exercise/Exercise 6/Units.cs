using System;

abstract class Units
{
    protected int _num = 0;
    public abstract int strength { get; }

}

class Squad : Units
{

    public override int strength 
    {
        get
        {
            return _num + 8;
        }
        
    }
}
    
class Platoon : Squad
{
    public override int strength
    {
        get
        {
            return _num + 39;
        } 
        
    }
}

class Company : Platoon
{
    public override int strength
    {
        get
        {
            return _num + 130;
        }

    }
}

