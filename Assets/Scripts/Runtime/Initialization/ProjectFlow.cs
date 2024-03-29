﻿using System;
using UnityEngine;
using Zenject;

namespace ProjectName.Runtime.Initialization
{
	public class ProjectFlow : IInitializable, IDisposable
	{
		public void Initialize()
		{
			Debug.Log($"{nameof(ProjectFlow)}.{nameof(Initialize)}");
		}

		public void Dispose()
		{
			Debug.Log($"{nameof(ProjectFlow)}.{nameof(Dispose)}");
		}
	}
}