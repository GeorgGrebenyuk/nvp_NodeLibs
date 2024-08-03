using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDataLinkUpdateOption 
{


	[NVP_Manifest(
		Id = "B540E10A-F134-473C-8BF0-25652D717538", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDataLinkUpdateOption.enum_acUpdateOptionNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDataLinkUpdateOption", 
		NodeName = "enum_acUpdateOptionNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUpdateOptionNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDataLinkUpdateOption.acUpdateOptionNone);

		}
	}


	[NVP_Manifest(
		Id = "7E37548D-8340-4972-8157-FD5AB8615FF2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDataLinkUpdateOption.enum_acUpdateOptionOverwriteContentModifiedAfterUpdate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDataLinkUpdateOption", 
		NodeName = "enum_acUpdateOptionOverwriteContentModifiedAfterUpdate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUpdateOptionOverwriteContentModifiedAfterUpdate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDataLinkUpdateOption.acUpdateOptionOverwriteContentModifiedAfterUpdate);

		}
	}


	[NVP_Manifest(
		Id = "BC011FD7-14F5-4BFB-BC3B-B8E7CADAD0BF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDataLinkUpdateOption.enum_acUpdateOptionOverwriteFormatModifiedAfterUpdate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDataLinkUpdateOption", 
		NodeName = "enum_acUpdateOptionOverwriteFormatModifiedAfterUpdate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUpdateOptionOverwriteFormatModifiedAfterUpdate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDataLinkUpdateOption.acUpdateOptionOverwriteFormatModifiedAfterUpdate);

		}
	}


	[NVP_Manifest(
		Id = "62B0ED35-2D66-4217-A3A6-751944DBBD9F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDataLinkUpdateOption.enum_acUpdateOptionUpdateFullSourceRange", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDataLinkUpdateOption", 
		NodeName = "enum_acUpdateOptionUpdateFullSourceRange", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUpdateOptionUpdateFullSourceRange : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDataLinkUpdateOption.acUpdateOptionUpdateFullSourceRange);

		}
	}


	[NVP_Manifest(
		Id = "68AA16F6-ABB2-4462-AADD-F4F73FF73DC9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDataLinkUpdateOption.enum_acUpdateOptionIncludeXrefs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDataLinkUpdateOption", 
		NodeName = "enum_acUpdateOptionIncludeXrefs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUpdateOptionIncludeXrefs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDataLinkUpdateOption.acUpdateOptionIncludeXrefs);

		}
	}
}
