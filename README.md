# qwqCounterStrikePlugin

一个 Counter-Strike 2 服务端插件，玩家在聊天框输入 `qwq`，服务端回复 `qwq!`。

基于 [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp) 框架，使用 C# (.NET 10) 编写。

## 快速开始

### 部署到服务器

1. **安装 Metamod:Source**  
   参考 https://cs2.poggu.me/metamod/installation/  
   下载对应的发行版，比如 Linux 版，解压到 `csgo/` 目录

2. **安装 CounterStrikeSharp**  
   下载 [with-runtime 版本](https://github.com/roflmuffin/CounterStrikeSharp/releases)  
   解压 `addons/` 合并到 `csgo/` 目录

   最终结构：
   ```
   csgo/
   ├── addons/
   │   ├── metamod/
   │   └── counterstrikesharp/
   │       ├── api/
   │       ├── dotnet/
   │       └── plugins/
   ```

3. **放入插件**
   ```bash
   cp bin/Release/net10.0/QwqPlugin.dll \
      csgo/addons/counterstrikesharp/plugins/
   ```

4. **启动服务器**
   ```bash
   ./srcds_run -game csgo -console +map de_dust2 +sv_lan 1
   ```

   控制台看到 `qwq CounterStrike Plugin loaded successfully!` 即加载成功。

5. **进游戏测试**  
   聊天框输入 `qwq` → 收到绿色回复 `qwq!`

## GitHub Actions

推送到 GitHub 时，commit 信息中的关键词控制流水线行为：

| Commit 关键词 | Build | Release |
|---|---|---|
| `build action` | ✅ 构建并上传 artifact | ❌ |
| `build release` | ✅ 构建并上传 artifact | ✅ 创建 GitHub Release |

### 工作流阶段

```
check ──→ build ──→ release
  │         │         │
  │         │         └── 下载 artifact → 创建 Release → 上传 zip
  │         │
  │         └── dotnet build → 打包 → 上传 artifact
  │
  └── 解析 commit 信息 → 输出控制 flag
```
