using Abp.Web.Mvc.Views;

namespace Che.Web.Views
{
    public abstract class CheWebViewPageBase : CheWebViewPageBase<dynamic>
    {

    }

    public abstract class CheWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CheWebViewPageBase()
        {
            LocalizationSourceName = CheConsts.LocalizationSourceName;
        }
    }
}