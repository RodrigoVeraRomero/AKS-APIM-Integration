﻿using System;

namespace Entities
{
    public class Adress
    {
        public int Id { get; set; }
        public string Street { get; set; }

        public int Number { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public int PersonId { get; set; }
    }
}
