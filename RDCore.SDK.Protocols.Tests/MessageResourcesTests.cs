using System.Globalization;
using System.Resources;
using RDCore.SDK.Assistant;
using RDCore.SDK.Client;
using RDCore.SDK.Platform;

namespace RDCore.Tests;

/// <summary>
/// The messages of the package are found in its assembly, in English and in French: a resource class looks its strings up by the name the
/// assembly embeds them under.
/// </summary>
[TestClass]
public sealed class MessageResourcesTests
{
    private static IEnumerable<object[]> Managers() =>
    [
        [nameof(McpMessages), McpMessages.ResourceManager],
        [nameof(LaunchMessages), LaunchMessages.ResourceManager],
        [nameof(PlatformMessages), PlatformMessages.ResourceManager],
    ];

    [TestMethod]
    [DynamicData(nameof(Managers))]
    public void TheMessages_AreFoundInEnglish(string name, ResourceManager manager)
    {
        var messages = manager.GetResourceSet(CultureInfo.InvariantCulture, createIfNotExists: true, tryParents: false);

        Assert.IsNotNull(messages, name);
        Assert.IsTrue(messages.Cast<object>().Any(), name);
    }

    [TestMethod]
    [DynamicData(nameof(Managers))]
    public void TheMessages_AreFoundInFrench(string name, ResourceManager manager)
    {
        var messages = manager.GetResourceSet(CultureInfo.GetCultureInfo("fr"), createIfNotExists: true, tryParents: false);

        Assert.IsNotNull(messages, name);
        Assert.IsTrue(messages.Cast<object>().Any(), name);
    }
}
