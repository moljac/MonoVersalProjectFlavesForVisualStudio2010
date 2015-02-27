using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell.Flavor;
using Microsoft.Win32;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;

namespace HolisticWare.MonoVersalFlave2010
{
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid(PackageProjectGuid)]
	public class XamarinIOSUnifiedFlavePackageProject : FlavoredProjectBase
	{
		// To initialize GUID in Attribute (above)
		private const string PackageProjectGuid = XamarinIOSUnifiedProject.Guid;

		private MonoVersalProjectFlavesForVisualStudio2010 package;

		public XamarinIOSUnifiedFlavePackageProject(MonoVersalProjectFlavesForVisualStudio2010 package)
		{
			this.package = package;
		}

		protected override void SetInnerProject(IntPtr innerIUnknown)
		{
			if (base.serviceProvider == null)
			{
				base.serviceProvider = this.package;
			}

			base.SetInnerProject(innerIUnknown);
		}

	}
}
