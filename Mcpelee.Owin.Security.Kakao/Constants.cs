// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace Mcpelee.Owin.Security.Kakao
{
    internal static class Constants
    {
        public const string DefaultAuthenticationType = "Kakao";

        internal const string AuthorizationEndpoint = "https://kauth.kakao.com/oauth/authorize";
        internal const string TokenEndpoint = "https://kauth.kakao.com/oauth/token";
        internal const string UserInformationEndpoint = "https://kapi.kakao.com/v2/user/me";
    }
}
