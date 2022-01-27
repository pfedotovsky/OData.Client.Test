using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataRoutingSample.DBAccess.Entities
{
    public class Amount
    {
        public int AmountId { get; set; }

        public int OrderId { get; set; }


        public int AccountId { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal TaxAmount { get; set; }
       
    }
}
