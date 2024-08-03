using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcVerticalTextAttachmentType 
{


	[NVP_Manifest(
		Id = "6FEAB5BB-3AD0-417C-A3E9-7877C02EE1AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcVerticalTextAttachmentType.enum_acAttachmentCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcVerticalTextAttachmentType", 
		NodeName = "enum_acAttachmentCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttachmentCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcVerticalTextAttachmentType.acAttachmentCenter);

		}
	}


	[NVP_Manifest(
		Id = "4BC8BD77-8B4B-48CC-9BBC-CA2EFF71ABC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcVerticalTextAttachmentType.enum_acAttachmentLinedCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcVerticalTextAttachmentType", 
		NodeName = "enum_acAttachmentLinedCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttachmentLinedCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcVerticalTextAttachmentType.acAttachmentLinedCenter);

		}
	}
}
