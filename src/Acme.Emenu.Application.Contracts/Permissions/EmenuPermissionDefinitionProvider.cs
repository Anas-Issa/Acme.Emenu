using Acme.Emenu.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.Emenu.Permissions;

public class EmenuPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EmenuPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EmenuPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EmenuResource>(name);
    }
}
