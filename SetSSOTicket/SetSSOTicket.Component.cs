using System;
using System.Collections;

namespace BizTalkComponents.PipelineComponents.SetSSOTicket
{
    public partial class SetSSOTicket
    {
        public string Name { get { return "SetSSOTicket"; } }
        public string Version { get { return "1.0"; } }
        public string Description { get { return "Issues and promotes a new SSO Ticket"; } }

        public IEnumerator Validate(object projectSystem)
        {
            return null;
        }

        public IntPtr Icon { get { return IntPtr.Zero; } }
    }
}
