using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDimTextMovement 
{


	[NVP_Manifest(
		Id = "ED6BDA81-164A-42B1-9E1E-0549F2E4F654", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimTextMovement.enum_acDimLineWithText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimTextMovement", 
		NodeName = "enum_acDimLineWithText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimLineWithText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimTextMovement.acDimLineWithText);

		}
	}


	[NVP_Manifest(
		Id = "BCB0F285-FE58-4D58-A53B-40F7B6F5185A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimTextMovement.enum_acMoveTextAddLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimTextMovement", 
		NodeName = "enum_acMoveTextAddLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMoveTextAddLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimTextMovement.acMoveTextAddLeader);

		}
	}


	[NVP_Manifest(
		Id = "49D1D04F-7BDC-4B00-8C71-A3748692420B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimTextMovement.enum_acMoveTextNoLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimTextMovement", 
		NodeName = "enum_acMoveTextNoLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMoveTextNoLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimTextMovement.acMoveTextNoLeader);

		}
	}
}
