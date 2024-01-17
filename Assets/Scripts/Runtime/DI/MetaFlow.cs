using System;
using ProjectName.Runtime.Infrastructure;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace ProjectName.Runtime.DI
{
	public class MetaFlow : IInitializable, IDisposable
	{
		public void Initialize()
		{
			Debug.Log($"{nameof(MetaFlow)}.{nameof(Initialize)}");
			SceneManager.LoadScene(SceneConstants.Core);
		}

		public void Dispose()
		{
			Debug.Log($"{nameof(MetaFlow)}.{nameof(Dispose)}");
		}
	}
}