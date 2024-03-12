using System.Globalization;
using System.Resources;

namespace MyLibrary;

public static class MyService
{
	public static string GetText(CultureInfo culture)
	{
		return new ResourceManager("MyLibrary.Resources.MyLibrary", typeof(MyService).Assembly).GetString("HelloWorld", culture);
	}
}
