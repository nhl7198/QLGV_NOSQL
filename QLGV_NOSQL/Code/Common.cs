﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLGV_NOSQL.Code
{
	public static class Common
	{
		public static int GetIntDayByDate(DateTime ngayNhapHoc)
		{
			switch (ngayNhapHoc.DayOfWeek)
			{
				case DayOfWeek.Monday: return 2;
				case DayOfWeek.Tuesday: return 3;
				case DayOfWeek.Wednesday: return 4;
				case DayOfWeek.Thursday: return 5;
				case DayOfWeek.Friday: return 6;
				case DayOfWeek.Saturday: return 7;
				case DayOfWeek.Sunday: return 8;
				default: return 0;


			}




		}
		
	} 
}
