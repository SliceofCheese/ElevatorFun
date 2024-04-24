

using static Floors;
using static ElevatorMovement;

public class ElevatorActions
{

    Dictionary<int, Level> floorsToTravel = new Dictionary<int, Level>();

    public void CallElevator(bool isExtremePoint, int elevatorFloor, Elevator elevator)
    {
        if (isExtremePoint)
        {
            Console.WriteLine("Call Elevator?");
            Console.WriteLine("[Y] Yes");
            Console.WriteLine("[N] No");
            var userAction = Console.ReadLine().ToUpper();
            switch (userAction)
            {
                case "Y":
                    Console.WriteLine("Boarded Elevator");
                    elevator.isTravelingUp = (elevator.userFloor == (int)Level.Bottom + 1);
                    SelectElevatorFloors(elevatorFloor, elevator);
                    break;
                case "N":
                    Console.WriteLine("Departed from the Elevator");
                    break;
                default:
                    Console.WriteLine("Please select a valid option");
                    CallElevator(isExtremePoint, elevatorFloor, elevator);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Call Elevator to go up or down?");
            Console.WriteLine("[U] Up");
            Console.WriteLine("[D] Down");
            Console.WriteLine("[N] No");
            var userAction = Console.ReadLine().ToUpper();
            switch (userAction)
            {
                case "U":
                    Console.WriteLine("Boarded Elevator");
                    elevator.isTravelingUp = true;
                    SelectElevatorFloors(elevatorFloor, elevator);
                    break;
                case "D":
                    Console.WriteLine("Boarded Elevator");
                    elevator.isTravelingUp = false;
                    SelectElevatorFloors(elevatorFloor, elevator);
                    break;
                case "N":
                    Console.WriteLine("You exited the Elevator");
                    break;
                default:
                    Console.WriteLine("Please select a valid option");
                    CallElevator(isExtremePoint, elevatorFloor, elevator);
                    break;
            }
        }
    }

    public void SelectElevatorFloors(int currentElevatorFloor, Elevator elevator)
    {
        Console.WriteLine("Please select floors you wish to travel to.");
        Console.WriteLine("[1] First Floor");
        Console.WriteLine("[2] Second Floor");
        Console.WriteLine("[3] Third Floor");
        Console.WriteLine("[4] Fourth Floor");
        Console.WriteLine("[5] Fifth Floor");
        Console.WriteLine("[C] Commit to floor button presses");
        Console.WriteLine("[E] Exit Elevator");
        var userAction = Console.ReadLine().ToUpper();
        switch (userAction)
        {
            case "1":
                QueueElevatorFloors(int.Parse(userAction));
                SelectElevatorFloors(currentElevatorFloor, elevator);
                break;
            case "2":
                QueueElevatorFloors(int.Parse(userAction));
                SelectElevatorFloors(currentElevatorFloor, elevator);
                break;
            case "3":
                QueueElevatorFloors(int.Parse(userAction));
                SelectElevatorFloors(currentElevatorFloor, elevator);
                break;
            case "4":
                QueueElevatorFloors(int.Parse(userAction));
                SelectElevatorFloors(currentElevatorFloor, elevator);
                break;
            case "5":
                QueueElevatorFloors(int.Parse(userAction));
                SelectElevatorFloors(currentElevatorFloor, elevator);
                break;
            case "C":
                ActivateElevator(floorsToTravel, elevator);
                break;
            case "E":
                break;
            default:
                Console.WriteLine("Please select a valid option");
                SelectElevatorFloors(currentElevatorFloor, elevator);
                break;
        }
    }

    public void QueueElevatorFloors(int selectedFloor)
    {
        var userFloor = Level.Bottom + selectedFloor - 1;
        if (!floorsToTravel.ContainsKey(selectedFloor))
            floorsToTravel.Add(selectedFloor, userFloor);
        else if (((int)userFloor) + 1 == selectedFloor)
            Console.WriteLine($"{selectedFloor} is already a pressed button and will not be added.");
        else
            Console.WriteLine($"{selectedFloor} was already a selected floor");
    }
}