# 构建工作流指南

推送到 GitHub 时，**commit 信息中的关键词**控制 CI/CD 流水线的行为。

## 关键词速查

| 关键词 | Build（编译 DLL） | Release（发布到 Releases） |
|---|---|---|
| `build action` | ✅ | ❌ |
| `build release` | ✅ | ✅ |

### 关键词不匹配

如果 commit 信息中**没有上述任一关键词**，流水线**不执行**，不会浪费 Actions 配额。

## 流水线阶段

```
check ──→ build ──→ release
  │         │         │
  │         │         └── 下载 artifact → 创建 GitHub Release → 上传 zip
  │         │
  │         └── dotnet restore → dotnet build → 打包 zip → 上传 artifact
  │
  └── 解析 commit 信息 → 输出控制 flag
```

### 阶段一：check（解析 commit）

- 读取最新一条 commit 的 message
- 匹配关键词，设置 `should_build` / `should_release` 开关
- 从 `qwqCounterStrikePlugin.csproj` 的 `<Version>` 标签提取版本号
- Release 标签格式：`v{版本号}-{run_number}` （例如 `v0.0.1-42`）

### 阶段二：build（编译）

- `dotnet restore` 还原 NuGet 依赖
- `dotnet build -c Release` 编译插件
- 产出 `QwqPlugin.dll` + `.pdb` 打包为 `qwqCounterStrikePlugin.zip`
- 上传到 Actions Artifact

### 阶段三：release（发布）

- 下载 Artifact
- 使用版本号创建 Git tag
- 创建 GitHub Release，附上 zip 文件

## 使用示例

```bash
# 只构建，不发布
git commit -m "fix: 修了个bug, build action"

# 构建并发布 Release
git commit -m "feat: 加了个新功能, build release"
```

## 产物说明

Artifact / Release 中的 zip 包含：

| 文件 | 说明 |
|---|---|
| `QwqPlugin.dll` | 插件主程序（放到服上 `addons/counterstrikesharp/plugins/`） |
| `QwqPlugin.pdb` | 调试符号文件（可选，保留方便报错时定位行号） |

## 自定义版本号

编辑 `qwqCounterStrikePlugin.csproj` 中的 `<Version>` 字段：

```xml
<Version>0.1.0</Version>
```

下次触发 Release 时，标签会自动变成 `v0.1.0-{run_number}`。
