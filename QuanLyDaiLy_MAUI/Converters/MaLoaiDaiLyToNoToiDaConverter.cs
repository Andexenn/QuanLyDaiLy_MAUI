using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace QuanLyDaiLy_MAUI.Converters;

public class MaLoaiDaiLyToNoToiDaConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is int maLoaiDaiLy)
        {
            return maLoaiDaiLy switch
            {
                1 => 60_000_000,
                2 => 80_000_000,
                3 => 100_000_000,
                4 => 120_000_000,
                5 => 135_000_000,
                6 => 150_000_000,
                7 => 165_000_000,
                8 => 180_000_000,
                9 => 190_000_000,
                10 => 200_000_000,
                _ => 0
            };
        }
        return 0;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}