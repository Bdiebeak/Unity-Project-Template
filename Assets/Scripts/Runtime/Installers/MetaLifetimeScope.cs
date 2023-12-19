using ProjectName.Runtime.Infrastructure;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;
using VContainer.Unity;

namespace ProjectName.Runtime.Installers
{
	public class MetaLifetimeScope : LifetimeScope
	{
		protected override void Configure(IContainerBuilder builder)
		{
			Debug.Log($"{nameof(MetaLifetimeScope)} Configure");
			SceneManager.LoadScene(SceneConstants.Core);
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			Debug.Log($"{nameof(MetaLifetimeScope)} Disposed");
		}
	}
}