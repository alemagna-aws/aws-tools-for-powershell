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
using Amazon.GameSparks;
using Amazon.GameSparks.Model;

namespace Amazon.PowerShell.Cmdlets.GMESP
{
    /// <summary>
    /// Updates one or more sections of the game configuration.
    /// </summary>
    [Cmdlet("Update", "GMESPGameConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.GameSparks.Model.GameConfigurationDetails")]
    [AWSCmdlet("Calls the Amazon GameSparks UpdateGameConfiguration API operation.", Operation = new[] {"UpdateGameConfiguration"}, SelectReturnType = typeof(Amazon.GameSparks.Model.UpdateGameConfigurationResponse))]
    [AWSCmdletOutput("Amazon.GameSparks.Model.GameConfigurationDetails or Amazon.GameSparks.Model.UpdateGameConfigurationResponse",
        "This cmdlet returns an Amazon.GameSparks.Model.GameConfigurationDetails object.",
        "The service call response (type Amazon.GameSparks.Model.UpdateGameConfigurationResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateGMESPGameConfigurationCmdlet : AmazonGameSparksClientCmdlet, IExecutor
    {
        
        #region Parameter GameName
        /// <summary>
        /// <para>
        /// <para>The name of the game.</para>
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
        public System.String GameName { get; set; }
        #endregion
        
        #region Parameter Modification
        /// <summary>
        /// <para>
        /// <para>The list of modifications to make.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("Modifications")]
        public Amazon.GameSparks.Model.SectionModification[] Modification { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'GameConfiguration'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.GameSparks.Model.UpdateGameConfigurationResponse).
        /// Specifying the name of a property of type Amazon.GameSparks.Model.UpdateGameConfigurationResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "GameConfiguration";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the GameName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^GameName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^GameName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.GameName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-GMESPGameConfiguration (UpdateGameConfiguration)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.GameSparks.Model.UpdateGameConfigurationResponse, UpdateGMESPGameConfigurationCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.GameName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.GameName = this.GameName;
            #if MODULAR
            if (this.GameName == null && ParameterWasBound(nameof(this.GameName)))
            {
                WriteWarning("You are passing $null as a value for parameter GameName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Modification != null)
            {
                context.Modification = new List<Amazon.GameSparks.Model.SectionModification>(this.Modification);
            }
            #if MODULAR
            if (this.Modification == null && ParameterWasBound(nameof(this.Modification)))
            {
                WriteWarning("You are passing $null as a value for parameter Modification which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
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
            var request = new Amazon.GameSparks.Model.UpdateGameConfigurationRequest();
            
            if (cmdletContext.GameName != null)
            {
                request.GameName = cmdletContext.GameName;
            }
            if (cmdletContext.Modification != null)
            {
                request.Modifications = cmdletContext.Modification;
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
        
        private Amazon.GameSparks.Model.UpdateGameConfigurationResponse CallAWSServiceOperation(IAmazonGameSparks client, Amazon.GameSparks.Model.UpdateGameConfigurationRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon GameSparks", "UpdateGameConfiguration");
            try
            {
                #if DESKTOP
                return client.UpdateGameConfiguration(request);
                #elif CORECLR
                return client.UpdateGameConfigurationAsync(request).GetAwaiter().GetResult();
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
            public System.String GameName { get; set; }
            public List<Amazon.GameSparks.Model.SectionModification> Modification { get; set; }
            public System.Func<Amazon.GameSparks.Model.UpdateGameConfigurationResponse, UpdateGMESPGameConfigurationCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.GameConfiguration;
        }
        
    }
}
