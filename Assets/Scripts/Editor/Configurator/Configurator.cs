using System.IO;
using UnityEditor;
using UnityEngine;

namespace UPT.Editor.Configurator
{
	// TODO:
	// 1. Change project name tool
	// 2. Separate project folder tool
	// 3. Create required folders tool
	public class Configurator
	{
		private const string ProjectName = "ProjectName";
		private const string NewName = "TestProject";
		private const string Regex = @"(namespace((\s)+)((.)*)(ProjectName)(\s|(\.))+)";

		[MenuItem("Configurator/Rename Project")]
		public static void RenameProject()
		{
			// TODO: separate function
			// Rename TestProject in .cs files.
			string[] scriptFiles = Directory.GetFiles(Application.dataPath, "*.cs", SearchOption.AllDirectories);
			foreach (string scriptFile in scriptFiles)
			{
				// Skip scripts which are inside Plugins folder.
				string fullPath = Path.GetFullPath(scriptFile);
				if (fullPath.Contains("\\Plugins\\"))
				{
					continue;
				}

				// TODO: separate function
				// Replace default TestProject with new one.
				string text = File.ReadAllText(scriptFile);
				if (text.Contains(ProjectName))
				{
					text = text.Replace(ProjectName, NewName);
					File.WriteAllText(scriptFile, text);
				}

				Debug.Log(Path.GetFullPath(scriptFile));
			}

			// TODO: separate function
			// Rename TestProject in .asmdef files.
			string[] assemblyFiles = Directory.GetFiles(Application.dataPath, "*.asmdef", SearchOption.AllDirectories);
			foreach (string assemblyFile in assemblyFiles)
			{
				// TODO: separate function
				// Replace default TestProject with new one.
				string text = File.ReadAllText(assemblyFile);
				if (text.Contains(ProjectName))
				{
					text = text.Replace(ProjectName, NewName);
					File.WriteAllText(assemblyFile, text);
				}

				Debug.Log(Path.GetFileName(assemblyFile));
			}
		}
	}
}