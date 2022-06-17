using System;
namespace PropertyManager.Models
{
	public class Resident
	{
		public long ID { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime createdOn { get; set; }

		public ICollection<Property> Properties { get; set; }

		public Resident()
		{
		}
	}
}

