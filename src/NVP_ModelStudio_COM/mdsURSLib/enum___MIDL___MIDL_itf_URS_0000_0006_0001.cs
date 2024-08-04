using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace mdsURSLib.enum___MIDL___MIDL_itf_URS_0000_0006_0001 
{


	[NVP_Manifest(
		Id = "CD26BF3F-D586-4D99-BE9E-527EE5FDCC80", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.enum___MIDL___MIDL_itf_URS_0000_0006_0001.enum_appCustom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.enum___MIDL___MIDL_itf_URS_0000_0006_0001", 
		NodeName = "enum_appCustom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_appCustom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(mdsURSLib.__MIDL___MIDL_itf_URS_0000_0006_0001.appCustom);

		}
	}


	[NVP_Manifest(
		Id = "64A2DC40-5470-486D-9917-7B35629809B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.enum___MIDL___MIDL_itf_URS_0000_0006_0001.enum_appMSWord", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.enum___MIDL___MIDL_itf_URS_0000_0006_0001", 
		NodeName = "enum_appMSWord", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_appMSWord : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(mdsURSLib.__MIDL___MIDL_itf_URS_0000_0006_0001.appMSWord);

		}
	}


	[NVP_Manifest(
		Id = "2EF156CC-39B3-4EE3-8018-5AE67D166489", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.enum___MIDL___MIDL_itf_URS_0000_0006_0001.enum_appMSExcel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.enum___MIDL___MIDL_itf_URS_0000_0006_0001", 
		NodeName = "enum_appMSExcel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_appMSExcel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(mdsURSLib.__MIDL___MIDL_itf_URS_0000_0006_0001.appMSExcel);

		}
	}
}
