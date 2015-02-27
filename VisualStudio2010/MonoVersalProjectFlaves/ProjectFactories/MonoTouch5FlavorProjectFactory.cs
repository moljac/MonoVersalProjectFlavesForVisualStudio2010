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
	[Guid(MonoTouch5ProjectFactoryGuid)]
	public class MonoTouch5FlavorProjectFactory : FlavoredProjectFactoryBase
	{
		// To initialize GUID in Attribute (above)
		//private const string PackageProjectGuid = "FDB50E18-0B79-4B8F-A500-B82729B03842";

		// ??????????????????
		private const string MonoTouch5ProjectFactoryGuid = MonoTouch5Project.Guid;

		private MonoVersalProjectFlavesForVisualStudio2010 package;

		public MonoTouch5FlavorProjectFactory(MonoVersalProjectFlavesForVisualStudio2010 package)
			: base()
		{
			this.package = package;
		}

		protected override object PreCreateForOuter(IntPtr outerProjectIUnknown)
		{
			return new MonoTouch5FlavePackageProject(this.package);
		}
	}

}
