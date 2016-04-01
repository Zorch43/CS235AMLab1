using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloM4A
{
	[Activity (Label = "HelloM4A", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);

			var aButton = FindViewById<Button> (Resource.Id.aButton);
			var aLabel = FindViewById<TextView> (Resource.Id.helloLabel);
			var resetButton = FindViewById<Button> (Resource.Id.resetButton);

			aButton.Click += (sender, e) => {
				aLabel.Text = "Hello from the button";
			};

			resetButton.Click += (sender, e) => {
				aLabel.SetText(Resource.String.helloLabelText);
			};

		}
	}
}


