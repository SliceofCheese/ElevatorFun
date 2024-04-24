using static ElevatorMovement;
using static Floors;

namespace TestElevators
{
    public class ElevatorMovementTests
    {

        private Dictionary<int, Level> floorsToTravel = new Dictionary<int, Level>();
        private Elevator _ElevatorTest { get; set; } = null!;

        
        [SetUp]
        public void Setup()
        {
            _ElevatorTest = new Elevator();
        }

        // Test to ensure that the directions are going in the correct direction and adding and removing the correct amounts. 

        [Test]
        public void ActivateElevatorTravelingUp_Test()
        {

            // Assign
            _ElevatorTest.userFloor = 4;
            _ElevatorTest.isTravelingUp = true;
            floorsToTravel.Add(2, Level.Bottom);
            floorsToTravel.Add(3, Level.Third);
            floorsToTravel.Add(5, Level.Top);


            // Act

            ActivateElevator(floorsToTravel, _ElevatorTest);

            // Pass or Fail
            Assert.That(floorsToTravel.Count, Is.EqualTo(2));
        }

        [Test]
        public void ActivateElevatorTravelingDownwards_Test()
        {

            // Assign
            _ElevatorTest.userFloor = 4;
            _ElevatorTest.isTravelingUp = false;
            floorsToTravel.Add(2, Level.Bottom);
            floorsToTravel.Add(3, Level.Third);

            // Action
            ActivateElevator(floorsToTravel, _ElevatorTest);

            // Pass or Fail
            Assert.That(floorsToTravel.Count, Is.EqualTo(0));
        }
    }
}