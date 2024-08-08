using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcTextAttachmentDirection 
{


	[NVP_Manifest(
		Id = "BD26DC19-5C9A-48B5-BB4D-1BFAA2806C22", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextAttachmentDirection.enum_acAttachmentHorizontal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextAttachmentDirection", 
		NodeName = "enum_acAttachmentHorizontal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttachmentHorizontal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTextAttachmentDirection.acAttachmentHorizontal);

		}
	}


	[NVP_Manifest(
		Id = "BC147525-7180-4436-BD5B-167BBCFBBCE8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextAttachmentDirection.enum_acAttachmentVertical", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextAttachmentDirection", 
		NodeName = "enum_acAttachmentVertical", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttachmentVertical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTextAttachmentDirection.acAttachmentVertical);

		}
	}
}
