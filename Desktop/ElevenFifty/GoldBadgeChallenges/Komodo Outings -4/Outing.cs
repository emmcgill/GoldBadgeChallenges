using System;
using System.Collections.Generic;
using System.Text;

namespace Komodo_Outings__4
{
    public class Outing
    {
        public enum EventType {Golf, Bowling, AmusementPark, Concert, Miscellaneous}
        public EventType TypeOfEvent { get; set; }
        public int NumberOfAtendees { get; set; }
        public DateTime DateOfEvent { get; set; }
        public double TotalCostOfEvent { get; set; }
        public double CostPerPerson { get; set; }

        public Outing()
        {

        }

        public Outing(EventType eventType, DateTime eventDate, int numberOfAtendees, double eventCost)
        {
            TypeOfEvent = eventType;
            DateOfEvent = eventDate;
            NumberOfAtendees = numberOfAtendees;
            TotalCostOfEvent = eventCost;
        }
    }
}
