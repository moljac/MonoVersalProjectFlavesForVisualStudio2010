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
	/// <summary>
	/// This is the class that implements the package exposed by this assembly.
	///
	/// The minimum requirement for a class to be considered a valid package for Visual Studio
	/// is to implement the IVsPackage interface and register itself with the shell.
	/// This package uses the helper classes defined inside the Managed Package Framework (MPF)
	/// to do it: it derives from the Package class that provides the implementation of the 
	/// IVsPackage interface and uses the registration attributes defined in the framework to 
	/// register itself and its components with the shell.
	/// </summary>
	// This attribute tells the PkgDef creation utility (CreatePkgDef.exe) that this class is
	// a package.

	// TODO: mc++ here to add new project type classes
	[ProvideProjectFactory
		(
		  typeof(MonoTouchFlavorProjectFactory)
		, "MonoTouch Flavor"
		, "Mono Files (*.csproj);*.csproj"
		, null			// default project extension
		, null			// possible project extension
		, null			// project templates directory
		)
	]
	[ProvideProjectFactory
		(
		  typeof(MonoTouch5FlavorProjectFactory)
		, "MonoTouch5 Flavor"
		, "Mono Files (*.csproj);*.csproj"
		, null			// default project extension
		, null			// possible project extension
		, null			// project templates directory
		)
	]
	[ProvideProjectFactory
		(
		  typeof(MonoMacFlavorProjectFactory)
		, "MonoMac Flavor"
		, "Mono Files (*.csproj);*.csproj"
		, null			// default project extension
		, null			// possible project extension
		, null			// project templates directory
		)
	]
	[ProvideProjectFactory
		(
		  typeof(MonoTouch5BindingFlavorProjectFactory)
		, "MonoTouch Binding Flavor"
		, "Mono Files (*.csproj);*.csproj"
		, null			// default project extension
		, null			// possible project extension
		, null			// project templates directory
		)
	]
	[ProvideProjectFactory
		(
		  typeof(CompactFrameworkSmartDeviceFlavorProjectFactory)
		, "CF Smart Device Flavor"
		, "CF Files (*.csproj);*.csproj"
		, null			// default project extension
		, null			// possible project extension
		, null			// project templates directory
		)
	]
	[ProvideProjectFactory
		(
		  typeof(PortableClassLibraryProjectFactory)
		, "Portable Class Library Flavor"
		, "Portable Class Library Files (*.csproj);*.csproj"
		, null			// default project extension
		, null			// possible project extension
		, null			// project templates directory
		)
	]
	[PackageRegistration(UseManagedResourcesOnly = true)]
	// This attribute is used to register the informations needed to show the this package
	// in the Help/About dialog of Visual Studio.
	[InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
	[Guid(GuidList.guidMonoFlave2010PkgString)]
	// mc++ [Guid(GuidList.List["guidMonoFlave2010PkgString"])] //  must be constant
	public sealed class MonoVersalProjectFlavesForVisualStudio2010 : Package
	{
		/// <summary>
		/// Default constructor of the package.
		/// Inside this method you can place any initialization code that does not require 
		/// any Visual Studio service because at this point the package object is created but 
		/// not sited yet inside Visual Studio environment. The place to do all the other 
		/// initialization is the Initialize method.
		/// </summary>
		public MonoVersalProjectFlavesForVisualStudio2010()
		{
			Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering constructor for: {0}", this.ToString()));
		}



		/////////////////////////////////////////////////////////////////////////////
		// Overriden Package Implementation
		#region Package Members

		/// <summary>
		/// Initialization of the package; this method is called right after the package is sited, so this is the place
		/// where you can put all the initilaization code that rely on services provided by VisualStudio.
		/// </summary>
		protected override void Initialize()
		{
			// TODO: here to add new GUIDs
			Trace.WriteLine (string.Format(CultureInfo.CurrentCulture, "Entering Initialize() of: {0}", this.ToString()));
			this.RegisterProjectFactory(new MonoTouchFlavorProjectFactory(this));
			this.RegisterProjectFactory(new MonoTouch5FlavorProjectFactory(this));
			this.RegisterProjectFactory(new MonoMacFlavorProjectFactory(this));

			// new project by moljac++
			this.RegisterProjectFactory(new MonoTouch5BindingFlavorProjectFactory(this));
			this.RegisterProjectFactory(new CompactFrameworkSmartDeviceFlavorProjectFactory(this));
			this.RegisterProjectFactory(new PortableClassLibraryProjectFactory(this));

			base.Initialize();

		}
		#endregion

	}






}
