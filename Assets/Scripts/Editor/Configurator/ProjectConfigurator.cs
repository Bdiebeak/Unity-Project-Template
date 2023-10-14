using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace ProjectName.Editor.Configurator
{
	public class ProjectConfigurator
	{
		private const string ProjectName = "_ProjectName";
		
		[MenuItem("Configurator/Get Folders")]
		public static string[] GetFolders()
		{
			return Directory.GetDirectories(Application.dataPath);
		}

		// TODO: move project files into separate folder
		// - use prefix "_"
		[MenuItem("Configurator/Separate Folders")]
		public static void SeparateFolders()
		{
			string projectFolderPath = Path.Combine(Application.dataPath, ProjectName);
			Directory.CreateDirectory(projectFolderPath);

			// TODO: Move only selected paths into project's folder.
			string[] folderPaths = GetFolders();
			foreach (string folderPath in folderPaths)
			{
				string folderName = folderPath.Split(Path.DirectorySeparatorChar).Last();
				if (string.Equals(folderName, ProjectName))
				{
					// Don't try to move directory into itself.
					continue;
				}
				Directory.Move(folderPath, Path.Combine(projectFolderPath, folderName));
				File.Delete($"{folderPath}.meta");
			}
			AssetDatabase.Refresh();
		}

		// TODO: change all ProjectName
		// - namespaces
		// - assemblies
	}
}