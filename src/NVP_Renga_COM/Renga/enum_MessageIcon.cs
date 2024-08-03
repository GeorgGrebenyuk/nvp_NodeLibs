using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_MessageIcon 
{


	[NVP_Manifest(
		Id = "4D392921-0596-4B3A-B66C-1DD3B1D5A4DF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_MessageIcon.enum_MessageIcon_NoIcon", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_MessageIcon", 
		NodeName = "enum_MessageIcon_NoIcon", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_MessageIcon_NoIcon : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.MessageIcon.MessageIcon_NoIcon);

		}
	}


	[NVP_Manifest(
		Id = "225FC2AA-36A9-4236-953A-1071D4301157", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_MessageIcon.enum_MessageIcon_Info", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_MessageIcon", 
		NodeName = "enum_MessageIcon_Info", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_MessageIcon_Info : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.MessageIcon.MessageIcon_Info);

		}
	}


	[NVP_Manifest(
		Id = "06CCD122-5D06-4659-A1C4-BA35EDD478B4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_MessageIcon.enum_MessageIcon_Warning", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_MessageIcon", 
		NodeName = "enum_MessageIcon_Warning", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_MessageIcon_Warning : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.MessageIcon.MessageIcon_Warning);

		}
	}


	[NVP_Manifest(
		Id = "7DCBEE47-FC89-44A6-B9AA-7E9C80389862", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_MessageIcon.enum_MessageIcon_Error", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_MessageIcon", 
		NodeName = "enum_MessageIcon_Error", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_MessageIcon_Error : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.MessageIcon.MessageIcon_Error);

		}
	}


	[NVP_Manifest(
		Id = "1B2AFEC8-A673-4670-AF44-420A7FDEC3C9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_MessageIcon.enum_MessageIcon_Question", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_MessageIcon", 
		NodeName = "enum_MessageIcon_Question", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_MessageIcon_Question : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.MessageIcon.MessageIcon_Question);

		}
	}
}
