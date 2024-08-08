using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcShadowDisplayType 
{


	[NVP_Manifest(
		Id = "6E78C6EC-EBE4-48F1-862D-AD2F73CF52CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcShadowDisplayType.enum_acCastsAndReceivesShadows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcShadowDisplayType", 
		NodeName = "enum_acCastsAndReceivesShadows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCastsAndReceivesShadows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcShadowDisplayType.acCastsAndReceivesShadows);

		}
	}


	[NVP_Manifest(
		Id = "8B550542-39AC-4D73-B77E-5C4521F4F145", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcShadowDisplayType.enum_acCastsShadows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcShadowDisplayType", 
		NodeName = "enum_acCastsShadows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCastsShadows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcShadowDisplayType.acCastsShadows);

		}
	}


	[NVP_Manifest(
		Id = "D92A32C3-7F48-4FE3-B51E-025F9ECBE0FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcShadowDisplayType.enum_acReceivesShadows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcShadowDisplayType", 
		NodeName = "enum_acReceivesShadows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acReceivesShadows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcShadowDisplayType.acReceivesShadows);

		}
	}


	[NVP_Manifest(
		Id = "FCF81FFC-7532-4452-96BB-A4DE76C0056C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcShadowDisplayType.enum_acIgnoreShadows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcShadowDisplayType", 
		NodeName = "enum_acIgnoreShadows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acIgnoreShadows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcShadowDisplayType.acIgnoreShadows);

		}
	}
}
