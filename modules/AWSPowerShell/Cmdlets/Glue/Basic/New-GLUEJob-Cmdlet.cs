/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.Glue;
using Amazon.Glue.Model;

namespace Amazon.PowerShell.Cmdlets.GLUE
{
    /// <summary>
    /// Creates a new job definition.
    /// </summary>
    [Cmdlet("New", "GLUEJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the AWS Glue CreateJob API operation.", Operation = new[] {"CreateJob"}, SelectReturnType = typeof(Amazon.Glue.Model.CreateJobResponse))]
    [AWSCmdletOutput("System.String or Amazon.Glue.Model.CreateJobResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.Glue.Model.CreateJobResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewGLUEJobCmdlet : AmazonGlueClientCmdlet, IExecutor
    {
        
        #region Parameter Command
        /// <summary>
        /// <para>
        /// <para>The <code>JobCommand</code> that runs this job.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public Amazon.Glue.Model.JobCommand Command { get; set; }
        #endregion
        
        #region Parameter Connections_Connection
        /// <summary>
        /// <para>
        /// <para>A list of connections used by the job.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Connections_Connections")]
        public System.String[] Connections_Connection { get; set; }
        #endregion
        
        #region Parameter DefaultArgument
        /// <summary>
        /// <para>
        /// <para>The default arguments for this job.</para><para>You can specify arguments here that your own job-execution script consumes, as well
        /// as arguments that Glue itself consumes.</para><para>For information about how to specify and consume your own Job arguments, see the <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-programming-python-calling.html">Calling
        /// Glue APIs in Python</a> topic in the developer guide.</para><para>For information about the key-value pairs that Glue consumes to set up your job, see
        /// the <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-programming-etl-glue-arguments.html">Special
        /// Parameters Used by Glue</a> topic in the developer guide.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("DefaultArguments")]
        public System.Collections.Hashtable DefaultArgument { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>Description of the job being defined.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter GlueVersion
        /// <summary>
        /// <para>
        /// <para>Glue version determines the versions of Apache Spark and Python that Glue supports.
        /// The Python version indicates the version supported for jobs of type Spark. </para><para>For more information about the available Glue versions and corresponding Spark and
        /// Python versions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Glue
        /// version</a> in the developer guide.</para><para>Jobs that are created without specifying a Glue version default to Glue 0.9.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String GlueVersion { get; set; }
        #endregion
        
        #region Parameter LogUri
        /// <summary>
        /// <para>
        /// <para>This field is reserved for future use.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LogUri { get; set; }
        #endregion
        
        #region Parameter MaxCapacity
        /// <summary>
        /// <para>
        /// <para>For Glue version 1.0 or earlier jobs, using the standard worker type, the number of
        /// Glue data processing units (DPUs) that can be allocated when this job runs. A DPU
        /// is a relative measure of processing power that consists of 4 vCPUs of compute capacity
        /// and 16 GB of memory. For more information, see the <a href="https://aws.amazon.com/glue/pricing/">Glue
        /// pricing page</a>.</para><para>Do not set <code>Max Capacity</code> if using <code>WorkerType</code> and <code>NumberOfWorkers</code>.</para><para>The value that can be allocated for <code>MaxCapacity</code> depends on whether you
        /// are running a Python shell job or an Apache Spark ETL job:</para><ul><li><para>When you specify a Python shell job (<code>JobCommand.Name</code>="pythonshell"),
        /// you can allocate either 0.0625 or 1 DPU. The default is 0.0625 DPU.</para></li><li><para>When you specify an Apache Spark ETL job (<code>JobCommand.Name</code>="glueetl")
        /// or Apache Spark streaming ETL job (<code>JobCommand.Name</code>="gluestreaming"),
        /// you can allocate from 2 to 100 DPUs. The default is 10 DPUs. This job type cannot
        /// have a fractional DPU allocation.</para></li></ul><para>For Glue version 2.0 jobs, you cannot instead specify a <code>Maximum capacity</code>.
        /// Instead, you should specify a <code>Worker type</code> and the <code>Number of workers</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Double? MaxCapacity { get; set; }
        #endregion
        
        #region Parameter ExecutionProperty_MaxConcurrentRun
        /// <summary>
        /// <para>
        /// <para>The maximum number of concurrent runs allowed for the job. The default is 1. An error
        /// is returned when this threshold is reached. The maximum value you can specify is controlled
        /// by a service limit.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ExecutionProperty_MaxConcurrentRuns")]
        public System.Int32? ExecutionProperty_MaxConcurrentRun { get; set; }
        #endregion
        
        #region Parameter MaxRetry
        /// <summary>
        /// <para>
        /// <para>The maximum number of times to retry this job if it fails.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxRetries")]
        public System.Int32? MaxRetry { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The name you assign to this job definition. It must be unique in your account.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter NonOverridableArgument
        /// <summary>
        /// <para>
        /// <para>Non-overridable arguments for this job, specified as name-value pairs.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("NonOverridableArguments")]
        public System.Collections.Hashtable NonOverridableArgument { get; set; }
        #endregion
        
        #region Parameter NotificationProperty_NotifyDelayAfter
        /// <summary>
        /// <para>
        /// <para>After a job run starts, the number of minutes to wait before sending a job run delay
        /// notification.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? NotificationProperty_NotifyDelayAfter { get; set; }
        #endregion
        
        #region Parameter NumberOfWorker
        /// <summary>
        /// <para>
        /// <para>The number of workers of a defined <code>workerType</code> that are allocated when
        /// a job runs.</para><para>The maximum number of workers you can define are 299 for <code>G.1X</code>, and 149
        /// for <code>G.2X</code>. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("NumberOfWorkers")]
        public System.Int32? NumberOfWorker { get; set; }
        #endregion
        
        #region Parameter Role
        /// <summary>
        /// <para>
        /// <para>The name or Amazon Resource Name (ARN) of the IAM role associated with this job.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String Role { get; set; }
        #endregion
        
        #region Parameter SecurityConfiguration
        /// <summary>
        /// <para>
        /// <para>The name of the <code>SecurityConfiguration</code> structure to be used with this
        /// job.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SecurityConfiguration { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>The tags to use with this job. You may use tags to limit access to the job. For more
        /// information about tags in Glue, see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-tags.html">Amazon
        /// Web Services Tags in Glue</a> in the developer guide.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public System.Collections.Hashtable Tag { get; set; }
        #endregion
        
        #region Parameter Timeout
        /// <summary>
        /// <para>
        /// <para>The job timeout in minutes. This is the maximum time that a job run can consume resources
        /// before it is terminated and enters <code>TIMEOUT</code> status. The default is 2,880
        /// minutes (48 hours).</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? Timeout { get; set; }
        #endregion
        
        #region Parameter WorkerType
        /// <summary>
        /// <para>
        /// <para>The type of predefined worker that is allocated when a job runs. Accepts a value of
        /// Standard, G.1X, or G.2X.</para><ul><li><para>For the <code>Standard</code> worker type, each worker provides 4 vCPU, 16 GB of memory
        /// and a 50GB disk, and 2 executors per worker.</para></li><li><para>For the <code>G.1X</code> worker type, each worker maps to 1 DPU (4 vCPU, 16 GB of
        /// memory, 64 GB disk), and provides 1 executor per worker. We recommend this worker
        /// type for memory-intensive jobs.</para></li><li><para>For the <code>G.2X</code> worker type, each worker maps to 2 DPU (8 vCPU, 32 GB of
        /// memory, 128 GB disk), and provides 1 executor per worker. We recommend this worker
        /// type for memory-intensive jobs.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Glue.WorkerType")]
        public Amazon.Glue.WorkerType WorkerType { get; set; }
        #endregion
        
        #region Parameter AllocatedCapacity
        /// <summary>
        /// <para>
        /// <para>This parameter is deprecated. Use <code>MaxCapacity</code> instead.</para><para>The number of Glue data processing units (DPUs) to allocate to this Job. You can allocate
        /// from 2 to 100 DPUs; the default is 10. A DPU is a relative measure of processing power
        /// that consists of 4 vCPUs of compute capacity and 16 GB of memory. For more information,
        /// see the <a href="https://aws.amazon.com/glue/pricing/">Glue pricing page</a>.</para>
        /// </para>
        /// <para>This parameter is deprecated.</para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [System.ObsoleteAttribute("This property is deprecated, use MaxCapacity instead.")]
        public System.Int32? AllocatedCapacity { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Name'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Glue.Model.CreateJobResponse).
        /// Specifying the name of a property of type Amazon.Glue.Model.CreateJobResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Name";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Command parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Command' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Command' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Name), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-GLUEJob (CreateJob)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Glue.Model.CreateJobResponse, NewGLUEJobCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Command;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AllocatedCapacity = this.AllocatedCapacity;
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Command = this.Command;
            #if MODULAR
            if (this.Command == null && ParameterWasBound(nameof(this.Command)))
            {
                WriteWarning("You are passing $null as a value for parameter Command which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Connections_Connection != null)
            {
                context.Connections_Connection = new List<System.String>(this.Connections_Connection);
            }
            if (this.DefaultArgument != null)
            {
                context.DefaultArgument = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.DefaultArgument.Keys)
                {
                    context.DefaultArgument.Add((String)hashKey, (String)(this.DefaultArgument[hashKey]));
                }
            }
            context.Description = this.Description;
            context.ExecutionProperty_MaxConcurrentRun = this.ExecutionProperty_MaxConcurrentRun;
            context.GlueVersion = this.GlueVersion;
            context.LogUri = this.LogUri;
            context.MaxCapacity = this.MaxCapacity;
            context.MaxRetry = this.MaxRetry;
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.NonOverridableArgument != null)
            {
                context.NonOverridableArgument = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.NonOverridableArgument.Keys)
                {
                    context.NonOverridableArgument.Add((String)hashKey, (String)(this.NonOverridableArgument[hashKey]));
                }
            }
            context.NotificationProperty_NotifyDelayAfter = this.NotificationProperty_NotifyDelayAfter;
            context.NumberOfWorker = this.NumberOfWorker;
            context.Role = this.Role;
            #if MODULAR
            if (this.Role == null && ParameterWasBound(nameof(this.Role)))
            {
                WriteWarning("You are passing $null as a value for parameter Role which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SecurityConfiguration = this.SecurityConfiguration;
            if (this.Tag != null)
            {
                context.Tag = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.Tag.Keys)
                {
                    context.Tag.Add((String)hashKey, (String)(this.Tag[hashKey]));
                }
            }
            context.Timeout = this.Timeout;
            context.WorkerType = this.WorkerType;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.Glue.Model.CreateJobRequest();
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (cmdletContext.AllocatedCapacity != null)
            {
                request.AllocatedCapacity = cmdletContext.AllocatedCapacity.Value;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (cmdletContext.Command != null)
            {
                request.Command = cmdletContext.Command;
            }
            
             // populate Connections
            var requestConnectionsIsNull = true;
            request.Connections = new Amazon.Glue.Model.ConnectionsList();
            List<System.String> requestConnections_connections_Connection = null;
            if (cmdletContext.Connections_Connection != null)
            {
                requestConnections_connections_Connection = cmdletContext.Connections_Connection;
            }
            if (requestConnections_connections_Connection != null)
            {
                request.Connections.Connections = requestConnections_connections_Connection;
                requestConnectionsIsNull = false;
            }
             // determine if request.Connections should be set to null
            if (requestConnectionsIsNull)
            {
                request.Connections = null;
            }
            if (cmdletContext.DefaultArgument != null)
            {
                request.DefaultArguments = cmdletContext.DefaultArgument;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            
             // populate ExecutionProperty
            var requestExecutionPropertyIsNull = true;
            request.ExecutionProperty = new Amazon.Glue.Model.ExecutionProperty();
            System.Int32? requestExecutionProperty_executionProperty_MaxConcurrentRun = null;
            if (cmdletContext.ExecutionProperty_MaxConcurrentRun != null)
            {
                requestExecutionProperty_executionProperty_MaxConcurrentRun = cmdletContext.ExecutionProperty_MaxConcurrentRun.Value;
            }
            if (requestExecutionProperty_executionProperty_MaxConcurrentRun != null)
            {
                request.ExecutionProperty.MaxConcurrentRuns = requestExecutionProperty_executionProperty_MaxConcurrentRun.Value;
                requestExecutionPropertyIsNull = false;
            }
             // determine if request.ExecutionProperty should be set to null
            if (requestExecutionPropertyIsNull)
            {
                request.ExecutionProperty = null;
            }
            if (cmdletContext.GlueVersion != null)
            {
                request.GlueVersion = cmdletContext.GlueVersion;
            }
            if (cmdletContext.LogUri != null)
            {
                request.LogUri = cmdletContext.LogUri;
            }
            if (cmdletContext.MaxCapacity != null)
            {
                request.MaxCapacity = cmdletContext.MaxCapacity.Value;
            }
            if (cmdletContext.MaxRetry != null)
            {
                request.MaxRetries = cmdletContext.MaxRetry.Value;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.NonOverridableArgument != null)
            {
                request.NonOverridableArguments = cmdletContext.NonOverridableArgument;
            }
            
             // populate NotificationProperty
            var requestNotificationPropertyIsNull = true;
            request.NotificationProperty = new Amazon.Glue.Model.NotificationProperty();
            System.Int32? requestNotificationProperty_notificationProperty_NotifyDelayAfter = null;
            if (cmdletContext.NotificationProperty_NotifyDelayAfter != null)
            {
                requestNotificationProperty_notificationProperty_NotifyDelayAfter = cmdletContext.NotificationProperty_NotifyDelayAfter.Value;
            }
            if (requestNotificationProperty_notificationProperty_NotifyDelayAfter != null)
            {
                request.NotificationProperty.NotifyDelayAfter = requestNotificationProperty_notificationProperty_NotifyDelayAfter.Value;
                requestNotificationPropertyIsNull = false;
            }
             // determine if request.NotificationProperty should be set to null
            if (requestNotificationPropertyIsNull)
            {
                request.NotificationProperty = null;
            }
            if (cmdletContext.NumberOfWorker != null)
            {
                request.NumberOfWorkers = cmdletContext.NumberOfWorker.Value;
            }
            if (cmdletContext.Role != null)
            {
                request.Role = cmdletContext.Role;
            }
            if (cmdletContext.SecurityConfiguration != null)
            {
                request.SecurityConfiguration = cmdletContext.SecurityConfiguration;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.Timeout != null)
            {
                request.Timeout = cmdletContext.Timeout.Value;
            }
            if (cmdletContext.WorkerType != null)
            {
                request.WorkerType = cmdletContext.WorkerType;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Glue.Model.CreateJobResponse CallAWSServiceOperation(IAmazonGlue client, Amazon.Glue.Model.CreateJobRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Glue", "CreateJob");
            try
            {
                #if DESKTOP
                return client.CreateJob(request);
                #elif CORECLR
                return client.CreateJobAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            [System.ObsoleteAttribute]
            public System.Int32? AllocatedCapacity { get; set; }
            public Amazon.Glue.Model.JobCommand Command { get; set; }
            public List<System.String> Connections_Connection { get; set; }
            public Dictionary<System.String, System.String> DefaultArgument { get; set; }
            public System.String Description { get; set; }
            public System.Int32? ExecutionProperty_MaxConcurrentRun { get; set; }
            public System.String GlueVersion { get; set; }
            public System.String LogUri { get; set; }
            public System.Double? MaxCapacity { get; set; }
            public System.Int32? MaxRetry { get; set; }
            public System.String Name { get; set; }
            public Dictionary<System.String, System.String> NonOverridableArgument { get; set; }
            public System.Int32? NotificationProperty_NotifyDelayAfter { get; set; }
            public System.Int32? NumberOfWorker { get; set; }
            public System.String Role { get; set; }
            public System.String SecurityConfiguration { get; set; }
            public Dictionary<System.String, System.String> Tag { get; set; }
            public System.Int32? Timeout { get; set; }
            public Amazon.Glue.WorkerType WorkerType { get; set; }
            public System.Func<Amazon.Glue.Model.CreateJobResponse, NewGLUEJobCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Name;
        }
        
    }
}
