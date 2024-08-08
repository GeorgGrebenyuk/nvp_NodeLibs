using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcMergeCellStyleOption 
{


	[NVP_Manifest(
		Id = "55F9CD6D-178A-4A46-819A-68A11C2C5579", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMergeCellStyleOption.enum_acMergeCellStyleNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMergeCellStyleOption", 
		NodeName = "enum_acMergeCellStyleNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMergeCellStyleNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMergeCellStyleOption.acMergeCellStyleNone);

		}
	}


	[NVP_Manifest(
		Id = "1B1A49A1-3426-470C-BEFE-61AD5A039066", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMergeCellStyleOption.enum_acMergeCellStyleCopyDuplicates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMergeCellStyleOption", 
		NodeName = "enum_acMergeCellStyleCopyDuplicates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMergeCellStyleCopyDuplicates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMergeCellStyleOption.acMergeCellStyleCopyDuplicates);

		}
	}


	[NVP_Manifest(
		Id = "8B121208-CABF-4227-8942-6DE1D7E4F9DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMergeCellStyleOption.enum_acMergeCellStyleOverwriteDuplicates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMergeCellStyleOption", 
		NodeName = "enum_acMergeCellStyleOverwriteDuplicates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMergeCellStyleOverwriteDuplicates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMergeCellStyleOption.acMergeCellStyleOverwriteDuplicates);

		}
	}


	[NVP_Manifest(
		Id = "17D76E13-B9EE-4E8C-AD52-65A5196DD5EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMergeCellStyleOption.enum_acMergeCellStyleConvertDuplicatesToOverrides", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMergeCellStyleOption", 
		NodeName = "enum_acMergeCellStyleConvertDuplicatesToOverrides", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMergeCellStyleConvertDuplicatesToOverrides : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMergeCellStyleOption.acMergeCellStyleConvertDuplicatesToOverrides);

		}
	}


	[NVP_Manifest(
		Id = "B9497D2F-16B5-4A73-9707-81881D10E5C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMergeCellStyleOption.enum_acMergeCellStyleIgnoreNewStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMergeCellStyleOption", 
		NodeName = "enum_acMergeCellStyleIgnoreNewStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMergeCellStyleIgnoreNewStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMergeCellStyleOption.acMergeCellStyleIgnoreNewStyles);

		}
	}
}
