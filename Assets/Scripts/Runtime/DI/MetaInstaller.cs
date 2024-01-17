using Zenject;

namespace ProjectName.Runtime.DI
{
    public class MetaInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MetaFlow>().AsSingle().NonLazy();
        }
    }
}