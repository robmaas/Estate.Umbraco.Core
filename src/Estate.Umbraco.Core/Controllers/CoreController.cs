using System;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace Estate.Umbraco.Core.Controllers
{
    public class CoreController : SurfaceController
    {
        public T GetCurrentItem<T>() where T : PublishedContentModel
        {
            return Activator.CreateInstance(typeof(T), ContextItem) as T;
        }

        public T GetItem<T>(IPublishedContent content) where T : PublishedContentModel
        {
            return Activator.CreateInstance(typeof(T), content) as T;
        }

        public IPublishedContent ContextItem
        {
            get
            {
                return UmbracoContext.Current.PublishedContentRequest.PublishedContent;
            }
        }
    }
}