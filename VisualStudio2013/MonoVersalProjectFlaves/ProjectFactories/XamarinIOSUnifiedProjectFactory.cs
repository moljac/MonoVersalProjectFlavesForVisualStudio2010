﻿using System;
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
	[Guid(PackageProjectGuid)]
	public class XamarinIOSUnifiedFlavorProjectFactory : FlavoredProjectFactoryBase
	{
		// To initialize GUID in Attribute (above)
		private const string PackageProjectGuid = XamarinIOSUnifiedProject.Guid;

		private MonoVersalProjectFlavesForVisualStudio2010 package;

		public XamarinIOSUnifiedFlavorProjectFactory(MonoVersalProjectFlavesForVisualStudio2010 package)
			: base()
		{
			this.package = package;
		}

		protected override object PreCreateForOuter(IntPtr outerProjectIUnknown)
		{
			return new XamarinIOSUnifiedFlavorProjectFactory(this.package);
		}
	}

}
