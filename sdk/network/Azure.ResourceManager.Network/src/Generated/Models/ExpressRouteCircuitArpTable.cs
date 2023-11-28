// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The ARP table associated with the ExpressRouteCircuit. </summary>
    public partial class ExpressRouteCircuitArpTable
    {
        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitArpTable"/>. </summary>
        internal ExpressRouteCircuitArpTable()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitArpTable"/>. </summary>
        /// <param name="age"> Entry age in minutes. </param>
        /// <param name="interface"> Interface address. </param>
        /// <param name="ipAddress"> The IP address. </param>
        /// <param name="macAddress"> The MAC address. </param>
        internal ExpressRouteCircuitArpTable(int? age, string @interface, string ipAddress, string macAddress)
        {
            Age = age;
            Interface = @interface;
            IPAddress = ipAddress;
            MacAddress = macAddress;
        }

        /// <summary> Entry age in minutes. </summary>
        public int? Age { get; }
        /// <summary> Interface address. </summary>
        public string Interface { get; }
        /// <summary> The IP address. </summary>
        public string IPAddress { get; }
        /// <summary> The MAC address. </summary>
        public string MacAddress { get; }
    }
}
