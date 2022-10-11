using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class SecurityDbSeeder
    {
        private readonly UserManager<IdentityUser> _userManager;
        public SecurityDbSeeder(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task EnsurePopulated()
        {
            const string claimUserType = "UserType";
            const string usernamePowerUser = "poweruser";
            const string password = "Secret123$";

            const string usernameRegularUser = "regularuser";
            

            IdentityUser user = await _userManager.FindByNameAsync(usernamePowerUser);
            Claim powerUserClaim = new Claim(claimUserType, "poweruser");
            Claim regularUserClaim = new Claim(claimUserType, "regularuser");

            if (user == null)
            {
                user = new IdentityUser(usernamePowerUser);

                await _userManager.CreateAsync(user, password);
                await _userManager.AddClaimAsync(user, powerUserClaim);
            }

            user = await _userManager.FindByNameAsync(usernameRegularUser);

            if (user == null)
            {
                user = new IdentityUser(usernameRegularUser);

                await _userManager.CreateAsync(user, password);
                await _userManager.AddClaimAsync(user, regularUserClaim);

                // for role-based authz use a role manager (via DI oc) -->
                //
                // var roleManager = new RoleManager<IdentityUser>();
                // roleManager.CreateAsync(...)
                // ...
                //_userManager.AddToRoleAsync(...)
            }

        }
    }
}
