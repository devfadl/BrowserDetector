﻿using Shyjus.BrowserDetector;
using Shyjus.BrowserDetector.Browsers;
using Shyjus.BrowserDetector.Tests;
using Xunit;

namespace BrowserDetector.Tests
{
    public class FirefoxTests
    {

        [Fact]
        public void Firefox_Windows_Desktop()
        {
            var isFireFox = Firefox.TryParse(UserAgents.Firefox_Windows, out var firefox);

            Assert.True(isFireFox);
            Assert.Equal(DeviceTypes.Desktop, firefox.DeviceType);
            Assert.Equal(OperatingSystems.Windows, firefox.OS);
        }

        [Fact]
        public void Firefox_OSX_Desktop()
        {
            var isFireFox = Firefox.TryParse(UserAgents.Firefox_OSX, out var firefox);

            Assert.True(isFireFox);
            Assert.Equal(DeviceTypes.Desktop, firefox.DeviceType);
            Assert.Equal(OperatingSystems.MacOSX, firefox.OS);
        }

        [Fact]
        public void Firefox_IOS_iPhone()
        {
            var isFireFox = Firefox.TryParse(UserAgents.Firefox_IPhone, out var firefox);

            Assert.True(isFireFox);
            Assert.Equal(DeviceTypes.Mobile, firefox.DeviceType);
            Assert.Equal(OperatingSystems.IOS, firefox.OS);
        }

        [Fact]
        public void Firefox_IOS_iPad()
        {
            var isFireFox = Firefox.TryParse(UserAgents.Firefox_IPad, out var firefox);

            Assert.True(isFireFox);
            Assert.Equal(DeviceTypes.Tablet, firefox.DeviceType);
            Assert.Equal(OperatingSystems.IOS, firefox.OS);
        }

        // This needs a special check. So let's create a sesperate FireFox version

        //[Fact]
        //public void Firefox_GalaxyTabS4()
        //{
        //    var isFireFox = Firefox.TryParse(UserAgents.Firefox_GalaxyTabS4, out var firefox);

        //    Assert.True(isFireFox);
        //    Assert.Equal(DeviceTypes.Desktop, firefox.DeviceType);
        //    Assert.Equal(OperatingSystems.Android, firefox.OS);
        //}
    }
}