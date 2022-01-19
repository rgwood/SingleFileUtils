using Utils;
using Xunit;

namespace ScriptCompilerTests;

public class Tests
{
    [Theory]
    [InlineData("SingleFileUtils.EmbeddedResources.Helpers.GlobalUsings.cs", "Helpers/GlobalUsings.cs")]
    [InlineData("SingleFileUtils.EmbeddedResources.Scripts.csproj", "Scripts.csproj")]
    [InlineData("SingleFileUtils.EmbeddedResources.foo", "foo")]
    public void ResourceNameToFileNameWorks(string resourceName, string expectedFilePath)
    {
        //string resourceName = "ScriptCompiler.EmbeddedResources.Helpers.GlobalUsings.cs";
        //string expectedFilePath = "Helpers/GlobalUsings.cs";
        string osIndependentFilePath = expectedFilePath.Replace('/', Path.DirectorySeparatorChar);
        Assert.Equal(osIndependentFilePath, ResourceUtils.FileNameFromResourceName(resourceName));
    }
}
