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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a condition for a rule.
    /// </summary>
    public partial class RuleCondition
    {
        private string _field;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The name of the field. The possible values are <code>host-header</code> and <code>path-pattern</code>.
        /// </para>
        /// </summary>
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The condition value.
        /// </para>
        ///  
        /// <para>
        /// If the field name is <code>host-header</code>, you can specify a single host name
        /// (for example, my.example.com). A host name is case insensitive, can be up to 128 characters
        /// in length, and can contain any of the following characters. Note that you can include
        /// up to three wildcard characters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A-Z, a-z, 0-9
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// - .
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// * (matches 0 or more characters)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ? (matches exactly 1 character)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the field name is <code>path-pattern</code>, you can specify a single path pattern
        /// (for example, /img/*). A path pattern is case sensitive, can be up to 128 characters
        /// in length, and can contain any of the following characters. Note that you can include
        /// up to three wildcard characters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A-Z, a-z, 0-9
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// _ - . $ / ~ " ' @ : +
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// &amp; (using &amp;amp;)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// * (matches 0 or more characters)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ? (matches exactly 1 character)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}