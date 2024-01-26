using System;
using System.ComponentModel.DataAnnotations;

namespace examthaison.Models
{
	public class Order
	{
		[Key]
		[Display (Name = "Item code")]
		public int ItemCode { get; set; }
        [Display(Name = "Item name")]
        public string ItemName { get; set; }
		[Display(Name = "Quantity")]
		public int ItemQty { get; set; }
        [Display(Name = "Order delivery")]
		public string OrderDelivery { get; set; }
        [Display(Name = "Order Address")]
		public string OrderAddress { get; set; }
        [Display(Name = "Phone Number")]
		public string PhoneNumber { get; set; }
	}
}

