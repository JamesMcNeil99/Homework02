using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02
{
    public class Model
    {
        public List<string> Genres { get; }
        public List<string> Ratings { get; }
        public List<string> PriceList { get; }
        public Dictionary<string, double>Prices { get; }
        public Dictionary<string, int> Tickets { get; }

        public string UserRating { set; get; }
        public string UserGenre { set; get; }
        public double Tax { get; }

        public double ConvenienceFee { get; set; }
        public Model()
        {
            Genres = createGenreList();
            Ratings = createRatingsList();
            Prices = createPrices();
            PriceList = createPriceList();
            Tickets = createTickets();
            Tax = 0.07;
        }


        //Creates list of genres to be used by the Genre page
        List<string> createGenreList()
        {
            List<string> genres = new List<string>();
            genres.Add("ACTION");
            genres.Add("COMEDY");
            genres.Add("ROMANCE");
            genres.Add("DOCUMENTARY");
            return genres;
        }

        //Creates list of ratings to be used by the ratings page
        List<string> createRatingsList()
        {
            List<string> ratings = new List<string>();
            ratings.Add("PG-13");
            ratings.Add("R");
            return ratings;
        }


        //Create List of Prices per type to be used for a combo box 
        List<string> createPriceList()
        {
            List<string> priceList = new List<string>();

            priceList.Add($"Children, {getTicketPrice("Children")}");
            priceList.Add($"Students, {getTicketPrice("Students")}");
            priceList.Add($"Adults, {getTicketPrice("Adults")}");
            priceList.Add($"Seniors, {getTicketPrice("Seniors")}");

            return priceList;
        }

        //creates list of prices to be used for price calculations 
        Dictionary<string, double> createPrices()
        {
            Dictionary<string, double> price = new Dictionary<string, double>();

            price.Add("Children", 4.00);
            price.Add("Students", 5.00);
            price.Add("Adults", 8.50);
            price.Add("Seniors", 5.00);      
            return price;
        }
        //Adds a ticket of the corresponding type selected in the combobox 
        public void addTicket(string type)
        {
            type = type.Split(",")[0];

            Tickets[type] += 1;
        }

        //Creates dictionary to be used for tracking number of tickets per type selected
        Dictionary<string, int> createTickets()
        {
            Dictionary<string, int> tickets = new Dictionary<string, int>();

            tickets.Add("Children", 0);
            tickets.Add("Students", 0);
            tickets.Add("Adults", 0);
            tickets.Add("Seniors", 0);

            return tickets;
        }

        public int getTicketCount(string type)
        {
            return Tickets[type];
        }
        public double getTicketPrice(string type)
        {
            return Prices[type];
        }
        public int getTotalTickets()
        {
            int ticketCount = 0;

            foreach(KeyValuePair<string,int> x in Tickets)
            {
                ticketCount += x.Value;
            }
            return ticketCount;
        }
        public double getTotalPrice()
        {
            double total = 0;
            foreach (KeyValuePair<string, int> x in Tickets)
            {
                total += x.Value * getTicketPrice(x.Key);
            }

            return total;

        }
    }
}
