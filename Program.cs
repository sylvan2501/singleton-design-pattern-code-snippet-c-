namespace SingletonDesignPattern;
class Program
{
    static AnimalDispatchCenter dispatchTeamOne = AnimalDispatchCenter.GetAnimalDispatchCenter();
    static AnimalDispatchCenter dispatchTeamTwo = AnimalDispatchCenter.GetAnimalDispatchCenter();


    static void Main(string[] args)
    {
        //AnimalDispatchCenter dispatchCenter = AnimalDispatchCenter.GetAnimalDispatchCenter();
        for (int i = 0; i < 7; i++)
        {
            teamOneGetNextDispatcher();
            teamTwoGetNextDispatcher();
        }
        

    }
    private static void teamOneGetNextDispatcher()
    {
        Console.WriteLine("The next dispatcher is: " + dispatchTeamOne.GetNextAnimalDispatcher());
    }

    private static void teamTwoGetNextDispatcher()
    {
        Console.WriteLine("The next dispatcher is: " + dispatchTeamTwo.GetNextAnimalDispatcher());
    }
}
