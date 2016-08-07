using System.Reflection;
using System.Runtime.InteropServices;
using IExpect;

[assembly: AssemblyTitle("I.Expect")]
[assembly: AssemblyDescription("An extensible assertion library for .NET.")]

[assembly: AssemblyProduct(AssemblyInfo.Product)]
[assembly: AssemblyCompany(AssemblyInfo.Company)]
[assembly: AssemblyCopyright(AssemblyInfo.Copyright)]
[assembly: AssemblyVersion(AssemblyInfo.Version)]
[assembly: AssemblyInformationalVersion(AssemblyInfo.InformationalVersion)]

[assembly: ComVisible(false)]
[assembly: Guid("b6e56d4b-6e23-43e3-bf9c-4ffefee8ac4c")]

namespace IExpect
{
    internal static class AssemblyInfo
    {
        public const string Product = "I.Expect";

        public const string Company = "Ben Quarmby";

        public const string Copyright = "Copyright © Ben Quarmby 2016";

        public const string Version = "1.0.0";

        public const string InformationalVersion = Version + "-alpha2";
    }
}
