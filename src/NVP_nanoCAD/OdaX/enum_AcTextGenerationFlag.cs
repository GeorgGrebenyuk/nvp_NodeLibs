using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcTextGenerationFlag 
{


	[NVP_Manifest(
		Id = "5EA5C3D3-19E9-45C4-9844-94ACDA154F1D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextGenerationFlag.enum_acTextFlagBackward", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextGenerationFlag", 
		NodeName = "enum_acTextFlagBackward", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTextFlagBackward : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTextGenerationFlag.acTextFlagBackward);

		}
	}


	[NVP_Manifest(
		Id = "6B23DBC7-BB98-4C8B-96A3-989534A628F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextGenerationFlag.enum_acTextFlagUpsideDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextGenerationFlag", 
		NodeName = "enum_acTextFlagUpsideDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTextFlagUpsideDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTextGenerationFlag.acTextFlagUpsideDown);

		}
	}
}
