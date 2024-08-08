using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_MessageIcon 
{


	[NVP_Manifest(
		Id = "CBFD4DE9-B21A-4F08-9561-735B9452CBF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_MessageIcon.enum_mcMessageSimple", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_MessageIcon", 
		NodeName = "enum_mcMessageSimple", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcMessageSimple : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.MessageIcon.mcMessageSimple);

		}
	}


	[NVP_Manifest(
		Id = "F1F62A53-FF2E-4018-A9EC-0A1092A82BA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_MessageIcon.enum_mcMessageText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_MessageIcon", 
		NodeName = "enum_mcMessageText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcMessageText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.MessageIcon.mcMessageText);

		}
	}


	[NVP_Manifest(
		Id = "71B5EEE7-5C58-42A0-8491-A7E92DA82D1A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_MessageIcon.enum_mcMessageWarning", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_MessageIcon", 
		NodeName = "enum_mcMessageWarning", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcMessageWarning : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.MessageIcon.mcMessageWarning);

		}
	}


	[NVP_Manifest(
		Id = "36AD65CC-B2FE-4AEA-A24B-8E8768C7F259", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_MessageIcon.enum_mcMessageCure", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_MessageIcon", 
		NodeName = "enum_mcMessageCure", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcMessageCure : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.MessageIcon.mcMessageCure);

		}
	}


	[NVP_Manifest(
		Id = "938B5EF0-64AF-4E8C-888B-48FC812CFF00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_MessageIcon.enum_mcMessageHint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_MessageIcon", 
		NodeName = "enum_mcMessageHint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcMessageHint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.MessageIcon.mcMessageHint);

		}
	}


	[NVP_Manifest(
		Id = "B1E891F8-97D1-4CAB-B157-A78BC10862BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_MessageIcon.enum_mcMessageError", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_MessageIcon", 
		NodeName = "enum_mcMessageError", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcMessageError : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.MessageIcon.mcMessageError);

		}
	}
}
