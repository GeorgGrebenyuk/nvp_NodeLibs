using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDimArcLengthSymbol 
{


	[NVP_Manifest(
		Id = "4492515C-97F5-49A4-A896-F0EFBE5C4079", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArcLengthSymbol.enum_acSymInFront", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArcLengthSymbol", 
		NodeName = "enum_acSymInFront", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSymInFront : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArcLengthSymbol.acSymInFront);

		}
	}


	[NVP_Manifest(
		Id = "A9DDA5D5-1ABC-4C03-B3A0-8B9C8BC16C3D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArcLengthSymbol.enum_acSymAbove", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArcLengthSymbol", 
		NodeName = "enum_acSymAbove", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSymAbove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArcLengthSymbol.acSymAbove);

		}
	}


	[NVP_Manifest(
		Id = "E2BB8807-3592-4738-B778-5E00A26FF0F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArcLengthSymbol.enum_acSymNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArcLengthSymbol", 
		NodeName = "enum_acSymNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSymNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArcLengthSymbol.acSymNone);

		}
	}
}
