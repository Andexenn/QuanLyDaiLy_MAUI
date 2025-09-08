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
                1 => 20000,
                2 => 50,
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