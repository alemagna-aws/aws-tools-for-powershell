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
using Amazon.ConnectWisdomService;
using Amazon.ConnectWisdomService.Model;

namespace Amazon.PowerShell.Cmdlets.WSDM
{
    /// <summary>
    /// Amazon.ConnectWisdomService.IAmazonConnectWisdomService.CreateKnowledgeBase
    /// </summary>
    [Cmdlet("New", "WSDMKnowledgeBase", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.ConnectWisdomService.Model.KnowledgeBaseData")]
    [AWSCmdlet("Calls the Amazon Connect Wisdom Service CreateKnowledgeBase API operation.", Operation = new[] {"CreateKnowledgeBase"}, SelectReturnType = typeof(Amazon.ConnectWisdomService.Model.CreateKnowledgeBaseResponse))]
    [AWSCmdletOutput("Amazon.ConnectWisdomService.Model.KnowledgeBaseData or Amazon.ConnectWisdomService.Model.CreateKnowledgeBaseResponse",
        "This cmdlet returns an Amazon.ConnectWisdomService.Model.KnowledgeBaseData object.",
        "The service call response (type Amazon.ConnectWisdomService.Model.CreateKnowledgeBaseResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewWSDMKnowledgeBaseCmdlet : AmazonConnectWisdomServiceClientCmdlet, IExecutor
    {
        
        #region Parameter AppIntegrations_AppIntegrationArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the AppIntegrations DataIntegration to use for ingesting
        /// content.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SourceConfiguration_AppIntegrations_AppIntegrationArn")]
        public System.String AppIntegrations_AppIntegrationArn { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>The description.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter ServerSideEncryptionConfiguration_KmsKeyId
        /// <summary>
        /// <para>
        /// <para>The KMS key. For information about valid ID values, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id">Key
        /// identifiers (KeyId)</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ServerSideEncryptionConfiguration_KmsKeyId { get; set; }
        #endregion
        
        #region Parameter KnowledgeBaseType
        /// <summary>
        /// <para>
        /// <para>The type of knowledge base. Only CUSTOM knowledge bases allow you to upload your own
        /// content. EXTERNAL knowledge bases support integrations with third-party systems whose
        /// content is synchronized automatically. </para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.ConnectWisdomService.KnowledgeBaseType")]
        public Amazon.ConnectWisdomService.KnowledgeBaseType KnowledgeBaseType { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The name of the knowledge base.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter AppIntegrations_ObjectField
        /// <summary>
        /// <para>
        /// <para>The fields from the source that are made available to your agents in Wisdom. </para><ul><li><para> For <a href="https://developer.salesforce.com/docs/atlas.en-us.knowledge_dev.meta/knowledge_dev/sforce_api_objects_knowledge__kav.htm">
        /// Salesforce</a>, you must include at least <code>Id</code>, <code>ArticleNumber</code>,
        /// <code>VersionNumber</code>, <code>Title</code>, <code>PublishStatus</code>, and <code>IsDeleted</code>.
        /// </para></li><li><para>For <a href="https://developer.servicenow.com/dev.do#!/reference/api/rome/rest/knowledge-management-api">
        /// ServiceNow</a>, you must include at least <code>number</code>, <code>short_description</code>,
        /// <code>sys_mod_count</code>, <code>workflow_state</code>, and <code>active</code>.
        /// </para></li></ul><para>Make sure to include additional fields. These fields are indexed and used to source
        /// recommendations. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SourceConfiguration_AppIntegrations_ObjectFields")]
        public System.String[] AppIntegrations_ObjectField { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>The tags used to organize, track, or control access for this resource.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public System.Collections.Hashtable Tag { get; set; }
        #endregion
        
        #region Parameter RenderingConfiguration_TemplateUri
        /// <summary>
        /// <para>
        /// <para>A URI template containing exactly one variable in <code>${variableName} </code>format.
        /// This can only be set for <code>EXTERNAL</code> knowledge bases. For Salesforce and
        /// ServiceNow, the variable must be one of the following:</para><ul><li><para>Salesforce: <code>Id</code>, <code>ArticleNumber</code>, <code>VersionNumber</code>,
        /// <code>Title</code>, <code>PublishStatus</code>, or <code>IsDeleted</code></para></li><li><para>ServiceNow: <code>number</code>, <code>short_description</code>, <code>sys_mod_count</code>,
        /// <code>workflow_state</code>, or <code>active</code></para></li></ul><pre><code> &lt;p&gt;The variable is replaced with the actual value for
        /// a piece of content when calling &lt;a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_GetContent.html"&gt;GetContent&lt;/a&gt;.
        /// &lt;/p&gt; </code></pre>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String RenderingConfiguration_TemplateUri { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'KnowledgeBase'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ConnectWisdomService.Model.CreateKnowledgeBaseResponse).
        /// Specifying the name of a property of type Amazon.ConnectWisdomService.Model.CreateKnowledgeBaseResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "KnowledgeBase";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Name parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.")]
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
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-WSDMKnowledgeBase (CreateKnowledgeBase)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ConnectWisdomService.Model.CreateKnowledgeBaseResponse, NewWSDMKnowledgeBaseCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Name;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClientToken = this.ClientToken;
            context.Description = this.Description;
            context.KnowledgeBaseType = this.KnowledgeBaseType;
            #if MODULAR
            if (this.KnowledgeBaseType == null && ParameterWasBound(nameof(this.KnowledgeBaseType)))
            {
                WriteWarning("You are passing $null as a value for parameter KnowledgeBaseType which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.RenderingConfiguration_TemplateUri = this.RenderingConfiguration_TemplateUri;
            context.ServerSideEncryptionConfiguration_KmsKeyId = this.ServerSideEncryptionConfiguration_KmsKeyId;
            context.AppIntegrations_AppIntegrationArn = this.AppIntegrations_AppIntegrationArn;
            if (this.AppIntegrations_ObjectField != null)
            {
                context.AppIntegrations_ObjectField = new List<System.String>(this.AppIntegrations_ObjectField);
            }
            if (this.Tag != null)
            {
                context.Tag = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.Tag.Keys)
                {
                    context.Tag.Add((String)hashKey, (String)(this.Tag[hashKey]));
                }
            }
            
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
            var request = new Amazon.ConnectWisdomService.Model.CreateKnowledgeBaseRequest();
            
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.KnowledgeBaseType != null)
            {
                request.KnowledgeBaseType = cmdletContext.KnowledgeBaseType;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            
             // populate RenderingConfiguration
            var requestRenderingConfigurationIsNull = true;
            request.RenderingConfiguration = new Amazon.ConnectWisdomService.Model.RenderingConfiguration();
            System.String requestRenderingConfiguration_renderingConfiguration_TemplateUri = null;
            if (cmdletContext.RenderingConfiguration_TemplateUri != null)
            {
                requestRenderingConfiguration_renderingConfiguration_TemplateUri = cmdletContext.RenderingConfiguration_TemplateUri;
            }
            if (requestRenderingConfiguration_renderingConfiguration_TemplateUri != null)
            {
                request.RenderingConfiguration.TemplateUri = requestRenderingConfiguration_renderingConfiguration_TemplateUri;
                requestRenderingConfigurationIsNull = false;
            }
             // determine if request.RenderingConfiguration should be set to null
            if (requestRenderingConfigurationIsNull)
            {
                request.RenderingConfiguration = null;
            }
            
             // populate ServerSideEncryptionConfiguration
            var requestServerSideEncryptionConfigurationIsNull = true;
            request.ServerSideEncryptionConfiguration = new Amazon.ConnectWisdomService.Model.ServerSideEncryptionConfiguration();
            System.String requestServerSideEncryptionConfiguration_serverSideEncryptionConfiguration_KmsKeyId = null;
            if (cmdletContext.ServerSideEncryptionConfiguration_KmsKeyId != null)
            {
                requestServerSideEncryptionConfiguration_serverSideEncryptionConfiguration_KmsKeyId = cmdletContext.ServerSideEncryptionConfiguration_KmsKeyId;
            }
            if (requestServerSideEncryptionConfiguration_serverSideEncryptionConfiguration_KmsKeyId != null)
            {
                request.ServerSideEncryptionConfiguration.KmsKeyId = requestServerSideEncryptionConfiguration_serverSideEncryptionConfiguration_KmsKeyId;
                requestServerSideEncryptionConfigurationIsNull = false;
            }
             // determine if request.ServerSideEncryptionConfiguration should be set to null
            if (requestServerSideEncryptionConfigurationIsNull)
            {
                request.ServerSideEncryptionConfiguration = null;
            }
            
             // populate SourceConfiguration
            var requestSourceConfigurationIsNull = true;
            request.SourceConfiguration = new Amazon.ConnectWisdomService.Model.SourceConfiguration();
            Amazon.ConnectWisdomService.Model.AppIntegrationsConfiguration requestSourceConfiguration_sourceConfiguration_AppIntegrations = null;
            
             // populate AppIntegrations
            var requestSourceConfiguration_sourceConfiguration_AppIntegrationsIsNull = true;
            requestSourceConfiguration_sourceConfiguration_AppIntegrations = new Amazon.ConnectWisdomService.Model.AppIntegrationsConfiguration();
            System.String requestSourceConfiguration_sourceConfiguration_AppIntegrations_appIntegrations_AppIntegrationArn = null;
            if (cmdletContext.AppIntegrations_AppIntegrationArn != null)
            {
                requestSourceConfiguration_sourceConfiguration_AppIntegrations_appIntegrations_AppIntegrationArn = cmdletContext.AppIntegrations_AppIntegrationArn;
            }
            if (requestSourceConfiguration_sourceConfiguration_AppIntegrations_appIntegrations_AppIntegrationArn != null)
            {
                requestSourceConfiguration_sourceConfiguration_AppIntegrations.AppIntegrationArn = requestSourceConfiguration_sourceConfiguration_AppIntegrations_appIntegrations_AppIntegrationArn;
                requestSourceConfiguration_sourceConfiguration_AppIntegrationsIsNull = false;
            }
            List<System.String> requestSourceConfiguration_sourceConfiguration_AppIntegrations_appIntegrations_ObjectField = null;
            if (cmdletContext.AppIntegrations_ObjectField != null)
            {
                requestSourceConfiguration_sourceConfiguration_AppIntegrations_appIntegrations_ObjectField = cmdletContext.AppIntegrations_ObjectField;
            }
            if (requestSourceConfiguration_sourceConfiguration_AppIntegrations_appIntegrations_ObjectField != null)
            {
                requestSourceConfiguration_sourceConfiguration_AppIntegrations.ObjectFields = requestSourceConfiguration_sourceConfiguration_AppIntegrations_appIntegrations_ObjectField;
                requestSourceConfiguration_sourceConfiguration_AppIntegrationsIsNull = false;
            }
             // determine if requestSourceConfiguration_sourceConfiguration_AppIntegrations should be set to null
            if (requestSourceConfiguration_sourceConfiguration_AppIntegrationsIsNull)
            {
                requestSourceConfiguration_sourceConfiguration_AppIntegrations = null;
            }
            if (requestSourceConfiguration_sourceConfiguration_AppIntegrations != null)
            {
                request.SourceConfiguration.AppIntegrations = requestSourceConfiguration_sourceConfiguration_AppIntegrations;
                requestSourceConfigurationIsNull = false;
            }
             // determine if request.SourceConfiguration should be set to null
            if (requestSourceConfigurationIsNull)
            {
                request.SourceConfiguration = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
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
        
        private Amazon.ConnectWisdomService.Model.CreateKnowledgeBaseResponse CallAWSServiceOperation(IAmazonConnectWisdomService client, Amazon.ConnectWisdomService.Model.CreateKnowledgeBaseRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Connect Wisdom Service", "CreateKnowledgeBase");
            try
            {
                #if DESKTOP
                return client.CreateKnowledgeBase(request);
                #elif CORECLR
                return client.CreateKnowledgeBaseAsync(request).GetAwaiter().GetResult();
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
            public System.String ClientToken { get; set; }
            public System.String Description { get; set; }
            public Amazon.ConnectWisdomService.KnowledgeBaseType KnowledgeBaseType { get; set; }
            public System.String Name { get; set; }
            public System.String RenderingConfiguration_TemplateUri { get; set; }
            public System.String ServerSideEncryptionConfiguration_KmsKeyId { get; set; }
            public System.String AppIntegrations_AppIntegrationArn { get; set; }
            public List<System.String> AppIntegrations_ObjectField { get; set; }
            public Dictionary<System.String, System.String> Tag { get; set; }
            public System.Func<Amazon.ConnectWisdomService.Model.CreateKnowledgeBaseResponse, NewWSDMKnowledgeBaseCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.KnowledgeBase;
        }
        
    }
}
