// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace HistamineSensor
{
	[Register ("ParameterViewController")]
	partial class ParameterViewController
	{
		[Outlet]
		AppKit.NSTextField ScanRate { get; set; }

		[Outlet]
		AppKit.NSTextField Vmax { get; set; }

		[Outlet]
		AppKit.NSTextField Vmin { get; set; }

		[Action ("StartVolt:")]
		partial void StartVolt (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ScanRate != null) {
				ScanRate.Dispose ();
				ScanRate = null;
			}

			if (Vmin != null) {
				Vmin.Dispose ();
				Vmin = null;
			}

			if (Vmax != null) {
				Vmax.Dispose ();
				Vmax = null;
			}
		}
	}
}
