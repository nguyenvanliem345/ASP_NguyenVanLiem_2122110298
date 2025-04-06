namespace Nguyenvanliem_2122110298.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }


        // Thêm thuộc tính CategoryId để tạo mối quan hệ với Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }  // Điều này để EF nhận biết quan hệ một-nhiều

    }
}
