using Zenject;

namespace ProjectName.Runtime.Initialization
{
	public class ProjectInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			// Binding some global project installers, flows and logic.
			// It should be global part of application, which is used from different modules.
			Container.BindInterfacesAndSelfTo<ProjectFlow>().AsSingle().NonLazy();
		}
	}
}