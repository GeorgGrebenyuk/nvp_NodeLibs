using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcFormatOption 
{


	[NVP_Manifest(
		Id = "D3D9B85A-D020-486D-8EB8-6F5E2E62AD38", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcFormatOption.enum_kFormatOptionNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcFormatOption", 
		NodeName = "enum_kFormatOptionNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_kFormatOptionNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcFormatOption.kFormatOptionNone);

		}
	}


	[NVP_Manifest(
		Id = "C4F3E911-20B1-4E22-B138-EFA51EF119ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcFormatOption.enum_acForEditing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcFormatOption", 
		NodeName = "enum_acForEditing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acForEditing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcFormatOption.acForEditing);

		}
	}


	[NVP_Manifest(
		Id = "C120772E-C88D-4865-B8F3-CB9552DA2C43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcFormatOption.enum_acForExpression", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcFormatOption", 
		NodeName = "enum_acForExpression", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acForExpression : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcFormatOption.acForExpression);

		}
	}


	[NVP_Manifest(
		Id = "293D9789-F95D-4470-B829-11C2195AFC51", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcFormatOption.enum_acUseMaximumPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcFormatOption", 
		NodeName = "enum_acUseMaximumPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUseMaximumPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcFormatOption.acUseMaximumPrecision);

		}
	}


	[NVP_Manifest(
		Id = "90DA72EA-B21F-499C-99EA-04BB5C72D45F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcFormatOption.enum_acIgnoreMtextFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcFormatOption", 
		NodeName = "enum_acIgnoreMtextFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acIgnoreMtextFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcFormatOption.acIgnoreMtextFormat);

		}
	}
}
