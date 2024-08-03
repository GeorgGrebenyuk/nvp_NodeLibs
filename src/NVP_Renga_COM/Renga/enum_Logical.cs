using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_Logical 
{


	[NVP_Manifest(
		Id = "095FD0A5-A3A4-4B66-A2A2-33903F4DC8B5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_Logical.enum_Logical_False", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_Logical", 
		NodeName = "enum_Logical_False", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_Logical_False : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.Logical.Logical_False);

		}
	}


	[NVP_Manifest(
		Id = "B4C641E9-CB40-405C-A3E6-0ABEEF73C08A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_Logical.enum_Logical_True", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_Logical", 
		NodeName = "enum_Logical_True", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_Logical_True : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.Logical.Logical_True);

		}
	}


	[NVP_Manifest(
		Id = "C16B4665-78E1-463E-89E4-AF780B7D39F5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_Logical.enum_Logical_Indeterminate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_Logical", 
		NodeName = "enum_Logical_Indeterminate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_Logical_Indeterminate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.Logical.Logical_Indeterminate);

		}
	}
}
