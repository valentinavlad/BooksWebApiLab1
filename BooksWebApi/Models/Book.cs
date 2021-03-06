﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebApi.Models
{
    public class Book
    {
        private string _title;
        public long Id { get; set; }
        public string Title 
        {
            get
            {
                return _title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title must not be blank");
                }

                _title = value;
            }
        }

        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }
    }
}
