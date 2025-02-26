using System.Runtime.InteropServices.JavaScript;

namespace EventEaseProject.Models
{
    public class Event(int id, string name, string date, string location)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Date { get; set; } = date;
        public string Location { get; set; } = location;
    }
}