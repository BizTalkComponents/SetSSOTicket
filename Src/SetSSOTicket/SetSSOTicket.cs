using BizTalkComponents.Utils;
using Microsoft.BizTalk.Component.Interop;
using Microsoft.BizTalk.Message.Interop;
using Microsoft.EnterpriseSingleSignOn.Interop;


namespace BizTalkComponents.PipelineComponents.SetSSOTicket
{
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [System.Runtime.InteropServices.Guid("84CA57A3-74AC-4262-B558-0B75B6D898F7")]
    [ComponentCategory(CategoryTypes.CATID_Encoder)]
    public partial class SetSSOTicket : IComponent, IBaseComponent, IComponentUI
    {
        public IBaseMessage Execute(IPipelineContext pContext, IBaseMessage pInMsg)
        {
            var ticket = new ISSOTicket();

            pInMsg.Context.Write(new ContextProperty(SSOTicketProperties.SSOTicket), ticket.IssueTicket(0));

            return pInMsg;
        }
    }
}
