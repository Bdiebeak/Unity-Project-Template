using Zenject;

namespace ProjectName.Runtime.DI
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ProjectFlow>().AsSingle().NonLazy();
        }
    }
}