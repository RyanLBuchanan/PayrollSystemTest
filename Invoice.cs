using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesChp11
{
    public class Invoice : IPayable
    {
        public string PartNumber { get; }
        public string PartDescription { get; }
        private int quantity;
        private decimal pricePerItem;

        // Four parameter constructor
        public Invoice(string partNumber, string partDescription, int quantity, 
            decimal pricePerItem)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            PricePerItem = pricePerItem;
        }

        // Property to get quantity in invoice
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                          value, $"{nameof(Quantity)} must >= 0");
                }

                quantity = value;
            }
        }

        // Property to get set PricePerItem in invoice
        public decimal PricePerItem
        {
            get
            {
                return pricePerItem;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                          value, $"{nameof(PricePerItem)} must >= 0");
                }

                pricePerItem = value;
            }
        }

        // Return string representation of Invoice object
        public override string ToString() =>
            $"Invoice:\nPart number: {PartNumber} ({PartDescription})" +
            $"Quantity: {Quantity}\nPrice per item: {PricePerItem}";

        // Method required to carry out contract with interface IPayable
        public decimal GetPaymentAmount() => Quantity * PricePerItem;
    }
}
