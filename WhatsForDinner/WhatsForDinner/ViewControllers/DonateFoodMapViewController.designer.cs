// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WhatsForDinner.ViewControllers
{
	[Register ("DonateFoodMapViewController")]
	partial class DonateFoodMapViewController
	{
		[Outlet]
		MapKit.MKMapView DonateIngredientsMapView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DonateIngredientsMapView != null) {
				DonateIngredientsMapView.Dispose ();
				DonateIngredientsMapView = null;
			}
		}
	}
}
