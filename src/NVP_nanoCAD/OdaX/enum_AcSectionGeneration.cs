using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcSectionGeneration 
{


	[NVP_Manifest(
		Id = "177350EA-E305-45DF-8B26-E551C923D5F1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSectionGeneration.enum_acSectionGenerationSourceAllObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSectionGeneration", 
		NodeName = "enum_acSectionGenerationSourceAllObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSectionGenerationSourceAllObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSectionGeneration.acSectionGenerationSourceAllObjects);

		}
	}


	[NVP_Manifest(
		Id = "DD7E1C7B-6E1F-4E80-AFC3-A99015F8EEF4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSectionGeneration.enum_acSectionGenerationSourceSelectedObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSectionGeneration", 
		NodeName = "enum_acSectionGenerationSourceSelectedObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSectionGenerationSourceSelectedObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSectionGeneration.acSectionGenerationSourceSelectedObjects);

		}
	}


	[NVP_Manifest(
		Id = "BFA4E33F-ED0D-48B7-A04F-DF83EC55F276", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSectionGeneration.enum_acSectionGenerationDestinationNewBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSectionGeneration", 
		NodeName = "enum_acSectionGenerationDestinationNewBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSectionGenerationDestinationNewBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSectionGeneration.acSectionGenerationDestinationNewBlock);

		}
	}


	[NVP_Manifest(
		Id = "E8F0892A-370C-41CC-9BC6-4167EC37BC0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSectionGeneration.enum_acSectionGenerationDestinationReplaceBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSectionGeneration", 
		NodeName = "enum_acSectionGenerationDestinationReplaceBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSectionGenerationDestinationReplaceBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSectionGeneration.acSectionGenerationDestinationReplaceBlock);

		}
	}


	[NVP_Manifest(
		Id = "60A624F0-6682-4A25-8A89-543185322B33", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSectionGeneration.enum_acSectionGenerationDestinationFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSectionGeneration", 
		NodeName = "enum_acSectionGenerationDestinationFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSectionGenerationDestinationFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSectionGeneration.acSectionGenerationDestinationFile);

		}
	}
}
