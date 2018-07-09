using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.Collections.Generic
{
	[Serializable]
	public sealed class WeakReference<T> : ISerializable where T : class {

		readonly WeakReference weakReference;


		public T Target {
			get { return weakReference.Target as T; }
			set { weakReference.Target = value; }
		}

		public bool IsAlive {
			get { return weakReference.IsAlive; }
		}


		public WeakReference(T target) : this(target, false) {}

		[SecuritySafeCritical]
		public WeakReference(T target, bool trackResurrection)
		{
			weakReference = new WeakReference(target, trackResurrection);
		}

		public bool TryGetValue(out T value)
		{
			value = weakReference.Target as T;
			return value != null;
		}

		public void GetObjectData (SerializationInfo info, StreamingContext context)
		{
			weakReference.GetObjectData(info, context);
		}
	}
}

