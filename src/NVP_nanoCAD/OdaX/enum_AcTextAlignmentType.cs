using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcTextAlignmentType 
{


	[NVP_Manifest(
		Id = "2C028DE7-ECD7-436A-ABF6-9B089020771C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextAlignmentType.enum_acLeftAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextAlignmentType", 
		NodeName = "enum_acLeftAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acLeftAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTextAlignmentType.acLeftAlignment);

		}
	}


	[NVP_Manifest(
		Id = "62C32612-A122-4449-87C3-D4D1CE91D32A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextAlignmentType.enum_acCenterAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextAlignmentType", 
		NodeName = "enum_acCenterAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCenterAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTextAlignmentType.acCenterAlignment);

		}
	}


	[NVP_Manifest(
		Id = "AAF22237-1C0F-48A5-BE75-8C8231E807C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextAlignmentType.enum_acRightAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextAlignmentType", 
		NodeName = "enum_acRightAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acRightAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTextAlignmentType.acRightAlignment);

		}
	}
}
