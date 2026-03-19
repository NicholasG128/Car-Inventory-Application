using System;

namespace Collection_Application
{
    [Serializable]
    public class Car : CollectionItem
    {
        public string CustomField { get; set; }

        // Constructor
        public Car(string name, string description, DateTime dateAcquired, string customField)
            : base(name, dateAcquired, description)
        {
            CustomField = customField;
        }
    }
}
