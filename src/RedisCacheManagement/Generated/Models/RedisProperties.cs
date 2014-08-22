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
    /// Properties generated only in response to CreateOrUpdate redis operation.
    /// </summary>
    public partial class RedisProperties : RedisReadableProperties
    {
        private RedisAccessKeys _accessKeys;
        
        /// <summary>
        /// Optional. Redis cache access keys.
        /// </summary>
        public RedisAccessKeys AccessKeys
        {
            get { return this._accessKeys; }
            set { this._accessKeys = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RedisProperties class.
        /// </summary>
        public RedisProperties()
        {
        }
    }
}
