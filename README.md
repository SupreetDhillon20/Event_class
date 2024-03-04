1.	Create the Event Class: Using your C# IDE, create a class named Event with two properties:
•	EventNumber: an integer representing the event number.
•	Location: a string representing the location of the event.
2.	Instantiate Event Object: Create an object from the Event class and assign the following values:
•	Set the EventNumber property to 1.
•	Set the Location property to "Calgary".
3.	Serialize Object to JSON File: Utilize JSON serialization to serialize the object to a file named event.json.
4.	Deserialize Object from JSON File: Use JSON deserialization to deserialize the object from the event.json file, and display the values on the console.
5.	Read Characters from File: Implement a method named ReadFromFile that accomplishes the following:
•	Write the word "Hackathon" to the event.json file.
•	Utilize StreamWriter and the Seek method to read and display the first, middle, and last characters from the file.
Expected Output
Event Number: 1
Location: Calgary
In Word: Hackathon
The First Character is: "H"
The Middle Character is: "a"
The Last Character is: "n"
