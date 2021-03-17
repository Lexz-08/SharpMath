using System;

namespace SharpMath
{
	public struct MathLikeOperations
	{
		public static string Concatenate(string str1, string str2)
		{
			return str1 + str2;
		}
		public static string TrimBeginning(string str1, int startPosition)
		{
			return str1.Substring(startPosition);
		}
		public static string TrimEnd(string str1, int startPosition)
		{
			return str1.Substring(startPosition, str1.Length - startPosition);
		}
		
		public static byte DoMathByte(string math)
		{
			string[] inputs = math.Split(' ');

			byte num1 = Convert.ToByte(inputs[0]);
			string operatorType = inputs[1];
			byte num2 = Convert.ToByte(inputs[2]);

			switch (operatorType)
			{
				case "+":
					return (byte)(num1 + num2);
				case "-":
					return (byte)(num1 - num2);
				case "*":
					return (byte)(num1 * num2);
				case "/":
					return (byte)(num1 / num2);
			}

			return 0;
		}
		public static decimal DoMathDecimal(string math)
		{
			string[] inputs = math.Split(' ');

			decimal num1 = Convert.ToDecimal(inputs[0]);
			string operatorType = inputs[1];
			decimal num2 = Convert.ToDecimal(inputs[2]);

			switch (operatorType)
			{
				case "+":
					return num1 + num2;
				case "-":
					return num1 - num2;
				case "*":
					return num1 * num2;
				case "/":
					return num1 / num2;
			}

			return 0;
		}
		public static double DoMathDouble(string math)
		{
			string[] inputs = math.Split(' ');

			double num1 = Convert.ToDouble(inputs[0]);
			string operatorType = inputs[1];
			double num2 = Convert.ToDouble(inputs[2]);

			switch (operatorType)
			{
				case "+":
					return (double)(num1 + num2);
				case "-":
					return (double)(num1 - num2);
				case "*":
					return (double)(num1 * num2);
				case "/":
					return (double)(num1 / num2);
			}

			return 0;
		}
		public static float DoMathFloat(string math)
		{
			string[] inputs = math.Split(' ');

			float num1 = Convert.ToSingle(inputs[0]);
			string operatorType = inputs[1];
			float num2 = Convert.ToSingle(inputs[2]);

			switch (operatorType)
			{
				case "+":
					return (float)(num1 + num2);
				case "-":
					return (float)(num1 - num2);
				case "*":
					return (float)(num1 * num2);
				case "/":
					return (float)(num1 / num2);
			}

			return 0;
		}
		public static int DoMathInt(string math)
		{
			string[] inputs = math.Split(' ');

			int num1 = Convert.ToInt32(inputs[0]);
			string operatorType = inputs[1];
			int num2 = Convert.ToInt32(inputs[2]);

			switch (operatorType)
			{
				case "+":
					return num1 + num2;
				case "-":
					return num1 - num2;
				case "*":
					return num1 * num2;
				case "/":
					return num1 / num2;
			}

			return 0;
		}
		public static long DoMathLong(string math)
		{
			string[] inputs = math.Split(' ');

			long num1 = Convert.ToInt64(inputs[0]);
			string operatorType = inputs[1];
			long num2 = Convert.ToInt64(inputs[2]);

			switch (operatorType)
			{
				case "+":
					return num1 + num2;
				case "-":
					return num1 - num2;
				case "*":
					return num1 * num2;
				case "/":
					return num1 / num2;
			}

			return 0;
		}
		public static sbyte DoMathSbyte(string math)
		{
			string[] inputs = math.Split(' ');

			sbyte num1 = Convert.ToSByte(inputs[0]);
			string operatorType = inputs[1];
			sbyte num2 = Convert.ToSByte(inputs[2]);

			switch (operatorType)
			{
				case "+":
					return (sbyte)(num1 + num2);
				case "-":
					return (sbyte)(num1 - num2);
				case "*":
					return (sbyte)(num1 * num2);
				case "/":
					return (sbyte)(num1 / num2);
			}

			return 0;
		}
		public static short DoMathShort(string math)
		{
			string[] inputs = math.Split(' ');

			short num1 = Convert.ToInt16(inputs[0]);
			string operatorType = inputs[1];
			short num2 = Convert.ToInt16(inputs[2]);

			switch (operatorType)
			{
				case "+":
					return (short)(num1 + num2);
				case "-":
					return (short)(num1 - num2);
				case "*":
					return (short)(num1 * num2);
				case "/":
					return (short)(num1 / num2);
			}

			return 0;
		}
		public static uint DoMathUInt(string math)
		{
			string[] inputs = math.Split(' ');

			uint num1 = Convert.ToUInt32(inputs[0]);
			string operatorType = inputs[1];
			uint num2 = Convert.ToUInt32(inputs[2]);

			switch (operatorType)
			{
				case "+":
					return num1 + num2;
				case "-":
					return num1 - num2;
				case "*":
					return num1 * num2;
				case "/":
					return num1 / num2;
			}

			return 0;
		}
		public static ulong DoMathULong(string math)
		{
			string[] inputs = math.Split(' ');

			ulong num1 = Convert.ToUInt64(inputs[0]);
			string operatorType = inputs[1];
			ulong num2 = Convert.ToUInt64(inputs[2]);

			switch (operatorType)
			{
				case "+":
					return num1 + num2;
				case "-":
					return num1 - num2;
				case "*":
					return num1 * num2;
				case "/":
					return num1 / num2;
			}

			return 0;
		}
		public static ushort DoMathUShort(string math)
		{
			string[] inputs = math.Split(' ');

			ushort num1 = Convert.ToUInt16(inputs[0]);
			string operatorType = inputs[1];
			ushort num2 = Convert.ToUInt16(inputs[2]);

			switch (operatorType)
			{
				case "+":
					return (ushort)(num1 + num2);
				case "-":
					return (ushort)(num1 - num2);
				case "*":
					return (ushort)(num1 * num2);
				case "/":
					return (ushort)(num1 / num2);
			}

			return 0;
		}
	}
}
