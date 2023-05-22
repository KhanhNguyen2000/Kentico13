using CMS.DocumentEngine;

using Kentico.Content.Web.Mvc;

namespace DancingGoat.Models
{
    public class MenuItemViewModel
    {
        public string Caption { get; set; }


        public string Url { get; set; }

        public string Parent { get; set; }
        
        public bool ShowInMenu { get; set; }

        public static MenuItemViewModel GetViewModel(TreeNode menuItem, IPageUrlRetriever pageUrlRetriever)
        {
            return new MenuItemViewModel
            {
                Parent = menuItem.Parent.DocumentName,
                ShowInMenu = menuItem.Parent.DocumentShowInMenu,
                Caption = menuItem.DocumentName,
                Url = pageUrlRetriever.Retrieve(menuItem).RelativePath
            };
        }
    }
}