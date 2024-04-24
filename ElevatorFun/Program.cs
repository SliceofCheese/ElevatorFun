using static Floors;
class Program
{
    static void Main(string[] args)
    {
        string exitCheck = "";
        Random rnd = new Random();
        ElevatorActions ElevatorActions = new ElevatorActions();
        Elevator Elevator = new Elevator

        {
            userFloor = rnd.Next(1, Enum.GetNames(typeof(Level)).Length + 1),
            elevatorFloor = rnd.Next(1, Enum.GetNames(typeof(Level)).Length + 1),
        };
        Elevator.isExtremePoint = (Elevator.userFloor == ((int)Level.Top + 1) || Elevator.userFloor == ((int)Level.Bottom + 1));


        while (exitCheck != "EXIT")
        {
            Console.WriteLine($"You are currently on floor {Elevator.userFloor}");
            Console.WriteLine($"Elevator is currently on floor {Elevator.elevatorFloor}");
            ElevatorActions.CallElevator(Elevator.isExtremePoint, Elevator.elevatorFloor, Elevator);
            Console.WriteLine("Exit by typing 'EXIT' Or enter any key to continue");
            exitCheck = Console.ReadLine().ToUpper();
        }

    }


}