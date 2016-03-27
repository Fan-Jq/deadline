Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Globalization
Imports System.Resources
Imports System.Windows

' 关于程序集的一般信息通过以下 
' 属性集来控制。请更改这些属性值以修改
' 与程序集关联的信息。

' 请检查程序集属性的值

<Assembly: AssemblyTitle("MathTools")> 
<Assembly: AssemblyDescription("")> 
<Assembly: AssemblyCompany("微软中国")> 
<Assembly: AssemblyProduct("MathTools")> 
<Assembly: AssemblyCopyright("Copyright © 微软中国 2015")> 
<Assembly: AssemblyTrademark("")> 
<Assembly: ComVisible(false)>

'为了开始生成可本地化的应用程序，请 
'在 .vbproj 文件中 <PropertyGroup> 内
'设置  <UICulture>CultureYouAreCodingWith</UICulture>。例如，如果您在源 
'文件中使用美国英语，请将 <UICulture> 设置为 "en-US"。然后取消注释
'以下 NeutralResourceLanguage 属性。请更新以下行中的 "en-US" 以
'与项目文件中的 UICulture 设置匹配。

'<Assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)> 


'ThemeInfo 属性描述在哪里可以找到任何主题特定资源字典和主题普通资源字典。
'第 1 个参数: 主题特定资源字典的位置
'(在页面或应用程序资源字典中 
' 未找到资源的情况下使用)

'第 2 个参数: 普通资源字典的位置
'(在页面、应用程序和任何主题特定资源字典中 
'未找到资源的情况下使用)
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)>



'如果此项目向 COM 公开，则以下 GUID 表示类型库的 ID
<Assembly: Guid("3ebdd7ac-297f-4e6b-af81-6340ece009a8")> 

' 程序集的版本信息包含以下四个值:
'
'      主要版本
'      次要版本 
'      内部版本号
'      修订
'
' 您可以指定所有值，或者可以默认修订号和内部版本号，
' 方法是按如下方式使用 "*":
' <Assembly: AssemblyVersion("1.0.*")> 

<Assembly: AssemblyVersion("1.0.0.0")> 
<Assembly: AssemblyFileVersion("1.0.0.0")> 
