using System.Collections.Generic;
using System.Text;

namespace CouncilWise
{
    internal class Receipt
    {
        public ICollection<ReceiptItem> Items { get; set; } = new List<ReceiptItem>();
        public decimal Total { get; set; }
        public decimal TaxTotal { get; set; }

        public override string ToString()
        {
            var printitems = "";
            foreach (var item in Items)
            {
                printitems += item.ToString();

            }

            return @$"
            Receipt:
                Items:
                    {printitems}
                    ... for all receipt items
                Total:   {Total}
                GST:     {TaxTotal} ";

        }


    }
}
