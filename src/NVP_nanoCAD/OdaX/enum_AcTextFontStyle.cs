using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcTextFontStyle 
{


	[NVP_Manifest(
		Id = "5F2A8C47-752C-40DA-A88F-1B6396541366", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextFontStyle.enum_acFontRegular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextFontStyle", 
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
			return new NodeResult(OdaX.AcTextFontStyle.acFontRegular);

		}
	}


	[NVP_Manifest(
		Id = "B7B19FEC-3BD4-490F-AE41-A7DF21895B6D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextFontStyle.enum_acFontItalic", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextFontStyle", 
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
			return new NodeResult(OdaX.AcTextFontStyle.acFontItalic);

		}
	}


	[NVP_Manifest(
		Id = "008CCA01-2EFB-424E-A901-B3793AA643BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextFontStyle.enum_acFontBold", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextFontStyle", 
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
			return new NodeResult(OdaX.AcTextFontStyle.acFontBold);

		}
	}


	[NVP_Manifest(
		Id = "CC96CE29-8155-4EED-B013-D740018D63C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextFontStyle.enum_acFontBoldItalic", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextFontStyle", 
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
			return new NodeResult(OdaX.AcTextFontStyle.acFontBoldItalic);

		}
	}
}
