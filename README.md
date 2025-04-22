# 🔧 .NET Argo CD CLI

[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Test](https://github.com/devantler-tech/dotnet-argocd-cli/actions/workflows/test.yaml/badge.svg)](https://github.com/devantler-tech/dotnet-argocd-cli/actions/workflows/test.yaml)
[![codecov](https://codecov.io/gh/devantler-tech/dotnet-argocd-cli/graph/badge.svg?token=RhQPb4fE7z)](https://codecov.io/gh/devantler-tech/dotnet-argocd-cli)

<details>
  <summary>Show/hide folder structure</summary>

<!-- readme-tree start -->
```
.
├── .github
│   └── workflows
├── scripts
├── src
│   └── Devantler.ArgoCDCLI
│       └── runtimes
│           ├── linux-arm64
│           │   └── native
│           ├── linux-x64
│           │   └── native
│           ├── osx-arm64
│           │   └── native
│           └── osx-x64
│               └── native
└── tests
    └── Devantler.ArgoCDCLI.Tests
        └── ArgoCDTests

18 directories
```
<!-- readme-tree end -->

</details>

A simple .NET library that embeds the Argo CD CLI.

## 🚀 Getting Started

To get started, you can install the package from NuGet.

```bash
dotnet add package Devantler.ArgoCDCLI
```

## 📝 Usage

You can execute the ArgoCD CLI commands using the `ArgoCD` class.

```csharp
using Devantler.ArgoCDCLI;

var (exitCode, output) = await ArgoCD.RunAsync(["arg1", "arg2"]);
```
