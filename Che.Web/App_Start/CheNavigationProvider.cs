﻿using Abp.Application.Navigation;
using Abp.Localization;
using Che.Authorization;

namespace Che.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class CheNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", CheConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Tenants",
                        L("Tenants"),
                        url: "#tenants",
                        icon: "fa fa-globe",
                        requiredPermissionName: PermissionNames.Pages_Tenants
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", CheConsts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        )
                ).AddItem(new MenuItemDefinition(
                    "lhl",
                    L("lhl"),
                    url: "#/lhl",
                    icon: "fa fa-globe"
                    ));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, CheConsts.LocalizationSourceName);
        }
    }
}
