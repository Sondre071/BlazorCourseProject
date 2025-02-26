using System.Runtime.InteropServices.JavaScript;

namespace EventEaseProject.Models
{
    public class Event
    {

        public string Name { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        
        public Event(string name, string date, string location)
        {
            Name = name;
            Date = date;
            Location = location;
        }
    }
}