namespace AwesomeAnimalTask
{
    public class Animal
    {
        public string Name { get; set;}
        public string Type { get; set;}
        public double Weight { get; set;}
        public virtual void MakeSound()
        {
            System.Console.WriteLine("Animal is going to make sooome noooise");
        }
    }

    public class Cat : Animal
    {
        public int NumberOfRatsCought { get; set; }

        public override void MakeSound()
        {
            base.MakeSound();
            System.Console.WriteLine("Meu");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            System.Console.WriteLine("Au Au");
        }
    }
}