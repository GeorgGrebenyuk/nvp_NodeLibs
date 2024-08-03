using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_ProjectType 
{


	[NVP_Manifest(
		Id = "436855ED-59A3-4B02-AD84-1F418C381E5E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ProjectType.enum_ProjectType_Project", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ProjectType", 
		NodeName = "enum_ProjectType_Project", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ProjectType_Project : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ProjectType.ProjectType_Project);

		}
	}


	[NVP_Manifest(
		Id = "A490B674-5379-4489-A567-EDA8BFEA60CD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ProjectType.enum_ProjectType_Template", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ProjectType", 
		NodeName = "enum_ProjectType_Template", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ProjectType_Template : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ProjectType.ProjectType_Template);

		}
	}
}
