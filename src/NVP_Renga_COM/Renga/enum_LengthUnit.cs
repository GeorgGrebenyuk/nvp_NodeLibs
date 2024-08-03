using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_LengthUnit 
{


	[NVP_Manifest(
		Id = "EA0EB11B-B236-46FA-BBDE-1980CCBCFF48", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_LengthUnit.enum_LengthUnit_Unknown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_LengthUnit", 
		NodeName = "enum_LengthUnit_Unknown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_LengthUnit_Unknown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.LengthUnit.LengthUnit_Unknown);

		}
	}


	[NVP_Manifest(
		Id = "AD64C947-6B26-4BF6-A894-919D39A2748F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_LengthUnit.enum_LengthUnit_Millimeters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_LengthUnit", 
		NodeName = "enum_LengthUnit_Millimeters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_LengthUnit_Millimeters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.LengthUnit.LengthUnit_Millimeters);

		}
	}


	[NVP_Manifest(
		Id = "A48E5168-0319-48BB-ADA5-0416A67791AF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_LengthUnit.enum_LengthUnit_Centimeters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_LengthUnit", 
		NodeName = "enum_LengthUnit_Centimeters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_LengthUnit_Centimeters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.LengthUnit.LengthUnit_Centimeters);

		}
	}


	[NVP_Manifest(
		Id = "B581BCFD-BCC8-4863-A1D5-76A0CE2C39E7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_LengthUnit.enum_LengthUnit_Inches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_LengthUnit", 
		NodeName = "enum_LengthUnit_Inches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_LengthUnit_Inches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.LengthUnit.LengthUnit_Inches);

		}
	}


	[NVP_Manifest(
		Id = "76492475-A951-4B2D-9894-A9213399081F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_LengthUnit.enum_LengthUnit_Meters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_LengthUnit", 
		NodeName = "enum_LengthUnit_Meters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_LengthUnit_Meters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.LengthUnit.LengthUnit_Meters);

		}
	}
}
