using static Floors;

public static class ElevatorMovement
{
    public static void ActivateElevator(Dictionary<int, Level> floorsToTravel, Elevator elevator)
    {

        if (floorsToTravel.Count == 0)
        {
            Console.WriteLine("No floors have been selected.");
        }
        else
        {
            if (elevator.isTravelingUp)
            {
                var reOrderFloors = floorsToTravel.ToList().OrderBy(floor => floor.Key);

                foreach (var floor in reOrderFloors)
                {
                    if (elevator.userFloor <= floor.Key)
                    {
                        elevator.userFloor = floor.Key;
                        elevator.elevatorFloor = floor.Key;
                        floorsToTravel.Remove(elevator.userFloor);
                        Console.WriteLine($"Elevator moved to floor {floor.Key}");
                    }
                }
            }
            else
            {
                var reOrderFloors = floorsToTravel.ToList().OrderByDescending(floor => floor.Key);
                foreach (var floor in reOrderFloors)
                {
                    if (elevator.userFloor >= floor.Key)
                    {
                        elevator.userFloor = floor.Key;
                        elevator.elevatorFloor = floor.Key;
                        floorsToTravel.Remove(elevator.userFloor);
                        Console.WriteLine($"Elevator moved to floor {floor.Key}");
                    }
                }
            }
        }
        Random rnd = new Random();
        Console.WriteLine($"Final User left at floor {elevator.userFloor}");
        elevator.isExtremePoint = (elevator.userFloor == ((int)Level.Top + 1) || elevator.userFloor == ((int)Level.Bottom + 1));
        elevator.userFloor = rnd.Next(1, Enum.GetNames(typeof(Level)).Length + 1);

    }
}