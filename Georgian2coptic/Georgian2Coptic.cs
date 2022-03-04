
/// </summary>
/// Convert Gregorian date to Coptic date using C#
/// Copyright :Isaac Be Website: www.isaacbe.com
/// For more inquiries contact me at info@isaacbe.com
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Georgian2coptic
{
	
	public class Georgian2Coptic
    {
		public string georgian2coptic(int day, int month, int year)
		{

			string[] coptic_month = {
	"توت",
	"بابه",
	"هاتور",
	"كيهك",
	"طوبه",
	"أمشير",
	"برمهات ",
	"برمودة",
	"بشنس",
	"بؤونة",
	"أبيب",
	"مسرى",
	"النسى"
};
			//convert georgian to julian
			double jd = jd_from_greg(Math.Abs(day), adjusted_month_from_month(month), adjusted_year_from_year(Math.Abs(year), month));
			//'//convert julian to Coptic
			double a = 1 * jd - 1824665;
			double b = division(a, 1461);
			double c = a % 1461;
			double d = Math.Min(3, division(c, 365));
			double e = c - 365 * d;
			double m = division(e, 30);
			int mm = (int)m;
			double t = (e % 30) + 1 * 1;
			double j = 4 * b + 1 * d;
			string result = t + "  " + coptic_month[mm] + "  " + j;
			return result;
		}
		private  double division(double zaehler, double nenner)
		{

			double quotient = zaehler / nenner;
			double rest = zaehler % nenner;
			double result = Math.Round(quotient - (rest / nenner));
			return result;
		}

		public double adjusted_month_from_month(double m)
		{
			double result = ((1 * m + 9) % 12) + 3;
			return result;
		}

		private  double adjusted_year_from_year(double y, double m)
		{

			double result = y - 1 + division((1 * m + 7), 10);
			return result;
		}

		private  double jd_from_greg(double d, double m_strich, double y_strich)
		{

			double y4800 = y_strich + 4800;
			double a = division(y4800, 100);
			double b = y4800 % 100;
			double result = 146097 * division(a, 4) + 36524 * (a % 4) + 1461 * division(b, 4) + 365 * (b % 4) + division((7 * (m_strich - 2)), 12) + 30 * m_strich + 1 * d + 1721029 - 1753164;
			return result;
		}
		private  string getmonthname(int m)
		{
			string mname = "";
			switch (m)
			{
				case 1:
					mname = "يناير";
					break;
				case 2:
					mname = "فبراير";
					break;
				case 3:
					mname = "مارس";
					break;
				case 4:
					mname = "أبريل";
					break;
				case 5:
					mname = "مايو";
					break;
				case 6:
					mname = "يونيو";
					break;
				case 7:
					mname = "يوليو";
					break;
				case 8:
					mname = "أغسطس";
					break;
				case 9:
					mname = "سبتمبر";
					break;
				case 10:
					mname = "اكتوبر";
					break;
				case 11:
					mname = "يونيو";
					break;
				case 12:
					mname = "ديسمبر";
					break;

			}
			return mname;
		}


		public string GetArabicGeorgianDateNow()
        {
			var datenow = DateTime.Now;

			var monthName = getmonthname(datenow.Month);
			return  $"{datenow.Day } { monthName} { datenow.Year }";

        }

	}
}
