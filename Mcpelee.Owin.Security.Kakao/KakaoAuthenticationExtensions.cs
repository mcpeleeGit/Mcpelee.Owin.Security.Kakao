// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Owin.Security;
using Mcpelee.Owin.Security.Kakao;

namespace Owin
{
    /// <summary>
    /// Extension methods for using <see cref="KakaoAuthenticationMiddleware"/>
    /// </summary>
    public static class KakaoAuthenticationExtensions
    {
        /// <summary>
        /// Authenticate users using Kakao
        /// </summary>
        /// <param name="app">The <see cref="IAppBuilder"/> passed to the configuration method</param>
        /// <param name="options">Middleware configuration options</param>
        /// <returns>The updated <see cref="IAppBuilder"/></returns>
        public static IAppBuilder UseKakaoAuthentication(this IAppBuilder app, KakaoAuthenticationOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            app.Use(typeof(KakaoAuthenticationMiddleware), app, options);
            return app;
        }

        /// <summary>
        /// Authenticate users using Kakao
        /// </summary>
        /// <param name="app">The <see cref="IAppBuilder"/> passed to the configuration method</param>
        /// <param name="appId">The appId assigned by Kakao</param>
        /// <param name="appSecret">The appSecret assigned by Kakao</param>
        /// <returns>The updated <see cref="IAppBuilder"/></returns>
        public static IAppBuilder UseKakaoAuthentication(
            this IAppBuilder app,
            string appId,
            string appSecret)
        {
            return UseKakaoAuthentication(
                app,
                new KakaoAuthenticationOptions
                {
                    AppId = appId,
                    AppSecret = appSecret,
                });
        }
    }
}
