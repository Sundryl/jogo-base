using System;

namespace csDelaunay
{
	public struct Vector2f : IEquatable<Vector2f>
	{
		public float x;

		public float y;

		public static readonly Vector2f ZERO;

		public static readonly Vector2f ONE;

		public static readonly Vector2f RIGHT;

		public static readonly Vector2f LEFT;

		public static readonly Vector2f UP;

		public static readonly Vector2f DOWN;

		public float Magnitude => 0f;

		public Vector2f Unit => default;

		public static bool operator ==(Vector2f a, Vector2f b)
		{
			return false;
		}

		public static bool operator !=(Vector2f a, Vector2f b)
		{
			return false;
		}

		public static Vector2f operator -(Vector2f a, Vector2f b)
		{
			return default;
		}

		public static Vector2f operator +(Vector2f a, Vector2f b)
		{
			return default;
		}

		public static Vector2f operator *(Vector2f a, float i)
		{
			return default;
		}

		public static Vector2f operator /(Vector2f a, float s)
		{
			return default;
		}

		public static Vector2f operator /(Vector2f a, Vector2f b)
		{
			return default;
		}

		public static Vector2f Min(Vector2f a, Vector2f b)
		{
			return default;
		}

		public static Vector2f Max(Vector2f a, Vector2f b)
		{
			return default;
		}

		public static Vector2f Normalize(Vector2f a)
		{
			return default;
		}

		public static Vector2f Interpolate(Vector2f a, Vector2f b, float s)
		{
			return default;
		}

		public static float DistanceSquare(Vector2f a, Vector2f b)
		{
			return 0f;
		}

		public static float Distance(Vector2f a, Vector2f b)
		{
			return 0f;
		}

		public Vector2f(float x, float y)
		{
			this.x = 0f;
			this.y = 0f;
		}

		public Vector2f(double x, double y)
		{
			this.x = 0f;
			this.y = 0f;
		}

		public void Normalize()
		{
		}

		public float Dot(Vector2f v)
		{
			return 0f;
		}

		public float Cross(Vector2f v)
		{
			return 0f;
		}

		public bool Equals(Vector2f other)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool NearlyEquals(Vector2f other, float tolerance = 0.0001f)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public float DistanceSquare(Vector2f v)
		{
			return 0f;
		}

		public static Vector2f Lerp(Vector2f a, Vector2f b, float t)
		{
			return default;
		}
	}
}
