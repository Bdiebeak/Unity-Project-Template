using Zenject;

namespace ProjectName.Runtime.DI
{
    public class CoreInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<CoreFlow>().AsSingle().NonLazy();
        }
    }
}