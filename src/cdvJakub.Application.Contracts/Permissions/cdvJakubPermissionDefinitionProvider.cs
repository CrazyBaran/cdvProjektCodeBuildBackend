using cdvJakub.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace cdvJakub.Permissions
{
    public class cdvJakubPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(cdvJakubPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(cdvJakubPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<cdvJakubResource>(name);
        }
    }
}
