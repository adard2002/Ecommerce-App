﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication1.Models.Identity;

namespace WebApplication1.Services.Identity
{
    public class IdentityUserService : IUserService
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IHttpContextAccessor httpContextAccessor;

        public IdentityUserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IHttpContextAccessor httpContextAccessor)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<ApplicationUser> GetCurrentUser()
        {
            var principal = httpContextAccessor.HttpContext.User;
            return await GetUser(principal);
        }

        public async Task<ApplicationUser> GetUser(ClaimsPrincipal principal)
        {
            return await userManager.GetUserAsync(principal);
        }


        public async Task<ApplicationUser> Register(RegisterData data, string role, ModelStateDictionary modelState)
        {
            var user = new ApplicationUser
            {
                UserName = data.Email,
                Email = data.Email,
            };

            var result = await userManager.CreateAsync(user, data.Password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, role);
                return user;
            }

            foreach (var error in result.Errors)
            {
                var errorKey =
                    error.Code.Contains("Password") ? nameof(data.Password) :
                    error.Code.Contains("Email") ? nameof(data.Email) :
                    error.Code.Contains("UserName") ? nameof(data.Email) :
                    "";
                modelState.AddModelError(errorKey, error.Description);
            }

            return null;
        }

        public async Task<bool> SignIn(LoginData data)
        {
            var result = await signInManager.PasswordSignInAsync(data.Email, data.Password, false, false);

            return result.Succeeded;
        }

        Task<ApplicationUser> IUserService.GetUser(ClaimsPrincipal principal)
        {
            throw new NotImplementedException();
        }

        
        public async Task SetCurrentProfileImageUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("Url is missing somewhere");

            var user = await GetCurrentUser();
            if (user == null) throw new InvalidOperationException("No current user");

            user.ProfileImageUrl = url;
            await userManager.UpdateAsync(user);

        }

    }
}
