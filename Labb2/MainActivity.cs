﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Labb2
{
	[Activity (Label = "Labb2", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			Button newEntry = FindViewById<Button> (Resource.Id.newEntry);
			newEntry.Click += delegate {
				Intent iNewEntry = new Intent (this, typeof(NewEntryActivity));
				StartActivity (iNewEntry);
			};

			Button showAllEntries = FindViewById<Button> (Resource.Id.showAllEntries);
			showAllEntries.Click += delegate {
				Intent iShowEntry = new Intent (this, typeof(ShowAllEntriesActivity));
				StartActivity (iShowEntry);
			};

			Button createReport = FindViewById<Button> (Resource.Id.createReport);
			createReport.Click += delegate {
				Intent iCreateReport = new Intent (this, typeof(CreateReportsActivity));
				StartActivity (iCreateReport);
			};
		}
	}
}


