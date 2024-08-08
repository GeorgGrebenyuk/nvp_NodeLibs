using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcTableFlowDirection 
{


	[NVP_Manifest(
		Id = "E741B3E0-5D13-4717-A3CA-46020C591B4C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableFlowDirection.enum_acTableFlowRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableFlowDirection", 
		NodeName = "enum_acTableFlowRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTableFlowRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableFlowDirection.acTableFlowRight);

		}
	}


	[NVP_Manifest(
		Id = "A1530F0C-8DED-47AE-B16D-1AFC01A01FA2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableFlowDirection.enum_acTableFlowDownOrUp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableFlowDirection", 
		NodeName = "enum_acTableFlowDownOrUp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTableFlowDownOrUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableFlowDirection.acTableFlowDownOrUp);

		}
	}


	[NVP_Manifest(
		Id = "6858268A-7A94-4E02-95D8-7D3982F1866E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableFlowDirection.enum_acTableFlowLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableFlowDirection", 
		NodeName = "enum_acTableFlowLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTableFlowLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableFlowDirection.acTableFlowLeft);

		}
	}
}
