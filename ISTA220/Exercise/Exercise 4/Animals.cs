using System;

    public class Animal
    {
        //base features
        public string name;
        public int feet;
        public string sex;
        public string food;
        public string noise;
        public string species;

    public Animal()
        {
        //default values for our animals
            name = "Null";
            sex = "He";
            food = "None";
            noise = "Loud";
            feet = 4;
            species = "hooman";
        }

        public Animal(string nm)
        {
            name = nm;
        }
    //name it
        public void AssignName(string newName)
        {
            name = newName;
        }
    //tell it what to eat
        public void Eats(string newFood)
        {
            food = newFood;
        }
    //how many feet does it have
        public void Feet(int newFeet)
        {
            feet = newFeet;
        }
    //what is it?
        public void setSpecies(string newSpecies)
        {
            species = newSpecies;
        }
    //does it make noise?
        public void makeNoise(string newNoise)
        {
            noise = newNoise;
        }
    //assume gender
        public void assumeGender(string pronoun)
        {
          sex = pronoun;
        }
        
        public void Talk()
    {
        Console.WriteLine("This is a {0} named: {1}", species, name);
        Console.WriteLine("{0} eats: {1}",sex, food);
        Console.WriteLine("{0} has {1} feet",sex, feet);
        Console.WriteLine("{0} says: {1}",sex, noise);
    }

    }

public class Horse : Animal
{
    public Horse()
    {
        name = "Shadowfax";
        species = "Horse";
        food = "hay";
        noise = "Neigh";
    }
}

public class Cow : Animal
{
    public Cow()
    {
        name = "Babe";
        sex = "She";
        species = "Cow";
        food = "Grass";
        noise = "Moooooo!";
    }
}

public class Duck : Animal
{
    public Duck()
    {
        name = "Aflac";
        species = "Duck";
        feet = 2;
        food = "Bread";
        noise = "Aflac!";
    }
}
public class Chicken : Duck 
{
    public Chicken()
    {
        name = "Atilla the Hen";
        sex = "She";
        species = "Chicken";
        noise = "Cluck Cluck, Mother Plucker!";
    }
}

