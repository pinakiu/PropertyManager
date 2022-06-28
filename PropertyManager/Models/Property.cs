
namespace PropertyManager.Models
{
	public class Property
	{
		public long ID { get; set; }
		public IEnumerable<Media> Content { get; set; }


		public Property()
		{
		}
	}
}