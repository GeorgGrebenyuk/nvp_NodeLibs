using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcHatchObjectType 
{


	[NVP_Manifest(
		Id = "283D8DDC-F283-4B2E-A3FD-1629731B2B8C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHatchObjectType.enum_acHatchObject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHatchObjectType", 
		NodeName = "enum_acHatchObject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatchObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHatchObjectType.acHatchObject);

		}
	}


	[NVP_Manifest(
		Id = "98B1FFD9-CEE0-41ED-97E5-2889BDE9B281", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHatchObjectType.enum_acGradientObject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHatchObjectType", 
		NodeName = "enum_acGradientObject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acGradientObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHatchObjectType.acGradientObject);

		}
	}
}
