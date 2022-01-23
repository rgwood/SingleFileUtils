using Utils;
using Xunit;

namespace SingleFileUtilsTests;

public class Tests
{
    [Theory]
    [InlineData("SingleFileUtils.EmbeddedResources.Helpers.GlobalUsings.cs", "Helpers/GlobalUsings.cs")]
    [InlineData("SingleFileUtils.EmbeddedResources.Scripts.csproj", "Scripts.csproj")]
    [InlineData("SingleFileUtils.EmbeddedResources.foo", "foo")]
    [InlineData("SingleFileUtils.EmbeddedResources.foo.txt", "foo.txt")]
    [InlineData("SingleFileUtils.EmbeddedResources.foo.bar", "foo/bar")]
    public void ResourceNameToFileNameWorks(string resourceName, string expectedFilePath)
    {
        string osIndependentFilePath = expectedFilePath.Replace('/', Path.DirectorySeparatorChar);
        Assert.Equal(osIndependentFilePath, ResourceUtils.FileNameFromResourceName(resourceName));
    }

    [Fact]
    public void CanGetTextFile()
    {
        var text = ResourceUtils.ReadTextResource("foo.txt");
        Assert.Equal("foo", text);
    }
}
