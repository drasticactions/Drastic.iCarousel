[![NuGet Version](https://img.shields.io/nuget/v/Drastic.Nuke.svg)](https://www.nuget.org/packages/Drastic.Nuke/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)

# Drastic.Nuke

Drastic.Nuke is binding of [Nuke](https://github.com/kean/Nuke), an image loading system for iOS, Mac Catalyst, macOS, and tvOS. The binding works via a proxy framework, NukeProxy, itself created by [roubachof](https://github.com/roubachof/NukeProxy) and forked here to add additional APIs and additional platforms that Nuke itself supports.

This is intended for use within dotnet6+ apple programs. While it can be used within MAUI UI applications, there are no helpers to guide its usage. If you want that, I would instead use [Maui.Nuke](https://github.com/roubachof/Maui.Nuke).