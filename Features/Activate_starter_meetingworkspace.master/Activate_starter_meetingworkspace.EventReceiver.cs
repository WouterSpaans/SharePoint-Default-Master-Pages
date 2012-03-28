using System.Runtime.InteropServices;

using Microsoft.SharePoint;

namespace SharePoint_Default_Master_Pages.Features.Activate_starter_meetingworkspace.master
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("dabe0330-575d-4c76-bb7b-d85ea4e479c1")]
    public class Activate_starter_meetingworkspaceEventReceiver : SPFeatureReceiver
    {
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            properties.SetMasterPage("/_catalogs/masterpage/_starter_meetingworkspace.master");
        }

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            properties.SetMasterPage();
        }
    }
}
