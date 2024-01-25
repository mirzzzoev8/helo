var date = new Date(1,12,2023);
date.Day = 1;
date.Month = 12;
date.Year = 2023;
System.Console.WriteLine("Date: " + GetDay());
System.Console.WriteLine("Month: " + GetMonth());
System.Console.WriteLine("Year: " + GetYear());
System.Console.WriteLine(date.ToString());
