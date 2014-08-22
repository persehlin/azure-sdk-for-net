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
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.Redis.Models
{
    /// <summary>
    /// The response to a GET redis operation.
    /// </summary>
    public partial class RedisGetResponse : OperationResponse
    {
        private string _id;
        
        /// <summary>
        /// Optional. The id of the created resource.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Optional. The resource's geographic location.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Name of the cache.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private RedisReadableProperties _properties;
        
        /// <summary>
        /// Optional. properties
        /// </summary>
        public RedisReadableProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Resource's type.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RedisGetResponse class.
        /// </summary>
        public RedisGetResponse()
        {
        }
    }
}
