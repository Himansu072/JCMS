dotnet new sln --name JCMS -o D:\My-Project\JMC
dotnet new mvc -n JCMS.Web -o D:\My-Project\JMC\JCMS.Web
dotnet sln D:\My-Project\JMC\JCMS.sln add  D:\My-Project\JMC\JCMS.Web\JCMS.Web.csproj
dotnet new classlib -n JCMS.Core -o D:\My-Project\JMC\JCMS.Core
dotnet sln D:\My-Project\JMC\JCMS.sln add  D:\My-Project\JMC\JCMS.Core\JCMS.Core.csproj
dotnet new classlib -n JCMS.Model -o D:\My-Project\JMC\JCMS.Model
dotnet sln D:\My-Project\JMC\JCMS.sln add  D:\My-Project\JMC\JCMS.Model\JCMS.Model.csproj
dotnet new classlib -n JCMS.Repository -o D:\My-Project\JMC\JCMS.Repository
dotnet sln D:\My-Project\JMC\JCMS.sln add  D:\My-Project\JMC\JCMS.Repository\JCMS.Repository.csproj
dotnet add D:\My-Project\JMC\JCMS.Web\JCMS.Web.csproj reference  D:\My-Project\JMC\JCMS.Repository\JCMS.Repository.csproj
dotnet add D:\My-Project\JMC\JCMS.Web\JCMS.Web.csproj reference  D:\My-Project\JMC\JCMS.Core\JCMS.Core.csproj
dotnet add D:\My-Project\JMC\JCMS.Web\JCMS.Web.csproj reference  D:\My-Project\JMC\JCMS.Model\JCMS.Model.csproj
dotnet add D:\My-Project\JMC\JCMS.Repository\JCMS.Repository.csproj reference  D:\My-Project\JMC\JCMS.Model\JCMS.Model.csproj
dotnet add D:\My-Project\JMC\JCMS.Repository\JCMS.Repository.csproj reference  D:\My-Project\JMC\JCMS.Core\JCMS.Core.csproj
dotnet add D:\My-Project\JMC\JCMS.Model\JCMS.Model.csproj reference  D:\My-Project\JMC\JCMS.Core\JCMS.Core.csproj
dotnet add D:\My-Project\JMC\JCMS.Core\JCMS.Core.csproj package Microsoft.AspNetCore.Http 
dotnet add D:\My-Project\JMC\JCMS.Core\JCMS.Core.csproj package Microsoft.Extensions.Configuration.Abstractions 
dotnet add D:\My-Project\JMC\JCMS.Core\JCMS.Core.csproj package Microsoft.AspNetCore.Hosting 
dotnet add D:\My-Project\JMC\JCMS.Core\JCMS.Core.csproj package Microsoft.Extensions.Logging 
dotnet add D:\My-Project\JMC\JCMS.Core\JCMS.Core.csproj package Microsoft.Extensions.Caching.Memory 
dotnet add D:\My-Project\JMC\JCMS.Core\JCMS.Core.csproj package Newtonsoft.Json 
dotnet add D:\My-Project\JMC\JCMS.Core\JCMS.Core.csproj package System.Drawing.Common
