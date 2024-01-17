using Zenject;

namespace ProjectName.Runtime.DI
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<BootstrapFlow>().AsSingle().NonLazy();
        }
    }
}