using Microsoft.EntityFrameworkCore;
using QuanLyDaiLy_MAUI.Models;
using System.Diagnostics;

namespace QuanLyDaiLy_MAUI.Helpers;

public static partial class DatabaseSeeder
{
	private static void SeedMatHang(ModelBuilder modelBuilder)
	{
#if DEBUG
        Debug.WriteLine("Seeding mat hang...");
#endif
        modelBuilder.Entity<MatHang>().HasData(
                new MatHang
                {
                    MaMatHang = 1,
                    TenMatHang = "Gạo",
                    MaDonViTinh = 1,
                    SoLuongTon = 7500
                },
                new MatHang
                {
                    MaMatHang = 2,
                    TenMatHang = "Nước ngọt",
                    MaDonViTinh = 5,
                    SoLuongTon = 8500
                },
                new MatHang
                {
                    MaMatHang = 3,
                    TenMatHang = "Mì tôm",
                    MaDonViTinh = 3,
                    SoLuongTon = 5500
                },
                // 4-23: Additional mat hang
                new MatHang
                {
                    MaMatHang = 4,
                    TenMatHang = "Đường",
                    MaDonViTinh = 1,
                    SoLuongTon = 8500
                },
                new MatHang
                {
                    MaMatHang = 5,
                    TenMatHang = "Muối",
                    MaDonViTinh = 1,
                    SoLuongTon = 5500
                },
                new MatHang
                {
                    MaMatHang = 6,
                    TenMatHang = "Bột giặt",
                    MaDonViTinh = 3,
                    SoLuongTon = 9500
                },
                new MatHang
                {
                    MaMatHang = 7,
                    TenMatHang = "Nước mắm",
                    MaDonViTinh = 5,
                    SoLuongTon = 80000
                },
                new MatHang
                {
                    MaMatHang = 8,
                    TenMatHang = "Dầu ăn",
                    MaDonViTinh = 5,
                    SoLuongTon = 8000
                },
                new MatHang
                {
                    MaMatHang = 9,
                    TenMatHang = "Sữa tươi",
                    MaDonViTinh = 5,
                    SoLuongTon = 7009
                },
                new MatHang
                {
                    MaMatHang = 10,
                    TenMatHang = "Bánh kẹo",
                    MaDonViTinh = 2,
                    SoLuongTon = 6000
                },
                new MatHang
                {
                    MaMatHang = 11,
                    TenMatHang = "Nước rửa chén",
                    MaDonViTinh = 5,
                    SoLuongTon = 9000
                },
                new MatHang
                {
                    MaMatHang = 12,
                    TenMatHang = "Bia",
                    MaDonViTinh = 3,
                    SoLuongTon = 6000
                },
                new MatHang
                {
                    MaMatHang = 13,
                    TenMatHang = "Nước suối",
                    MaDonViTinh = 5,
                    SoLuongTon = 7000
                },
                new MatHang
                {
                    MaMatHang = 14,
                    TenMatHang = "Bột ngọt",
                    MaDonViTinh = 1,
                    SoLuongTon = 9888
                },
                new MatHang
                {
                    MaMatHang = 15,
                    TenMatHang = "Giấy vệ sinh",
                    MaDonViTinh = 3,
                    SoLuongTon = 7600
                },
                new MatHang
                {
                    MaMatHang = 16,
                    TenMatHang = "Khăn giấy",
                    MaDonViTinh = 2,
                    SoLuongTon = 8500
                },
                new MatHang
                {
                    MaMatHang = 17,
                    TenMatHang = "Nước tương",
                    MaDonViTinh = 5,
                    SoLuongTon = 10000
                },
                new MatHang
                {
                    MaMatHang = 18,
                    TenMatHang = "Tương ớt",
                    MaDonViTinh = 5,
                    SoLuongTon = 9000
                },
                new MatHang
                {
                    MaMatHang = 19,
                    TenMatHang = "Bột canh",
                    MaDonViTinh = 1,
                    SoLuongTon = 8000
                },
                new MatHang
                {
                    MaMatHang = 20,
                    TenMatHang = "Dầu gội",
                    MaDonViTinh = 5,
                    SoLuongTon = 5000
                },
                new MatHang
                {
                    MaMatHang = 21,
                    TenMatHang = "Sữa tắm",
                    MaDonViTinh = 5,
                    SoLuongTon = 6000
                },
                new MatHang
                {
                    MaMatHang = 22,
                    TenMatHang = "Kem đánh răng",
                    MaDonViTinh = 2,
                    SoLuongTon = 9086
                },
                new MatHang
                {
                    MaMatHang = 23,
                    TenMatHang = "Cafe",
                    MaDonViTinh = 1,
                    SoLuongTon = 8005
                },
                // 24-100 : thêm 77 mặt hàng mới
                new MatHang
                {
                    MaMatHang = 24,
                    TenMatHang = "Khoai tây",
                    MaDonViTinh = 1,
                    SoLuongTon = 9569
                },
                new MatHang
                {
                    MaMatHang = 25,
                    TenMatHang = "Cà rốt",
                    MaDonViTinh = 1,
                    SoLuongTon = 8238
                },
                new MatHang
                {
                    MaMatHang = 26,
                    TenMatHang = "Hành tây",
                    MaDonViTinh = 1,
                    SoLuongTon = 7173
                },
                new MatHang
                {
                    MaMatHang = 27,
                    TenMatHang = "Ớt chuông",
                    MaDonViTinh = 1,
                    SoLuongTon = 9473
                },
                new MatHang
                {
                    MaMatHang = 28,
                    TenMatHang = "Bắp cải",
                    MaDonViTinh = 1,
                    SoLuongTon = 5886
                },
                new MatHang
                {
                    MaMatHang = 29,
                    TenMatHang = "Rau muống",
                    MaDonViTinh = 1,
                    SoLuongTon = 8324
                },
                new MatHang
                {
                    MaMatHang = 30,
                    TenMatHang = "Măng tây",
                    MaDonViTinh = 1,
                    SoLuongTon = 9391
                },
                new MatHang
                {
                    MaMatHang = 31,
                    TenMatHang = "Bông cải xanh",
                    MaDonViTinh = 1,
                    SoLuongTon = 7706
                },
                new MatHang
                {
                    MaMatHang = 32,
                    TenMatHang = "Dưa chuột",
                    MaDonViTinh = 1,
                    SoLuongTon = 6424
                },
                new MatHang
                {
                    MaMatHang = 33,
                    TenMatHang = "Bí đỏ",
                    MaDonViTinh = 1,
                    SoLuongTon = 7356
                },
                new MatHang
                {
                    MaMatHang = 34,
                    TenMatHang = "Cải bó xôi",
                    MaDonViTinh = 1,
                    SoLuongTon = 9912
                },
                new MatHang
                {
                    MaMatHang = 35,
                    TenMatHang = "Gừng",
                    MaDonViTinh = 1,
                    SoLuongTon = 5982
                },
                new MatHang
                {
                    MaMatHang = 36,
                    TenMatHang = "Tỏi",
                    MaDonViTinh = 1,
                    SoLuongTon = 8970
                },
                new MatHang
                {
                    MaMatHang = 37,
                    TenMatHang = "Chanh",
                    MaDonViTinh = 1,
                    SoLuongTon = 7001
                },
                new MatHang
                {
                    MaMatHang = 38,
                    TenMatHang = "Dứa",
                    MaDonViTinh = 1,
                    SoLuongTon = 6311
                },
                new MatHang
                {
                    MaMatHang = 39,
                    TenMatHang = "Xoài",
                    MaDonViTinh = 1,
                    SoLuongTon = 7998
                },
                new MatHang
                {
                    MaMatHang = 40,
                    TenMatHang = "Dưa hấu",
                    MaDonViTinh = 1,
                    SoLuongTon = 6632
                },
                new MatHang
                {
                    MaMatHang = 41,
                    TenMatHang = "Đu đủ",
                    MaDonViTinh = 1,
                    SoLuongTon = 7329
                },
                new MatHang
                {
                    MaMatHang = 42,
                    TenMatHang = "Dâu tây",
                    MaDonViTinh = 1,
                    SoLuongTon = 6798
                },
                new MatHang
                {
                    MaMatHang = 43,
                    TenMatHang = "Việt quất",
                    MaDonViTinh = 1,
                    SoLuongTon = 9622
                },
                new MatHang
                {
                    MaMatHang = 44,
                    TenMatHang = "Thịt bò",
                    MaDonViTinh = 1,
                    SoLuongTon = 8092
                },
                new MatHang
                {
                    MaMatHang = 45,
                    TenMatHang = "Thịt heo",
                    MaDonViTinh = 1,
                    SoLuongTon = 9508
                },
                new MatHang
                {
                    MaMatHang = 46,
                    TenMatHang = "Thịt gà",
                    MaDonViTinh = 1,
                    SoLuongTon = 6439
                },
                new MatHang
                {
                    MaMatHang = 47,
                    TenMatHang = "Cá hồi",
                    MaDonViTinh = 1,
                    SoLuongTon = 8422
                },
                new MatHang
                {
                    MaMatHang = 48,
                    TenMatHang = "Cá ngừ",
                    MaDonViTinh = 1,
                    SoLuongTon = 6570
                },
                new MatHang
                {
                    MaMatHang = 49,
                    TenMatHang = "Tôm",
                    MaDonViTinh = 1,
                    SoLuongTon = 7901
                },
                new MatHang
                {
                    MaMatHang = 50,
                    TenMatHang = "Cua",
                    MaDonViTinh = 1,
                    SoLuongTon = 7350
                },
                new MatHang
                {
                    MaMatHang = 51,
                    TenMatHang = "Mực",
                    MaDonViTinh = 1,
                    SoLuongTon = 6155
                },
                new MatHang
                {
                    MaMatHang = 52,
                    TenMatHang = "Mật ong",
                    MaDonViTinh = 5,
                    SoLuongTon = 6738
                },
                new MatHang
                {
                    MaMatHang = 53,
                    TenMatHang = "Nước khoáng",
                    MaDonViTinh = 5,
                    SoLuongTon = 5954
                },
                new MatHang
                {
                    MaMatHang = 54,
                    TenMatHang = "Nước tăng lực",
                    MaDonViTinh = 5,
                    SoLuongTon = 7564
                },
                new MatHang
                {
                    MaMatHang = 55,
                    TenMatHang = "Nước dừa",
                    MaDonViTinh = 5,
                    SoLuongTon = 8077
                },
                new MatHang
                {
                    MaMatHang = 56,
                    TenMatHang = "Nước cam",
                    MaDonViTinh = 4,
                    SoLuongTon = 5269
                },
                new MatHang
                {
                    MaMatHang = 57,
                    TenMatHang = "Trà sữa",
                    MaDonViTinh = 5,
                    SoLuongTon = 7489
                },
                new MatHang
                {
                    MaMatHang = 58,
                    TenMatHang = "Trà đào",
                    MaDonViTinh = 5,
                    SoLuongTon = 5492
                },
                new MatHang
                {
                    MaMatHang = 59,
                    TenMatHang = "Trà chanh",
                    MaDonViTinh = 5,
                    SoLuongTon = 5928
                },
                new MatHang
                {
                    MaMatHang = 60,
                    TenMatHang = "Nước ép cà rốt",
                    MaDonViTinh = 4,
                    SoLuongTon = 9939
                },
                new MatHang
                {
                    MaMatHang = 61,
                    TenMatHang = "Nước ép dưa hấu",
                    MaDonViTinh = 4,
                    SoLuongTon = 8384
                },
                new MatHang
                {
                    MaMatHang = 62,
                    TenMatHang = "Bia không cồn",
                    MaDonViTinh = 5,
                    SoLuongTon = 9562
                },
                new MatHang
                {
                    MaMatHang = 63,
                    TenMatHang = "Bia lon",
                    MaDonViTinh = 5,
                    SoLuongTon = 9384
                },
                new MatHang
                {
                    MaMatHang = 64,
                    TenMatHang = "Bia chai lớn",
                    MaDonViTinh = 5,
                    SoLuongTon = 8224
                },
                new MatHang
                {
                    MaMatHang = 65,
                    TenMatHang = "Rượu vang đỏ",
                    MaDonViTinh = 5,
                    SoLuongTon = 9839
                },
                new MatHang
                {
                    MaMatHang = 66,
                    TenMatHang = "Rượu vang trắng",
                    MaDonViTinh = 5,
                    SoLuongTon = 5136
                },
                new MatHang
                {
                    MaMatHang = 67,
                    TenMatHang = "Rượu gạo",
                    MaDonViTinh = 5,
                    SoLuongTon = 9810
                },
                new MatHang
                {
                    MaMatHang = 68,
                    TenMatHang = "Rượu trắng",
                    MaDonViTinh = 5,
                    SoLuongTon = 6367
                },
                new MatHang
                {
                    MaMatHang = 69,
                    TenMatHang = "Rượu nếp",
                    MaDonViTinh = 5,
                    SoLuongTon = 7126
                },
                new MatHang
                {
                    MaMatHang = 70,
                    TenMatHang = "Dầu ô-liu",
                    MaDonViTinh = 5,
                    SoLuongTon = 9546
                },
                new MatHang
                {
                    MaMatHang = 71,
                    TenMatHang = "Dầu mè",
                    MaDonViTinh = 5,
                    SoLuongTon = 8149
                },
                new MatHang
                {
                    MaMatHang = 72,
                    TenMatHang = "Dầu hướng dương",
                    MaDonViTinh = 5,
                    SoLuongTon = 9092
                },
                new MatHang
                {
                    MaMatHang = 73,
                    TenMatHang = "Giấm táo",
                    MaDonViTinh = 5,
                    SoLuongTon = 7324
                },
                new MatHang
                {
                    MaMatHang = 74,
                    TenMatHang = "Giấm gạo",
                    MaDonViTinh = 5,
                    SoLuongTon = 8977
                },
                new MatHang
                {
                    MaMatHang = 75,
                    TenMatHang = "Cà chua",
                    MaDonViTinh = 1,
                    SoLuongTon = 6463
                },
                new MatHang
                {
                    MaMatHang = 76,
                    TenMatHang = "Ớt cay",
                    MaDonViTinh = 1,
                    SoLuongTon = 8854
                },
                new MatHang
                {
                    MaMatHang = 77,
                    TenMatHang = "Hạt điều",
                    MaDonViTinh = 1,
                    SoLuongTon = 9781
                },
                new MatHang
                {
                    MaMatHang = 78,
                    TenMatHang = "Hạt bí",
                    MaDonViTinh = 1,
                    SoLuongTon = 9938
                },
                new MatHang
                {
                    MaMatHang = 79,
                    TenMatHang = "Hạt dẻ",
                    MaDonViTinh = 1,
                    SoLuongTon = 5281
                },
                new MatHang
                {
                    MaMatHang = 80,
                    TenMatHang = "Ngô ngọt",
                    MaDonViTinh = 1,
                    SoLuongTon = 8512
                },
                new MatHang
                {
                    MaMatHang = 81,
                    TenMatHang = "Bột sắn",
                    MaDonViTinh = 1,
                    SoLuongTon = 5986
                },
                new MatHang
                {
                    MaMatHang = 82,
                    TenMatHang = "Tương đậu nành",
                    MaDonViTinh = 5,
                    SoLuongTon = 5275
                },
                new MatHang
                {
                    MaMatHang = 83,
                    TenMatHang = "Nước súc miệng",
                    MaDonViTinh = 5,
                    SoLuongTon = 6450
                },
                new MatHang
                {
                    MaMatHang = 84,
                    TenMatHang = "Kem dưỡng da",
                    MaDonViTinh = 5,
                    SoLuongTon = 8428
                },
                new MatHang
                {
                    MaMatHang = 85,
                    TenMatHang = "Bánh đa",
                    MaDonViTinh = 2,
                    SoLuongTon = 6025
                },
                new MatHang
                {
                    MaMatHang = 86,
                    TenMatHang = "Bánh phở",
                    MaDonViTinh = 2,
                    SoLuongTon = 6714
                },
                new MatHang
                {
                    MaMatHang = 87,
                    TenMatHang = "Bắp rang",
                    MaDonViTinh = 2,
                    SoLuongTon = 9699
                },
                new MatHang
                {
                    MaMatHang = 88,
                    TenMatHang = "Bột chiên xù",
                    MaDonViTinh = 1,
                    SoLuongTon = 9867
                },
                new MatHang
                {
                    MaMatHang = 89,
                    TenMatHang = "Sốt BBQ",
                    MaDonViTinh = 5,
                    SoLuongTon = 6308
                },
                new MatHang
                {
                    MaMatHang = 90,
                    TenMatHang = "Tỏi băm",
                    MaDonViTinh = 1,
                    SoLuongTon = 8923
                },
                new MatHang
                {
                    MaMatHang = 91,
                    TenMatHang = "Hành phi",
                    MaDonViTinh = 1,
                    SoLuongTon = 6811
                },
                new MatHang
                {
                    MaMatHang = 92,
                    TenMatHang = "Muối tiêu chanh",
                    MaDonViTinh = 1,
                    SoLuongTon = 5264
                },
                new MatHang
                {
                    MaMatHang = 93,
                    TenMatHang = "Gia vị nấu phở",
                    MaDonViTinh = 1,
                    SoLuongTon = 9104
                },
                new MatHang
                {
                    MaMatHang = 94,
                    TenMatHang = "Dầu đậu nành",
                    MaDonViTinh = 5,
                    SoLuongTon = 7958
                },
                new MatHang
                {
                    MaMatHang = 95,
                    TenMatHang = "Xúc xích Đức",
                    MaDonViTinh = 2,
                    SoLuongTon = 6935
                },
                new MatHang
                {
                    MaMatHang = 96,
                    TenMatHang = "Thịt xông khói",
                    MaDonViTinh = 2,
                    SoLuongTon = 7513
                },
                new MatHang
                {
                    MaMatHang = 97,
                    TenMatHang = "Phô mai que",
                    MaDonViTinh = 2,
                    SoLuongTon = 9917
                },
                new MatHang
                {
                    MaMatHang = 98,
                    TenMatHang = "Bánh quy mặn",
                    MaDonViTinh = 2,
                    SoLuongTon = 9349
                },
                new MatHang
                {
                    MaMatHang = 99,
                    TenMatHang = "Bánh quy ngọt",
                    MaDonViTinh = 2,
                    SoLuongTon = 6794
                },
                new MatHang
                {
                    MaMatHang = 100,
                    TenMatHang = "Bánh pía",
                    MaDonViTinh = 2,
                    SoLuongTon = 7160
                }
            );
	}
}