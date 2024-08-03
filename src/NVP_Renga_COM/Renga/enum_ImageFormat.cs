using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_ImageFormat 
{


	[NVP_Manifest(
		Id = "94E6E643-AB66-4C76-BB9D-D062C067BFEB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ImageFormat.enum_ImageFormat_Undefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ImageFormat", 
		NodeName = "enum_ImageFormat_Undefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ImageFormat_Undefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ImageFormat.ImageFormat_Undefined);

		}
	}


	[NVP_Manifest(
		Id = "40F7E5ED-CA01-478F-AAE7-0FB083186CA8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ImageFormat.enum_ImageFormat_BMP", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ImageFormat", 
		NodeName = "enum_ImageFormat_BMP", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ImageFormat_BMP : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ImageFormat.ImageFormat_BMP);

		}
	}


	[NVP_Manifest(
		Id = "AF4A5082-1736-43E3-98FF-D054B46B684D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ImageFormat.enum_ImageFormat_PNG", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ImageFormat", 
		NodeName = "enum_ImageFormat_PNG", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ImageFormat_PNG : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ImageFormat.ImageFormat_PNG);

		}
	}
}
