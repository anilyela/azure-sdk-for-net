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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.ServiceBus;
using Microsoft.WindowsAzure.Management.ServiceBus.Models;

namespace Microsoft.WindowsAzure.Management.ServiceBus
{
    /// <summary>
    /// The Service Bus Management API includes operations for managing Service
    /// Bus relays.
    /// </summary>
    public static partial class RelayOperationsExtensions
    {
        /// <summary>
        /// Gets the set of connection strings for a relay.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ServiceBus.IRelayOperations.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='relayName'>
        /// The relay name.
        /// </param>
        /// <returns>
        /// The set of connection details for a service bus entity.
        /// </returns>
        public static ServiceBusConnectionDetailsResponse GetConnectionDetails(this IRelayOperations operations, string namespaceName, string relayName)
        {
            try
            {
                return operations.GetConnectionDetailsAsync(namespaceName, relayName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Gets the set of connection strings for a relay.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ServiceBus.IRelayOperations.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='relayName'>
        /// The relay name.
        /// </param>
        /// <returns>
        /// The set of connection details for a service bus entity.
        /// </returns>
        public static Task<ServiceBusConnectionDetailsResponse> GetConnectionDetailsAsync(this IRelayOperations operations, string namespaceName, string relayName)
        {
            return operations.GetConnectionDetailsAsync(namespaceName, relayName, CancellationToken.None);
        }
    }
}