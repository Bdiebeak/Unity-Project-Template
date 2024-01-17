using System;
using UnityEngine;
using Zenject;

namespace ProjectName.Runtime.DI
{
	public class CoreFlow : IInitializable, IDisposable
	{
		public void Initialize()
		{
			Debug.Log($"{nameof(CoreFlow)}.{nameof(Initialize)}");
		}

		public void Dispose()
		{
			Debug.Log($"{nameof(CoreFlow)}.{nameof(Dispose)}");
		}
	}
}