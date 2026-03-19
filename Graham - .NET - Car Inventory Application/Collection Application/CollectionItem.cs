using System;
using System.Globalization;

namespace Collection_Application
{
    // Car Item class
    public abstract class CollectionItem
    {
        public string Name { get; set; }
        private DateTime dateAcquired;
        public string Description { get; set; }
        public string CustomField { get; set; }

        // Constructor
        protected CollectionItem(string name, DateTime dateAcquired, string description)
        {
            Name = name;
            DateAcquired = dateAcquired;
            Description = description;
        }

        // The Date
        public DateTime DateAcquired
        {
            get => dateAcquired;
            set
            {
                dateAcquired = value; 
            }
        }
        private bool IsValidDate(string date)
        {
            return DateTime.TryParseExact(date, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }

        // Displays the Car Summary
        public virtual string GetCar()
        {
            string dateInfo = DateAcquired == DateTime.MinValue ? "Unknown" : DateAcquired.ToString("MM/dd/yyyy");
            return $"{Name} - Acquired on {dateInfo}. Description: {Description}. Custom Field: {CustomField}";
        }
    }
}
