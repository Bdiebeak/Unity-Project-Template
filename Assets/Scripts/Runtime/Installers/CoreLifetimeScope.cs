using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ProjectName.Runtime.Installers
{
	public class CoreLifetimeScope : LifetimeScope
	{
		protected override void Configure(IContainerBuilder builder)
		{
			Debug.Log($"{nameof(CoreLifetimeScope)} Configure");
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			Debug.Log($"{nameof(CoreLifetimeScope)} Disposed");
		}
	}
}