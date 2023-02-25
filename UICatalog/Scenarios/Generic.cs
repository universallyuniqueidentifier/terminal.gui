using System;
using Terminal.Gui;

namespace UICatalog.Scenarios {
	[ScenarioMetadata (Name: "Generic", Description: "Generic sample - A template for creating new Scenarios")]
	[ScenarioCategory ("Controls")]
	public class MyScenario : Scenario {
		public override void Init (ColorScheme colorScheme)
		{
			// The base `Scenario.Init` implementation:
			//  - Calls `Application.Init ()`
			//  - Adds a full-screen Window to Application.Top with a title
			//    that reads "Press <hotkey> to Quit". Access this Window with `this.Win`.
			//  - Sets the ColorScheme property of `this.Win` to `colorScheme`.
			// To overrride this, implement an override of `Init`.
			base.Init (colorScheme);

			// A common, alternate, implementation where `this.Win` is not used:
			//   Application.Init ();
			//   Application.Top.ColorScheme = colorScheme;
		}

		public override void Setup ()
		{
			// Put scenario code here (in a real app, this would be the code
			// that would setup the app before `Application.Run` is called`).
			// With a Scenario, after UI Catalog calls `Scenario.Setup` it calls
			// `Scenario.Run` which calls `Application.Run`.
			// Example:
			var button = new Button ("Press me!") {
				AutoSize = false,
				X = Pos.Center (),
				Y = Pos.Center (),
			};
			Win.Add (horizontalView, verticalView);
			verticalView.Text = $"最初の行{Environment.NewLine}二行目";
			//Application.Top.Redraw (Application.Top.Bounds);

		}
	}
}