﻿using Grabacr07.KanColleWrapper;
using Livet;

namespace Grabacr07.KanColleViewer.ViewModels.Contents
{
	public class MaterialsViewModel : ViewModel
	{
		public Materials Model { get; private set; }

		public MaterialsViewModel()
		{
			this.Model = KanColleClient.Current.Homeport.Materials;
		}
	}
}
