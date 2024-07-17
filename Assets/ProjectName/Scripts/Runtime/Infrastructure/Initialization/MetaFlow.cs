using System;
using ProjectName.Scripts.Runtime.Utilities.Constants;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace ProjectName.Scripts.Runtime.Infrastructure.Initialization
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