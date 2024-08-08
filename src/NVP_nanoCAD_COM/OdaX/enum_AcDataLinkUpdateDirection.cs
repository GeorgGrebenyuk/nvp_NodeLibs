using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDataLinkUpdateDirection 
{


	[NVP_Manifest(
		Id = "40CB183F-B4C3-4E66-8C8B-103E73D8D20B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDataLinkUpdateDirection.enum_acUpdateDataFromSource", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDataLinkUpdateDirection", 
		NodeName = "enum_acUpdateDataFromSource", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUpdateDataFromSource : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDataLinkUpdateDirection.acUpdateDataFromSource);

		}
	}


	[NVP_Manifest(
		Id = "EF75001E-859B-4602-9889-D3744E5BAF81", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDataLinkUpdateDirection.enum_acUpdateSourceFromData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDataLinkUpdateDirection", 
		NodeName = "enum_acUpdateSourceFromData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUpdateSourceFromData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDataLinkUpdateDirection.acUpdateSourceFromData);

		}
	}
}
