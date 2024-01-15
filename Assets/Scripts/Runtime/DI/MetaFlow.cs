using ProjectName.Runtime.Infrastructure;
using UnityEngine.SceneManagement;
using VContainer.Unity;

namespace ProjectName.Runtime.DI
{
	public class MetaFlow : IStartable
	{
		public void Start()
		{
			SceneManager.LoadScene(SceneConstants.Core);
		}
	}
}