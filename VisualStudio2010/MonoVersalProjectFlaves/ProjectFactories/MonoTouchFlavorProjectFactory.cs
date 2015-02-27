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
	[ComVisible(false)]
	[Guid(MonoProjectFactoryGuid)]
	public class MonoTouchFlavorProjectFactory : FlavoredProjectFactoryBase
	{
		// To initialize GUID in Attribute (above)
		private const string PackageProjectGuid = MonoTouchProject.Guid;

		// ?????
		private const string MonoProjectFactoryGuid = "E613F3A2-FE9C-494F-B74E-F63BCB86FEA6";

		private MonoVersalProjectFlavesForVisualStudio2010 package;

		public MonoTouchFlavorProjectFactory(MonoVersalProjectFlavesForVisualStudio2010 package)
			: base()
		{
			this.package = package;
		}

		protected override object PreCreateForOuter(IntPtr outerProjectIUnknown)
		{
			return new MonoTouchFlavePackageProject(this.package);
		}
	}

}
