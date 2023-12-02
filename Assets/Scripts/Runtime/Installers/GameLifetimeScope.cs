using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ProjectName.Runtime.Installers
{
	public class GameLifetimeScope : LifetimeScope
	{
		protected override void Configure(IContainerBuilder builder)
		{
			Debug.Log("Game Configure");
		}
	}
}