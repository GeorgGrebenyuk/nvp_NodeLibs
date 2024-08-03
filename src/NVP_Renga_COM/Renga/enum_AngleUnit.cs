using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_AngleUnit 
{


	[NVP_Manifest(
		Id = "F683C9D3-B392-4BC2-AC13-F6DA55862AED", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_AngleUnit.enum_AngleUnit_Unknown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_AngleUnit", 
		NodeName = "enum_AngleUnit_Unknown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_AngleUnit_Unknown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.AngleUnit.AngleUnit_Unknown);

		}
	}


	[NVP_Manifest(
		Id = "09FA352A-2626-4E73-9B63-39079DF960AB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_AngleUnit.enum_AngleUnit_Degrees", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_AngleUnit", 
		NodeName = "enum_AngleUnit_Degrees", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_AngleUnit_Degrees : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.AngleUnit.AngleUnit_Degrees);

		}
	}
}
