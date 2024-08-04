using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_GradientUnitType 
{


	[NVP_Manifest(
		Id = "43FEB115-DF03-4A1E-B68D-B02B74A7A99E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_GradientUnitType.enum_mcGradUnitNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_GradientUnitType", 
		NodeName = "enum_mcGradUnitNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcGradUnitNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.GradientUnitType.mcGradUnitNone);

		}
	}


	[NVP_Manifest(
		Id = "F56FC221-5542-46C3-B589-7F914560D293", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_GradientUnitType.enum_mcGradUnitRatio", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_GradientUnitType", 
		NodeName = "enum_mcGradUnitRatio", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcGradUnitRatio : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.GradientUnitType.mcGradUnitRatio);

		}
	}


	[NVP_Manifest(
		Id = "528DCBDE-B90C-43E4-BA44-3590B5D66162", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_GradientUnitType.enum_mcGradUnitDecimal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_GradientUnitType", 
		NodeName = "enum_mcGradUnitDecimal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcGradUnitDecimal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.GradientUnitType.mcGradUnitDecimal);

		}
	}


	[NVP_Manifest(
		Id = "782E8794-5560-49AF-9363-6745E100447C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_GradientUnitType.enum_mcGradUnitPercent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_GradientUnitType", 
		NodeName = "enum_mcGradUnitPercent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcGradUnitPercent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.GradientUnitType.mcGradUnitPercent);

		}
	}


	[NVP_Manifest(
		Id = "A1861CAD-89CD-44B6-9C22-106DDEA4C1E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_GradientUnitType.enum_mcGradUnitPermille", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_GradientUnitType", 
		NodeName = "enum_mcGradUnitPermille", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcGradUnitPermille : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.GradientUnitType.mcGradUnitPermille);

		}
	}


	[NVP_Manifest(
		Id = "01DB8594-7664-4CF9-9FA5-FF0EB0053D71", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_GradientUnitType.enum_mcGradUnitAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_GradientUnitType", 
		NodeName = "enum_mcGradUnitAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcGradUnitAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.GradientUnitType.mcGradUnitAngle);

		}
	}
}
