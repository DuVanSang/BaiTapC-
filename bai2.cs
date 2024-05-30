using System;

namespace NumericTypeConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhắc người dùng nhập một số thực
            Console.WriteLine("Nhập một số thực:");

            // Đọc giá trị nhập từ bàn phím
            string userInput = Console.ReadLine();

            // Chuyển đổi giá trị nhập thành số thực (double)
            double realNumber;
            if (double.TryParse(userInput, out realNumber))
            {
                // Ép kiểu số thực thành kiểu int
                int intNumber = (int)realNumber;

                // Ép kiểu số thực thành kiểu long
                long longNumber = (long)realNumber;

                // Hiển thị kết quả ra màn hình
                Console.WriteLine($"Số bạn đã nhập là {realNumber}, khi chuyển thành int là {intNumber} và khi chuyển thành long là {longNumber}");
            }
            else
            {
                Console.WriteLine("Giá trị nhập không phải là số thực hợp lệ.");
            }
        }
    }
}
