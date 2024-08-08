using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDrawLeaderOrderType 
{


	[NVP_Manifest(
		Id = "952007F4-9F66-4362-85D3-DADBE0523A27", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDrawLeaderOrderType.enum_acDrawLeaderHeadFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDrawLeaderOrderType", 
		NodeName = "enum_acDrawLeaderHeadFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDrawLeaderHeadFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDrawLeaderOrderType.acDrawLeaderHeadFirst);

		}
	}


	[NVP_Manifest(
		Id = "B26600A6-BAA9-4E35-8E70-BA7C2952CAE1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDrawLeaderOrderType.enum_acDrawLeaderTailFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDrawLeaderOrderType", 
		NodeName = "enum_acDrawLeaderTailFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDrawLeaderTailFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDrawLeaderOrderType.acDrawLeaderTailFirst);

		}
	}
}
