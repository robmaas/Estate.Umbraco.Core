using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;
using Umbraco.Core.Models.Membership;
using Umbraco.Web;
using Umbraco.Web.Models;

using UM = Umbraco.Web;

namespace Estate.Umbraco.Core
{
    public class CoreContext
    {
        public static IPublishedContent Item
        {
            get
            {
                return UmbracoContext.Current.PublishedContentRequest.PublishedContent;
            }
        }

        public static IUser User
        {
            get
            {
                return UmbracoContext.Current.Security.CurrentUser;
            }
        }
    }
}
