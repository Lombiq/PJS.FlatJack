using System.Collections.Generic;
using Orchard.Environment.Extensions.Models;
using Orchard.Security.Permissions;

namespace PJS.FlatJack {
    public class Permissions : IPermissionProvider {
        public static readonly Permission ManageThemeSettings = new Permission { Description = "Manage Theme Settings", Name = "ManageThemeSettings" };

        public virtual Feature Feature { get; set; }

        public IEnumerable<Permission> GetPermissions() {
            return new[] {
                ManageThemeSettings
            };
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes() {
            return new[] {
                new PermissionStereotype {
                    Name = "Administrator",
                    Permissions = new[] { ManageThemeSettings }
                },
            };
        }
    }
}