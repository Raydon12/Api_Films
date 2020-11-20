﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.DAL.Models
{
    public class Rental : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime RentalDate { get; set; }
        public int CustomerId { get; set; }

        public Rental()
        {

        }
        public Rental(DateTime RentalDate, int CustomerId)
        {
            this.RentalDate = RentalDate;
            this.CustomerId = CustomerId;
        }
        public Rental(int Id, DateTime RentalDate, int CustomerId): this(RentalDate,CustomerId)
        {
            this.Id = Id;
        }


    }
}
