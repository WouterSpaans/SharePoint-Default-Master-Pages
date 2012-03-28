using System.Runtime.InteropServices;

using Microsoft.SharePoint;

namespace SharePoint_Default_Master_Pages.Features.Activate_starter_foundation.master
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("fce9dc73-6189-4eca-be59-9821d4adf1ec")]
    public class Activate_starter_foundationEventReceiver : SPFeatureReceiver
    {
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            properties.SetMasterPage("/_catalogs/masterpage/_starter_foundation.master");
        }

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            properties.SetMasterPage();
        }
    }
}
