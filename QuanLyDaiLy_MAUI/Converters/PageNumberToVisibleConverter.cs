using System.Globalization;

namespace QuanLyDaiLy_MAUI.Converters;

public class PageNumberToVisibleConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo cultureInfo)
    {
        if(value is int pageNumber)
        {
            return pageNumber switch
            {
                > 0 => true,
                _ => false
            };
        }
        return false;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new Exception("Bug at getting visible state");
    }
}