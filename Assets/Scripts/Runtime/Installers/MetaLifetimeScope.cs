using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;
using VContainer.Unity;

namespace ProjectName.Runtime.Installers
{
    public class MetaLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
			Debug.Log("Meta Configure");
			SceneManager.LoadScene(SceneConstants.Game);
        }
    }
}
