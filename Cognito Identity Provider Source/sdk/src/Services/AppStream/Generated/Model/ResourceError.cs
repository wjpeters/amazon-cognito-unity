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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes a resource error.
    /// </summary>
    public partial class ResourceError
    {
        private FleetErrorCode _errorCode;
        private string _errorMessage;
        private DateTime? _errorTimestamp;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code.
        /// </para>
        /// </summary>
        public FleetErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorTimestamp. 
        /// <para>
        /// The time the error occurred.
        /// </para>
        /// </summary>
        public DateTime ErrorTimestamp
        {
            get { return this._errorTimestamp.GetValueOrDefault(); }
            set { this._errorTimestamp = value; }
        }

        // Check to see if ErrorTimestamp property is set
        internal bool IsSetErrorTimestamp()
        {
            return this._errorTimestamp.HasValue; 
        }

    }
}