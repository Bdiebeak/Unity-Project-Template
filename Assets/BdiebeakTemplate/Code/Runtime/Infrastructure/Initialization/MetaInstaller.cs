using Zenject;

namespace BdiebeakTemplate.Code.Runtime.Infrastructure.Initialization
{
	public class MetaInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			// Binding some meta installers, flows and logic.
			// It should be meta part of application - meta logic, UI.
			Container.BindInterfacesAndSelfTo<MetaFlow>().AsSingle().NonLazy();
		}
	}
}