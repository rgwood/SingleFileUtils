using Utils;
using Xunit;

namespace SingleFileUtilsTests;

public class Tests
{
    [Theory]
    [InlineData("SingleFileUtils.EmbeddedResources.Helpers.GlobalUsings.cs", "Helpers/GlobalUsings.cs")]
    [InlineData("SingleFileUtils.EmbeddedResources.Scripts.csproj", "Scripts.csproj")]
    [InlineData("SingleFileUtils.EmbeddedResources.foo", "foo")]
    public void ResourceNameToFileNameWorks(string resourceName, string expectedFilePath)
    {
        string osIndependentFilePath = expectedFilePath.Replace('/', Path.DirectorySeparatorChar);
        Assert.Equal(osIndependentFilePath, ResourceUtils.FileNameFromResourceName(resourceName));
    }
}
