using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using EqComparer = System.Collections.Generic.EqualityComparer<object>;
using Comparer = System.Collections.Generic.Comparer<object>;

namespace System {

	public static class Tuple {

		public static Tuple<T1> Create<T1>(T1 t1) {
			return new Tuple<T1>(t1);
		}

		public static Tuple<T1,T2> Create<T1,T2>(T1 t1, T2 t2) {
			return new Tuple<T1,T2>(t1,t2);
		}

		internal static int CombineHashCodes(int h1, int h2) {
			return (((h1 << 5) + h1) ^ h2);
		}

		internal static int CombineHashCodes(int h1, int h2, int h3) {
			return CombineHashCodes(CombineHashCodes(h1, h2), h3);
		}
	}

	[Serializable]
	public class Tuple<T1> : IComparable {

		public readonly T1 Item1;
		public readonly int Length = 1;


		public object this[int index] {
			get {
				if(index != 0)
					throw new IndexOutOfRangeException();
				return Item1;
			}
		}


		public Tuple(T1 t1)
		{
			Item1 = t1;
		}

		public override bool Equals (object obj)
		{
			if(obj == null) return false;
			Tuple<T1> other = obj as Tuple<T1>;
			if(other == null) return false;
			return EqComparer.Default.Equals(this.Item1, other.Item1);
		}

		public override string ToString ()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append('(')
				.Append(Item1)
				.Append(')');
			return sb.ToString();
		}

		public override int GetHashCode ()
		{
			return EqComparer.Default.GetHashCode(Item1);
		}

		public int CompareTo(object obj)
		{
			if(obj == null) return 1;
			Tuple<T1> other = obj as Tuple<T1>;
			if(other == null)
				throw new ArgumentException("Argument type invalid", "obj");
			return Comparer.Default.Compare(this.Item1, other.Item1);
		}
	}

	[Serializable]
	public class Tuple<T1, T2> : IComparable {

		public readonly T1 Item1;
		public readonly T2 Item2;
		public readonly int Length = 2;


		public object this[int index] {
			get {
				switch(index) {
				case 0: return Item1;
				case 1: return Item2;
				default: throw new IndexOutOfRangeException();
				}
			}
		}


		public Tuple(T1 t1, T2 t2)
		{
			Item1 = t1;
			Item2 = t2;
		}

		public override bool Equals (object obj)
		{
			if(obj == null) return false;
			Tuple<T1,T2> other = obj as Tuple<T1,T2>;
			if(other == null) return false;
			return EqComparer.Default.Equals(this.Item1, other.Item1) &&
				EqComparer.Default.Equals(this.Item2, other.Item2);
		}

		public override string ToString ()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append('(')
				.Append(Item1).Append(", ")
				.Append(Item2)
				.Append(')');
			return sb.ToString();
		}

		public override int GetHashCode ()
		{
			var comparer = EqComparer.Default;
			return Tuple.CombineHashCodes(
				comparer.GetHashCode(Item1),
				comparer.GetHashCode(Item2)
			);
		}

		public int CompareTo(object obj)
		{
			if(obj == null) return 1;
			Tuple<T1,T2> other = obj as Tuple<T1,T2>;
			if(other == null)
				throw new ArgumentException("Argument type invalid", "obj");
			int c = 0;
			c = Comparer.Default.Compare(this.Item1, other.Item1);
			if(c != 0) return c;
			return Comparer.Default.Compare(this.Item2, other.Item2);
		}
	}

	[Serializable]
	public class Tuple<T1, T2, T3> : IComparable {

		public readonly T1 Item1;
		public readonly T2 Item2;
		public readonly T3 Item3;
		public readonly int Length = 3;


		public object this[int index] {
			get {
				switch(index) {
				case 0: return Item1;
				case 1: return Item2;
				case 2: return Item3;
				default: throw new IndexOutOfRangeException();
				}
			}
		}


		public Tuple(T1 t1, T2 t2, T3 t3)
		{
			Item1 = t1;
			Item2 = t2;
			Item3 = t3;
		}

		public override bool Equals (object obj)
		{
			if(obj == null) return false;
			Tuple<T1,T2,T3> other = obj as Tuple<T1,T2,T3>;
			if(other == null) return false;
			return EqComparer.Default.Equals(this.Item1, other.Item1) &&
				EqComparer.Default.Equals(this.Item2, other.Item2) &&
				EqComparer.Default.Equals(this.Item3, other.Item3);
		}

		public override string ToString ()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append('(')
				.Append(Item1).Append(", ")
				.Append(Item2).Append(", ")
				.Append(Item3)
				.Append(')');
			return sb.ToString();
		}

		public override int GetHashCode ()
		{
			var comparer = EqComparer.Default;
			return Tuple.CombineHashCodes(
				comparer.GetHashCode(Item1),
				comparer.GetHashCode(Item2),
				comparer.GetHashCode(Item3)
			);
		}

		public int CompareTo(object obj)
		{
			if(obj == null) return 1;
			Tuple<T1,T2,T3> other = obj as Tuple<T1,T2,T3>;
			if(other == null)
				throw new ArgumentException("Argument type invalid", "obj");
			int c = 0;
			c = Comparer.Default.Compare(this.Item1, other.Item1);
			if(c != 0) return c;
			c = Comparer.Default.Compare(this.Item2, other.Item2);
			if(c != 0) return c;
			return Comparer.Default.Compare(this.Item3, other.Item3);
		}
	}
}