using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_VolumeUnit 
{


	[NVP_Manifest(
		Id = "F3301906-E44B-49A1-9600-ADD9E5A7DF17", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_VolumeUnit.enum_VolumeUnit_Unknown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_VolumeUnit", 
		NodeName = "enum_VolumeUnit_Unknown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_VolumeUnit_Unknown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.VolumeUnit.VolumeUnit_Unknown);

		}
	}


	[NVP_Manifest(
		Id = "7EB8143D-7FC9-4DC7-ADA3-B7AFA9AB3943", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_VolumeUnit.enum_VolumeUnit_Millimeters3", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_VolumeUnit", 
		NodeName = "enum_VolumeUnit_Millimeters3", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_VolumeUnit_Millimeters3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.VolumeUnit.VolumeUnit_Millimeters3);

		}
	}


	[NVP_Manifest(
		Id = "B8317A2F-B5F6-41EA-8FC5-731E4ABBB6AF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_VolumeUnit.enum_VolumeUnit_Centimeters3", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_VolumeUnit", 
		NodeName = "enum_VolumeUnit_Centimeters3", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_VolumeUnit_Centimeters3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.VolumeUnit.VolumeUnit_Centimeters3);

		}
	}


	[NVP_Manifest(
		Id = "A428F874-3806-4DBF-A463-D9F464B3A1D0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_VolumeUnit.enum_VolumeUnit_Meters3", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_VolumeUnit", 
		NodeName = "enum_VolumeUnit_Meters3", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_VolumeUnit_Meters3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.VolumeUnit.VolumeUnit_Meters3);

		}
	}
}
