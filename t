[1;33mdiff --git a/.vs/CursoNETCompleto/config/applicationhost.config b/.vs/CursoNETCompleto/config/applicationhost.config[m
[1;33mindex cf6418a..eea1a16 100644[m
[1;33m--- a/.vs/CursoNETCompleto/config/applicationhost.config[m
[1;33m+++ b/.vs/CursoNETCompleto/config/applicationhost.config[m
[1;35m@@ -162,7 +162,7 @@[m
             </site>[m
             <site name="CursoNETCompleto" id="2">[m
                 <application path="/" applicationPool="Clr4IntegratedAppPool">[m
[1;31m-                    <virtualDirectory path="/" physicalPath="C:\Users\evazq\source\repos\CursoNETCompleto\CursoNETCompleto" />[m
[1;32m+[m[1;32m                    <virtualDirectory path="/" physicalPath="C:\Users\ECTOTEC\git\GitHub\CursoNETCompleto\CursoNETCompleto" />[m
                 </application>[m
                 <bindings>[m
                     <binding protocol="http" bindingInformation="*:50309:localhost" />[m
[1;33mdiff --git a/CursoNETCompleto/Web.config b/CursoNETCompleto/Web.config[m
[1;33mindex a19467e..b6fe7d6 100644[m
[1;33m--- a/CursoNETCompleto/Web.config[m
[1;33m+++ b/CursoNETCompleto/Web.config[m
[1;35m@@ -59,10 +59,10 @@[m
       </dependentAssembly>[m
     </assemblyBinding>[m
   </runtime>[m
[1;31m-  <connectionStrings>[m
[1;31m-    <add name="BANNER" connectionString="Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=172.16.201.121)(PORT=2385)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=BANDEVL)));User Id=DASHUSER;Password=D4SHUS3R20!;" />[m
[1;31m-    <add name="OracleDbContext" providerName="Oracle.ManagedDataAccess.Client" connectionString="User Id=oracle_user;Password=oracle_user_password;Data Source=oracle" />[m
[1;31m-  </connectionStrings>[m
[1;32m+[m	[1;32m<connectionStrings>[m
[1;32m+[m		[1;32m<add name="BANNER" connectionString="Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=ectotec-train.cdecq0ipag3a.us-east-1.rds.amazonaws.com)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));User Id=ALUMNO02;Password=ALUMNO02;" />[m
[1;32m+[m		[1;32m<add name="OracleDbContext" providerName="Oracle.ManagedDataAccess.Client" connectionString="User Id=oracle_user;Password=oracle_user_password;Data Source=oracle" />[m
[1;32m+[m	[1;32m</connectionStrings>[m
   <system.codedom>[m
     <compilers>[m
       <compiler language="c#;cs;csharp" extension=".cs" type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" warningLevel="4" compilerOptions="/langversion:default /nowarn:1659;1699;1701" />[m
[1;33mdiff --git a/CursoNETCompleto/obj/Debug/CursoNETCompleto.csproj.AssemblyReference.cache b/CursoNETCompleto/obj/Debug/CursoNETCompleto.csproj.AssemblyReference.cache[m
[1;33mindex f5e894a..bcccc2b 100644[m
Binary files a/CursoNETCompleto/obj/Debug/CursoNETCompleto.csproj.AssemblyReference.cache and b/CursoNETCompleto/obj/Debug/CursoNETCompleto.csproj.AssemblyReference.cache differ
[1;33mdiff --git a/CursoNETCompleto/obj/Debug/DesignTimeResolveAssemblyReferencesInput.cache b/CursoNETCompleto/obj/Debug/DesignTimeResolveAssemblyReferencesInput.cache[m
[1;33mindex 3952058..0d1c064 100644[m
Binary files a/CursoNETCompleto/obj/Debug/DesignTimeResolveAssemblyReferencesInput.cache and b/CursoNETCompleto/obj/Debug/DesignTimeResolveAssemblyReferencesInput.cache differ
