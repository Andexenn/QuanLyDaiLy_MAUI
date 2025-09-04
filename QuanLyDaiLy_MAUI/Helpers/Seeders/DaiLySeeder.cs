using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Helpers;

public static partial class DatabaseSeeder
{
	private static void SeedDaiLy(ModelBuilder modelBuilder)
	{
#if DEBUG
		Debug.WriteLine("Bug at seeding DaiLy...");
#endif
        var seedDate = new DateTime(2023, 1, 1);
        modelBuilder.Entity<DaiLy>().HasData(
            // 1-4: Original dai ly
            new DaiLy
            {
                MaDaiLy = 1,
                TenDaiLy = "Minh Phát",
                MaLoaiDaiLy = 1,
                MaQuan = 1,
                DiaChi = "12 Nguyễn Huệ",
                SoDienThoai = "0901234567",
                Email = "MinhPhat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-3),
                NoDaiLy = 15000000L
            },
            new DaiLy
            {
                MaDaiLy = 2,
                TenDaiLy = "Hoàng Gia",
                MaLoaiDaiLy = 2,
                MaQuan = 2,
                DiaChi = "45 Lê Lợi",
                SoDienThoai = "0912345678",
                Email = "HoangGia@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-2),
                NoDaiLy = 20000000L
            },
            new DaiLy
            {
                MaDaiLy = 3,
                TenDaiLy = "Thịnh Vượng",
                MaLoaiDaiLy = 1,
                MaQuan = 3,
                DiaChi = "78 Nguyễn Trãi",
                SoDienThoai = "0923456789",
                Email = "ThinhVuong@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-4),
                NoDaiLy = 17000000L
            },
            new DaiLy
            {
                MaDaiLy = 4,
                TenDaiLy = "Thành Công",
                MaLoaiDaiLy = 2,
                MaQuan = 4,
                DiaChi = "32 Lý Tự Trọng",
                SoDienThoai = "0934567890",
                Email = "ThanhCong@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-1),
                NoDaiLy = 11000000L
            },
            // 5-14: Additional dai ly
            new DaiLy
            {
                MaDaiLy = 5,
                TenDaiLy = "Tân Tiến",
                MaLoaiDaiLy = 1,
                MaQuan = 5,
                DiaChi = "56 Trần Hưng Đạo",
                SoDienThoai = "0945678901",
                Email = "TanTien@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-5),
                NoDaiLy = 21000000L
            },
            new DaiLy
            {
                MaDaiLy = 6,
                TenDaiLy = "Phát Đạt",
                MaLoaiDaiLy = 2,
                MaQuan = 6,
                DiaChi = "123 Nguyễn Văn Cừ",
                SoDienThoai = "0956789012",
                Email = "PhatDat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-6),
                NoDaiLy = 11000000L
            },
            new DaiLy
            {
                MaDaiLy = 7,
                TenDaiLy = "Kim Cương",
                MaLoaiDaiLy = 1,
                MaQuan = 7,
                DiaChi = "87 Nguyễn Thị Minh Khai",
                SoDienThoai = "0967890123",
                Email = "KimCuong@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-7),
                NoDaiLy = 23000000L
            },
            new DaiLy
            {
                MaDaiLy = 8,
                TenDaiLy = "Hoàng Long",
                MaLoaiDaiLy = 1,
                MaQuan = 8,
                DiaChi = "245 Hai Bà Trưng",
                SoDienThoai = "0978901234",
                Email = "HoangLong@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-2),
                NoDaiLy = 13000000L
            },
            new DaiLy
            {
                MaDaiLy = 9,
                TenDaiLy = "Bình Minh",
                MaLoaiDaiLy = 2,
                MaQuan = 9,
                DiaChi = "67 Phan Đình Phùng",
                SoDienThoai = "0989012345",
                Email = "BinhMinh@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-3),
                NoDaiLy = 18000000L
            },
            new DaiLy
            {
                MaDaiLy = 10,
                TenDaiLy = "Trường Thịnh",
                MaLoaiDaiLy = 2,
                MaQuan = 10,
                DiaChi = "34 Lê Thánh Tôn",
                SoDienThoai = "0990123456",
                Email = "TruongThinh@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-8),
                NoDaiLy = 14000000L
            },
            new DaiLy
            {
                MaDaiLy = 11,
                TenDaiLy = "Tấn Phát",
                MaLoaiDaiLy = 1,
                MaQuan = 11,
                DiaChi = "189 Điện Biên Phủ",
                SoDienThoai = "0901234567",
                Email = "TanPhat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-4),
                NoDaiLy = 20000000L
            },
            new DaiLy
            {
                MaDaiLy = 12,
                TenDaiLy = "Quang Minh",
                MaLoaiDaiLy = 1,
                MaQuan = 12,
                DiaChi = "76 Võ Văn Tần",
                SoDienThoai = "0912345678",
                Email = "QuangMinh@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-9),
                NoDaiLy = 15000000L
            },
            new DaiLy
            {
                MaDaiLy = 13,
                TenDaiLy = "Hưng Thịnh",
                MaLoaiDaiLy = 2,
                MaQuan = 13,
                DiaChi = "54 Cách Mạng Tháng 8",
                SoDienThoai = "0923456789",
                Email = "HungThinh@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-5),
                NoDaiLy = 25000000L
            },
            new DaiLy
            {
                MaDaiLy = 14,
                TenDaiLy = "Phú Quý",
                MaLoaiDaiLy = 2,
                MaQuan = 14,
                DiaChi = "112 Nguyễn Du",
                SoDienThoai = "0934567890",
                Email = "PhuQuy@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-10),
                NoDaiLy = 15000000L
            },
            // ======= ĐẠI LÝ 15 → 50 =======
            new DaiLy
            {
                MaDaiLy = 15,
                TenDaiLy = "An Khang",
                MaLoaiDaiLy = 1,
                MaQuan = 15,
                DiaChi = "15 Phạm Ngũ Lão",
                SoDienThoai = "0940012345",
                Email = "AnKhang@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-6),
                NoDaiLy = 16000000L
            },
            new DaiLy
            {
                MaDaiLy = 16,
                TenDaiLy = "Đại Phát",
                MaLoaiDaiLy = 2,
                MaQuan = 16,
                DiaChi = "164 Trường Chinh",
                SoDienThoai = "0941123456",
                Email = "DaiPhat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-7),
                NoDaiLy = 24000000L
            },
            new DaiLy
            {
                MaDaiLy = 17,
                TenDaiLy = "Gia Hưng",
                MaLoaiDaiLy = 1,
                MaQuan = 17,
                DiaChi = "79 Huỳnh Tấn Phát",
                SoDienThoai = "0942234567",
                Email = "GiaHung@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-8),
                NoDaiLy = 15000000L
            },
            new DaiLy
            {
                MaDaiLy = 18,
                TenDaiLy = "Lộc Phát",
                MaLoaiDaiLy = 2,
                MaQuan = 18,
                DiaChi = "88 Nguyễn Đình Chiểu",
                SoDienThoai = "0943345678",
                Email = "LocPhat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-9),
                NoDaiLy = 19000000L
            },
            new DaiLy
            {
                MaDaiLy = 19,
                TenDaiLy = "Vạn Lợi",
                MaLoaiDaiLy = 1,
                MaQuan = 19,
                DiaChi = "19 Điện Biên Phủ",
                SoDienThoai = "0944456789",
                Email = "VanLoi@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-10),
                NoDaiLy = 17500000L
            },
            new DaiLy
            {
                MaDaiLy = 20,
                TenDaiLy = "Đông Á",
                MaLoaiDaiLy = 2,
                MaQuan = 20,
                DiaChi = "205 Lê Quang Định",
                SoDienThoai = "0945567890",
                Email = "DongA@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-11),
                NoDaiLy = 15000000L
            },
            new DaiLy
            {
                MaDaiLy = 21,
                TenDaiLy = "Nam Long",
                MaLoaiDaiLy = 1,
                MaQuan = 21,
                DiaChi = "21 Nguyễn Văn Thoại",
                SoDienThoai = "0946678901",
                Email = "NamLong@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-12),
                NoDaiLy = 22000000L
            },
            new DaiLy
            {
                MaDaiLy = 22,
                TenDaiLy = "Phát Tài",
                MaLoaiDaiLy = 2,
                MaQuan = 22,
                DiaChi = "222 Bình Giã",
                SoDienThoai = "0947789012",
                Email = "PhatTai@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-13),
                NoDaiLy = 16500000L
            },
            new DaiLy
            {
                MaDaiLy = 23,
                TenDaiLy = "Thái Bình",
                MaLoaiDaiLy = 1,
                MaQuan = 23,
                DiaChi = "23 Võ Thị Sáu",
                SoDienThoai = "0948890123",
                Email = "ThaiBinh@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-14),
                NoDaiLy = 14000000L
            },
            new DaiLy
            {
                MaDaiLy = 24,
                TenDaiLy = "Hòa Bình",
                MaLoaiDaiLy = 2,
                MaQuan = 24,
                DiaChi = "240 Xô Viết Nghệ Tĩnh",
                SoDienThoai = "0949901234",
                Email = "HoaBinh@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-15),
                NoDaiLy = 21000000L
            },
            new DaiLy
            {
                MaDaiLy = 25,
                TenDaiLy = "Thanh Bình",
                MaLoaiDaiLy = 1,
                MaQuan = 25,
                DiaChi = "25 Nguyễn Hữu Thọ",
                SoDienThoai = "0950012345",
                Email = "ThanhBinh@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-16),
                NoDaiLy = 18500000L
            },
            new DaiLy
            {
                MaDaiLy = 26,
                TenDaiLy = "Hải Hà",
                MaLoaiDaiLy = 2,
                MaQuan = 26,
                DiaChi = "260 CMT8",
                SoDienThoai = "0951123456",
                Email = "HaiHa@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-17),
                NoDaiLy = 15500000L
            },
            new DaiLy
            {
                MaDaiLy = 27,
                TenDaiLy = "Ngọc Bích",
                MaLoaiDaiLy = 1,
                MaQuan = 27,
                DiaChi = "27 Bạch Đằng",
                SoDienThoai = "0952234567",
                Email = "NgocBich@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-18),
                NoDaiLy = 23000000L
            },
            new DaiLy
            {
                MaDaiLy = 28,
                TenDaiLy = "An Phú",
                MaLoaiDaiLy = 2,
                MaQuan = 28,
                DiaChi = "288 Hoàng Hoa Thám",
                SoDienThoai = "0953345678",
                Email = "AnPhu@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-19),
                NoDaiLy = 17000000L
            },
            new DaiLy
            {
                MaDaiLy = 29,
                TenDaiLy = "Bảo An",
                MaLoaiDaiLy = 1,
                MaQuan = 29,
                DiaChi = "29 Phạm Hùng",
                SoDienThoai = "0954456789",
                Email = "BaoAn@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-20),
                NoDaiLy = 16000000L
            },
            new DaiLy
            {
                MaDaiLy = 30,
                TenDaiLy = "Đức Tín",
                MaLoaiDaiLy = 2,
                MaQuan = 30,
                DiaChi = "305 Lương Định Của",
                SoDienThoai = "0955567890",
                Email = "DucTin@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-21),
                NoDaiLy = 19500000L
            },
            new DaiLy
            {
                MaDaiLy = 31,
                TenDaiLy = "Khánh Hòa",
                MaLoaiDaiLy = 1,
                MaQuan = 31,
                DiaChi = "31 Pasteur",
                SoDienThoai = "0956678901",
                Email = "KhanhHoa@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-22),
                NoDaiLy = 15000000L
            },
            new DaiLy
            {
                MaDaiLy = 32,
                TenDaiLy = "Lâm Hồng",
                MaLoaiDaiLy = 2,
                MaQuan = 32,
                DiaChi = "322 Hàm Nghi",
                SoDienThoai = "0957789012",
                Email = "LamHong@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-23),
                NoDaiLy = 20000000L
            },
            new DaiLy
            {
                MaDaiLy = 33,
                TenDaiLy = "Minh Châu",
                MaLoaiDaiLy = 1,
                MaQuan = 33,
                DiaChi = "33 Nguyễn Kiệm",
                SoDienThoai = "0958890123",
                Email = "MinhChau@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-24),
                NoDaiLy = 18000000L
            },
            new DaiLy
            {
                MaDaiLy = 34,
                TenDaiLy = "Phước Lộc",
                MaLoaiDaiLy = 2,
                MaQuan = 34,
                DiaChi = "340 Lý Thái Tổ",
                SoDienThoai = "0959901234",
                Email = "PhuocLoc@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-25),
                NoDaiLy = 17000000L
            },
            new DaiLy
            {
                MaDaiLy = 35,
                TenDaiLy = "Quang Huy",
                MaLoaiDaiLy = 1,
                MaQuan = 35,
                DiaChi = "35 Phan Chu Trinh",
                SoDienThoai = "0960012345",
                Email = "QuangHuy@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-26),
                NoDaiLy = 21000000L
            },
            new DaiLy
            {
                MaDaiLy = 36,
                TenDaiLy = "Sơn Hà",
                MaLoaiDaiLy = 2,
                MaQuan = 36,
                DiaChi = "362 Kha Vạn Cân",
                SoDienThoai = "0961123456",
                Email = "SonHa@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-27),
                NoDaiLy = 15500000L
            },
            new DaiLy
            {
                MaDaiLy = 37,
                TenDaiLy = "Thành Đạt",
                MaLoaiDaiLy = 1,
                MaQuan = 37,
                DiaChi = "37 Nguyễn Cư Trinh",
                SoDienThoai = "0962234567",
                Email = "ThanhDat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-28),
                NoDaiLy = 24000000L
            },
            new DaiLy
            {
                MaDaiLy = 38,
                TenDaiLy = "Trí Việt",
                MaLoaiDaiLy = 2,
                MaQuan = 38,
                DiaChi = "388 Bùi Viện",
                SoDienThoai = "0963345678",
                Email = "TriViet@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-29),
                NoDaiLy = 17500000L
            },
            new DaiLy
            {
                MaDaiLy = 39,
                TenDaiLy = "Vân Sơn",
                MaLoaiDaiLy = 1,
                MaQuan = 39,
                DiaChi = "39 Lê Văn Sỹ",
                SoDienThoai = "0964456789",
                Email = "VanSon@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-30),
                NoDaiLy = 16000000L
            },
            new DaiLy
            {
                MaDaiLy = 40,
                TenDaiLy = "Xuân Mai",
                MaLoaiDaiLy = 2,
                MaQuan = 40,
                DiaChi = "400 Hoàng Sa",
                SoDienThoai = "0965567890",
                Email = "XuanMai@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-31),
                NoDaiLy = 19000000L
            },
            new DaiLy
            {
                MaDaiLy = 41,
                TenDaiLy = "Yến Nhi",
                MaLoaiDaiLy = 1,
                MaQuan = 41,
                DiaChi = "41 Phạm Văn Đồng",
                SoDienThoai = "0966678901",
                Email = "YenNhi@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-32),
                NoDaiLy = 15000000L
            },
            new DaiLy
            {
                MaDaiLy = 42,
                TenDaiLy = "Ánh Dương",
                MaLoaiDaiLy = 2,
                MaQuan = 42,
                DiaChi = "422 Nguyễn Oanh",
                SoDienThoai = "0967789012",
                Email = "AnhDuong@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-33),
                NoDaiLy = 20500000L
            },
            new DaiLy
            {
                MaDaiLy = 43,
                TenDaiLy = "Bảo Minh",
                MaLoaiDaiLy = 1,
                MaQuan = 43,
                DiaChi = "43 Lê Đức Thọ",
                SoDienThoai = "0968890123",
                Email = "BaoMinh@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-34),
                NoDaiLy = 16500000L
            },
            new DaiLy
            {
                MaDaiLy = 44,
                TenDaiLy = "Cát Tường",
                MaLoaiDaiLy = 2,
                MaQuan = 44,
                DiaChi = "440 Phạm Văn Hai",
                SoDienThoai = "0969901234",
                Email = "CatTuong@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-35),
                NoDaiLy = 15500000L
            },
            new DaiLy
            {
                MaDaiLy = 45,
                TenDaiLy = "Đăng Khoa",
                MaLoaiDaiLy = 1,
                MaQuan = 45,
                DiaChi = "45 Nguyễn Thái Học",
                SoDienThoai = "0970012345",
                Email = "DangKhoa@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-36),
                NoDaiLy = 18500000L
            },
            new DaiLy
            {
                MaDaiLy = 46,
                TenDaiLy = "Gia Phát",
                MaLoaiDaiLy = 2,
                MaQuan = 46,
                DiaChi = "468 Phan Văn Trị",
                SoDienThoai = "0971123456",
                Email = "GiaPhat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-37),
                NoDaiLy = 21000000L
            },
            new DaiLy
            {
                MaDaiLy = 47,
                TenDaiLy = "Hồng Phúc",
                MaLoaiDaiLy = 1,
                MaQuan = 47,
                DiaChi = "47 Lũy Bán Bích",
                SoDienThoai = "0972234567",
                Email = "HongPhuc@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-38),
                NoDaiLy = 17000000L
            },
            new DaiLy
            {
                MaDaiLy = 48,
                TenDaiLy = "Kim Ngân",
                MaLoaiDaiLy = 2,
                MaQuan = 48,
                DiaChi = "488 Nguyễn Duy Trinh",
                SoDienThoai = "0973345678",
                Email = "KimNgan@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-39),
                NoDaiLy = 16000000L
            },
            new DaiLy
            {
                MaDaiLy = 49,
                TenDaiLy = "Long Phụng",
                MaLoaiDaiLy = 1,
                MaQuan = 49,
                DiaChi = "49 Trần Quốc Thảo",
                SoDienThoai = "0974456789",
                Email = "LongPhung@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-40),
                NoDaiLy = 22500000L
            },
            new DaiLy
            {
                MaDaiLy = 50,
                TenDaiLy = "Nguyên Khang",
                MaLoaiDaiLy = 2,
                MaQuan = 50,
                DiaChi = "500 Lê Đại Hành",
                SoDienThoai = "0975567890",
                Email = "NguyenKhang@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-41),
                NoDaiLy = 18000000L
            },
            new DaiLy
            {
                MaDaiLy = 51,
                TenDaiLy = "Lâm Phát",
                MaLoaiDaiLy = 1,
                MaQuan = 1,
                DiaChi = "51 Nguyễn Văn Cừ",
                SoDienThoai = "0965678901",
                Email = "LamPhat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-51),
                NoDaiLy = 16000000L
            },
            new DaiLy
            {
                MaDaiLy = 52,
                TenDaiLy = "Thái Bình",
                MaLoaiDaiLy = 2,
                MaQuan = 2,
                DiaChi = "52 Nguyễn Văn Cừ",
                SoDienThoai = "0966789012",
                Email = "ThaiBinh@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-52),
                NoDaiLy = 16000000L
            },
            new DaiLy
            {
                MaDaiLy = 53,
                TenDaiLy = "Thanh Phát",
                MaLoaiDaiLy = 3,
                MaQuan = 3,
                DiaChi = "53 Trần Hưng Đạo",
                SoDienThoai = "0977890123",
                Email = "ThanhPhat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-53),
                NoDaiLy = 18000000L
            },
            new DaiLy
            {
                MaDaiLy = 54,
                TenDaiLy = "Gia Hưng",
                MaLoaiDaiLy = 4,
                MaQuan = 4,
                DiaChi = "54 Bà Triệu",
                SoDienThoai = "0978901234",
                Email = "GiaHung@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-54),
                NoDaiLy = 20000000L
            },
            new DaiLy
            {
                MaDaiLy = 55,
                TenDaiLy = "Tân Phát",
                MaLoaiDaiLy = 5,
                MaQuan = 5,
                DiaChi = "55 Đường Láng",
                SoDienThoai = "0989012345",
                Email = "TanPhat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-55),
                NoDaiLy = 19000000L
            },
            new DaiLy
            {
                MaDaiLy = 56,
                TenDaiLy = "Gia Tiến",
                MaLoaiDaiLy = 6,
                MaQuan = 6,
                DiaChi = "56 Nguyễn Văn Hưởng",
                SoDienThoai = "0990123456",
                Email = "GiaTien@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-56),
                NoDaiLy = 24000000L
            },
            new DaiLy
            {
                MaDaiLy = 57,
                TenDaiLy = "Thanh Hải",
                MaLoaiDaiLy = 7,
                MaQuan = 7,
                DiaChi = "57 Trường Chinh",
                SoDienThoai = "0901234567",
                Email = "ThanhHai@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-57),
                NoDaiLy = 23000000L
            },
            new DaiLy
            {
                MaDaiLy = 58,
                TenDaiLy = "Tâm Phúc",
                MaLoaiDaiLy = 8,
                MaQuan = 8,
                DiaChi = "58 Bà Triệu",
                SoDienThoai = "0912345678",
                Email = "TamPhuc@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-58),
                NoDaiLy = 22000000L
            },
            new DaiLy
            {
                MaDaiLy = 59,
                TenDaiLy = "Ngọc Lan",
                MaLoaiDaiLy = 9,
                MaQuan = 9,
                DiaChi = "59 Nguyễn Huệ",
                SoDienThoai = "0923456789",
                Email = "NgocLan@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-59),
                NoDaiLy = 23000000L
            },
            new DaiLy
            {
                MaDaiLy = 60,
                TenDaiLy = "Bảo Lâm",
                MaLoaiDaiLy = 10,
                MaQuan = 10,
                DiaChi = "60 Phan Đình Phùng",
                SoDienThoai = "0934567890",
                Email = "BaoLam@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-60),
                NoDaiLy = 25000000L
            },
            new DaiLy
            {
                MaDaiLy = 61,
                TenDaiLy = "Hoàng Hải",
                MaLoaiDaiLy = 1,
                MaQuan = 11,
                DiaChi = "61 Nguyễn Quang Định",
                SoDienThoai = "0945678901",
                Email = "HoangHai@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-61),
                NoDaiLy = 16000000L
            },
            new DaiLy
            {
                MaDaiLy = 62,
                TenDaiLy = "An Bình",
                MaLoaiDaiLy = 2,
                MaQuan = 12,
                DiaChi = "62 Nguyễn Văn Cừ",
                SoDienThoai = "0956789012",
                Email = "AnBinh@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-62),
                NoDaiLy = 17000000L
            },
            new DaiLy
            {
                MaDaiLy = 63,
                TenDaiLy = "Thanh Phát",
                MaLoaiDaiLy = 3,
                MaQuan = 13,
                DiaChi = "63 Trần Hưng Đạo",
                SoDienThoai = "0967890123",
                Email = "ThanhPhat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-63),
                NoDaiLy = 18000000L
            },
            new DaiLy
            {
                MaDaiLy = 64,
                TenDaiLy = "Gia Hưng",
                MaLoaiDaiLy = 4,
                MaQuan = 14,
                DiaChi = "64 Cách Mạng Tháng 8",
                SoDienThoai = "0978901234",
                Email = "GiaHung@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-64),
                NoDaiLy = 19000000L
            },
            new DaiLy
            {
                MaDaiLy = 65,
                TenDaiLy = "Tân Phát",
                MaLoaiDaiLy = 5,
                MaQuan = 15,
                DiaChi = "65 Nguyễn Thái Học",
                SoDienThoai = "0989012345",
                Email = "TanPhat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-65),
                NoDaiLy = 21000000L
            },
            new DaiLy
            {
                MaDaiLy = 66,
                TenDaiLy = "Hoàng Long",
                MaLoaiDaiLy = 6,
                MaQuan = 16,
                DiaChi = "66 Nguyễn Thị Minh Khai",
                SoDienThoai = "0990123456",
                Email = "HoangLong@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-66),
                NoDaiLy = 22000000L
            },
            new DaiLy
            {
                MaDaiLy = 67,
                TenDaiLy = "Lộc Phát",
                MaLoaiDaiLy = 7,
                MaQuan = 17,
                DiaChi = "67 Trường Chinh",
                SoDienThoai = "0901234567",
                Email = "LocPhat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-67),
                NoDaiLy = 23000000L
            },
            new DaiLy
            {
                MaDaiLy = 68,
                TenDaiLy = "Bình Minh",
                MaLoaiDaiLy = 8,
                MaQuan = 18,
                DiaChi = "68 Nguyễn Hữu Thọ",
                SoDienThoai = "0912345678",
                Email = "BinhMinh@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-68),
                NoDaiLy = 24000000L
            },
            new DaiLy
            {
                MaDaiLy = 69,
                TenDaiLy = "Kim Ngân",
                MaLoaiDaiLy = 9,
                MaQuan = 19,
                DiaChi = "69 Nguyễn Văn Linh",
                SoDienThoai = "0923456789",
                Email = "KimNgan@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-69),
                NoDaiLy = 25000000L
            },
            new DaiLy
            {
                MaDaiLy = 70,
                TenDaiLy = "Hồng Bích",
                MaLoaiDaiLy = 10,
                MaQuan = 20,
                DiaChi = "70 Phan Đình Phùng",
                SoDienThoai = "0934567890",
                Email = "HongBich@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-70),
                NoDaiLy = 26000000L
            },
            new DaiLy
            {
                MaDaiLy = 71,
                TenDaiLy = "Lâm Phát",
                MaLoaiDaiLy = 1,
                MaQuan = 21,
                DiaChi = "71 Nguyễn Cư Trinh",
                SoDienThoai = "0965678901",
                Email = "LamPhat@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-71),
                NoDaiLy = 27000000L
            },
            new DaiLy
            {
                MaDaiLy = 72,
                TenDaiLy = "Thái Bình",
                MaLoaiDaiLy = 2,
                MaQuan = 22,
                DiaChi = "72 Nguyễn Văn Cừ",
                SoDienThoai = "0966789012",
                Email = "ThaiBinh@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-72),
                NoDaiLy = 28000000L
            },
            new DaiLy
            {
                MaDaiLy = 73,
                TenDaiLy = "Hải Đăng",
                MaLoaiDaiLy = 3,
                MaQuan = 23,
                DiaChi = "73 Lê Lợi",
                SoDienThoai = "0907300001",
                Email = "HaiDang73@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-73),
                NoDaiLy = 12000000L
            },
            new DaiLy
            {
                MaDaiLy = 74,
                TenDaiLy = "Kim Sơn",
                MaLoaiDaiLy = 4,
                MaQuan = 24,
                DiaChi = "74 Điện Biên Phủ",
                SoDienThoai = "0907400002",
                Email = "KimSon74@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-74),
                NoDaiLy = 13000000L
            },
            new DaiLy
            {
                MaDaiLy = 75,
                TenDaiLy = "Phúc An",
                MaLoaiDaiLy = 5,
                MaQuan = 25,
                DiaChi = "75 Trần Hưng Đạo",
                SoDienThoai = "0907500003",
                Email = "PhucAn75@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-75),
                NoDaiLy = 14000000L
            },
            new DaiLy
            {
                MaDaiLy = 76,
                TenDaiLy = "Gia Phúc",
                MaLoaiDaiLy = 6,
                MaQuan = 26,
                DiaChi = "76 Nguyễn Huệ",
                SoDienThoai = "0907600004",
                Email = "GiaPhuc76@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-76),
                NoDaiLy = 15000000L
            },
            new DaiLy
            {
                MaDaiLy = 77,
                TenDaiLy = "Tài Lộc",
                MaLoaiDaiLy = 7,
                MaQuan = 27,
                DiaChi = "77 Xô Viết Nghệ Tĩnh",
                SoDienThoai = "0907700005",
                Email = "TaiLoc77@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-77),
                NoDaiLy = 16000000L
            },
            new DaiLy
            {
                MaDaiLy = 78,
                TenDaiLy = "An Lạc",
                MaLoaiDaiLy = 8,
                MaQuan = 28,
                DiaChi = "78 Cách Mạng Tháng 8",
                SoDienThoai = "0907800006",
                Email = "AnLac78@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-78),
                NoDaiLy = 17000000L
            },
            new DaiLy
            {
                MaDaiLy = 79,
                TenDaiLy = "Minh Quân",
                MaLoaiDaiLy = 9,
                MaQuan = 29,
                DiaChi = "79 Nguyễn Trãi",
                SoDienThoai = "0907900007",
                Email = "MinhQuan79@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-79),
                NoDaiLy = 18000000L
            },
            new DaiLy
            {
                MaDaiLy = 80,
                TenDaiLy = "Bình An",
                MaLoaiDaiLy = 10,
                MaQuan = 30,
                DiaChi = "80 Phạm Ngũ Lão",
                SoDienThoai = "0908000008",
                Email = "BinhAn80@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-80),
                NoDaiLy = 19000000L
            },
            new DaiLy
            {
                MaDaiLy = 81,
                TenDaiLy = "Trường Sơn",
                MaLoaiDaiLy = 1,
                MaQuan = 31,
                DiaChi = "81 Nguyễn Cư Trinh",
                SoDienThoai = "0908100009",
                Email = "TruongSon81@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-81),
                NoDaiLy = 20000000L
            },
            new DaiLy
            {
                MaDaiLy = 82,
                TenDaiLy = "Hưng Phát",
                MaLoaiDaiLy = 2,
                MaQuan = 32,
                DiaChi = "82 Nguyễn Thị Minh Khai",
                SoDienThoai = "0908200010",
                Email = "HungPhat82@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-82),
                NoDaiLy = 21000000L
            },
            new DaiLy
            {
                MaDaiLy = 83,
                TenDaiLy = "Đại Cát",
                MaLoaiDaiLy = 3,
                MaQuan = 33,
                DiaChi = "83 Pasteur",
                SoDienThoai = "0908300011",
                Email = "DaiCat83@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-83),
                NoDaiLy = 22000000L
            },
            new DaiLy
            {
                MaDaiLy = 84,
                TenDaiLy = "Xuân Phú",
                MaLoaiDaiLy = 4,
                MaQuan = 34,
                DiaChi = "84 Phan Xích Long",
                SoDienThoai = "0908400012",
                Email = "XuanPhu84@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-84),
                NoDaiLy = 23000000L
            },
            new DaiLy
            {
                MaDaiLy = 85,
                TenDaiLy = "Ngọc Minh",
                MaLoaiDaiLy = 5,
                MaQuan = 35,
                DiaChi = "85 Lý Thường Kiệt",
                SoDienThoai = "0908500013",
                Email = "NgocMinh85@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-85),
                NoDaiLy = 24000000L
            },
            new DaiLy
            {
                MaDaiLy = 86,
                TenDaiLy = "Thiên Ân",
                MaLoaiDaiLy = 6,
                MaQuan = 36,
                DiaChi = "86 Lê Văn Sỹ",
                SoDienThoai = "0908600014",
                Email = "ThienAn86@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-86),
                NoDaiLy = 25000000L
            },
            new DaiLy
            {
                MaDaiLy = 87,
                TenDaiLy = "Phú Quang",
                MaLoaiDaiLy = 7,
                MaQuan = 37,
                DiaChi = "87 Hoàng Hoa Thám",
                SoDienThoai = "0908700015",
                Email = "PhuQuang87@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-87),
                NoDaiLy = 11000000L
            },
            new DaiLy
            {
                MaDaiLy = 88,
                TenDaiLy = "Quang Vinh",
                MaLoaiDaiLy = 8,
                MaQuan = 38,
                DiaChi = "88 Phan Đăng Lưu",
                SoDienThoai = "0908800016",
                Email = "QuangVinh88@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-88),
                NoDaiLy = 12000000L
            },
            new DaiLy
            {
                MaDaiLy = 89,
                TenDaiLy = "Khánh Duy",
                MaLoaiDaiLy = 9,
                MaQuan = 39,
                DiaChi = "89 Trường Sa",
                SoDienThoai = "0908900017",
                Email = "KhanhDuy89@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-89),
                NoDaiLy = 13000000L
            },
            new DaiLy
            {
                MaDaiLy = 90,
                TenDaiLy = "Thành Công 2",
                MaLoaiDaiLy = 10,
                MaQuan = 40,
                DiaChi = "90 Hoàng Sa",
                SoDienThoai = "0909000018",
                Email = "ThanhCong90@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-90),
                NoDaiLy = 14000000L
            },
            new DaiLy
            {
                MaDaiLy = 91,
                TenDaiLy = "Bảo An",
                MaLoaiDaiLy = 1,
                MaQuan = 41,
                DiaChi = "91 Nguyễn Oanh",
                SoDienThoai = "0909100019",
                Email = "BaoAn91@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-91),
                NoDaiLy = 15000000L
            },
            new DaiLy
            {
                MaDaiLy = 92,
                TenDaiLy = "Phúc Lộc",
                MaLoaiDaiLy = 2,
                MaQuan = 42,
                DiaChi = "92 Lê Đức Thọ",
                SoDienThoai = "0909200020",
                Email = "PhucLoc92@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-92),
                NoDaiLy = 16000000L
            },
            new DaiLy
            {
                MaDaiLy = 93,
                TenDaiLy = "Đăng Khoa 2",
                MaLoaiDaiLy = 3,
                MaQuan = 43,
                DiaChi = "93 Nguyễn Thái Sơn",
                SoDienThoai = "0909300021",
                Email = "DangKhoa93@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-93),
                NoDaiLy = 17000000L
            },
            new DaiLy
            {
                MaDaiLy = 94,
                TenDaiLy = "Tấn Tài",
                MaLoaiDaiLy = 4,
                MaQuan = 44,
                DiaChi = "94 Huỳnh Tấn Phát",
                SoDienThoai = "0909400022",
                Email = "TanTai94@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-94),
                NoDaiLy = 18000000L
            },
            new DaiLy
            {
                MaDaiLy = 95,
                TenDaiLy = "Long Vân",
                MaLoaiDaiLy = 5,
                MaQuan = 45,
                DiaChi = "95 Âu Cơ",
                SoDienThoai = "0909500023",
                Email = "LongVan95@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-95),
                NoDaiLy = 19000000L
            },
            new DaiLy
            {
                MaDaiLy = 96,
                TenDaiLy = "Thanh Tùng",
                MaLoaiDaiLy = 6,
                MaQuan = 46,
                DiaChi = "96 Phan Văn Trị",
                SoDienThoai = "0909600024",
                Email = "ThanhTung96@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-96),
                NoDaiLy = 20000000L
            },
            new DaiLy
            {
                MaDaiLy = 97,
                TenDaiLy = "Hoàng Phúc",
                MaLoaiDaiLy = 7,
                MaQuan = 47,
                DiaChi = "97 Lũy Bán Bích",
                SoDienThoai = "0909700025",
                Email = "HoangPhuc97@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-97),
                NoDaiLy = 21000000L
            },
            new DaiLy
            {
                MaDaiLy = 98,
                TenDaiLy = "Trí Dũng",
                MaLoaiDaiLy = 8,
                MaQuan = 48,
                DiaChi = "98 Nguyễn Duy Trinh",
                SoDienThoai = "0909800026",
                Email = "TriDung98@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-98),
                NoDaiLy = 22000000L
            },
            new DaiLy
            {
                MaDaiLy = 99,
                TenDaiLy = "Kim Phụng",
                MaLoaiDaiLy = 9,
                MaQuan = 49,
                DiaChi = "99 Trần Quốc Thảo",
                SoDienThoai = "0909900027",
                Email = "KimPhung99@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-99),
                NoDaiLy = 23000000L
            },
            new DaiLy
            {
                MaDaiLy = 100,
                TenDaiLy = "Nguyên Phát",
                MaLoaiDaiLy = 10,
                MaQuan = 50,
                DiaChi = "100 Lê Đại Hành",
                SoDienThoai = "0910000028",
                Email = "NguyenPhat100@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-100),
                NoDaiLy = 24000000L
            },
            new DaiLy
            {
                MaDaiLy = 101,
                TenDaiLy = "An Phát",
                MaLoaiDaiLy = 1,
                MaQuan = 1,
                DiaChi = "101 Trần Não",
                SoDienThoai = "0910100029",
                Email = "AnPhat101@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-101),
                NoDaiLy = 25000000L
            },
            new DaiLy
            {
                MaDaiLy = 102,
                TenDaiLy = "Bình Minh 2",
                MaLoaiDaiLy = 2,
                MaQuan = 2,
                DiaChi = "102 Đinh Tiên Hoàng",
                SoDienThoai = "0910200030",
                Email = "BinhMinh102@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-102),
                NoDaiLy = 11000000L
            },
            new DaiLy
            {
                MaDaiLy = 103,
                TenDaiLy = "Phong Vũ",
                MaLoaiDaiLy = 3,
                MaQuan = 3,
                DiaChi = "103 Tôn Đức Thắng",
                SoDienThoai = "0910300031",
                Email = "PhongVu103@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-103),
                NoDaiLy = 12000000L
            },
            new DaiLy
            {
                MaDaiLy = 104,
                TenDaiLy = "Hòa Phát",
                MaLoaiDaiLy = 4,
                MaQuan = 4,
                DiaChi = "104 Võ Văn Kiệt",
                SoDienThoai = "0910400032",
                Email = "HoaPhat104@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-104),
                NoDaiLy = 13000000L
            },
            new DaiLy
            {
                MaDaiLy = 105,
                TenDaiLy = "Phúc Thịnh",
                MaLoaiDaiLy = 5,
                MaQuan = 5,
                DiaChi = "105 Nam Kỳ Khởi Nghĩa",
                SoDienThoai = "0910500033",
                Email = "PhucThinh105@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-105),
                NoDaiLy = 14000000L
            },
            new DaiLy
            {
                MaDaiLy = 106,
                TenDaiLy = "Quang Minh 2",
                MaLoaiDaiLy = 6,
                MaQuan = 6,
                DiaChi = "106 Nguyễn Thị Thập",
                SoDienThoai = "0910600034",
                Email = "QuangMinh106@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-106),
                NoDaiLy = 15000000L
            },
            new DaiLy
            {
                MaDaiLy = 107,
                TenDaiLy = "Đức Huy",
                MaLoaiDaiLy = 7,
                MaQuan = 7,
                DiaChi = "107 Lê Văn Lương",
                SoDienThoai = "0910700035",
                Email = "DucHuy107@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-107),
                NoDaiLy = 16000000L
            },
            new DaiLy
            {
                MaDaiLy = 108,
                TenDaiLy = "Tấn Phúc",
                MaLoaiDaiLy = 8,
                MaQuan = 8,
                DiaChi = "108 Hoàng Diệu",
                SoDienThoai = "0910800036",
                Email = "TanPhuc108@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-108),
                NoDaiLy = 17000000L
            },
            new DaiLy
            {
                MaDaiLy = 109,
                TenDaiLy = "Hải Nam",
                MaLoaiDaiLy = 9,
                MaQuan = 9,
                DiaChi = "109 Trần Não",
                SoDienThoai = "0910900037",
                Email = "HaiNam109@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-109),
                NoDaiLy = 18000000L
            },
            new DaiLy
            {
                MaDaiLy = 110,
                TenDaiLy = "Bảo Châu",
                MaLoaiDaiLy = 10,
                MaQuan = 10,
                DiaChi = "110 Lê Lợi",
                SoDienThoai = "0911000038",
                Email = "BaoChau110@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-110),
                NoDaiLy = 19000000L
            },
            new DaiLy
            {
                MaDaiLy = 111,
                TenDaiLy = "Kim Cương 2",
                MaLoaiDaiLy = 1,
                MaQuan = 11,
                DiaChi = "111 Đề Thám",
                SoDienThoai = "0911100039",
                Email = "KimCuong111@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-111),
                NoDaiLy = 20000000L
            },
            new DaiLy
            {
                MaDaiLy = 112,
                TenDaiLy = "Hồng Ân",
                MaLoaiDaiLy = 2,
                MaQuan = 12,
                DiaChi = "112 Hai Bà Trưng",
                SoDienThoai = "0911200040",
                Email = "HongAn112@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-112),
                NoDaiLy = 21000000L
            },
            new DaiLy
            {
                MaDaiLy = 113,
                TenDaiLy = "Việt Phát",
                MaLoaiDaiLy = 3,
                MaQuan = 13,
                DiaChi = "113 Nguyễn Chí Thanh",
                SoDienThoai = "0911300041",
                Email = "VietPhat113@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-113),
                NoDaiLy = 22000000L
            },
            new DaiLy
            {
                MaDaiLy = 114,
                TenDaiLy = "Đại Phước",
                MaLoaiDaiLy = 4,
                MaQuan = 14,
                DiaChi = "114 Bạch Đằng",
                SoDienThoai = "0911400042",
                Email = "DaiPhuoc114@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-114),
                NoDaiLy = 23000000L
            },
            new DaiLy
            {
                MaDaiLy = 115,
                TenDaiLy = "Phước Long",
                MaLoaiDaiLy = 5,
                MaQuan = 15,
                DiaChi = "115 Phạm Văn Đồng",
                SoDienThoai = "0911500043",
                Email = "PhuocLong115@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-115),
                NoDaiLy = 24000000L
            },
            new DaiLy
            {
                MaDaiLy = 116,
                TenDaiLy = "Hoàng Ngân",
                MaLoaiDaiLy = 6,
                MaQuan = 16,
                DiaChi = "116 Quốc Hương",
                SoDienThoai = "0911600044",
                Email = "HoangNgan116@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-116),
                NoDaiLy = 25000000L
            },
            new DaiLy
            {
                MaDaiLy = 117,
                TenDaiLy = "Thịnh Vượng 2",
                MaLoaiDaiLy = 7,
                MaQuan = 17,
                DiaChi = "117 Võ Văn Kiệt",
                SoDienThoai = "0911700045",
                Email = "ThinhVuong117@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-117),
                NoDaiLy = 11000000L
            },
            new DaiLy
            {
                MaDaiLy = 118,
                TenDaiLy = "An Hòa",
                MaLoaiDaiLy = 8,
                MaQuan = 18,
                DiaChi = "118 Hàm Nghi",
                SoDienThoai = "0911800046",
                Email = "AnHoa118@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-118),
                NoDaiLy = 12000000L
            },
            new DaiLy
            {
                MaDaiLy = 119,
                TenDaiLy = "Phúc An 2",
                MaLoaiDaiLy = 9,
                MaQuan = 19,
                DiaChi = "119 Quốc Lộ 50",
                SoDienThoai = "0911900047",
                Email = "PhucAn119@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-119),
                NoDaiLy = 13000000L
            },
            new DaiLy
            {
                MaDaiLy = 120,
                TenDaiLy = "Bình Phát",
                MaLoaiDaiLy = 10,
                MaQuan = 20,
                DiaChi = "120 Nguyễn Văn Quá",
                SoDienThoai = "0912000048",
                Email = "BinhPhat120@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-120),
                NoDaiLy = 14000000L
            },
            new DaiLy
            {
                MaDaiLy = 121,
                TenDaiLy = "Huỳnh Đức",
                MaLoaiDaiLy = 1,
                MaQuan = 21,
                DiaChi = "121 Đỗ Xuân Hợp",
                SoDienThoai = "0912100049",
                Email = "HuynhDuc121@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-121),
                NoDaiLy = 15000000L
            },
            new DaiLy
            {
                MaDaiLy = 122,
                TenDaiLy = "Thiên Long",
                MaLoaiDaiLy = 2,
                MaQuan = 22,
                DiaChi = "122 Lãnh Binh Thăng",
                SoDienThoai = "0912200050",
                Email = "ThienLong122@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-122),
                NoDaiLy = 16000000L
            },
            new DaiLy
            {
                MaDaiLy = 123,
                TenDaiLy = "Ánh Sao",
                MaLoaiDaiLy = 3,
                MaQuan = 23,
                DiaChi = "123 Nguyễn Sơn",
                SoDienThoai = "0912300051",
                Email = "AnhSao123@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-123),
                NoDaiLy = 17000000L
            },
            new DaiLy
            {
                MaDaiLy = 124,
                TenDaiLy = "Đắc Lộc",
                MaLoaiDaiLy = 4,
                MaQuan = 24,
                DiaChi = "124 Tô Hiến Thành",
                SoDienThoai = "0912400052",
                Email = "DacLoc124@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-124),
                NoDaiLy = 18000000L
            },
            new DaiLy
            {
                MaDaiLy = 125,
                TenDaiLy = "Khải Hoàn",
                MaLoaiDaiLy = 5,
                MaQuan = 25,
                DiaChi = "125 D5 Bình Thạnh",
                SoDienThoai = "0912500053",
                Email = "KhaiHoan125@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-125),
                NoDaiLy = 19000000L
            },
            new DaiLy
            {
                MaDaiLy = 126,
                TenDaiLy = "Hoàng Gia 2",
                MaLoaiDaiLy = 6,
                MaQuan = 26,
                DiaChi = "126 Phạm Văn Đồng",
                SoDienThoai = "0912600054",
                Email = "HoangGia126@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-126),
                NoDaiLy = 20000000L
            },
            new DaiLy
            {
                MaDaiLy = 127,
                TenDaiLy = "Bảo Ngọc",
                MaLoaiDaiLy = 7,
                MaQuan = 27,
                DiaChi = "127 Phan Văn Hân",
                SoDienThoai = "0912700055",
                Email = "BaoNgoc127@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-127),
                NoDaiLy = 21000000L
            },
            new DaiLy
            {
                MaDaiLy = 128,
                TenDaiLy = "Ngọc Phát",
                MaLoaiDaiLy = 8,
                MaQuan = 28,
                DiaChi = "128 Bình Giã",
                SoDienThoai = "0912800056",
                Email = "NgocPhat128@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-128),
                NoDaiLy = 22000000L
            },
            new DaiLy
            {
                MaDaiLy = 129,
                TenDaiLy = "Đại Thành",
                MaLoaiDaiLy = 9,
                MaQuan = 29,
                DiaChi = "129 Nguyễn Duy",
                SoDienThoai = "0912900057",
                Email = "DaiThanh129@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-129),
                NoDaiLy = 23000000L
            },
            new DaiLy
            {
                MaDaiLy = 130,
                TenDaiLy = "Thuận Phát",
                MaLoaiDaiLy = 10,
                MaQuan = 30,
                DiaChi = "130 Nguyễn Khuyến",
                SoDienThoai = "0913000058",
                Email = "ThuanPhat130@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-130),
                NoDaiLy = 24000000L
            },
            new DaiLy
            {
                MaDaiLy = 131,
                TenDaiLy = "Hưng Long",
                MaLoaiDaiLy = 1,
                MaQuan = 31,
                DiaChi = "131 Tôn Thất Thuyết",
                SoDienThoai = "0913100059",
                Email = "HungLong131@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-131),
                NoDaiLy = 25000000L
            },
            new DaiLy
            {
                MaDaiLy = 132,
                TenDaiLy = "Đức Thành",
                MaLoaiDaiLy = 2,
                MaQuan = 32,
                DiaChi = "132 Nguyễn Kiệm",
                SoDienThoai = "0913200060",
                Email = "DucThanh132@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-132),
                NoDaiLy = 11000000L
            },
            new DaiLy
            {
                MaDaiLy = 133,
                TenDaiLy = "Lộc Phúc",
                MaLoaiDaiLy = 3,
                MaQuan = 33,
                DiaChi = "133 Cách Mạng Tháng 8",
                SoDienThoai = "0913300061",
                Email = "LocPhuc133@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-133),
                NoDaiLy = 12000000L
            },
            new DaiLy
            {
                MaDaiLy = 134,
                TenDaiLy = "Phú Hòa",
                MaLoaiDaiLy = 4,
                MaQuan = 34,
                DiaChi = "134 Ba Tháng Hai",
                SoDienThoai = "0913400062",
                Email = "PhuHoa134@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-134),
                NoDaiLy = 13000000L
            },
            new DaiLy
            {
                MaDaiLy = 135,
                TenDaiLy = "Tân Long",
                MaLoaiDaiLy = 5,
                MaQuan = 35,
                DiaChi = "135 Tạ Quang Bửu",
                SoDienThoai = "0913500063",
                Email = "TanLong135@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-135),
                NoDaiLy = 14000000L
            },
            new DaiLy
            {
                MaDaiLy = 136,
                TenDaiLy = "Phú Quý 2",
                MaLoaiDaiLy = 6,
                MaQuan = 36,
                DiaChi = "136 Phan Chu Trinh",
                SoDienThoai = "0913600064",
                Email = "PhuQuy136@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-136),
                NoDaiLy = 15000000L
            },
            new DaiLy
            {
                MaDaiLy = 137,
                TenDaiLy = "Hoàng Tiến",
                MaLoaiDaiLy = 7,
                MaQuan = 37,
                DiaChi = "137 Nguyễn Khoái",
                SoDienThoai = "0913700065",
                Email = "HoangTien137@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-137),
                NoDaiLy = 16000000L
            },
            new DaiLy
            {
                MaDaiLy = 138,
                TenDaiLy = "Đại Hưng",
                MaLoaiDaiLy = 8,
                MaQuan = 38,
                DiaChi = "138 Phạm Thế Hiển",
                SoDienThoai = "0913800066",
                Email = "DaiHung138@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-138),
                NoDaiLy = 17000000L
            },
            new DaiLy
            {
                MaDaiLy = 139,
                TenDaiLy = "Tấn Lộc",
                MaLoaiDaiLy = 9,
                MaQuan = 39,
                DiaChi = "139 Nguyễn Ảnh Thủ",
                SoDienThoai = "0913900067",
                Email = "TanLoc139@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-139),
                NoDaiLy = 18000000L
            },
            new DaiLy
            {
                MaDaiLy = 140,
                TenDaiLy = "Nhật Quang",
                MaLoaiDaiLy = 10,
                MaQuan = 40,
                DiaChi = "140 Vườn Lài",
                SoDienThoai = "0914000068",
                Email = "NhatQuang140@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-140),
                NoDaiLy = 19000000L
            },
            new DaiLy
            {
                MaDaiLy = 141,
                TenDaiLy = "Khải Minh",
                MaLoaiDaiLy = 1,
                MaQuan = 41,
                DiaChi = "141 Quốc Lộ 13",
                SoDienThoai = "0914100069",
                Email = "KhaiMinh141@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-141),
                NoDaiLy = 20000000L
            },
            new DaiLy
            {
                MaDaiLy = 142,
                TenDaiLy = "Phú Thành",
                MaLoaiDaiLy = 2,
                MaQuan = 42,
                DiaChi = "142 Lê Đức Thọ",
                SoDienThoai = "0914200070",
                Email = "PhuThanh142@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-142),
                NoDaiLy = 21000000L
            },
            new DaiLy
            {
                MaDaiLy = 143,
                TenDaiLy = "Bảo Khang",
                MaLoaiDaiLy = 3,
                MaQuan = 43,
                DiaChi = "143 Huỳnh Văn Bánh",
                SoDienThoai = "0914300071",
                Email = "BaoKhang143@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-143),
                NoDaiLy = 22000000L
            },
            new DaiLy
            {
                MaDaiLy = 144,
                TenDaiLy = "Gia Khánh",
                MaLoaiDaiLy = 4,
                MaQuan = 44,
                DiaChi = "144 Phan Đình Giót",
                SoDienThoai = "0914400072",
                Email = "GiaKhanh144@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-144),
                NoDaiLy = 23000000L
            },
            new DaiLy
            {
                MaDaiLy = 145,
                TenDaiLy = "Phúc Khang",
                MaLoaiDaiLy = 5,
                MaQuan = 45,
                DiaChi = "145 Nguyễn Văn Đậu",
                SoDienThoai = "0914500073",
                Email = "PhucKhang145@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-145),
                NoDaiLy = 24000000L
            },
            new DaiLy
            {
                MaDaiLy = 146,
                TenDaiLy = "Tấn Phong",
                MaLoaiDaiLy = 6,
                MaQuan = 46,
                DiaChi = "146 Bùi Hữu Nghĩa",
                SoDienThoai = "0914600074",
                Email = "TanPhong146@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-146),
                NoDaiLy = 25000000L
            },
            new DaiLy
            {
                MaDaiLy = 147,
                TenDaiLy = "Triệu Phát",
                MaLoaiDaiLy = 7,
                MaQuan = 47,
                DiaChi = "147 Hoàng Văn Thụ",
                SoDienThoai = "0914700075",
                Email = "TrieuPhat147@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-147),
                NoDaiLy = 11000000L
            },
            new DaiLy
            {
                MaDaiLy = 148,
                TenDaiLy = "Đinh Phát",
                MaLoaiDaiLy = 8,
                MaQuan = 48,
                DiaChi = "148 Đặng Văn Bi",
                SoDienThoai = "0914800076",
                Email = "DinhPhat148@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-148),
                NoDaiLy = 12000000L
            },
            new DaiLy
            {
                MaDaiLy = 149,
                TenDaiLy = "Trí Nghĩa",
                MaLoaiDaiLy = 9,
                MaQuan = 49,
                DiaChi = "149 Hà Huy Giáp",
                SoDienThoai = "0914900077",
                Email = "TriNghia149@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-149),
                NoDaiLy = 13000000L
            },
            new DaiLy
            {
                MaDaiLy = 150,
                TenDaiLy = "Phát Tài 2",
                MaLoaiDaiLy = 10,
                MaQuan = 50,
                DiaChi = "150 Quốc Lộ 22",
                SoDienThoai = "0915000078",
                Email = "PhatTai150@gmail.com",
                NgayTiepNhan = seedDate.AddMonths(-150),
                NoDaiLy = 14000000L
            }
        );
    }
}