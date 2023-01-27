using System.ComponentModel.DataAnnotations;

namespace DistanceConverter.Models
{
	public class DistanceConverterModel
	{

		[Required(ErrorMessage = "Distance must be a valid number between 1 and 100")]
		[Range(1, 100, ErrorMessage = "Distance must be a valid number between 1 and 100")]
		public decimal? DistanceInInches { get; set; }

		public decimal? DistanceInCentimeters { get; set; }


		public decimal? ConvertToCentimeters()
		{
			DistanceInCentimeters = DistanceInInches * 2.54m;

			return DistanceInCentimeters;

		}


	}
}
