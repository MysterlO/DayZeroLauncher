﻿namespace Dotjosh.DayZCommander.Ui.ServerList
{
	public class ServerListViewModel : ViewModelBase
	{
		public ServerListViewModel()
		{
			Title = "servers";

			FiltersViewModel = new FiltersViewModel();
			ListViewModel = new ListViewModel();

			FiltersViewModel.PublishFilter();
		}

		public FiltersViewModel FiltersViewModel { get; set; }
		public ListViewModel ListViewModel { get; set; }
	}
}