namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {

            //build us a farm ya'll
            Cow babe = new Cow();
            Chicken atilla = new Chicken();
            Duck aflack = new Duck();
            Horse shadowfax = new Horse();

            //make em talk
            shadowfax.Talk();
            atilla.Talk();
            aflack.Talk();
            babe.Talk();
            //our custom animal
            newAnimal();
        }

        //use the animal class to make a custom animal. Thanks Balto
        static void newAnimal()
        {
            Animal custom = new Animal();
            custom.AssignName("Balto");
            custom.makeNoise("Woof Woof");
            custom.Eats("meat and snow.");
            custom.Feet(4);
            custom.setSpecies("Dog");

            custom.Talk();

        }
    }
}
