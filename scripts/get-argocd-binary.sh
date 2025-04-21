#!/bin/bash
set -e

get() {
  local url=$1
  local binary=$2
  local target_dir=$3
  local target_name=$4
  local archiveType=$5

  echo "Downloading $target_name from $url"
  if [ "$archiveType" = "tar" ]; then
    curl -LJ "$url" | tar xvz -C "$target_dir" "$binary"
    mv "$target_dir/$binary" "${target_dir}/$target_name"
  elif [ "$archiveType" = "zip" ]; then
    curl -LJ "$url" -o "$target_dir/$target_name.zip"
    unzip -o "$target_dir/$target_name.zip" -d "$target_dir"
    mv "$target_dir/$binary" "${target_dir}/$target_name"
    rm "$target_dir/$target_name.zip"
  elif [ "$archiveType" = false ]; then
    curl -LJ "$url" -o "$target_dir/$target_name"
  fi
  chmod +x "$target_dir/$target_name"
}

get "https://getbin.io/argoproj/argo-cd?os=darwin&arch=amd64" "argocd" "src/Devantler.ArgoCDCLI/runtimes/osx-x64/native" "argocd-osx-x64" false
get "https://getbin.io/argoproj/argo-cd?os=darwin&arch=arm64" "argocd" "src/Devantler.ArgoCDCLI/runtimes/osx-arm64/native" "argocd-osx-arm64" false
get "https://getbin.io/argoproj/argo-cd?os=linux&arch=amd64" "argocd" "src/Devantler.ArgoCDCLI/runtimes/linux-x64/native" "argocd-linux-x64" false
get "https://getbin.io/argoproj/argo-cd?os=linux&arch=arm64" "argocd" "src/Devantler.ArgoCDCLI/runtimes/linux-arm64/native" "argocd-linux-arm64" false
get "https://getbin.io/argoproj/argo-cd?os=windows&arch=amd64" "argocd.exe" "src/Devantler.ArgoCDCLI/runtimes/win-x64/native" "argocd-win-x64.exe" false
