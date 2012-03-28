using System.Runtime.InteropServices;

using Microsoft.SharePoint;

namespace SharePoint_Default_Master_Pages.Features.Activate_starter_mysitehost.master
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("bfaab585-38bb-4b5a-8147-bc5ac766188b")]
    public class Activate_starter_mysitehostEventReceiver : SPFeatureReceiver
    {
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            MasterPageMethods.SetMasterPage(properties, "/_catalogs/masterpage/_starter_mysitehost.master");
        }

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            MasterPageMethods.SetDefaultMasterPage(properties);
        }
    }
}
