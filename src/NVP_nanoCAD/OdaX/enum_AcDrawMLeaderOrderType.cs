using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDrawMLeaderOrderType 
{


	[NVP_Manifest(
		Id = "DBA44290-A234-4AD3-8725-4AE6B5E35A19", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDrawMLeaderOrderType.enum_acDrawContentFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDrawMLeaderOrderType", 
		NodeName = "enum_acDrawContentFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDrawContentFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDrawMLeaderOrderType.acDrawContentFirst);

		}
	}


	[NVP_Manifest(
		Id = "061AB15D-8D6A-4688-987D-372C9CA5BC85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDrawMLeaderOrderType.enum_acDrawLeaderFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDrawMLeaderOrderType", 
		NodeName = "enum_acDrawLeaderFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDrawLeaderFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDrawMLeaderOrderType.acDrawLeaderFirst);

		}
	}
}
