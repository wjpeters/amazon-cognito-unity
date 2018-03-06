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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the DescribeSubscriptionFilters operation.
    /// </summary>
    public partial class DescribeSubscriptionFiltersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SubscriptionFilter> _subscriptionFilters = new List<SubscriptionFilter>();

        /// <summary>
        /// Gets and sets the property NextToken.
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
        /// Gets and sets the property SubscriptionFilters. 
        /// <para>
        /// The subscription filters.
        /// </para>
        /// </summary>
        public List<SubscriptionFilter> SubscriptionFilters
        {
            get { return this._subscriptionFilters; }
            set { this._subscriptionFilters = value; }
        }

        // Check to see if SubscriptionFilters property is set
        internal bool IsSetSubscriptionFilters()
        {
            return this._subscriptionFilters != null && this._subscriptionFilters.Count > 0; 
        }

    }
}