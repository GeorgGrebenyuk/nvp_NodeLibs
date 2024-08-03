using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_AreaUnit 
{


	[NVP_Manifest(
		Id = "8B0721C8-A568-404A-B8BC-A61553EF2C54", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_AreaUnit.enum_AreaUnit_Unknown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_AreaUnit", 
		NodeName = "enum_AreaUnit_Unknown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_AreaUnit_Unknown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.AreaUnit.AreaUnit_Unknown);

		}
	}


	[NVP_Manifest(
		Id = "2DA5D689-5744-42FB-9F7E-EC8FD89D7AE8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_AreaUnit.enum_AreaUnit_Millimeters2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_AreaUnit", 
		NodeName = "enum_AreaUnit_Millimeters2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_AreaUnit_Millimeters2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.AreaUnit.AreaUnit_Millimeters2);

		}
	}


	[NVP_Manifest(
		Id = "535E9F49-AB07-4F01-9ECC-10FF9D1C3E92", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_AreaUnit.enum_AreaUnit_Centimeters2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_AreaUnit", 
		NodeName = "enum_AreaUnit_Centimeters2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_AreaUnit_Centimeters2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.AreaUnit.AreaUnit_Centimeters2);

		}
	}


	[NVP_Manifest(
		Id = "F6E64C9D-0B08-4C09-B180-01AE2104AA70", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_AreaUnit.enum_AreaUnit_Meters2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_AreaUnit", 
		NodeName = "enum_AreaUnit_Meters2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_AreaUnit_Meters2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.AreaUnit.AreaUnit_Meters2);

		}
	}
}
