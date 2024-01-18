using Zenject;

namespace ProjectName.Runtime.Initialization
{
	public class MetaInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.BindInterfacesAndSelfTo<MetaFlow>().AsSingle().NonLazy();
		}
	}
}