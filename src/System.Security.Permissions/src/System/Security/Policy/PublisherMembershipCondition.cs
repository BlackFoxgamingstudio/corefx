﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Security.Policy
{
    public sealed partial class PublisherMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public PublisherMembershipCondition(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get; set; }
        public bool Check(System.Security.Policy.Evidence evidence) { return false; }
        public System.Security.Policy.IMembershipCondition Copy() { return this; }
        public override bool Equals(object o) => base.Equals(o);
        public void FromXml(SecurityElement e) { }
        public void FromXml(SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() => base.GetHashCode();
        public override string ToString() => base.ToString();
        public SecurityElement ToXml() { return default(SecurityElement); }
        public SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(SecurityElement); }
    }
}
