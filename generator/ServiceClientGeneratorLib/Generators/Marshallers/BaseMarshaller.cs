﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Marshallers
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class BaseMarshaller : Generators.BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 7 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

    // Adds the neccesary namespaces for the marshaller
protected void AddCommonUsingStatements()
    {

        
        #line default
        #line hidden
        
        #line 11 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Globalization;\r\nus" +
        "ing System.IO;\r\nusing System.Text;\r\nusing System.Xml.Serialization;\r\n\r\nusing ");

        
        #line default
        #line hidden
        
        #line 19 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));

        
        #line default
        #line hidden
        
        #line 19 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".Model;\r\nusing Amazon.Runtime;\r\nusing Amazon.Runtime.Internal;\r\nusing Amazon.Runt" +
        "ime.Internal.Transform;\r\nusing Amazon.Runtime.Internal.Util;\r\n");

        
        #line default
        #line hidden
        
        #line 24 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

    }

        
        #line default
        #line hidden
        
        #line 28 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

    // Generates code to add members to the header of the request
    // If it's a custom marshaller then it calls the custom marshaller first
	protected void ProcessHeaderMembers(string variableName, IEnumerable<Member> members)
	{
		foreach(var member in members)
		{

        
        #line default
        #line hidden
        
        #line 35 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\r\n\t\t\tif(");

        
        #line default
        #line hidden
        
        #line 36 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 36 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 36 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 36 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("())\r\n");

        
        #line default
        #line hidden
        
        #line 37 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

            if (member.CustomMarshallerTransformation != null)
            {

        
        #line default
        #line hidden
        
        #line 40 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Headers[\"");

        
        #line default
        #line hidden
        
        #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\"] = ");

        
        #line default
        #line hidden
        
        #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.CustomMarshallerTransformation));

        
        #line default
        #line hidden
        
        #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(");\r\n");

        
        #line default
        #line hidden
        
        #line 42 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
        
            }
            else if (member.IsJsonValue)
            {

        
        #line default
        #line hidden
        
        #line 46 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Headers[\"");

        
        #line default
        #line hidden
        
        #line 47 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 47 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\"] = Convert.ToBase64String(Encoding.UTF8.GetBytes(");

        
        #line default
        #line hidden
        
        #line 47 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 47 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 47 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 47 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 48 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

            }
            else
            {

        
        #line default
        #line hidden
        
        #line 52 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Headers[\"");

        
        #line default
        #line hidden
        
        #line 53 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 53 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\"] = ");

        
        #line default
        #line hidden
        
        #line 53 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 53 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 53 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 53 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(";\r\n");

        
        #line default
        #line hidden
        
        #line 54 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
			
		    }
        }
	}

    // Generates code to add the operation's requestURIMembers to the uriResourcePath
	protected void ProcessUriMembers(string variableName, Operation operation)
	{
		foreach(var member in operation.RequestUriMembers)
		{
            if (member.model.Customizations.SkipUriPropertyValidations.Contains(member.PropertyName))
            {

        
        #line default
        #line hidden
        
        #line 66 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\turiResourcePath = uriResourcePath.Replace(\"{");

        
        #line default
        #line hidden
        
        #line 67 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 67 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("}\", ");

        
        #line default
        #line hidden
        
        #line 67 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 67 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 67 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 67 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("() ? StringUtils.From");

        
        #line default
        #line hidden
        
        #line 67 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.GetPrimitiveType()));

        
        #line default
        #line hidden
        
        #line 67 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 67 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 67 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 67 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 67 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(") : string.Empty);\r\n");

        
        #line default
        #line hidden
        
        #line 68 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

            }
            else
            {

        
        #line default
        #line hidden
        
        #line 72 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("            if (!");

        
        #line default
        #line hidden
        
        #line 73 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 73 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 73 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 73 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("())\r\n                throw new ");

        
        #line default
        #line hidden
        
        #line 74 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseException));

        
        #line default
        #line hidden
        
        #line 74 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("(\"Request object does not have required field ");

        
        #line default
        #line hidden
        
        #line 74 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 74 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(" set\");\r\n\t\t\turiResourcePath = uriResourcePath.Replace(\"{");

        
        #line default
        #line hidden
        
        #line 75 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 75 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("}\", StringUtils.From");

        
        #line default
        #line hidden
        
        #line 75 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.GetPrimitiveType()));

        
        #line default
        #line hidden
        
        #line 75 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 75 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 75 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 75 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 75 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 76 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
			
            }
		}
	}

	protected void ProcessRequestUri(Operation operation)
	{

        
        #line default
        #line hidden
        
        #line 83 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\tstring uriResourcePath = \"");

        
        #line default
        #line hidden
        
        #line 84 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(operation.RequestUri));

        
        #line default
        #line hidden
        
        #line 84 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\";\r\n");

        
        #line default
        #line hidden
        
        #line 85 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

		foreach(var staticQueryParam in operation.StaticQueryParameters)
		{
			if(staticQueryParam.Value != null)
			{

        
        #line default
        #line hidden
        
        #line 90 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\trequest.AddSubResource(\"");

        
        #line default
        #line hidden
        
        #line 91 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(staticQueryParam.Key));

        
        #line default
        #line hidden
        
        #line 91 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\", \"");

        
        #line default
        #line hidden
        
        #line 91 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(staticQueryParam.Value));

        
        #line default
        #line hidden
        
        #line 91 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\");\r\n");

        
        #line default
        #line hidden
        
        #line 92 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
			
			}
			else
			{

        
        #line default
        #line hidden
        
        #line 96 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\trequest.AddSubResource(\"");

        
        #line default
        #line hidden
        
        #line 97 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(staticQueryParam.Key));

        
        #line default
        #line hidden
        
        #line 97 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\");\r\n");

        
        #line default
        #line hidden
        
        #line 98 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
						
			}
		}
	}

    // Generates code to add any operation query members to the query string for the request
    // If the marshaller is customized, it marshalls the value before changing it to a string
	protected void ProcessQueryStringMembers(string variableName, Operation operation)
	{
		if(operation.RequestHasQueryStringMembers)		
		{
			foreach(var member in operation.RequestQueryStringMembers)
			{

        
        #line default
        #line hidden
        
        #line 111 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\t\r\n\t\t\tif (");

        
        #line default
        #line hidden
        
        #line 112 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 112 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 112 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 112 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("())\r\n");

        
        #line default
        #line hidden
        
        #line 113 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

                if (member.CustomMarshallerTransformation != null)
                {

        
        #line default
        #line hidden
        
        #line 116 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Parameters.Add(\"");

        
        #line default
        #line hidden
        
        #line 117 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 117 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\", ");

        
        #line default
        #line hidden
        
        #line 117 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.CustomMarshallerTransformation));

        
        #line default
        #line hidden
        
        #line 117 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 117 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 117 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 117 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 117 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 118 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
        
                }
                else if (member.IsMap)
                {

        
        #line default
        #line hidden
        
        #line 122 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("            {\r\n                foreach(var kvp in ");

        
        #line default
        #line hidden
        
        #line 124 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 124 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 124 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 124 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(")\r\n                {\r\n                    request.Parameters.Add(kvp.Key, kvp.Val" +
        "ue);\r\n                }\r\n            }\r\n");

        
        #line default
        #line hidden
        
        #line 129 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

                }
                else
                {

        
        #line default
        #line hidden
        
        #line 133 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Parameters.Add(\"");

        
        #line default
        #line hidden
        
        #line 134 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 134 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\", StringUtils.From");

        
        #line default
        #line hidden
        
        #line 134 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.GetPrimitiveType()));

        
        #line default
        #line hidden
        
        #line 134 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 134 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 134 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 134 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 134 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 135 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
			
				}
			}
		}
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
