using System;
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
			CleanUpFiles();

			AssetDatabase.Refresh();
		}

		private void RenameDirectories(string rootPath)
		{
			foreach (string directory in Directory.GetDirectories(rootPath, $"*{currentName}*", SearchOption.AllDirectories))
			{
				try
				{
					if (Directory.Exists(directory) == false)
					{
						continue;
					}

					string newDirectoryPath = directory.Replace(currentName, newName);
					Directory.Move(directory, newDirectoryPath);
					RenameDirectories(newDirectoryPath);
				}
				catch (Exception ex)
				{
					Debug.LogError($"Error while renaming directory {directory}: {ex.Message}");
				}
			}
		}

		private void RenameFiles(string rootPath)
		{
			foreach (string filePath in Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories))
			{
				try
				{
					string currentPath = filePath;
					if (filePath.Contains(currentName))
					{
						currentPath = filePath.Replace(currentName, newName);
						File.Move(filePath, currentPath);
					}

					// Change names in file content - namespaces, etc.
					string extension = Path.GetExtension(currentPath);
					if (extension.Equals(".cs") || extension.Equals(".asmdef"))
					{
						string content = File.ReadAllText(currentPath);
						content = content.Replace(currentName, newName);
						File.WriteAllText(currentPath, content);
					}
				}
				catch (Exception ex)
				{
					Debug.LogError($"Error while renaming file {filePath}: {ex.Message}");
				}
			}
		}

		private void CleanUpFiles()
		{
			try
			{
				File.Delete(Path.Combine(Application.dataPath, $"{currentName}.meta"));
				if (shouldDestroySelf)
				{
					Directory.Delete(Path.Combine(Application.dataPath, newName, "Code", "Editor", "Configurator"),
									 true);
				}
			}
			catch (Exception ex)
			{
				Debug.LogError($"Error while cleaning up files: {ex.Message}");
			}
		}
	}
}