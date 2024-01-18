using Zenject;

namespace ProjectName.Runtime.Initialization
{
	public class BootstrapInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.BindInterfacesAndSelfTo<BootstrapFlow>().AsSingle().NonLazy();
		}
	}
}