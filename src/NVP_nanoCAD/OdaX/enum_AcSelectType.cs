using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcSelectType 
{


	[NVP_Manifest(
		Id = "AEF6BDE6-43C7-41B2-BC03-FCE50CEC4253", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSelectType.enum_acTableSelectWindow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSelectType", 
		NodeName = "enum_acTableSelectWindow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTableSelectWindow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSelectType.acTableSelectWindow);

		}
	}


	[NVP_Manifest(
		Id = "3F243622-6637-47CF-BEF2-0D564E0A4364", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSelectType.enum_acTableSelectCrossing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSelectType", 
		NodeName = "enum_acTableSelectCrossing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTableSelectCrossing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSelectType.acTableSelectCrossing);

		}
	}
}
