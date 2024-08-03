using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_DuctConnectionType 
{


	[NVP_Manifest(
		Id = "C43793DD-B0E4-4A78-9A63-38813E4BFA23", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_DuctConnectionType.enum_DuctConnectionType_Drawband", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_DuctConnectionType", 
		NodeName = "enum_DuctConnectionType_Drawband", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_DuctConnectionType_Drawband : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.DuctConnectionType.DuctConnectionType_Drawband);

		}
	}


	[NVP_Manifest(
		Id = "002EE30B-8DAD-4364-B7DF-DFB00E7F3993", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_DuctConnectionType.enum_DuctConnectionType_SlipOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_DuctConnectionType", 
		NodeName = "enum_DuctConnectionType_SlipOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_DuctConnectionType_SlipOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.DuctConnectionType.DuctConnectionType_SlipOn);

		}
	}


	[NVP_Manifest(
		Id = "EAE3144A-4675-4D6F-89ED-9A6916930741", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_DuctConnectionType.enum_DuctConnectionType_DriveSlip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_DuctConnectionType", 
		NodeName = "enum_DuctConnectionType_DriveSlip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_DuctConnectionType_DriveSlip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.DuctConnectionType.DuctConnectionType_DriveSlip);

		}
	}


	[NVP_Manifest(
		Id = "3C201221-BFAA-44C8-88F1-CB00B669C49B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_DuctConnectionType.enum_DuctConnectionType_Weld", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_DuctConnectionType", 
		NodeName = "enum_DuctConnectionType_Weld", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_DuctConnectionType_Weld : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.DuctConnectionType.DuctConnectionType_Weld);

		}
	}


	[NVP_Manifest(
		Id = "4CEC6E6A-EA33-4515-BA87-01A7974CEA5F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_DuctConnectionType.enum_DuctConnectionType_Flange", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_DuctConnectionType", 
		NodeName = "enum_DuctConnectionType_Flange", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_DuctConnectionType_Flange : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.DuctConnectionType.DuctConnectionType_Flange);

		}
	}
}
