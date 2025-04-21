using CliWrap;

namespace Devantler.ArgoCDCLI.Tests.ArgoCDTests;

/// <summary>
/// Tests for the <see cref="ArgoCD.RunAsync(string[], CommandResultValidation, bool, bool, CancellationToken)" /> method.
/// </summary>
public class RunAsyncTests
{
  /// <summary>
  /// Tests that the binary can return the version of the argocd CLI command.
  /// </summary>
  /// <returns></returns>
  [Fact]
  public async Task RunAsync_Version_ReturnsVersion()
  {
    // Act
    var (exitCode, output) = await ArgoCD.RunAsync(["version", "--client"]);

    // Assert
    Assert.Equal(0, exitCode);
    // argocd: v2.14.9+3b308d6.dirty
    Assert.Matches(@"^argocd: v\d+\.\d+\.\d+\+\w+$", output.Split("\n").First());
  }
}
