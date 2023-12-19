using ProjectName.Runtime.Infrastructure;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;
using VContainer.Unity;

namespace ProjectName.Runtime.Installers
{
	public class ProjectLifetimeScope : LifetimeScope
	{
		protected override void Awake()
		{
			IsRoot = true;
			DontDestroyOnLoad(this);
			base.Awake();
		}

		protected override void Configure(IContainerBuilder builder)
		{
			Debug.Log($"{nameof(ProjectLifetimeScope)} Configure");
			SceneManager.LoadScene(SceneConstants.Meta);
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			Debug.Log($"{nameof(ProjectLifetimeScope)} Disposed");
		}
	}
}