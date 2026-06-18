> **[📖 English](README.md)**
> **[📖 简体中文(大陆)](README.zh-cn.md)**

![qwqCounterStrikeSharpPlugin](https://socialify.git.ci/VincentZyuApps/qwqCounterStrikeSharpPlugin/image?custom_description=%F0%9F%8E%AE+CS2+%E6%9C%8D%E5%8A%A1%E7%AB%AF+C%23+%E6%8F%92%E4%BB%B6%E6%A8%A1%E6%9D%BF%E9%A1%B9%E7%9B%AE+%E2%80%94+%E7%8E%A9%E5%AE%B6%E8%BE%93%E5%85%A5+qwq%EF%BC%8C%E6%9C%8D%E5%8A%A1%E7%AB%AF%E5%9B%9E%E5%A4%8D+qwq%EF%BC%81%E2%9C%A8+%E5%9F%BA%E4%BA%8E+CounterStrikeSharp%EF%BC%8CGitHub+Actions+%E8%87%AA%E5%8A%A8%E6%9E%84%E5%BB%BA%E5%8F%91%E5%B8%83+%F0%9F%9A%80qwq......qwq%21&description=1&font=Inter&forks=1&issues=1&language=1&logo=https%3A%2F%2Fpreview.redd.it%2Fcounter-strike-2-has-updated-their-logo-v0-tyyh6jk17n0f1.jpg%3Fwidth%3D474%26format%3Dpjpg%26auto%3Dwebp%26s%3D08f8163f425191d3f34d95108f13d22173245e7d&name=1&owner=1&pulls=1&stargazers=1&theme=Auto)

[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/VincentZyuApps/qwqCounterStrikeSharpPlugin)
[![Gitee](https://img.shields.io/badge/Gitee-C71D23?style=for-the-badge&logo=gitee&logoColor=white)](https://gitee.com/vincent-zyu/qwqCounterStrikeSharpPlugin)

[![CS2](https://img.shields.io/badge/for-CounterStrikeSharp-2B3980?style=for-the-badge&logo=csharp&logoColor=white&labelColor=FCAC19)](https://github.com/roflmuffin/CounterStrikeSharp)
[![NET](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)

[![QQ群](https://img.shields.io/badge/QQ群-1085190201-12B7F5?style=for-the-badge&logo=qq&logoColor=white)](https://qm.qq.com/q/4vjto4V7Di)

<p><del>💬 插件使用问题 / 🐛 Bug反馈 / 👨‍💻 插件开发交流，欢迎加入QQ群：<b>259248174</b>   🎉（这个群G了</del> </p>
<p>💬 插件使用问题 / 🐛 Bug反馈 / 👨‍💻 插件开发交流，欢迎加入QQ群：<b>1085190201</b> 🎉</p>
<p>💡 在群里直接艾特我，回复的更快哦~ ✨</p>

# 🎮 ✨ 🚀 💬 qwqCounterStrikeSharpPlugin

A Counter-Strike 2 server plugin. Type `qwq` in chat, the server replies `qwq!`.

Built on [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp), written in C# (.NET 10).

![effect preview](doc/images/preview.cs2.server-console.client-console.client-chat.png)

## 🏃 💨 🔜 Quick Start

### 📦 🔧 Deploy to Server

1. **Install Metamod:Source**  
   See https://cs2.poggu.me/metamod/installation/  
   Download the Linux build and extract to the `csgo/` directory

   Structure after extraction:
   ```
   csgo/addons/
   └── metamod/
   ```

2. **Install CounterStrikeSharp**  
   Download the [with-runtime release](https://github.com/roflmuffin/CounterStrikeSharp/releases)  
   Merge the `addons/` folder into `csgo/`

   Structure after merging:
   ```
   csgo/
   └── addons/
     ├── metamod/
     └── counterstrikesharp/
         ├── api/
         ├── dotnet/
         └── plugins/
   ```

3. **Add the Plugin**
   CSS requires plugins in `plugins/<PluginName>/<PluginName>.dll` (directory name = DLL filename).
   Download the `.dll` from [Releases](https://github.com/VincentZyuApps/qwqCounterStrikeSharpPlugin/releases/latest):
   ```bash
   TAG=<latest version tag>
   PLUGIN_DIR=csgo/addons/counterstrikesharp/plugins/qwqCounterStrikeSharpPlugin
   mkdir -p $PLUGIN_DIR
   cd $PLUGIN_DIR
   wget "https://github.com/VincentZyuApps/qwqCounterStrikeSharpPlugin/releases/download/$TAG/qwqCounterStrikeSharpPlugin-$TAG.dll"
   mv qwqCounterStrikeSharpPlugin-$TAG.dll qwqCounterStrikeSharpPlugin.dll
   ```

   Final plugin structure:
   ```
   plugins/
   └── qwqCounterStrikeSharpPlugin/
       └── qwqCounterStrikeSharpPlugin.dll
   ```

4. **Start the Server**
   ```bash
   ./cs2 -dedicated -game csgo +map de_dust2 +sv_lan 1
   ```

   You should see `Finished loading plugin qwq CounterStrikeSharp Plugin` in the console.

5. **Test In-Game**  
   Type `qwq` in chat → you'll see a green `qwq!` reply.

> **[📋 My deployment notes](doc/images/prod/prod.md)**

## 🤖 ⚙️ 🔄 GitHub Actions

When pushing to GitHub, **keywords in the commit message control the pipeline**.  
Full details in the [「Build Workflow Guide」](#-build-workflow-guide) below.

| Keyword | Build | Release |
|---|---|---|
| `build action` | ✅ | ❌ |
| `build release` | ✅ | ✅ |

[![Last Commit](https://img.shields.io/github/last-commit/VincentZyuApps/qwqCounterStrikeSharpPlugin?style=for-the-badge&label=Last%20Commit&labelColor=181717&color=555555)](https://github.com/VincentZyuApps/qwqCounterStrikeSharpPlugin/commits/main)
[![Build Status](https://img.shields.io/github/actions/workflow/status/VincentZyuApps/qwqCounterStrikeSharpPlugin/build.yml?style=for-the-badge&label=Build%20Status&labelColor=181717&logo=github)](https://github.com/VincentZyuApps/qwqCounterStrikeSharpPlugin/actions)

## 📋 🏗️ 🚀 Build Workflow Guide

When pushing to GitHub, **keywords in the commit message** control the CI/CD pipeline.

### 🔑 📌 Keywords Reference

| Keyword | Build DLL | Publish Release |
|---|---|---|
| `build action` | ✅ | ❌ |
| `build release` | ✅ | ✅ |

#### ⚠️ No Keyword Matched

If the commit message contains **none of the keywords above**, the pipeline **will not run**, saving your Actions quota.

### 🏭 📊 Pipeline Stages

```
check ──→ build ──→ release
  │         │         │
  │         │         └── download artifact → create GitHub Release → upload zip
  │         │
  │         └── dotnet restore → dotnet build → zip → upload artifact
  │
  └── parse commit message → set control flags
```

#### 🔍 Stage 1: check (parse commit)

- Read the latest commit message
- Match keywords, set `should_build` / `should_release` flags
- Extract version from `<Version>` in `qwqCounterStrikeSharpPlugin.csproj`
- Release tag format: `v{version}-{run_number}` (e.g. `vx.y.z-k`)

#### 🛠️ Stage 2: build (compile)

- `dotnet restore` restore NuGet dependencies
- `dotnet build -c Release` compile the plugin
- Produces `QwqCounterStrikeSharpPlugin.dll` + `.pdb` packaged as `qwqCounterStrikeSharpPlugin.zip`
- Uploaded to Actions Artifact

#### 🎯 Stage 3: release (publish)

- Download the artifact
- Create a Git tag with the version number
- Create a GitHub Release with the zip attached

### 📝 💻 Usage Examples

```bash
# Build only, no release
git commit -m "fix: fixed a bug, build action"

# Build and publish a Release
git commit -m "feat: added a new feature, build release"
```

### 📦 📄 Artifact Contents

The zip inside the Artifact / Release contains:

| File | Description |
|---|---|
| `QwqCounterStrikeSharpPlugin.dll` | Main plugin (place in `addons/counterstrikesharp/plugins/`) |
| `QwqCounterStrikeSharpPlugin.pdb` | Debug symbols (optional, keep for stack trace line numbers) |

### 🔖 🔢 Custom Version

Edit the `<Version>` field in `qwqCounterStrikeSharpPlugin.csproj`:
```xml
<Version>x.y.z</Version>
```
Edit the `ModuleVersion` string in `QwqCounterStrikeSharpPlugin.cs`:
```cs
public override string ModuleVersion => "x.y.z";
```

The next Release will automatically use `vx.y.z-{run_number}` as the tag.
