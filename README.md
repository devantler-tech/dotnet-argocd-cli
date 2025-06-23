# 🔧 .NET Argo CD CLI

[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Test](https://github.com/devantler-tech/dotnet-argocd-cli/actions/workflows/test.yaml/badge.svg)](https://github.com/devantler-tech/dotnet-argocd-cli/actions/workflows/test.yaml)
[![codecov](https://codecov.io/gh/devantler-tech/dotnet-argocd-cli/graph/badge.svg?token=RhQPb4fE7z)](https://codecov.io/gh/devantler-tech/dotnet-argocd-cli)

A simple .NET library that embeds the Argo CD CLI.

## 🚀 Getting Started

### Prerequisites

- .NET 9.0 or later
- [ArgoCD CLI](https://argo-cd.readthedocs.io/en/stable/getting_started/#1-install-argo-cd) installed and available in your system's PATH

### Installation

To get started, you can install the package from NuGet.

```bash
dotnet add package DevantlerTech.ArgoCDCLI
```

## 📝 Usage

You can execute the ArgoCD CLI commands using the `ArgoCD` class.

```csharp
using DevantlerTech.ArgoCDCLI;

var (exitCode, output) = await ArgoCD.RunAsync(["arg1", "arg2"]);
```
