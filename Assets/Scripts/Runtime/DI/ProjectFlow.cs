using ProjectName.Runtime.Infrastructure;
using UnityEngine.SceneManagement;
using VContainer.Unity;

namespace ProjectName.Runtime.DI
{
	public class ProjectFlow : IStartable
	{
		public async void Start()
		{
			// It can be async to wait some loading.
			// Here should be:
			// 1) Loading of some global data (configs and etc.);
			// 2) Execution of some actions which are required to continue project flow (load next scene);

			SceneManager.LoadScene(SceneConstants.Meta);
		}
	}
}