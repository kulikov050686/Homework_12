using System;
using System.Collections.Generic;

namespace Services
{
    public static class DaysMonthsYears
    {
        /// <summary>
        /// Список месяцев
        /// </summary>        
        public static List<string> Months()
        {
           return new List<string> { "январь",
                                     "февраль",
                                     "март",
                                     "апрель",
                                     "май",
                                     "июнь",
                                     "июль",
                                     "август",
                                     "сентябрь",
                                     "октябрь",
                                     "ноябрь",
                                     "декабрь" };
        }

        /// <summary>
        /// Список дней
        /// </summary>
        /// <param name="maxNumber"> Максимальное число месяца </param>        
        public static List<int> Days(int maxNumber)
        {
            if(maxNumber > 31 || maxNumber < 1) throw new ArgumentException("");

            List<int> numbers = new List<int>();

            for (int i = 1; i <= maxNumber; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }

        /// <summary>
        /// Список годов
        /// </summary>
        /// <param name="minYears"> Минимальный год </param>
        /// <param name="maxYear"> Максимальный год </param>        
        public static List<int> Years(int minYears, int maxYear)
        {
            if(minYears < 0 || maxYear < 0 || minYears > maxYear) throw new ArgumentException("");

            List<int> years = new List<int>();

            for (int i = 0; i <= maxYear - minYears; i++)
            {
                years.Add(minYears + i);
            }

            return years;
        }
    }
}
