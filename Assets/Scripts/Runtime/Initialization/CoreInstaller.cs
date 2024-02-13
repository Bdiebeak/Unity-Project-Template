using Zenject;

namespace ProjectName.Runtime.Initialization
{
	public class CoreInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			// Binding some core installers, flows and logic.
			// It should be core part of application - gameplay logic and etc.
			Container.BindInterfacesAndSelfTo<CoreFlow>().AsSingle().NonLazy();
		}
	}
}