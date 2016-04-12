using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Che
{
    [DependsOn(typeof(CheCoreModule), typeof(AbpAutoMapperModule))]
    public class CheApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
