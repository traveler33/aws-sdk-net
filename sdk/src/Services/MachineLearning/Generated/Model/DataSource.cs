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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Represents the output of the <a>GetDataSource</a> operation. 
    /// 
    ///  
    /// <para>
    ///  The content consists of the detailed metadata and data file information and the current
    /// status of the <code>DataSource</code>. 
    /// </para>
    /// </summary>
    public partial class DataSource
    {
        private bool? _computeStatistics;
        private DateTime? _createdAt;
        private string _createdByIamUser;
        private string _dataLocationS3;
        private string _dataRearrangement;
        private long? _dataSizeInBytes;
        private string _dataSourceId;
        private DateTime? _lastUpdatedAt;
        private string _message;
        private string _name;
        private long? _numberOfFiles;
        private RDSMetadata _rdsMetadata;
        private RedshiftMetadata _redshiftMetadata;
        private string _roleARN;
        private EntityStatus _status;

        /// <summary>
        /// Gets and sets the property ComputeStatistics. 
        /// <para>
        ///  The parameter is <code>true</code> if statistics need to be generated from the observation
        /// data. 
        /// </para>
        /// </summary>
        public bool ComputeStatistics
        {
            get { return this._computeStatistics.GetValueOrDefault(); }
            set { this._computeStatistics = value; }
        }

        // Check to see if ComputeStatistics property is set
        internal bool IsSetComputeStatistics()
        {
            return this._computeStatistics.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the <code>DataSource</code> was created. The time is expressed in epoch
        /// time.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedByIamUser. 
        /// <para>
        /// The AWS user account from which the <code>DataSource</code> was created. The account
        /// type can be either an AWS root account or an AWS Identity and Access Management (IAM)
        /// user account.
        /// </para>
        /// </summary>
        public string CreatedByIamUser
        {
            get { return this._createdByIamUser; }
            set { this._createdByIamUser = value; }
        }

        // Check to see if CreatedByIamUser property is set
        internal bool IsSetCreatedByIamUser()
        {
            return this._createdByIamUser != null;
        }

        /// <summary>
        /// Gets and sets the property DataLocationS3. 
        /// <para>
        /// The location and name of the data in Amazon Simple Storage Service (Amazon S3) that
        /// is used by a <code>DataSource</code>.
        /// </para>
        /// </summary>
        public string DataLocationS3
        {
            get { return this._dataLocationS3; }
            set { this._dataLocationS3 = value; }
        }

        // Check to see if DataLocationS3 property is set
        internal bool IsSetDataLocationS3()
        {
            return this._dataLocationS3 != null;
        }

        /// <summary>
        /// Gets and sets the property DataRearrangement. 
        /// <para>
        /// A JSON string that represents the splitting requirement of a <code>Datasource</code>.
        /// 
        /// </para>
        /// </summary>
        public string DataRearrangement
        {
            get { return this._dataRearrangement; }
            set { this._dataRearrangement = value; }
        }

        // Check to see if DataRearrangement property is set
        internal bool IsSetDataRearrangement()
        {
            return this._dataRearrangement != null;
        }

        /// <summary>
        /// Gets and sets the property DataSizeInBytes. 
        /// <para>
        /// The total number of observations contained in the data files that the <code>DataSource</code>
        /// references.
        /// </para>
        /// </summary>
        public long DataSizeInBytes
        {
            get { return this._dataSizeInBytes.GetValueOrDefault(); }
            set { this._dataSizeInBytes = value; }
        }

        // Check to see if DataSizeInBytes property is set
        internal bool IsSetDataSizeInBytes()
        {
            return this._dataSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID that is assigned to the <code>DataSource</code> during creation.
        /// </para>
        /// </summary>
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time of the most recent edit to the <code>BatchPrediction</code>. The time is
        /// expressed in epoch time.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the most recent details about creating the <code>DataSource</code>.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-supplied name or description of the <code>DataSource</code>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfFiles. 
        /// <para>
        /// The number of data files referenced by the <code>DataSource</code>.
        /// </para>
        /// </summary>
        public long NumberOfFiles
        {
            get { return this._numberOfFiles.GetValueOrDefault(); }
            set { this._numberOfFiles = value; }
        }

        // Check to see if NumberOfFiles property is set
        internal bool IsSetNumberOfFiles()
        {
            return this._numberOfFiles.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RDSMetadata.
        /// </summary>
        public RDSMetadata RDSMetadata
        {
            get { return this._rdsMetadata; }
            set { this._rdsMetadata = value; }
        }

        // Check to see if RDSMetadata property is set
        internal bool IsSetRDSMetadata()
        {
            return this._rdsMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftMetadata.
        /// </summary>
        public RedshiftMetadata RedshiftMetadata
        {
            get { return this._redshiftMetadata; }
            set { this._redshiftMetadata = value; }
        }

        // Check to see if RedshiftMetadata property is set
        internal bool IsSetRedshiftMetadata()
        {
            return this._redshiftMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN.
        /// </summary>
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the <code>DataSource</code>. This element can have one of the
        /// following values: 
        /// </para>
        ///  <ul> <li>PENDING - Amazon Machine Learning (Amazon ML) submitted a request to create
        /// a <code>DataSource</code>.</li> <li>INPROGRESS - The creation process is underway.</li>
        /// <li>FAILED - The request to create a <code>DataSource</code> did not run to completion.
        /// It is not usable.</li> <li>COMPLETED - The creation process completed successfully.</li>
        /// <li>DELETED - The <code>DataSource</code> is marked as deleted. It is not usable.</li>
        /// </ul>
        /// </summary>
        public EntityStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}