using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcKeyboardAccelerator 
{


	[NVP_Manifest(
		Id = "A2A1DE69-5E30-476F-A204-964154B35522", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcKeyboardAccelerator.enum_acPreferenceClassic", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcKeyboardAccelerator", 
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
			return new NodeResult(nanoCAD.AcKeyboardAccelerator.acPreferenceClassic);

		}
	}


	[NVP_Manifest(
		Id = "E3D5BB97-6EC4-4810-A5D4-9018EF939B16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcKeyboardAccelerator.enum_acPreferenceCustom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcKeyboardAccelerator", 
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
			return new NodeResult(nanoCAD.AcKeyboardAccelerator.acPreferenceCustom);

		}
	}
}
