

### 实操记录

> 在我的Debian13机器 完整部署命令：
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
> PLUGIN_DIR="/root/.local/share/Steam/steamapps/common/Counter-Strike Global Offensive/game/csgo/addons/counterstrikesharp/plugins/qwqCounterStrikeSharpPlugin"
> mkdir -p "$PLUGIN_DIR"
> cd "$PLUGIN_DIR"
> proxychains4 wget "https://github.com/VincentZyuApps/qwqCounterStrikeSharpPlugin/releases/download/$TAG/qwqCounterStrikeSharpPlugin-$TAG.dll"
> mv qwqCounterStrikeSharpPlugin-$TAG.dll qwqCounterStrikeSharpPlugin.dll
>
> # 5. 启动服务器
> /root/.local/share/Steam/steamapps/common/Counter-Strike\ Global\ Offensive/game/bin/linuxsteamrt64/cs2 \
>   -dedicated -game csgo +map de_dust2 +sv_lan 1
>
> # 或者使用启动脚本
> /home/mac/SSoftwareFiles/cs2ds/cs2ds.sh
> ```
