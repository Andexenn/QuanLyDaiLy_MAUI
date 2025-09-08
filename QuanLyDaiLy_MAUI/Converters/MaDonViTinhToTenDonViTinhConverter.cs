using System;
using System.Globalization;
using Microsoft.Maui.Controls;
namespace QuanLyDaiLy_MAUI.Converters;

public class MaDonViTinhToTenDonViTinhConverter : IValueConverter
{
	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
        if (value is int maDonViTinh)
        {
            return maDonViTinh switch
            {
                1 => "Kg",
                2 => "Cái",
                3 => "Thùng",
                4 => "Lít",
                5 => "Chai",
                _ => "Unknown"
            };
        }
        return "Unknown";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}