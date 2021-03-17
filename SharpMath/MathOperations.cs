using System;

namespace SharpMath
{
	public struct MathOperations
	{
		public static byte Add(byte num1, byte num2)
		{
			return (byte)(num1 + num2);
		}
		public static byte Sub(byte num1, byte num2)
		{
			return (byte)(num1 - num2);
		}
		public static byte Mult(byte num1, byte num2)
		{
			return (byte)(num1 * num2);
		}
		public static byte Div(byte num1, byte num2)
		{
			return (byte)(num1 / num2);
		}
		public static byte GetPow(byte baseNum, byte powerNum)
		{
			byte result = 0;
			for (byte i = 0; i < powerNum; i++)
			{
				result = (byte)(baseNum * baseNum);
			}
			return result;
		}
		public static byte Circumference(byte radius)
		{
			return (byte)(2 * (Math.PI * radius));
		}
		public static byte Radius(byte circumference)
		{
			return (byte)(circumference / 2);
		}
		public static byte SurfaceAreaCubic(byte sideArea)
		{
			return (byte)(6 * GetPow(sideArea, (byte)2));
		}
		public static byte SurfaceAreaRectangular(byte length, byte width, byte height)
		{
			byte face1 = (byte)(2 * length * width);
			byte face2 = (byte)(2 * length * height);
			byte face3 = (byte)(2 * width * height);

			return (byte)(face1 + face2 + face3);
		}

		public static decimal Add(decimal num1, decimal num2)
		{
			return num1 + num2;
		}
		public static decimal Sub(decimal num1, decimal num2)
		{
			return num1 - num2;
		}
		public static decimal Mult(decimal num1, decimal num2)
		{
			return num1 * num2;
		}
		public static decimal Div(decimal num1, decimal num2)
		{
			return num1 / num2;
		}
		public static decimal GetPow(decimal baseNum, decimal powerNum)
		{
			decimal result = 0;
			for (decimal i = 0; i < powerNum; i++)
			{
				result = baseNum * baseNum;
			}
			return result;
		}
		public static decimal Circumference(decimal radius)
		{
			return 2 * ((decimal)Math.PI * radius);
		}
		public static decimal Radius(decimal circumference)
		{
			return circumference / 2;
		}
		public static decimal SurfaceAreaCubic(decimal sideArea)
		{
			return 6 * GetPow(sideArea, 2);
		}
		public static decimal SurfaceAreaRectangular(decimal length, decimal width, decimal height)
		{
			decimal face1 = 2 * length * width;
			decimal face2 = 2 * length * height;
			decimal face3 = 2 * width * height;

			return face1 + face2 + face3;
		}

		public static double Add(double num1, double num2)
		{
			return (double)(num1 + num2);
		}
		public static double Sub(double num1, double num2)
		{
			return (double)(num1 - num2);
		}
		public static double Mult(double num1, double num2)
		{
			return (double)(num1 * num2);
		}
		public static double Div(double num1, double num2)
		{
			return (double)(num1 / num2);
		}
		public static double GetPow(double baseNum, double powerNum)
		{
			double result = 0;
			for (double i = 0; i < powerNum; i++)
			{
				result = (double)(baseNum * baseNum);
			}
			return result;
		}
		public static double Circumference(double radius)
		{
			return (double)(2 * (Math.PI * radius));
		}
		public static double Radius(double circumference)
		{
			return (double)(circumference / 2);
		}
		public static double SurfaceAreaCubic(double sideArea)
		{
			return (double)(6 * GetPow(sideArea, 2));
		}
		public static double SurfaceAreaRectangular(double length, double width, double height)
		{
			double face1 = (double)(2 * length * width);
			double face2 = (double)(2 * length * height);
			double face3 = (double)(2 * width * height);

			return (double)(face1 + face2 + face3);
		}

		public static float Add(float num1, float num2)
		{
			return (float)(num1 + num2);
		}
		public static float Sub(float num1, float num2)
		{
			return (float)(num1 - num2);
		}
		public static float Mult(float num1, float num2)
		{
			return (float)(num1 * num2);
		}
		public static float Div(float num1, float num2)
		{
			return (float)(num1 / num2);
		}
		public static float GetPow(float baseNum, float powerNum)
		{
			float result = 0;
			for (float i = 0; i < powerNum; i++)
			{
				result = (float)(baseNum * baseNum);
			}
			return result;
		}
		public static float Circumference(float radius)
		{
			return (float)(2 * (Math.PI * radius));
		}
		public static float Radius(float circumference)
		{
			return (float)(circumference / 2);
		}
		public static float SurfaceAreaCubic(float sideArea)
		{
			return (float)(6 * GetPow(sideArea, 2));
		}
		public static float SurfaceAreaRectangular(float length, float width, float height)
		{
			float face1 = (float)(2 * length * width);
			float face2 = (float)(2 * length * height);
			float face3 = (float)(2 * width * height);

			return (float)(face1 + face2 + face3);
		}

