using System.Runtime.InteropServices;

using Microsoft.SharePoint;

namespace SharePoint_Default_Master_Pages.Features.Activate_starter.master
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("b6aafe7b-37e4-488d-9956-7863da5a4cff")]
    public class Activate_starterEventReceiver : SPFeatureReceiver
    {
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            properties.SetMasterPage("/_catalogs/masterpage/_starter.master");
        }

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            properties.SetMasterPage();
        }
    }
}
