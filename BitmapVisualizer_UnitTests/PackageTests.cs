using System;
using System.Collections;
using System.Text;
using System.Reflection;
using Microsoft.VsSDK.UnitTestLibrary;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MMaitre.BitmapVisualizer;

namespace BitmapVisualizer_UnitTests
{
    [TestClass]
    public class PackageTests
    {
        [TestMethod]
        public void Package_CreateInstance()
        {
            BitmapVisualizerPackage package = new BitmapVisualizerPackage();
        }

        [TestMethod]
        public void Package_IsIVsPackage()
        {
            BitmapVisualizerPackage package = new BitmapVisualizerPackage();
            Assert.IsNotNull(package as IVsPackage, "The object does not implement IVsPackage");
        }

        [TestMethod]
        public void Package_SetSite()
        {
            // Create the package
            IVsPackage package = new BitmapVisualizerPackage() as IVsPackage;
            Assert.IsNotNull(package, "The object does not implement IVsPackage");

            // Create a basic service provider
            OleServiceProvider serviceProvider = OleServiceProvider.CreateOleServiceProviderWithBasicServices();

            BaseMock activityLogMock =
                new GenericMockFactory(
                    "MockVsActivityLog",
                    new[] { typeof(IVsActivityLog) }
                    ).GetInstance();

            serviceProvider.AddService(
                typeof(SVsActivityLog),
                activityLogMock,
                true);

            // Site the package
            Assert.AreEqual(0, package.SetSite(serviceProvider), "SetSite did not return S_OK");

            // Unsite the package
            Assert.AreEqual(0, package.SetSite(null), "SetSite(null) did not return S_OK");
        }
    }
}
