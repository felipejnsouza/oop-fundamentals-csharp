using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem() { }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieve the product item by id.
        /// </summary>
        /// <param name="productItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int productItemId)
        {
            // Code
            return new OrderItem();
        }

        /// <summary>
        /// Saves the current orderItem.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code
            return true;
        }

        /// <summary>
        /// Validates the orderItem data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
