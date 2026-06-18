<div align=center>

[![Downloads](https://img.shields.io/github/downloads/__REPO__/v__VERSION__/total?style=flat-square&logo=github)](https://github.com/__REPO__/releases/tag/v__VERSION__)
[![CS2](https://img.shields.io/badge/for-CounterStrikeSharp-FCAC19?style=flat-square&logo=csharp&logoColor=white&labelColor=2B3980)](https://github.com/roflmuffin/CounterStrikeSharp)
[![NET](https://img.shields.io/badge/.NET-10-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)

</div>

---

### 🎯 Commit Log

__COMMIT_LOG__

---

### ⬇️ Download Release Assets

| File | Description |
|------|------------|
| [📦 `qwqCounterStrikeSharpPlugin-__VERSION__.dll`](__BASE_URL__/qwqCounterStrikeSharpPlugin-__VERSION__.dll) | 🔌 Plugin main DLL |
| [📦 `qwqCounterStrikeSharpPlugin-__VERSION__.pdb`](__BASE_URL__/qwqCounterStrikeSharpPlugin-__VERSION__.pdb) | 🐛 Debug symbols (optional, kept for error line numbers) |

### 📥 Install Plugin

```bash
# Default Steam path is usually under ~/.local
cd "path/to/Steam/steamapps/common/Counter-Strike Global Offensive/game"
# Download to plugin subdirectory (dir name must match DLL filename)
cd ./csgo/addons/counterstrikesharp/plugins/
mkdir -p qwqCounterStrikeSharpPlugin
cd qwqCounterStrikeSharpPlugin
wget "__BASE_URL__/qwqCounterStrikeSharpPlugin-__VERSION__.dll"
wget "__BASE_URL__/qwqCounterStrikeSharpPlugin-__VERSION__.pdb"
mv qwqCounterStrikeSharpPlugin-__VERSION__.dll qwqCounterStrikeSharpPlugin.dll
mv qwqCounterStrikeSharpPlugin-__VERSION__.pdb qwqCounterStrikeSharpPlugin.pdb
```

### 📋 Deployment Steps
> See [README.md](https://github.com/VincentZyuApps/qwqCounterStrikeSharpPlugin) for details

1. ✅ Server has Metamod:Source + CounterStrikeSharp installed
2. ✅ Download DLL into `plugins/qwqCounterStrikeSharpPlugin/`
3. ✅ Restart the server
4. 🎮 Type `qwq` in chat → receive green reply `qwq!`

---

### 📊 Build Info

- **Build Date**: __BUILD_DATE__
- **Commit**: __COMMIT_HASH__
- **Full Changelog**: __CHANGELOG_URL__
