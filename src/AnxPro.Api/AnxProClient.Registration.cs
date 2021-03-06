﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    public partial class AnxProClient
    {
        /// <summary>
        /// Register a user account.
        /// </summary>
        /// <param name="username">User account name.  E.g., user's email.</param>
        /// <param name="userTimezone">Timezone of user's registration country.  E.g., Hong Kong.</param>
        /// <param name="country">Three letter country code.</param>
        /// <param name="acceptTc">True to accept t&c of the platform. Must set to true to register successfully.</param>
        /// <param name="language">User preferred language. E.g., en</param>
        /// <remarks>
        /// The platform will send email with verification code if user registered correctly.
        /// </remarks>
        /// <returns></returns>
        public async Task<AnxProResponse> RegisterAsync(string username, string userTimezone, string country, bool acceptTc, string language)
        {
            return await QueryPrivateAsync<AnxProResponse>(
                "register/register",
                new Dictionary<string, string>(5)
                {
                    ["username"] = username,
                    ["userTimezone"] = userTimezone,
                    ["country"] = country,
                    ["accepttc"] = acceptTc ? "1" : "0",
                    ["language"] = language,
                }
            );
        }

        /// <summary>
        /// Verify registration.
        /// </summary>
        /// <param name="verificationCode">Verification code.</param>
        /// <param name="password">Password.</param>
        /// <param name="password2"><c>Password2</c> needs to match <c>Password</c>.</param>
        /// <param name="acceptTc">True to accept t&c of the platform. Must set to true to register successfully.</param>
        /// <param name="country">Three letter country code.</param>
        /// <remarks>
        /// No Rest-Key and Rest-Sign in HTTP header.
        /// The platform will send email with verification code for user to complete registration.
        /// </remarks>
        /// <returns>
        /// <c>ResultCode</c> <c>OK</c> if verification succeeded. <c>SYSTEM_ERROR</c> if verification failed.
        /// </returns>
        public async Task<AnxProResponse> VerifyRegistrationAsync(string verificationCode, string password, string password2, bool acceptTc, string country)
        {
            return await QueryPrivateAsync<AnxProResponse>(
                "register/verifyRegistration",
                new Dictionary<string, string>(5)
                {
                    ["verificationCode"] = verificationCode,
                    ["password"] = password,
                    ["password2"] = password2,
                    ["accepttc"] = acceptTc ? "1" : "0",
                    ["country"] = country,
                }
            );
        }

        /// <summary>
        /// Resend verification.
        /// </summary>
        /// <param name="username">Email for verification code to be resend.</param>
        /// <remarks>
        /// The platform resend verification email to the user.
        /// No Rest-Key and Rest-Sign in HTTP header.
        /// </remarks>
        /// <returns>
        /// <c>ResultCode</c> <c>OK</c> if verification succeeded.
        /// </returns>
        public async Task<AnxProResponse> ResendVerificationAsync(string username)
        {
            return await QueryPrivateAsync<AnxProResponse>(
                "register/resendVerification",
                new Dictionary<string, string>(1)
                {
                    ["username"] = username,
                }
            );
        }

        /// <summary>
        /// Create a user account without email confirmation.
        /// </summary>
        /// <param name="userTimezone">Timezone of user's registration country.</param>
        /// <param name="country">Three letter country code.</param>
        /// <param name="acceptTc">True to accept t&c of the platform. Must set to true to register successfully.</param>
        /// <param name="language">User preferred language.</param>
        /// <param name="usernameType">Type of user account name. E.g., PHONENUMBER</param>
        /// <param name="username">User account name. E.g., +85295271816</param>
        /// <remarks>
        /// This account cannot be login from website/mobile app. The account is only accessible by the master key api.
        /// </remarks>
        /// <returns></returns>
        public async Task<AutoRegisterResponse> AutoRegisterAsync(string userTimezone, string country, bool acceptTc, Language language, UserNameType usernameType, string username)
        {
            return await QueryPrivateAsync<AutoRegisterResponse>(
                "register/autoRegister",
                new Dictionary<string, string>(6)
                {
                    ["userTimezone"] = userTimezone,
                    ["country"] = country,
                    ["accepttc"] = acceptTc ? "1" : "0",
                    ["language"] = language.ToString(),
                    ["usernameType"] = usernameType.ToString(),
                    ["username"] = username,
                }
            );
        }
    }
}