		public static int Add(int num1, int num2)
		{
			return num1 + num2;
		}
		public static int Sub(int num1, int num2)
		{
			return num1 - num2;
		}
		public static int Mult(int num1, int num2)
		{
			return num1 * num2;
		}
		public static int Div(int num1, int num2)
		{
			return num1 / num2;
		}
		public static int GetPow(int baseNum, int powerNum)
		{
			int result = 0;
			for (int i = 0; i < powerNum; i++)
			{
				result = baseNum * baseNum;
			}
			return result;
		}
		public static int Circumference(int radius)
		{
			return (int)(2 * (Math.PI * radius));
		}
		public static int Radius(int circumference)
		{
			return circumference / 2;
		}
		public static int SurfaceAreaCubic(int sideArea)
		{
			return 6 * GetPow(sideArea, 2);
		}
		public static int SurfaceAreaRectangular(int length, int width, int height)
		{
			int face1 = 2 * length * width;
			int face2 = 2 * length * height;
			int face3 = 2 * width * height;

			return face1 + face2 + face3;
		}

		public static long Add(long num1, long num2)
		{
			return num1 + num2;
		}
		public static long Sub(long num1, long num2)
		{
			return num1 - num2;
		}
		public static long Mult(long num1, long num2)
		{
			return num1 * num2;
		}
		public static long Div(long num1, long num2)
		{
			return num1 / num2;
		}
		public static long GetPow(long baseNum, long powerNum)
		{
			long result = 0;
			for (long i = 0; i < powerNum; i++)
			{
				result = baseNum * baseNum;
			}
			return result;
		}
		public static long Circumference(long radius)
		{
			return (long)(2 * (Math.PI * radius));
		}
		public static long Radius(long circumference)
		{
			return circumference / 2;
		}
		public static long SurfaceAreaCubic(long sideArea)
		{
			return 6 * GetPow(sideArea, 2);
		}
		public static long SurfaceAreaRectangular(long length, long width, long height)
		{
			long face1 = 2 * length * width;
			long face2 = 2 * length * height;
			long face3 = 2 * width * height;

			return face1 + face2 + face3;
		}

		public static sbyte Add(sbyte num1, sbyte num2)
		{
			return (sbyte)(num1 + num2);
		}
		public static sbyte Sub(sbyte num1, sbyte num2)
		{
			return (sbyte)(num1 - num2);
		}
		public static sbyte Mult(sbyte num1, sbyte num2)
		{
			return (sbyte)(num1 * num2);
		}
		public static sbyte Div(sbyte num1, sbyte num2)
		{
			return (sbyte)(num1 / num2);
		}
		public static sbyte GetPow(sbyte baseNum, sbyte powerNum)
		{
			sbyte result = 0;
			for (sbyte i = 0; i < powerNum; i++)
			{
				result = (sbyte)(baseNum * baseNum);
			}
			return result;
		}
		public static sbyte Circumference(sbyte radius)
		{
			return (sbyte)(2 * (Math.PI * radius));
		}
		public static sbyte Radius(sbyte circumference)
		{
			return (sbyte)(circumference / 2);
		}
		public static sbyte SurfaceAreaCubic(sbyte sideArea)
		{
			return (sbyte)(6 * GetPow(sideArea, (sbyte)2));
		}
		public static sbyte SurfaceAreaRectangular(sbyte length, sbyte width, sbyte height)
		{
			sbyte face1 = (sbyte)(2 * length * width);
			sbyte face2 = (sbyte)(2 * length * height);
			sbyte face3 = (sbyte)(2 * width * height);

			return (sbyte)(face1 + face2 + face3);
		}

