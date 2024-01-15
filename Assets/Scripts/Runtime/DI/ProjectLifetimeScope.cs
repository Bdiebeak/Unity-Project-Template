using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ProjectName.Runtime.DI
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
			// Here should be:
			// 1) Initialization of global services which are used across project (LogService and etc.);
			// 2) Initialization and starting of ProjectFlow;

			Debug.Log($"{nameof(ProjectLifetimeScope)} Configure");
			builder.RegisterEntryPoint<ProjectFlow>();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			Debug.Log($"{nameof(ProjectLifetimeScope)} Disposed");
		}
	}
}