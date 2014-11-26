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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HadoopJarStepConfig Object
    /// </summary>  
    public class HadoopJarStepConfigUnmarshaller : IUnmarshaller<HadoopJarStepConfig, XmlUnmarshallerContext>, IUnmarshaller<HadoopJarStepConfig, JsonUnmarshallerContext>
    {
        HadoopJarStepConfig IUnmarshaller<HadoopJarStepConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public HadoopJarStepConfig Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new HadoopJarStepConfig();
            unmarshalledObject.Args = null;
            unmarshalledObject.Properties = null;
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("Args", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.Args =  null;
                            continue;
                        }
                        unmarshalledObject.Args = new List<string>();
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.Args.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("Jar", targetDepth))
                    {
                        unmarshalledObject.Jar = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MainClass", targetDepth))
                    {
                        unmarshalledObject.MainClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Properties", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.Properties =  null;
                            continue;
                        }
                        unmarshalledObject.Properties = new List<KeyValue>();
                        var unmarshaller = KeyValueUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.Properties.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }


        private static HadoopJarStepConfigUnmarshaller instance;
        public static HadoopJarStepConfigUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new HadoopJarStepConfigUnmarshaller();
            }
            return instance;
        }

    }
}