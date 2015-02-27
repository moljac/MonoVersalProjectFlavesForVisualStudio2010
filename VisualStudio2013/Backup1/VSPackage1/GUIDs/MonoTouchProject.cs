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
	public class MonoTouchProject
	{
		// From Project File
		// To initialize GUID in Attribute (above)
		public const string Guid = "E613F3A2-FE9C-494F-B74E-F63BCB86FEA6";  
		
		// found in Jamie Bryant's
		// private const string MonoProjectFactoryGuid = "E613F3A2-FE9C-494F-B74E-F63BCB86FEA6";
	}
}
