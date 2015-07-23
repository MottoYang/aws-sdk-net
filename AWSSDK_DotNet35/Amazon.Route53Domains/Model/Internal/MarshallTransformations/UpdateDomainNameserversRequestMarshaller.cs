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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Domains.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Route53Domains.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDomainNameservers Request Marshaller
    /// </summary>       
    public class UpdateDomainNameserversRequestMarshaller : IMarshaller<IRequest, UpdateDomainNameserversRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDomainNameserversRequest)input);
        }

        public IRequest Marshall(UpdateDomainNameserversRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53Domains");
            string target = "Route53Domains_v20140515.UpdateDomainNameservers";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDomainName())
                {
                    context.Writer.WritePropertyName("DomainName");
                    context.Writer.Write(publicRequest.DomainName);
                }

                if(publicRequest.IsSetFIAuthKey())
                {
                    context.Writer.WritePropertyName("FIAuthKey");
                    context.Writer.Write(publicRequest.FIAuthKey);
                }

                if(publicRequest.IsSetNameservers())
                {
                    context.Writer.WritePropertyName("Nameservers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNameserversListValue in publicRequest.Nameservers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = NameserverMarshaller.Instance;
                        marshaller.Marshall(publicRequestNameserversListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}