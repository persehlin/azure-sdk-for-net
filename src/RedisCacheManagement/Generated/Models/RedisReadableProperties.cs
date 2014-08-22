// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Redis.Models;

namespace Microsoft.Azure.Management.Redis.Models
{
    /// <summary>
    /// Parameters describing a redis instance
    /// </summary>
    public partial class RedisReadableProperties : RedisWriteableProperties
    {
        private string _hostName;
        
        /// <summary>
        /// Optional. The redis host name
        /// </summary>
        public string HostName
        {
            get { return this._hostName; }
            set { this._hostName = value; }
        }
        
        private int _port;
        
        /// <summary>
        /// Optional. The redis non-ssl port
        /// </summary>
        public int Port
        {
            get { return this._port; }
            set { this._port = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. The redis instance provisioning status
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private string _runtimeVersion;
        
        /// <summary>
        /// Optional. The detailed version of Redis deploy.
        /// </summary>
        public string RuntimeVersion
        {
            get { return this._runtimeVersion; }
            set { this._runtimeVersion = value; }
        }
        
        private int _sslPort;
        
        /// <summary>
        /// Optional. The redis ssl port
        /// </summary>
        public int SslPort
        {
            get { return this._sslPort; }
            set { this._sslPort = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RedisReadableProperties class.
        /// </summary>
        public RedisReadableProperties()
        {
        }
    }
}
