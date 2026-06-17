![qwqCounterStrikePlugin](https://socialify.git.ci/VincentZyu233/qwqCounterStrikePlugin/image?custom_description=%F0%9F%8E%AE+CS2+%E6%9C%8D%E5%8A%A1%E7%AB%AF+C%23+%E6%8F%92%E4%BB%B6%E6%A8%A1%E6%9D%BF%E9%A1%B9%E7%9B%AE+%E2%80%94+%E7%8E%A9%E5%AE%B6%E8%BE%93%E5%85%A5+qwq%EF%BC%8C%E6%9C%8D%E5%8A%A1%E7%AB%AF%E5%9B%9E%E5%A4%8D+qwq%EF%BC%81%E2%9C%A8+%E5%9F%BA%E4%BA%8E+CounterStrikeSharp%EF%BC%8CGitHub+Actions+%E8%87%AA%E5%8A%A8%E6%9E%84%E5%BB%BA%E5%8F%91%E5%B8%83+%F0%9F%9A%80qwq......qwq%21&description=1&font=Inter&forks=1&issues=1&language=1&logo=https%3A%2F%2Fpreview.redd.it%2Fcounter-strike-2-has-updated-their-logo-v0-tyyh6jk17n0f1.jpg%3Fwidth%3D474%26format%3Dpjpg%26auto%3Dwebp%26s%3D08f8163f425191d3f34d95108f13d22173245e7d&name=1&owner=1&pulls=1&stargazers=1&theme=Auto)

[![GITHUB](https://img.shields.io/badge/GITHUB-REPO?style=for-the-badge&logo=github&logoColor=white&labelColor=181717&color=555555)](https://github.com/VincentZyuApps/qwqCounterStrikePlugin)
[![GITEE](https://img.shields.io/badge/GITEE-REPO?style=for-the-badge&logo=gitee&logoColor=white&labelColor=C71D23&color=555555)](https://gitee.com/vincent-zyu/qwq-counter-strike-plugin)

[![QQ群](https://img.shields.io/badge/QQ群-1085190201-12B7F5?style=flat-square&logo=qq&logoColor=white)](https://qm.qq.com/q/4vjto4V7Di)


<p><del>💬 插件使用问题 / 🐛 Bug反馈 / 👨‍💻 插件开发交流，欢迎加入QQ群：<b>259248174</b>   🎉（这个群G了</del> </p> 
<p>💬 插件使用问题 / 🐛 Bug反馈 / 👨‍💻 插件开发交流，欢迎加入QQ群：<b>1085190201</b> 🎉</p>
<p>💡 在群里直接艾特我，回复的更快哦~ ✨</p>

# qwqCounterStrikePlugin

一个 Counter-Strike 2 服务端插件，玩家在聊天框输入 `qwq`，服务端回复 `qwq!`。

基于 [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp) 框架，使用 C# (.NET 10) 编写。

![效果预览](doc/images/preview.cs2.server-console.client-chat.png)

## 快速开始

### 部署到服务器

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
   从 [Releases](https://github.com/VincentZyu233/qwqCounterStrikePlugin/releases/latest) 下载 `.dll`：
   ```bash
   TAG=<最新版本号>
   PLUGIN_DIR=csgo/addons/counterstrikesharp/plugins/qwqCounterStrikePlugin
   mkdir -p $PLUGIN_DIR
   cd $PLUGIN_DIR
   wget "https://github.com/VincentZyu233/qwqCounterStrikePlugin/releases/download/$TAG/qwqCounterStrikePlugin-$TAG.dll"
   mv qwqCounterStrikePlugin-$TAG.dll qwqCounterStrikePlugin.dll
   ```

   最终插件结构：
   ```
   plugins/
   └── qwqCounterStrikePlugin/
       └── qwqCounterStrikePlugin.dll
   ```

4. **启动服务器**
   ```bash
   ./cs2 -dedicated -game csgo +map de_dust2 +sv_lan 1
   ```

   控制台看到 `Finished loading plugin qwq CounterStrike Plugin` 即加载成功。

5. **进游戏测试**  
   聊天框输入 `qwq` → 收到绿色回复 `qwq!`


> 
> ### 实操记录
> 
> 在我的Debian13机器 完整部署命令：
>
> ```bash
> # 1. 解压 Metamod 到 CS2 目录
> # 正确结构: csgo/addons/
> #              ├── metamod/
> #              ├── metamod.vdf
> #              └── metamod_x64.vdf
> tar -xzf /home/mac/SSoftwareFiles/mmsource/mmsource-2.0.0-git1402-linux.tar.gz \
>   -C "/root/.local/share/Steam/steamapps/common/Counter-Strike Global Offensive/game/csgo/"
>
> # 解压后检查
> ls /root/.local/share/Steam/steamapps/common/Counter-Strike\ Global\ Offensive/game/csgo/addons/
>
> # 2. 装 CounterStrikeSharp
> # 正确结构: csgo/addons/{metamod/, counterstrikesharp/{api/, dotnet/, plugins/}}
> cp -r /home/mac/SSoftwareFiles/css/ccs-with-runtime/addons/* \
>   "/root/.local/share/Steam/steamapps/common/Counter-Strike Global Offensive/game/csgo/addons/"
>
> # 检查结构
> tree /root/.local/share/Steam/steamapps/common/Counter-Strike\ Global\ Offensive/game/csgo/addons/
>
>
> # 3. 下载插件到插件子目录（目录名必须等于 DLL 文件名）
> TAG=v0.1.3-9
> PLUGIN_DIR="/root/.local/share/Steam/steamapps/common/Counter-Strike Global Offensive/game/csgo/addons/counterstrikesharp/plugins/qwqCounterStrikePlugin"
> mkdir -p "$PLUGIN_DIR"
> cd "$PLUGIN_DIR"
> proxychains4 wget "https://github.com/VincentZyu233/qwqCounterStrikePlugin/releases/download/$TAG/qwqCounterStrikePlugin-$TAG.dll"
> mv qwqCounterStrikePlugin-$TAG.dll qwqCounterStrikePlugin.dll
>
> # 5. 启动服务器
> /root/.local/share/Steam/steamapps/common/Counter-Strike\ Global\ Offensive/game/bin/linuxsteamrt64/cs2 \
>   -dedicated -game csgo +map de_dust2 +sv_lan 1
>
> # 或者使用启动脚本
> /home/mac/SSoftwareFiles/cs2ds/cs2ds.sh
> ```

## GitHub Actions

推送到 GitHub 时，**commit 信息中的关键词控制流水线行为**。  
详细说明见 [`.github/workflows/build.md`](.github/workflows/build.md)。

| 关键词 | 构建 | 发布 Release |
|---|---|---|
| `build action` | ✅ | ❌ |
| `build release` | ✅ | ✅ |

[![最后提交](https://img.shields.io/github/last-commit/VincentZyuApps/qwqCounterStrikePlugin?style=flat-square&label=最后提交&labelColor=181717&color=555555)](https://github.com/VincentZyuApps/qwqCounterStrikePlugin/commits/main)
[![构建状态](https://img.shields.io/github/actions/workflow/status/VincentZyuApps/qwqCounterStrikePlugin/build.yml?style=flat-square&label=构建状态&labelColor=181717&logo=github)](https://github.com/VincentZyuApps/qwqCounterStrikePlugin/actions)
