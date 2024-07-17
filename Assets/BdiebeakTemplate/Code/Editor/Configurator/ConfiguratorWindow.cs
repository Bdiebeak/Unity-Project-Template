using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace BdiebeakTemplate.Code.Editor.Configurator
{
	public class ConfiguratorWindow : EditorWindow
	{
		private readonly ProjectRenamer _renamer = new();

		[MenuItem("Configurator/Window")]
		public static void Open()
		{
			ConfiguratorWindow window = GetWindow<ConfiguratorWindow>();
			window.minSize = new Vector2(400, 150);
			window.titleContent = new GUIContent("Configurator Window");
		}

		private void CreateGUI()
		{
			VisualElement root = rootVisualElement;

			InitializeCurrentNameField(root);
			InitializeNewNameField(root);
			InitializeShouldDestroySelfToggle(root);
			InitializeConfigureButton(root);
		}

		private void InitializeCurrentNameField(VisualElement root)
		{
			TextField currentNameField = new()
										 {
											 label = "Current Name",
											 value = _renamer.currentName
										 };
			currentNameField.RegisterCallback<ChangeEvent<string>>(OnCurrentNameChanged);
			root.Add(currentNameField);
		}

		private void InitializeNewNameField(VisualElement root)
		{
			TextField newNameField = new()
									 {
										 label = "New Name",
										 value = _renamer.newName
									 };
			newNameField.RegisterCallback<ChangeEvent<string>>(OnNewNameChanged);
			root.Add(newNameField);
		}

		private void InitializeShouldDestroySelfToggle(VisualElement root)
		{
			Toggle toggle = new()
							{
								label = "Remove extra",
								tooltip = "Will remove this configurator and editor class, after configuration",
								value = _renamer.shouldDestroySelf
							};
			toggle.RegisterCallback<ChangeEvent<bool>>(OnDestroyToggleChanged);
			root.Add(toggle);
		}

		private void InitializeConfigureButton(VisualElement root)
		{
			Button button = new()
							{
								text = "Configure"
							};
			button.clicked += OnConfigureClicked;
			root.Add(button);
		}

		private void OnCurrentNameChanged(ChangeEvent<string> evt)
		{
			_renamer.currentName = evt.newValue;
		}

		private void OnNewNameChanged(ChangeEvent<string> evt)
		{
			_renamer.newName = evt.newValue;
		}

		private void OnDestroyToggleChanged(ChangeEvent<bool> evt)
		{
			_renamer.shouldDestroySelf = evt.newValue;
		}

		private void OnConfigureClicked()
		{
			_renamer.RenameProject();
			Close();
		}
	}
}