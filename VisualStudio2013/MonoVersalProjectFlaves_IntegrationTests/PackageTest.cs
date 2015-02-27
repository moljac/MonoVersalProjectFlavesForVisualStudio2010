using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Microsoft.VSSDK.Tools.VsIdeTesting;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Shell;
using EnvDTE;

namespace MonoFlave2010_IntegrationTests
{
	/// <summary>
	/// Integration test for package validation
	/// </summary>
	[TestClass]
	public class PackageTest
	{
		private delegate void ThreadInvoker();

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		[TestMethod]
		[HostType("VS IDE")]
		public void PackageLoadTest()
		{
			UIThreadInvoker.Invoke(
				(ThreadInvoker)
				delegate()
			{

				//Get the Shell Service
				IVsShell shellService = VsIdeTestHostContext.ServiceProvider.GetService(typeof(SVsShell)) as IVsShell;
				Assert.IsNotNull(shellService);

				//Validate package load
				IVsPackage package;
				Guid packageGuid = new Guid(HolisticWare.MonoVersalFlave2010.GuidList.guidMonoFlave2010PkgString);
				Assert.IsTrue(0 == shellService.LoadPackage(ref packageGuid, out package));
				Assert.IsNotNull(package, "Package failed to load");


				// mc++  added
				Dictionary<string, string> List = List = new Dictionary<string, string>();



				List.Add("guidMonoFlave2010PkgString","04cd35f2-1f09-4ef9-b7f7-577761e322ab");
				List.Add("guidMonoFlave2010CmdSetString","04cd35f2-1f09-4ef9-b7f7-577761e322ab");
				List.Add("Compact Framework, Smart Device", "4D628B5B-2FBC-4AA6-8C16-197242AEB884");
 
				foreach(KeyValuePair<string, string> kvp in List)
				{
					Guid pckg_guid =  new Guid(kvp.Value);

					int pckg_id = shellService.LoadPackage(ref packageGuid, out package);
					Assert.IsTrue(0 == pckg_id);
					Assert.IsNotNull(package, "Package {0} failed to load", kvp.Key);

					//package.
				}
			}
			);

			return;
		}
	}
}
