using System;
using ProjectName.Runtime.Infrastructure;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace ProjectName.Runtime.DI
{
	public class BootstrapFlow : IInitializable, IDisposable
	{
		public void Initialize()
		{
			// It can be async to wait some loading.
			// Here should be:
			// 1) Loading of some global data (configs and etc.);
			// 2) Execution of some actions which are required to continue project flow (load next scene);
			Debug.Log($"{nameof(BootstrapFlow)}.{nameof(Initialize)}");
			SceneManager.LoadScene(SceneConstants.Meta);
		}

		public void Dispose()
		{
			Debug.Log($"{nameof(BootstrapFlow)}.{nameof(Dispose)}");
		}
	}
}