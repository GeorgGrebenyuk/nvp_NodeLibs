using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcHatchStyle 
{


	[NVP_Manifest(
		Id = "8A33CE91-FC86-4B09-95F2-EF0D43C9CC60", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHatchStyle.enum_acHatchStyleNormal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHatchStyle", 
		NodeName = "enum_acHatchStyleNormal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatchStyleNormal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHatchStyle.acHatchStyleNormal);

		}
	}


	[NVP_Manifest(
		Id = "95F06746-D692-4E86-88A2-1FC1C49C1716", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHatchStyle.enum_acHatchStyleOuter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHatchStyle", 
		NodeName = "enum_acHatchStyleOuter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatchStyleOuter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHatchStyle.acHatchStyleOuter);

		}
	}


	[NVP_Manifest(
		Id = "DB8A913A-7404-42EF-8085-A9A098150FE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHatchStyle.enum_acHatchStyleIgnore", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHatchStyle", 
		NodeName = "enum_acHatchStyleIgnore", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatchStyleIgnore : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHatchStyle.acHatchStyleIgnore);

		}
	}
}
