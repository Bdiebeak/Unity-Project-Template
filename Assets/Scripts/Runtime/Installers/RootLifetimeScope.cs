using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ProjectName.Runtime.Installers
{
	public class RootLifetimeScope : LifetimeScope
	{
		protected override void Awake()
		{
			IsRoot = true;
			DontDestroyOnLoad(this);
			base.Awake();
		}

		protected override void Configure(IContainerBuilder builder)
		{
			Debug.Log("Root Configure");
		}
	}
}