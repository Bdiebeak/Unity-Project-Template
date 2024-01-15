using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ProjectName.Runtime.DI
{
	public class CoreLifetimeScope : LifetimeScope
	{
		protected override void Configure(IContainerBuilder builder)
		{
			Debug.Log($"{nameof(CoreLifetimeScope)} Configure");
			builder.RegisterEntryPoint<CoreFlow>();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			Debug.Log($"{nameof(CoreLifetimeScope)} Disposed");
		}
	}
}