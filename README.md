# BootstrapDemo

------

# 通过 Visual Studio 2019 + LibMan 管理客户端库

1. 在VS的**解决方案资源管理器**中右击需要管理客户端库的项目下的`wwwroot/lib`目录，并点击菜单**添加**>**客户端库**
2. 选择**提供程序**并输入客户端库的名称`twitter-bootstrap`
3. **选择特定文件**
4. 修改**目标位置**
5. 安装
6. 编辑`Views\Shared\_Layout.cshtml`以引用客户端库文件
7. 此时项目内会出现`libman.json`文件，也可以手动编辑以管理客户端库

