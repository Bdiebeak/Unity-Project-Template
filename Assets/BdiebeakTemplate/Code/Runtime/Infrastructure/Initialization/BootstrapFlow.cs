using System;
using BdiebeakTemplate.Code.Runtime.Utilities.Constants;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace BdiebeakTemplate.Code.Runtime.Infrastructure.Initialization
{
	public class BootstrapFlow : IInitializable, IDisposable
	{
		public void Initialize()
		{
			// It can be async to wait some logic.
			// Here should be:
			// 1) Loading of some global data (configs, etc.);
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