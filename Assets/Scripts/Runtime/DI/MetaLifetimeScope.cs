using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ProjectName.Runtime.DI
{
	public class MetaLifetimeScope : LifetimeScope
	{
		protected override void Configure(IContainerBuilder builder)
		{
			Debug.Log($"{nameof(MetaLifetimeScope)} Configure");
			builder.RegisterEntryPoint<MetaFlow>();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			Debug.Log($"{nameof(MetaLifetimeScope)} Disposed");
		}
	}
}