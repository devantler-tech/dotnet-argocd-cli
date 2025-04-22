using System.Runtime.InteropServices;

namespace Devantler.ArgoCDCLI.Tests.ArgoCDTests;

/// <summary>
/// Tests for the <see cref="ArgoCD.GetCommand(PlatformID?, Architecture?, string?)"/> method.
/// </summary>
public class GetCommandTests
{
  /// <summary>
  /// Test to verify that the command returns the correct binary for MacOS on x64 architecture.
  /// </summary>
  [Fact]
  public void GetCommand_ShouldReturnOSXx64Binary()
  {
    {
      // Arrange
      string expectedBinary = "argocd-osx-x64";

      // Act
      string actualBinary = Path.GetFileName(ArgoCD.GetCommand(PlatformID.Unix, Architecture.X64, "osx-x64").TargetFilePath);

      // Assert
      Assert.Equal(expectedBinary, actualBinary);
    }
  }

  /// <summary>
  /// Test to verify that the command returns the correct binary for Linux on x64 architecture.
  /// </summary>
  [Fact]
  public void GetCommand_ShouldReturnOSXArm64Binary()
  {
    // Arrange
    string expectedBinary = "argocd-osx-arm64";

    // Act
    string actualBinary = Path.GetFileName(ArgoCD.GetCommand(PlatformID.Unix, Architecture.Arm64, "osx-arm64").TargetFilePath);

    // Assert
    Assert.Equal(expectedBinary, actualBinary);
  }

  /// <summary>
  /// Test to verify that the command returns the correct binary for Linux on ARM64 architecture.
  /// </summary>
  [Fact]
  public void GetCommand_ShouldReturnLinuxArm64Binary()
  {
    // Arrange
    string expectedBinary = "argocd-linux-arm64";

    // Act
    string actualBinary = Path.GetFileName(ArgoCD.GetCommand(PlatformID.Unix, Architecture.Arm64, "linux-arm64").TargetFilePath);

    // Assert
    Assert.Equal(expectedBinary, actualBinary);
  }

  /// <summary>
  /// Test to verify that the command returns a <see cref="PlatformNotSupportedException"/> when the platform is not supported.
  /// </summary>
  [Fact]
  public void GetCommand_GivenInvaldiPlatform_ShouldThrowPlatformNotSupportedException()
  {
    // Arrange
    var platformID = PlatformID.Other;
    var architecture = Architecture.Wasm;
    string runtimeIdentifier = "wasm";

    // Act
    void Act() => ArgoCD.GetCommand(platformID, architecture, runtimeIdentifier);

    // Assert
    _ = Assert.Throws<PlatformNotSupportedException>(Act);
  }
}
