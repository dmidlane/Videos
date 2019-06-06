using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videos.Models;

namespace Videos.Dtos
{
    public class RentalsDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}