// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> SSIS access credential. </summary>
    public partial class SsisAccessCredential
    {
        /// <summary> Initializes a new instance of SsisAccessCredential. </summary>
        /// <param name="domain"> Domain for windows authentication. </param>
        /// <param name="userName"> UseName for windows authentication. </param>
        /// <param name="password"> Password for windows authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domain"/>, <paramref name="userName"/>, or <paramref name="password"/> is null. </exception>
        public SsisAccessCredential(object domain, object userName, SecretBase password)
        {
            if (domain == null)
            {
                throw new ArgumentNullException(nameof(domain));
            }
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            Domain = domain;
            UserName = userName;
            Password = password;
        }

        /// <summary> Domain for windows authentication. </summary>
        public object Domain { get; set; }
        /// <summary> UseName for windows authentication. </summary>
        public object UserName { get; set; }
        /// <summary> Password for windows authentication. </summary>
        public SecretBase Password { get; set; }
    }
}