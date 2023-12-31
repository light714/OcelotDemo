﻿using IdentityServer4.Models;
using IdentityServer4.Services;

namespace OcelotDemo.Auth.DataInit
{
    public class ProfileService : IProfileService
    {
        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var claims = context.Subject.Claims.ToList();
            context.IssuedClaims = claims.ToList();
        }
        public async Task IsActiveAsync(IsActiveContext context)
        {
            context.IsActive = true;
        }
    }
}
