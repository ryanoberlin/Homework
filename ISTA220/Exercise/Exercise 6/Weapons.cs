abstract class Weapon
{
        public virtual string Load()
        {
             return "Weapon is unloaded and placed on safe";
        }

    public virtual string Name => "standard issue boom stick";
}

class Rifle : Weapon
{
    public override string Load()
    {
        return "5.56mm rounds";
    }

    public override string Name => "Standard Issue M4";
}

class Artillery : Weapon
{
    public override string Load()
    {
        return "155mm High Explosive Round loaded.";
     }

    public override string Name => "M777 Howitzer";
}

class Tank : Weapon
{
    public override string Load()
    {
        return "120mm Sabot loaded";
    }

    public override string Name => "M1A3 Main Battle Tank";
}
