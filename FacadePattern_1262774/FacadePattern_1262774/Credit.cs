﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern_1262774
{
    enum CreditRating : int
    {
        BAD,
        MEDIUM,
        GOOD,
        EXCELLENT
    }
    class Credit
    {
        public CreditRating CheckCredit(string ssnum)
        {
            CreditRating creditRating = CreditRating.BAD;
            if (ssnum == "111-22-3333")
                creditRating = CreditRating.GOOD;
            else if (ssnum == "111-22-3334")
                creditRating = CreditRating.MEDIUM;
            return creditRating;
        }
    }
}