		public static short Add(short num1, short num2)
		{
			return (short)(num1 + num2);
		}
		public static short Sub(short num1, short num2)
		{
			return (short)(num1 - num2);
		}
		public static short Mult(short num1, short num2)
		{
			return (short)(num1 * num2);
		}
		public static short Div(short num1, short num2)
		{
			return (short)(num1 / num2);
		}
		public static short GetPow(short baseNum, short powerNum)
		{
			short result = 0;
			for (short i = 0; i < powerNum; i++)
			{
				result = (short)(baseNum * baseNum);
			}
			return result;
		}
		public static short Circumference(short radius)
		{
			return (short)(2 * (Math.PI * radius));
		}
		public static short Radius(short circumference)
		{
			return (short)(circumference / 2);
		}
		public static short SurfaceAreaCubic(short sideArea)
		{
			return (short)(6 * GetPow(sideArea, (short)2));
		}
		public static short SurfaceAreaRectangular(short length, short width, short height)
		{
			short face1 = (short)(2 * length * width);
			short face2 = (short)(2 * length * height);
			short face3 = (short)(2 * width * height);

			return (short)(face1 + face2 + face3);
		}

		public static uint Add(uint num1, uint num2)
		{
			return num1 + num2;
		}
		public static uint Sub(uint num1, uint num2)
		{
			return num1 - num2;
		}
		public static uint Mult(uint num1, uint num2)
		{
			return num1 * num2;
		}
		public static uint Div(uint num1, uint num2)
		{
			return num1 / num2;
		}
		public static uint GetPow(uint baseNum, uint powerNum)
		{
			uint result = 0;
			for (uint i = 0; i < powerNum; i++)
			{
				result = baseNum * baseNum;
			}
			return result;
		}
		public static uint Circumference(uint radius)
		{
			return (uint)(2 * (Math.PI * radius));
		}
		public static uint Radius(uint circumference)
		{
			return circumference / 2;
		}
		public static uint SurfaceAreaCubic(uint sideArea)
		{
			return 6 * GetPow(sideArea, 2);
		}
		public static uint SurfaceAreaRectangular(uint length, uint width, uint height)
		{
			uint face1 = 2 * length * width;
			uint face2 = 2 * length * height;
			uint face3 = 2 * width * height;

			return face1 + face2 + face3;
		}

		public static ulong Add(ulong num1, ulong num2)
		{
			return num1 + num2;
		}
		public static ulong Sub(ulong num1, ulong num2)
		{
			return num1 - num2;
		}
		public static ulong Mult(ulong num1, ulong num2)
		{
			return num1 * num2;
		}
		public static ulong Div(ulong num1, ulong num2)
		{
			return num1 / num2;
		}
		public static ulong GetPow(ulong baseNum, ulong powerNum)
		{
			ulong result = 0;
			for (ulong i = 0; i < powerNum; i++)
			{
				result = baseNum * baseNum;
			}
			return result;
		}
		public static ulong Circumference(ulong radius)
		{
			return (ulong)(2 * (Math.PI * radius));
		}
		public static ulong Radius(ulong circumference)
		{
			return circumference / 2;
		}
		public static ulong SurfaceAreaCubic(ulong sideArea)
		{
			return 6 * GetPow(sideArea, 2);
		}
		public static ulong SurfaceAreaRectangular(ulong length, ulong width, ulong height)
		{
			ulong face1 = 2 * length * width;
			ulong face2 = 2 * length * height;
			ulong face3 = 2 * width * height;

			return face1 + face2 + face3;
		}

		public static ushort Add(ushort num1, ushort num2)
		{
			return (ushort)(num1 + num2);
		}
		public static ushort Sub(ushort num1, ushort num2)
		{
			return (ushort)(num1 - num2);
		}
		public static ushort Mult(ushort num1, ushort num2)
		{
			return (ushort)(num1 * num2);
		}
		public static ushort Div(ushort num1, ushort num2)
		{
			return (ushort)(num1 / num2);
		}
		public static ushort GetPow(ushort baseNum, ushort powerNum)
		{
			ushort result = 0;
			for (ushort i = 0; i < powerNum; i++)
			{
				result = (ushort)(baseNum * baseNum);
			}
			return result;
		}
		public static ushort Circumference(ushort radius)
		{
			return (ushort)(2 * (Math.PI * radius));
		}
		public static ushort Radius(ushort circumference)
		{
			return (ushort)(circumference / 2);
		}
		public static ushort SurfaceAreaCubic(ushort sideArea)
		{
			return (ushort)(6 * GetPow(sideArea, (ushort)2));
		}
		public static ushort SurfaceAreaRectangular(ushort length, ushort width, ushort height)
		{
			ushort face1 = (ushort)(2 * length * width);
			ushort face2 = (ushort)(2 * length * height);
			ushort face3 = (ushort)(2 * width * height);

			return (ushort)(face1 + face2 + face3);
		}
	}
}
