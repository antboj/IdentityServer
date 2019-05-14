using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using Abp.Domain.Uow;
using Abp.Runtime.Security;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using TestProject.Authorization.Users;

namespace IdentityServerService
{
    public class MyProfileService : IProfileService
    {
        private readonly UserManager _userManager;
        private readonly IActiveUnitOfWork _unitOfWorkManager;

        public MyProfileService(UserManager userManager, IActiveUnitOfWork unitOfWorkManager)
        {
            _userManager = userManager;
            _unitOfWorkManager = unitOfWorkManager;
        }

        public Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            //var subject = context.Subject;
            //var requestedClaimTypes = context.RequestedClaimTypes?.ToArray();
            //var key = subject.GetSubjectId();
            ////var sub = subject.FindFirst("sub")?.Value;

            //if (subject == null)
            //{
            //    throw new ArgumentException("The subject can't be null");
            //}

            //var user = _userManager.FindByIdAsync(key);
            ////var user = await _userManager.FindByNameAsync(sub);
            //var claimsPr = await GetClaims(await user);
            //var claims = claimsPr.Claims;

            //if (requestedClaimTypes != null && requestedClaimTypes.Any())
            //{
            //    claims = claims.Where(x => requestedClaimTypes.Contains(x.Type)).ToList();
            //}

            //context.IssuedClaims = claims as List<Claim>;
            throw new NotImplementedException();
        }

        //private async Task<ClaimsPrincipal> GetClaims (User user)
        //{
        //    if (user == null)
        //    {
        //        throw new ArgumentNullException(nameof(user));
        //    }

        //    var id = new ClaimsIdentity();
        //    id.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
        //    id.AddClaims(await _userManager.GetClaimsAsync(user));
        //    //id.AddClaim(new Claim(ClaimTypes.Email, user.EmailAddress));

        //    return new ClaimsPrincipal(id);
        //}


        public Task IsActiveAsync(IsActiveContext context)
        {
            throw new NotImplementedException();
        }
    }
}