![qwqCounterStrikeSharpPlugin](https://socialify.git.ci/VincentZyuApps/qwqCounterStrikeSharpPlugin/image?custom_description=%F0%9F%8E%AE+CS2+%E6%9C%8D%E5%8A%A1%E7%AB%AF+C%23+%E6%8F%92%E4%BB%B6%E6%A8%A1%E6%9D%BF%E9%A1%B9%E7%9B%AE+%E2%80%94+%E7%8E%A9%E5%AE%B6%E8%BE%93%E5%85%A5+qwq%EF%BC%8C%E6%9C%8D%E5%8A%A1%E7%AB%AF%E5%9B%9E%E5%A4%8D+qwq%EF%BC%81%E2%9C%A8+%E5%9F%BA%E4%BA%8E+CounterStrikeSharp%EF%BC%8CGitHub+Actions+%E8%87%AA%E5%8A%A8%E6%9E%84%E5%BB%BA%E5%8F%91%E5%B8%83+%F0%9F%9A%80qwq......qwq%21&description=1&font=Inter&forks=1&issues=1&language=1&logo=https%3A%2F%2Fpreview.redd.it%2Fcounter-strike-2-has-updated-their-logo-v0-tyyh6jk17n0f1.jpg%3Fwidth%3D474%26format%3Dpjpg%26auto%3Dwebp%26s%3D08f8163f425191d3f34d95108f13d22173245e7d&name=1&owner=1&pulls=1&stargazers=1&theme=Auto)

[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/VincentZyuApps/qwqCounterStrikeSharpPlugin)
[![Gitee](https://img.shields.io/badge/Gitee-C71D23?style=for-the-badge&logo=gitee&logoColor=white)](https://gitee.com/vincent-zyu/qwqCounterStrikeSharpPlugin)

[![CS2](https://img.shields.io/badge/for-CounterStrikeSharp-2B3980?style=for-the-badge&logo=csharp&logoColor=white&labelColor=FCAC19)](https://github.com/roflmuffin/CounterStrikeSharp)
[![NET](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)

[![QQ群](https://img.shields.io/badge/QQ群-1085190201-12B7F5?style=for-the-badge&logo=qq&logoColor=white)](https://qm.qq.com/q/4vjto4V7Di)

<p>💬 插件使用问题 / 🐛 Bug反馈 / 👨‍💻 插件开发交流，欢迎加入QQ群：<b>1085190201</b> 🎉</p>
<p>💡 在群里直接艾特我，回复的更快哦~ ✨</p>

# 🎮 ✨ 🚀 💬 qwqCounterStrikeSharpPlugin

一个 Counter-Strike 2 服务端插件，玩家在聊天框输入 `qwq`，服务端回复 `qwq!`。

基于 [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp) 框架，使用 C# (.NET 10) 编写。

![效果预览](doc/images/preview.cs2.server-console.client-chat.png)

## 🏃 💨 🔜 快速开始

### 📦 🔧 部署到服务器

1. **安装 Metamod:Source**  
   参考 https://cs2.poggu.me/metamod/installation/  
   下载对应的发行版，比如 Linux 版，解压到 `csgo/` 目录

   解压后结构：
   ```
   csgo/addons/
   └── metamod/
   ```

2. **安装 CounterStrikeSharp**  
   下载 [with-runtime 版本](https://github.com/roflmuffin/CounterStrikeSharp/releases)  
   解压 `addons/` 合并到 `csgo/` 目录

   合并后结构：
   ```
   csgo/
   └── addons/
     ├── metamod/
     └── counterstrikesharp/
         ├── api/
         ├── dotnet/
         └── plugins/
   ```

3. **放入插件**
   CSS 要求插件放在 `plugins/<插件名>/<插件名>.dll` 子目录中（目录名 = DLL 文件名）。
   从 [Releases](https://github.com/VincentZyuApps/qwqCounterStrikeSharpPlugin/releases/latest) 下载 `.dll`：
   ```bash
   TAG=<最新版本号>
   PLUGIN_DIR=csgo/addons/counterstrikesharp/plugins/qwqCounterStrikeSharpPlugin
   mkdir -p $PLUGIN_DIR
   cd $PLUGIN_DIR
   wget "https://github.com/VincentZyuApps/qwqCounterStrikeSharpPlugin/releases/download/$TAG/qwqCounterStrikeSharpPlugin-$TAG.dll"
   mv qwqCounterStrikeSharpPlugin-$TAG.dll qwqCounterStrikeSharpPlugin.dll
   ```

   最终插件结构：
   ```
   plugins/
   └── qwqCounterStrikeSharpPlugin/
       └── qwqCounterStrikeSharpPlugin.dll
   ```

4. **启动服务器**
   ```bash
   ./cs2 -dedicated -game csgo +map de_dust2 +sv_lan 1
   ```

   控制台看到 `Finished loading plugin qwq CounterStrike Plugin` 即加载成功。

5. **进游戏测试**  
   聊天框输入 `qwq` → 收到绿色回复 `qwq!`

> **[📋 我的自己的环境的部署指令记录](doc/images/prod/prod.md)**

## 🤖 ⚙️ 🔄 GitHub Actions

推送到 GitHub 时，**commit 信息中的关键词控制流水线行为**。  
详细说明见下方 [「构建工作流指南」](#构建工作流指南)。

| 关键词 | 构建 | 发布 Release |
|---|---|---|
| `build action` | ✅ | ❌ |
| `build release` | ✅ | ✅ |

[![最后提交](https://img.shields.io/github/last-commit/VincentZyuApps/qwqCounterStrikeSharpPlugin?style=for-the-badge&label=最后提交&labelColor=181717&color=555555)](https://github.com/VincentZyuApps/qwqCounterStrikeSharpPlugin/commits/main)
[![构建状态](https://img.shields.io/github/actions/workflow/status/VincentZyuApps/qwqCounterStrikeSharpPlugin/build.yml?style=for-the-badge&label=构建状态&labelColor=181717&logo=github)](https://github.com/VincentZyuApps/qwqCounterStrikeSharpPlugin/actions)

## 📋 🏗️ 🚀 构建工作流指南

推送到 GitHub 时，**commit 信息中的关键词**控制 CI/CD 流水线的行为。

### 🔑 📌 关键词速查

| 关键词 | Build（编译 DLL） | Release（发布到 Releases） |
|---|---|---|
| `build action` | ✅ | ❌ |
| `build release` | ✅ | ✅ |

#### ⚠️ 关键词不匹配

如果 commit 信息中**没有上述任一关键词**，流水线**不执行**，不会浪费 Actions 配额。

### 🏭 📊 流水线阶段

```
check ──→ build ──→ release
  │         │         │
  │         │         └── 下载 artifact → 创建 GitHub Release → 上传 zip
  │         │
  │         └── dotnet restore → dotnet build → 打包 zip → 上传 artifact
  │
  └── 解析 commit 信息 → 输出控制 flag
```

#### 🔍 阶段一：check（解析 commit）

- 读取最新一条 commit 的 message
- 匹配关键词，设置 `should_build` / `should_release` 开关
- 从 `qwqCounterStrikeSharpPlugin.csproj` 的 `<Version>` 标签提取版本号
- Release 标签格式：`v{版本号}-{run_number}` （例如 `v0.0.1-42`）

#### 🛠️ 阶段二：build（编译）

- `dotnet restore` 还原 NuGet 依赖
- `dotnet build -c Release` 编译插件
- 产出 `QwqCounterStrikeSharpPlugin.dll` + `.pdb` 打包为 `qwqCounterStrikeSharpPlugin.zip`
- 上传到 Actions Artifact

#### 🎯 阶段三：release（发布）

- 下载 Artifact
- 使用版本号创建 Git tag
- 创建 GitHub Release，附上 zip 文件

### 📝 💻 使用示例

```bash
# 只构建，不发布
git commit -m "fix: 修了个bug, build action"

# 构建并发布 Release
git commit -m "feat: 加了个新功能, build release"
```

### 📦 📄 产物说明

Artifact / Release 中的 zip 包含：

| 文件 | 说明 |
|---|---|
| `QwqCounterStrikeSharpPlugin.dll` | 插件主程序（放到服上 `addons/counterstrikesharp/plugins/`） |
| `QwqCounterStrikeSharpPlugin.pdb` | 调试符号文件（可选，保留方便报错时定位行号） |

### 🔖 🔢 自定义版本号

编辑 `qwqCounterStrikeSharpPlugin.csproj` 中的 `<Version>` 字段：
```xml
<Version>x.y.z</Version>
```
编辑 `QwqCounterStrikeSharpPlugin.cs` 中的类属性字符串 `ModuleVersion` 的值：
```cs
public override string ModuleVersion => "x.y.z";
```

下次触发 Release 时，标签会自动变成 `vx.y.z-{run_number}`。
