using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SimplePaymentAppUITest
{
	[TestFixture(Platform.Android)]
	public class XamarinUITests
	{
		IApp app;
		Platform platform;

		public XamarinUITests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void PayScreen()
		{

            app.Tap(c => c.Marked("Pay now"));
            app.Screenshot("Welcome screen.");

		}
	}
}
