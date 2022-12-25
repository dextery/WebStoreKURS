using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
	public class Order
	{
		public int id { get; set; }

		[Display(Name = "Введите имя")]
		[StringLength(25)]
		[Required(ErrorMessage = "Длина имени не больше 25 символов")]
		public string name { get; set; }
		[Display(Name = "Введите имя")]
		[StringLength(25)]
		[Required(ErrorMessage = "Длина имени не больше 25 символов")]
		public string surname { get; set; }
		[Display(Name = "Введите адрес")]

		[StringLength(35)]
		[Required(ErrorMessage = "Длина адреса не больше 35 символов")]
		public string address { get; set; }
		[Display(Name = "Введите номер телефона")]
		[DataType(DataType.PhoneNumber)]
		[StringLength(20)]
		[Required(ErrorMessage = "Длина номера не больше 20 символов")]
		public string phone { get; set; }
		[Display(Name = "Введите Email")]
		[DataType(DataType.EmailAddress)]
		public string email { get; set; }
		[ScaffoldColumn(false)]
		public DateTime orderTime { get; set; }
		public List<OrderDetail> orderDetails { get; set; }
	}
}
