using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_MassUnit 
{


	[NVP_Manifest(
		Id = "164E4E22-C29E-457E-AA31-80B057550935", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_MassUnit.enum_MassUnit_Unknown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_MassUnit", 
		NodeName = "enum_MassUnit_Unknown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_MassUnit_Unknown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.MassUnit.MassUnit_Unknown);

		}
	}


	[NVP_Manifest(
		Id = "DA82AAA8-21B5-4BF2-9797-8B2C87D4FA5D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_MassUnit.enum_MassUnit_Grams", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_MassUnit", 
		NodeName = "enum_MassUnit_Grams", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_MassUnit_Grams : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.MassUnit.MassUnit_Grams);

		}
	}


	[NVP_Manifest(
		Id = "95F26EDC-62FD-46C4-90DB-2405A8F0FA13", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_MassUnit.enum_MassUnit_Kilograms", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_MassUnit", 
		NodeName = "enum_MassUnit_Kilograms", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_MassUnit_Kilograms : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.MassUnit.MassUnit_Kilograms);

		}
	}


	[NVP_Manifest(
		Id = "FEFEF8E0-7757-4D65-B10C-F8D400CEE7EE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_MassUnit.enum_MassUnit_Tons", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_MassUnit", 
		NodeName = "enum_MassUnit_Tons", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_MassUnit_Tons : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.MassUnit.MassUnit_Tons);

		}
	}
}
