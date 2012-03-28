using System.Runtime.InteropServices;

using Microsoft.SharePoint;

namespace SharePoint_Default_Master_Pages.Features.Activate_starter_publishing.master
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("bd157fd4-637c-42a9-bfc3-47e0b8683666")]
    public class Activate_starter_publishingEventReceiver : SPFeatureReceiver
    {
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            MasterPageMethods.SetMasterPage(properties, "/_catalogs/masterpage/_starter_publishing.master");
        }

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            MasterPageMethods.SetDefaultMasterPage(properties);
        }
    }
}
