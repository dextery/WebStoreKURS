namespace DataAccess.Entities
{
	public class Parts
	{
		public int id { set; get; } //ID товара
		public string name { set; get; }
		public string shortDesc { set; get; }
		public string longDesc { set; get; }
		public string img { set; get; }
		public uint price { set; get; }
		public bool isFavourite { set; get; }
		public bool isavailable { set; get; }
		public int categoryID { set; get; }
		public virtual Categories Category { set; get; }
	}
}
