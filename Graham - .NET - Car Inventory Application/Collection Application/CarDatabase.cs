using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Collection_Application
{
    public class CarDatabase
    {
        private string filePath;

        public CarDatabase(string filePath)
        {
            this.filePath = filePath;
        }

        public void SaveCollection(List<Car> collection)
        {
            try
            {
                // Serialize the collection to JSON and write it to a file
                string json = JsonSerializer.Serialize(collection, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
                Console.WriteLine("Collection saved.");
            }
            catch (Exception ex)
            {
                // Log to console
                Console.WriteLine($"Error saving collection: {ex.Message}");  
                throw new Exception("Error saving the collection: " + ex.Message);
            }
        }

        public List<Car> LoadCollection()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File doesn't exist. Returning empty list.");
                    // Return empty collection if the file doesn't exist
                    return new List<Car>(); 
                }

                // Read the file
                string json = File.ReadAllText(filePath);
                Console.WriteLine("Collection loaded.");
                return JsonSerializer.Deserialize<List<Car>>(json);
            }
            catch (Exception ex)
            {
                // Log to console
                Console.WriteLine($"Error loading collection: {ex.Message}"); 
                throw new Exception("Error loading the collection: " + ex.Message);
            }
        }
    }
}
