using Zenject;

namespace ProjectName.Runtime.Initialization
{
	public class ProjectInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.BindInterfacesAndSelfTo<ProjectFlow>().AsSingle().NonLazy();
		}
	}
}