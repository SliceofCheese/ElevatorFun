Requirements
Application has 5 floors. 
1st Floor and Last Floor have a call button 
2nd 3rd 4th floor has up and down buttons. 
Elevator Features
•	Elevator has Floor 1 – 5 for buttons
•	Elevator should notice when a person pushes the same floor as the current floor that they are boarded on (and proceed to do nothing)? It can just drop off, so this is more of a bell and whistle but not necessary. 
•	Elevator should prioritize the correct direction it’s going.  
•	Elevator has a status of being open and closed?
•	Elevator needs  a priority for going up or down based on the buttons pressed and the current direction a person is going. 
•	Queue order should not matter. IE, if a person is on floor 4, and they want to go down, pushing 2, 3 and then 1 should still result in going to 3, then 2, then 1. 

Scenarios 
User on Top Floor – Should only be able to go down. 
User on Bottom Floor – Should only be able to go up. 
User presses up button – Floors that are greater than or equal to the current floor should be prioritized. 
User presses down button – Floors that are less than or equal to the current floor should be prioritized. 
User presses a button and commits to with no buttons selected. – The elevator goes nowhere. 
User presses up button and chooses floors that are both higher than the current floor and lower than the current floor.  – Elevator should only go up, but not remove the other directions from the queue. 
User presses down button and chooses floors that are both lower than the current floor and lower than the current floor.  – Elevator should only go up, but not remove the other directions from the queue. 

Unit Testing: 
The main components that need to be tested I think are the aspects that are probably most subject to screw up, and that’s the queue system with a specific direction, so I placed those as a test to ensure that these would always work, as they are vital to displaying which floors people successfully were dropped off at. 
I considered testing the amount of people / where they  were dropped off, but that test wasn’t really necessary because in the end of the day, you would see the end results of what floor you were currently on, so running a unit test wouldn’t actually save time or add any real safeguards. How many elevators are the floor is tricky because you have no way of verifying the amount that should be still readily available in the current code. I specifically didn’t add a “check the amount of buttons highlighted” so specify this point as that seems more like a logging feature than a functionality to the elevators. Because if this doesn’t work, this means that nothing actually works for the entire ordeal. 
So in this case, I opted to keep the tests a bit more simple to prevent an overwhelming amount of unit test to be made. By breaking things down too much, I run into the risk of over engineering things and deluding the tests’ usefulness. 

Thoughts: 
At first I was going to loop through the enums to display a message that said “moving to X floor,” but then realized the whole thing was messy and just displayed stopped on floors because it gets really messy to show both, and since elevators cannot teleport, I left them alone initially. 
I didn’t break the classes into different assemblies and left most as static classes as the type of project that this is, isn’t robust enough to feasibly need to have multiple instantiations of these methods, even if they are broken into different methods. I think it’s a good idea to keep things separated when need be, but I’d rather have a setup where the state of Elevator itself is managed by the various calls instead of having Elevator’s object have multiple ones and having to verify at various points which version of the object is being changed in various classes. Even if it’s passing. 
P.S. I didn’t actually truly know how elevators worked initially as I had to actually verify certain behaviors, and apparently some elevators act differently for certain instances, so I hope the solution I chose was something that was clear enough. As strange as it is, I’ve always taken the functionality of elevators for granted. 
