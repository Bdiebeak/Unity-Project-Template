using System;
using BdiebeakTemplate.Code.Runtime.Utilities.Constants;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace BdiebeakTemplate.Code.Runtime.Infrastructure.Initialization
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