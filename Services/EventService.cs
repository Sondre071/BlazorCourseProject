using EventEaseProject.Components.Pages.Events;
using EventEaseProject.Models;

namespace EventEaseProject.Services;

public class EventService
{
    private static readonly List<Event> Events = [];

    private static readonly List<Registration> Registrations = [];

    public EventService()
    {
        Events.Add(new Event(1, "NDC", "April 13th 2025", "Oslo"));
        Events.Add(new Event(2, "Kingsday", "April 27th 2025", "The Netherlands"));
        Events.Add(new Event(3, "Dinner with the Queen", "August 6th 2025", "Stockholm"));
        Events.Add(new Event(4, "National pet-a-cat-day", "September 15th 2025", "Norway"));
    }

    public List<Event> GetAllEvents() => Events;

    public Event? GetEventById(int id) => Events.FirstOrDefault(e => e.Id == id);

    public List<Registration> GetEventRegistrations() => Registrations;

    public Registration? GetRegistrationById(int id) => Registrations.FirstOrDefault(r => r.EventId == id);

    public static void AddRegistration(int eventId, string name, int age, string email)
    {
        int id = Registrations.Count != 0 ? Registrations.Max(e => e.Id) + 1 : 1;

        Registrations.Add(new Registration(id, eventId, name, age, email));
    }
}