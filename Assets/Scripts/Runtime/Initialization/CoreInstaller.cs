using Zenject;

namespace ProjectName.Runtime.Initialization
{
	public class CoreInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.BindInterfacesAndSelfTo<CoreFlow>().AsSingle().NonLazy();
		}
	}
}