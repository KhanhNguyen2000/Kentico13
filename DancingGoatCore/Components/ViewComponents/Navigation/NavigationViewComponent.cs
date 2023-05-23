using System.Collections.Generic;
using System.Linq;
using CMS.DocumentEngine;
using DancingGoat.Models;

using Kentico.Content.Web.Mvc;

using Microsoft.AspNetCore.Mvc;

namespace DancingGoat.Controllers
{
    public class NavigationViewComponent : ViewComponent
    {
        private readonly NavigationRepository navigationRepository;
        private readonly IPageUrlRetriever pageUrlRetriever;


        public NavigationViewComponent(NavigationRepository navigationRepository, IPageUrlRetriever pageUrlRetriever)
        {
            this.navigationRepository = navigationRepository;
            this.pageUrlRetriever = pageUrlRetriever;
        }

        public bool CheckRootParent(TreeNode node, string nameParent)
        {
            if(node.Parent == null && node.DocumentName == nameParent)
            {
                return true;
            }
            if (node.Parent == null && node.DocumentName != nameParent)
            {
                return false;
            }
            if (node.Parent.DocumentName != nameParent) {
                return CheckRootParent(node.Parent, nameParent); 
            }
            return true;
        }

        public IViewComponentResult Invoke(bool footerNavigation, bool flag)
        {
            var viewName = footerNavigation ? "Footer" : "Menu";
            var menuItems = footerNavigation ? navigationRepository.GetFooterNavigationItems() : navigationRepository.GetMenuItems();
            HashSet<string> customers = new HashSet<string>();
            List<TreeNode> lst = new List<TreeNode>();
            
            if(flag)
            {
                foreach (var menuItem in menuItems)
                {
                    bool rs = CheckRootParent(menuItem, "Khách hàng cá nhân");       
                    if (rs)
                    {
                        lst.Add(menuItem);
                    }
                }
            }
            else
            {
                foreach (var menuItem in menuItems)
                {
                    bool rs = CheckRootParent(menuItem, "Khách hàng doanh nghiệp");
                    if (rs)
                    {
                        lst.Add(menuItem);
                    }
                }
            }
            


            var menuItemsModel = lst.Select(menuItem => MenuItemViewModel.GetViewModel(menuItem, pageUrlRetriever));
            /*var menuItemsModel = menuItems.Select(menuItem => MenuItemViewModel.GetViewModel(menuItem, pageUrlRetriever));
            */
            return View($"~/Components/ViewComponents/Navigation/{viewName}.cshtml", menuItemsModel);
        }
    }
}