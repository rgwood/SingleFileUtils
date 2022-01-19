using Utils;
using Xunit;

namespace SingleFileUtilsTests;

public class SystemdTests
{
    [Theory]
    [InlineData("", null)]
    [InlineData("/root/exename", "root")]
    [InlineData("asdf", null)]
    [InlineData("/asdf", null)]
    [InlineData("/home", null)]
    [InlineData("/home/", null)]
    [InlineData("/home/pi/exename", "pi")]
    public void CanGetUserFromPath(string path, string? expectedUser)
    {
        Assert.Equal(expectedUser, Systemd.TryGetUserFromPath(path));
    }
}