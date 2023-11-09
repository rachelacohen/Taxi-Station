﻿namespace DotenetProject.Enitities
{
    public class Order
    {
        public string Source { get; set; }
        public int Id { get; set; }
        public string Destination { get; set; }
        public TimeOnly Order_time { get; set; }

        public Order(string source, int id, string destination, TimeOnly order_time)
        {
            Source = source;
            Id = id;
            Destination = destination;
            Order_time = order_time;
        }
    }
}
