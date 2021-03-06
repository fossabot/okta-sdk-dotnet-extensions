using Okta.Sdk;

namespace Finbourne.Extensions.Okta.Sdk.Resources.Settings
{
    public interface ISignInPageSettings : IResource
    {
        string SigninLabel { get; set; }
        string UsernameLabel { get; set; }
        string UsernameInlineLabel { get; set; }
        string PasswordLabel { get; set; }
        string PasswordInlineLabel { get; set; }
        string ForgottenPasswordLabel { get; set; }
        string ForgottenPasswordHref { get; set; }
        string UnlockAccountLabel { get; set; }
        string UnlockAccountHref { get; set; }
        string OktaHelpLabel { get; set; }
        string OktaHelpHref { get; set; }
        string CustomLinkOneText { get; set; }
        string CustomLinkOneHref { get; set; }
        string CustomLinkTwoText { get; set; }
        string CustomLinkTwoHref { get; set; }
        string FooterHelpTitle { get; set; }
        string RecoveryFlowPlaceholder { get; set; }
        IDefaultOrgLoginPageSettings DefaultOrgLoginPageSettings { get; set; }
    }
}