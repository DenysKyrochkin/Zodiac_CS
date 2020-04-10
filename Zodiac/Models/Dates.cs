using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace Zodiac.Models
{
    public class Dates
    {
        

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public bool BirthToday { get; set; }
        public string ZodiacW { get; set; }
        public string ZodiacC { get; set; }

        public Dates(string parse)
        {
            DateTime.TryParseExact(parse, "yyyy-MM-dd",
                CultureInfo.InvariantCulture, DateTimeStyles.None,
                out var date);
            Birthday = date;
            Age = GetAge();
            BirthToday = isBirthday();
            ZodiacC = GetZodiacC();
            ZodiacW = GetZodiacW();
        }

        private int GetAge()
        {
            DateTime today = DateTime.Today;
            return today.Year - Birthday.Year - 1 +
                ((today.Month > Birthday.Month || today.Month == Birthday.Month && today.Day >= Birthday.Day) ? 1 : 0);
        }


        public bool isBirthday()
        {
            DateTime today = DateTime.Today;
            if (today.Month == Birthday.Month && today.Day == Birthday.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetZodiacC()
        {
            int year = Birthday.Year;
            if (year % 12 == 0) { return "Monkey"; }
            else if (year % 12 == 1) { return "Rooster"; }
            else if (year % 12 == 2) { return "Dog"; }
            else if (year % 12 == 3) { return "Pig"; }
            else if (year % 12 == 4) { return "Rat"; }
            else if (year % 12 == 5) { return "Ox"; }
            else if (year % 12 == 6) { return "Tiger"; }
            else if (year % 12 == 7) { return "Rabbit"; }
            else if (year % 12 == 8) { return "Dragon"; }
            else if (year % 12 == 9) { return "Snake"; }
            else if (year % 12 == 10) { return "Horse"; }
            else { return "Sheep"; }
        }

        private string GetZodiacW()
        {
            int month = Birthday.Month;
            int day = Birthday.Year;
            switch (month)
            {
                case 1:
                    if (day < 20)
                        return "Capricorn";
                    else
                        return "Aquarius";

                case 2:
                    if (day < 19)
                        return "Aquarius";
                    else
                        return "Pisces";

                case 3:
                    if (day < 21)
                        return "Pisces";
                    else
                        return "Aries";

                case 4:
                    if (day < 20)
                        return "Aries";
                    else
                        return "Taurus";

                case 5:
                    if (day < 21)
                        return "Taurus";
                    else
                        return "Gemini";

                case 6:

                    if (day < 21)
                        return "Gemini";
                    else
                        return "Cancer";

                case 7:
                    if (day < 23)
                        return "Cancer";
                    else
                        return "Leo";


                case 8:
                    if (day < 23)
                        return "Leo";
                    else
                        return "Virgo";

                case 9:
                    if (day < 23)
                        return "Virgo";
                    else
                        return "Libra";

                case 10:
                    if (day < 23)
                        return "Libra";
                    else
                        return "Scorpio";

                case 11:

                    if (day < 22)
                        return "Scorpio";
                    else
                        return "Sagittarius";

                case 12:
                    if (day < 22)
                        return "Sagittarius";
                    else
                        return "Capricorn";
                default:
                    return "";
            }
        }

    }
}
