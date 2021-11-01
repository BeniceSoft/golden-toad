using BeniceSoft.GoldenToad.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BeniceSoft.GoldenToad.Permissions
{
    public class GoldenToadPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(GoldenToadPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(GoldenToadPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<GoldenToadResource>(name);
        }
    }
}
