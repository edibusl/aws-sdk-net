/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the result of a successful invocation of the following actions: 
    /// 
    ///  <ul> <li><a>CreateDBSubnetGroup</a></li> <li><a>ModifyDBSubnetGroup</a></li> <li><a>DescribeDBSubnetGroups</a></li>
    /// <li><a>DeleteDBSubnetGroup</a></li> </ul> 
    /// <para>
    /// This data type is used as a response element in the <a>DescribeDBSubnetGroups</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class DBSubnetGroup
    {
        private string _dbSubnetGroupDescription;
        private string _dbSubnetGroupName;
        private string _subnetGroupStatus;
        private List<Subnet> _subnets = new List<Subnet>();
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property DBSubnetGroupDescription. 
        /// <para>
        ///  Provides the description of the DB subnet group. 
        /// </para>
        /// </summary>
        public string DBSubnetGroupDescription
        {
            get { return this._dbSubnetGroupDescription; }
            set { this._dbSubnetGroupDescription = value; }
        }

        // Check to see if DBSubnetGroupDescription property is set
        internal bool IsSetDBSubnetGroupDescription()
        {
            return this._dbSubnetGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        ///  Specifies the name of the DB subnet group. 
        /// </para>
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this._dbSubnetGroupName; }
            set { this._dbSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this._dbSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetGroupStatus. 
        /// <para>
        ///  Provides the status of the DB subnet group. 
        /// </para>
        /// </summary>
        public string SubnetGroupStatus
        {
            get { return this._subnetGroupStatus; }
            set { this._subnetGroupStatus = value; }
        }

        // Check to see if SubnetGroupStatus property is set
        internal bool IsSetSubnetGroupStatus()
        {
            return this._subnetGroupStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        ///  Contains a list of <a>Subnet</a> elements. 
        /// </para>
        /// </summary>
        public List<Subnet> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        ///  Provides the VpcId of the DB subnet group. 
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}