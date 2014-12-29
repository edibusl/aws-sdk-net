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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribePoliciesResult : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ScalingPolicy> _scalingPolicies = new List<ScalingPolicy>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use when requesting the next set of items. If there are no additional
        /// items to return, the string is empty.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingPolicies. 
        /// <para>
        /// The scaling policies.
        /// </para>
        /// </summary>
        public List<ScalingPolicy> ScalingPolicies
        {
            get { return this._scalingPolicies; }
            set { this._scalingPolicies = value; }
        }

        // Check to see if ScalingPolicies property is set
        internal bool IsSetScalingPolicies()
        {
            return this._scalingPolicies != null && this._scalingPolicies.Count > 0; 
        }

    }
}