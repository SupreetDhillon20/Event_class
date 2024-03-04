using System;
using System.IO;
using System.Text.Json;

// 1. Created Event Class
class Event
{
    public int EventNumber { get; set; }
    public string Location { get; set; }
}

class MainProgram
{
    static void Main()
    {
        // 2. Instantiate Event Object
        Event myEvent = new Event
        {
            EventNumber = 1,
            Location = "Calgary"
        };

        // 3. Serialize Object to JSON File
        SerializeToJsonFile(myEvent, "event.json");

        // 4. Deserialize Object from JSON File
        Event deserializedEvent = DeserializeFromJsonFile("event.json");
        Console.WriteLine($"Event Number: {deserializedEvent.EventNumber}");
        Console.WriteLine($"Location: {deserializedEvent.Location}");

        // 5. Read Characters from File
        ReadFromFile("event.json");
    }

    static void SerializeToJsonFile(Event myEvent, string filePath)
    {
        string jsonString = JsonSerializer.Serialize(myEvent);
        File.WriteAllText(filePath, jsonString);
    }

    static Event DeserializeFromJsonFile(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<Event>(jsonString);
    }

    static void ReadFromFile(string filePath)
    {
        // Write "Hackathon" to the file
        File.WriteAllText(filePath, "Hackathon");

        using (StreamReader reader = new StreamReader(filePath))
        {
            // Read the content of the file
            string fileContent = reader.ReadToEnd();

            // Display the content of the file
            Console.WriteLine($"In Word: {fileContent}");

            // Extract the first, middle, and last characters
            char firstChar = fileContent[0];
            char middleChar = fileContent[fileContent.Length / 2];
            char lastChar = fileContent[fileContent.Length - 1];

            // Display the first, middle, and last characters
            Console.WriteLine($"The First Character is: \"{firstChar}\"");
            Console.WriteLine($"The Middle Character is: \"{middleChar}\"");
            Console.WriteLine($"The Last Character is: \"{lastChar}\"");
        }
    }
}




