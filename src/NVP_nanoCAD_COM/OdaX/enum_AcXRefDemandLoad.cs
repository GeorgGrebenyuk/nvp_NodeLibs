using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcXRefDemandLoad 
{


	[NVP_Manifest(
		Id = "71DF7449-CAA8-4956-9F34-75B2ADFDB48F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcXRefDemandLoad.enum_acDemandLoadDisabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcXRefDemandLoad", 
		NodeName = "enum_acDemandLoadDisabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDemandLoadDisabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcXRefDemandLoad.acDemandLoadDisabled);

		}
	}


	[NVP_Manifest(
		Id = "7EF5971B-C8AA-4A4D-9A60-869454785805", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcXRefDemandLoad.enum_acDemandLoadEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcXRefDemandLoad", 
		NodeName = "enum_acDemandLoadEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDemandLoadEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcXRefDemandLoad.acDemandLoadEnabled);

		}
	}


	[NVP_Manifest(
		Id = "3C32A466-03A7-4AC3-82C4-74B50750E3DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcXRefDemandLoad.enum_acDemandLoadEnabledWithCopy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcXRefDemandLoad", 
		NodeName = "enum_acDemandLoadEnabledWithCopy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDemandLoadEnabledWithCopy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcXRefDemandLoad.acDemandLoadEnabledWithCopy);

		}
	}
}
