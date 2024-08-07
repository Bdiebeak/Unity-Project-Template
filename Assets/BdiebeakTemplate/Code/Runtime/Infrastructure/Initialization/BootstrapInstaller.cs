using Zenject;

namespace BdiebeakTemplate.Code.Runtime.Infrastructure.Initialization
{
	public class BootstrapInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			// Binding some bootstrap installers and flows.
			Container.BindInterfacesAndSelfTo<BootstrapFlow>().AsSingle().NonLazy();
		}
	}
}