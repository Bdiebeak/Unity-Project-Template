using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;
using VContainer.Unity;

namespace ProjectName.Runtime.Installers
{
	public class BootstrapLifetimeScope : LifetimeScope
	{
		protected override void Configure(IContainerBuilder builder)
		{
			Debug.Log("Bootstrap Configure");
			SceneManager.LoadScene(SceneConstants.Meta);
		}
	}
}