using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcSectionState 
{


	[NVP_Manifest(
		Id = "A946288C-5BC3-4604-BE15-A3774268C9F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSectionState.enum_acSectionStatePlane", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSectionState", 
		NodeName = "enum_acSectionStatePlane", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSectionStatePlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSectionState.acSectionStatePlane);

		}
	}


	[NVP_Manifest(
		Id = "0BCF1148-7AD4-4F42-B6A0-F50AE76EE146", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSectionState.enum_acSectionStateBoundary", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSectionState", 
		NodeName = "enum_acSectionStateBoundary", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSectionStateBoundary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSectionState.acSectionStateBoundary);

		}
	}


	[NVP_Manifest(
		Id = "E22213A1-A0AB-4F1E-8C28-95ED072E0B1A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSectionState.enum_acSectionStateVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSectionState", 
		NodeName = "enum_acSectionStateVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSectionStateVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSectionState.acSectionStateVolume);

		}
	}
}
