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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Contains the dimension configuration to use when you publish email sending events
    /// to Amazon CloudWatch.
    /// 
    ///  
    /// <para>
    /// For information about publishing email sending events to Amazon CloudWatch, see the
    /// <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class CloudWatchDimensionConfiguration
    {
        private string _defaultDimensionValue;
        private string _dimensionName;
        private DimensionValueSource _dimensionValueSource;

        /// <summary>
        /// Gets and sets the property DefaultDimensionValue. 
        /// <para>
        /// The default value of the dimension that is published to Amazon CloudWatch if you do
        /// not provide the value of the dimension when you send an email. The default value must:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This value can only contain ASCII letters (a-z, A-Z), numbers (0-9), underscores (_),
        /// or dashes (-).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Contain less than 256 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DefaultDimensionValue
        {
            get { return this._defaultDimensionValue; }
            set { this._defaultDimensionValue = value; }
        }

        // Check to see if DefaultDimensionValue property is set
        internal bool IsSetDefaultDimensionValue()
        {
            return this._defaultDimensionValue != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionName. 
        /// <para>
        /// The name of an Amazon CloudWatch dimension associated with an email sending metric.
        /// The name must:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This value can only contain ASCII letters (a-z, A-Z), numbers (0-9), underscores (_),
        /// or dashes (-).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Contain less than 256 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DimensionName
        {
            get { return this._dimensionName; }
            set { this._dimensionName = value; }
        }

        // Check to see if DimensionName property is set
        internal bool IsSetDimensionName()
        {
            return this._dimensionName != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionValueSource. 
        /// <para>
        /// The place where Amazon SES finds the value of a dimension to publish to Amazon CloudWatch.
        /// If you want Amazon SES to use the message tags that you specify using an <code>X-SES-MESSAGE-TAGS</code>
        /// header or a parameter to the <code>SendEmail</code>/<code>SendRawEmail</code> API,
        /// choose <code>messageTag</code>. If you want Amazon SES to use your own email headers,
        /// choose <code>emailHeader</code>.
        /// </para>
        /// </summary>
        public DimensionValueSource DimensionValueSource
        {
            get { return this._dimensionValueSource; }
            set { this._dimensionValueSource = value; }
        }

        // Check to see if DimensionValueSource property is set
        internal bool IsSetDimensionValueSource()
        {
            return this._dimensionValueSource != null;
        }

    }
}