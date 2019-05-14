// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.Collections;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using IdentityServer4.Quickstart.UI;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServerService.Quickstart.Diagnostics
{
    [SecurityHeaders]
    [Authorize]
    public class DiagnosticsController : AbpController
    {
        public async Task<IActionResult> Index()
        {
            var localAddresses = new string[] {"127.0.0.1", "::1", HttpContext.Connection.LocalIpAddress.ToString()};
            // castovao u ilist
            if (!((IList) localAddresses).Contains(HttpContext.Connection.RemoteIpAddress.ToString())) return NotFound();

            var model = new DiagnosticsViewModel(await HttpContext.AuthenticateAsync());
            return View(model);
        }
    }
}