namespace SharePoint_Default_Master_Pages
{
    using System;

    using Microsoft.SharePoint;

    public static class SPFeatureReceiverPropertiesExtensions
    {
        public static void SetMasterPage(this SPFeatureReceiverProperties properties)
        {
            properties.SetMasterPage("/_catalogs/masterpage/v4.master");
        }

        public static void SetMasterPage(this SPFeatureReceiverProperties properties, string url)
        {
            properties.SetMasterPage(url, true);
        }

        public static void SetMasterPage(this SPFeatureReceiverProperties properties, string url, bool setCustomMasterUrl)
        {
            var curSite = (SPSite)properties.Feature.Parent;
            var curWeb = curSite.RootWeb;
            var masterUri = new Uri(curWeb.Url + url);

            curWeb.MasterUrl = masterUri.AbsolutePath;
            if (setCustomMasterUrl)
            {
                curWeb.CustomMasterUrl = masterUri.AbsolutePath;
            }

            curWeb.Update();
        }
    }
}
