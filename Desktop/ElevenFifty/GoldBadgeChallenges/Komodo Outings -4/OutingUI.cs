using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static Komodo_Outings__4.Outing;

namespace Komodo_Outings__4
{
    public class OutingUI
    {
        private OutingRepository _outingRepo = new OutingRepository();
        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepProgramRunning = true;
            while (keepProgramRunning)
            {
                Console.Clear();
                Console.WriteLine("Please select an option below:\n" +
                    "1. Add a new outing:\n" +
                    "2. Display all outings:\n" +
                    "3. Display Outing Costs\n" +
                    "4. Display Golf Outing Cost Total:\n" +
                    "5. Display Bowling Outing Cost Total:\n" +
                    "6. Display Amusement Park Outing Cost Total:\n" +
                    "7. Display Concert Outing Cost Total:\n"+
                    "8. Exit");

                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    AddNewOuting();
                }
                else if (userInput == "2")
                {
                    ViewAllOutings();
                }
                else if (userInput == "3")
                {
                    ViewTotalCostOfAllOutings();
                }
                else if (userInput == "4")
                {
                    ViewTotalGolfCost();
                }
                else if (userInput == "5")
                {
                    ViewTotalBowlingCost();   
                }
                else if (userInput == "6")
                {
                    ViewTotalAmusementCost();
                }
                else if (userInput == "7")
                {
                    ViewTotalConcertCost();
                }
                else if(userInput == "8")
                {
                    keepProgramRunning = false;
                }
                else
                {
                    Console.WriteLine("Selection unknown. Please try again");
                    Menu();

                }

            }
        }

         //ADD NEW OUTING
         private void AddNewOuting()
         {
            Console.Clear();
            Outing newOuting = new Outing();
            Console.WriteLine("Enter the type of event outing:\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert");
            string outingSelection = Console.ReadLine();
            switch(outingSelection)
            {
                case "1":
                    newOuting.TypeOfEvent = EventType.Golf;
                    break;
                case "2":
                    newOuting.TypeOfEvent = EventType.Bowling;
                    break;
                case "3":
                    newOuting.TypeOfEvent = EventType.AmusementPark;
                    break;
                case "4":
                    newOuting.TypeOfEvent = EventType.Concert;
                    break;
                default:
                    newOuting.TypeOfEvent = EventType.Miscellaneous;
                    break;
            }
            Console.WriteLine("Enter the date of this event: mm/dd/yy");
            string eventDate = Console.ReadLine();
            newOuting.DateOfEvent = DateTime.Parse(eventDate);
            Console.WriteLine("Enter the number of attendees of this outing:");
            string numberOfAtendeesString = Console.ReadLine();
            newOuting.NumberOfAtendees = Convert.ToInt32(numberOfAtendeesString);
            Console.WriteLine("Enter the event cost:");
            string eventCostString = Console.ReadLine();
            double totalCostOfEvent = Convert.ToDouble(eventCostString);
            newOuting.TotalCostOfEvent = totalCostOfEvent;

            _outingRepo.AddNewEvent(newOuting);
         }

        //DISPLAY ALL OUTINGS
        private void ViewAllOutings()
        {
            Console.Clear();
            List<Outing> outingList = _outingRepo.ShowAllEvents();
            foreach (Outing outing in outingList)
            {
                double eventCostPerPerson = outing.TotalCostOfEvent / outing.NumberOfAtendees;

                Console.WriteLine($" \nEvent Type: {outing.TypeOfEvent}\n" +
                    $"\nEvent Date: {outing.DateOfEvent.ToShortDateString()}\n" +
                    $"\nNumber of Atendees: {outing.NumberOfAtendees}\n" +
                    $"\nTotal Event Cost: {outing.TotalCostOfEvent.ToString("C")}\n" +
                    $"\nEvent Cost Per Person:{eventCostPerPerson.ToString("C")}\n\n");

            }
            Console.ReadLine();
        }

        public void ViewTotalCostOfAllOutings()
        {
            double totalCost = DisplayTotalCostOfAllEvents();
            Console.WriteLine($"\n\nThe total cost of all Komodo Outings: {totalCost.ToString("C")}");
            Console.ReadLine();
            Menu();
        }

        //DISPLAY TOTAL COST OF ALL EVENTS
        public double DisplayTotalCostOfAllEvents()
        {
            List<Outing> outingList = _outingRepo.ShowAllEvents();
            double totalCost = 0;
            foreach (Outing outing in outingList)
            {
                totalCost += outing.TotalCostOfEvent;
            }
            return totalCost;
        }


        //VIEW TOTAL GOLF COST
        public void ViewTotalGolfCost()
        {
            double totalCost = DisplayTotalGolfCost();
            Console.WriteLine($"\n\nThe total cost of all Komodo Golf Outings: {totalCost.ToString("C")}");
            Console.ReadLine();
            Menu();


        }

        public double DisplayTotalGolfCost()
        {
            double totalGolfCost = 0;
            List<Outing> outingList = _outingRepo.ShowAllEvents();
            foreach (Outing outing in outingList)
            {
                if (outing.TypeOfEvent == EventType.Golf)
                {
                    totalGolfCost += outing.TotalCostOfEvent;
                }

            }
            return totalGolfCost;
        }

        //VIEW TOTAL BOWLING COST
        public void ViewTotalBowlingCost()
        {
            double totalCost = DisplayTotalBowlingCost();
            Console.WriteLine($"\n\nThe total cost of all Komodo Bowling Outings: {totalCost.ToString("C")}");
            Console.ReadLine();
            Menu();


        }

        public double DisplayTotalBowlingCost()
        {
            double totalBowlingCost = 0;
            List<Outing> outingList = _outingRepo.ShowAllEvents();
            foreach (Outing outing in outingList)
            {
                if (outing.TypeOfEvent == EventType.Bowling)
                {
                    totalBowlingCost += outing.TotalCostOfEvent;
                }

            }
            return totalBowlingCost;
        }

        //VIEW TOTAL AMUSEMENT COST
        public void ViewTotalAmusementCost()
        {
            double totalCost = DisplayTotalAmusementCost();
            Console.WriteLine($"\n\nThe total cost of all Komodo Amusement Outings: {totalCost.ToString("C")}");
            Console.ReadLine();
            Menu();


        }

        public double DisplayTotalAmusementCost()
        {
            double totalAmusementCost = 0;
            List<Outing> outingList = _outingRepo.ShowAllEvents();
            foreach (Outing outing in outingList)
            {
                if (outing.TypeOfEvent == EventType.AmusementPark)
                {
                    totalAmusementCost += outing.TotalCostOfEvent;
                }

            }
            return totalAmusementCost;
        }

        //VIEW TOTAL CONCERT COST
        public void ViewTotalConcertCost()
        {
            double totalCost = DisplayTotalConcertCost();
            Console.WriteLine($"\n\nThe total cost of all Komodo Golf Outings: {totalCost.ToString("C")}");
            Console.ReadLine();
            Menu();


        }

        public double DisplayTotalConcertCost()
        {
            double totalConcertCost = 0;
            List<Outing> outingList = _outingRepo.ShowAllEvents();
            foreach (Outing outing in outingList)
            {
                if (outing.TypeOfEvent == EventType.Concert)
                {
                    totalConcertCost += outing.TotalCostOfEvent;
                }

            }
            return totalConcertCost;
        }


    }
}
