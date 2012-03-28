namespace SharePoint_Default_Master_Pages
{
    using System;

    using Microsoft.SharePoint;

    public class MasterPageMethods
    {
        public static void SetDefaultMasterPage(SPFeatureReceiverProperties properties)
        {
            SetMasterPage(properties, "/_catalogs/masterpage/v4.master");
        }

        public static void SetMasterPage(SPFeatureReceiverProperties properties, string url)
        {
            SPSite curSite = (SPSite)properties.Feature.Parent;
            SPWeb curWeb = curSite.RootWeb;
            Uri masterUri = new Uri(curWeb.Url + url);
            curWeb.MasterUrl = masterUri.AbsolutePath;
            curWeb.CustomMasterUrl = masterUri.AbsolutePath;
            curWeb.Update();
        }
    }
}
