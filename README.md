# Convert Gregorian date to Coptic date using C#
Simple application written by C# to convert current Gregorian date to current Coptic date

Source Code on GitHub: 
https://github.com/isaacbegit/Georgian2coptic
![alt text](https://github.com/isaacbegit/Georgian2coptic/blob/master/Georgian2coptic.jpg)
###### georgian2coptic method
```
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
```

