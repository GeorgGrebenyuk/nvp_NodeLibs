using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcKeyboardAccelerator 
{


	[NVP_Manifest(
		Id = "4EB56248-CF3F-425B-98B9-748291F5293F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcKeyboardAccelerator.enum_acPreferenceClassic", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcKeyboardAccelerator", 
		NodeName = "enum_acPreferenceClassic", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPreferenceClassic : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcKeyboardAccelerator.acPreferenceClassic);

		}
	}


	[NVP_Manifest(
		Id = "5E2BD887-05AC-4AE0-991F-E0F5E74F7165", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcKeyboardAccelerator.enum_acPreferenceCustom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcKeyboardAccelerator", 
		NodeName = "enum_acPreferenceCustom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPreferenceCustom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcKeyboardAccelerator.acPreferenceCustom);

		}
	}
}
