using System.ComponentModel.DataAnnotations;

namespace OrderForm.Models
{
	public class OrderFormModel
	{
		[Required (ErrorMessage="Must Enter A Quantity")]
		public decimal? OrderQuantity { get; set; }

		public string? DiscountCode { get; set; }

		public string? DiscountMessage { get; set; }

		public decimal? PricePerShirt { get; set; }

		public decimal? Subtotal { get; set; }

		public decimal? Tax { get; set; }

		public decimal? Total { get; set; }

		public decimal? CalculatePrice()
		{
			PricePerShirt = 15;


			if(DiscountCode == "6175") 
			{
				PricePerShirt = PricePerShirt - (0.3m * PricePerShirt);
				DiscountMessage = "Discount Applied";
			}
			else if(DiscountCode == "1390")
			{
				PricePerShirt = PricePerShirt - (0.2m * PricePerShirt);
				DiscountMessage = "Discount Applied";

			}
			else if(DiscountCode == "BB88")
			{
				PricePerShirt = PricePerShirt - (0.1m * PricePerShirt);
				DiscountMessage = "Discount Applied";
			}
			else if(DiscountCode == null)
			{
				PricePerShirt = 15;
				DiscountMessage = " ";
			}
			else
			{
				PricePerShirt = 15;
				DiscountMessage = "Invalid Discount Code";
			}


			Subtotal = PricePerShirt * OrderQuantity;
			Tax = 0.08m * Subtotal;
			Total = Tax + Subtotal;

			return Total;
		}
	}
}
