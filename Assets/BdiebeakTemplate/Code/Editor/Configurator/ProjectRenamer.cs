using System.IO;
using UnityEditor;
using UnityEngine;

namespace BdiebeakTemplate.Code.Editor.Configurator
{
	public class ProjectRenamer
	{
		public string currentName = "BdiebeakTemplate";
		public string newName = "NewProject";
		public bool shouldDestroySelf;

		public void RenameProject()
		{
			RenameDirectories(Application.dataPath);
			RenameFiles(Path.Combine(Application.dataPath, newName));
			File.Delete(Path.Combine(Application.dataPath, $"{currentName}.meta"));
			if (shouldDestroySelf)
			{
				Directory.Delete(Path.Combine(Application.dataPath, newName, "Code", "Editor", "Configurator"), true);
			}

			AssetDatabase.Refresh();
		}

		private void RenameDirectories(string rootPath)
		{
			string[] directories = Directory.GetDirectories(rootPath, $"*{currentName}*", SearchOption.AllDirectories);
			foreach (string directory in directories)
			{
				if (Directory.Exists(directory) == false)
				{
					continue;
				}

				if (directory.Contains(currentName))
				{
					string newDirectoryPath = directory.Replace(currentName, newName);
					Directory.Move(directory, newDirectoryPath);
					RenameDirectories(newDirectoryPath);
				}
			}
		}

		private void RenameFiles(string rootPath)
		{
			foreach (string filePath in Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories))
			{
				string currentPath = filePath;
				if (filePath.Contains(currentName))
				{
					currentPath = filePath.Replace(currentName, newName);
					File.Move(filePath, currentPath);
				}

				string extension = Path.GetExtension(currentPath);
				if (extension.Equals(".cs") || extension.Equals(".asmdef"))
				{
					string content = File.ReadAllText(currentPath);
					content = content.Replace(currentName, newName);
					File.WriteAllText(currentPath, content);
				}
			}
		}
	}
}