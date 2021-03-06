﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Videos.Models
{
    public class MembershipType
    {
        public byte MembershipTypeId { get; set; }
        public string MembershipName { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayasYouGo = 1;

    }
}