using System;
namespace App {
	public class Application {

		public static void Main(string[] args) {
			Console.WriteLine(Formatter.Format("Hello world"));
		}
	}

	public class Formatter {
		public static string Format(string s) {
			return Global.Locale.Formatter.Format(new Locale("en"), "UTF-8", s);
		}
	}
}