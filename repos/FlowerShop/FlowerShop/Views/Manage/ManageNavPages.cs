﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace FlowerShop.Views.Manage
{
    public static class ManageNavPages
    {
        public static string ActivePageKey = "ActivePage";
        public static string Index = "Обшая информация";
        public static string ChangePassword = "Изменить пароль";
       
        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);
        public static string ChangePasswordNavClass(ViewContext viewContext) => PageNavClass(viewContext, ChangePassword);

        public static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string;

            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;

        }
        public static void AddActivePage(this ViewDataDictionary viewData, string activePage)
        {
            viewData[ActivePageKey] = activePage;
        } 
    }
}
