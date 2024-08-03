using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcTextFontStyle 
{


	[NVP_Manifest(
		Id = "A05DF569-546B-49F2-AAF2-7F38D8D0288F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcTextFontStyle.enum_acFontRegular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcTextFontStyle", 
		NodeName = "enum_acFontRegular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acFontRegular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcTextFontStyle.acFontRegular);

		}
	}


	[NVP_Manifest(
		Id = "9246B27B-7BEA-45A8-B178-EDF3245DA9BF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcTextFontStyle.enum_acFontItalic", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcTextFontStyle", 
		NodeName = "enum_acFontItalic", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acFontItalic : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcTextFontStyle.acFontItalic);

		}
	}


	[NVP_Manifest(
		Id = "2A2B7AA3-3618-44CF-AA72-FBF4A2530ED6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcTextFontStyle.enum_acFontBold", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcTextFontStyle", 
		NodeName = "enum_acFontBold", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acFontBold : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcTextFontStyle.acFontBold);

		}
	}


	[NVP_Manifest(
		Id = "32E931C5-2722-4EAD-AA6A-594037370BF6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcTextFontStyle.enum_acFontBoldItalic", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcTextFontStyle", 
		NodeName = "enum_acFontBoldItalic", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acFontBoldItalic : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcTextFontStyle.acFontBoldItalic);

		}
	}
}
