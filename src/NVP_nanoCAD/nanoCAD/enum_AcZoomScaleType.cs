using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcZoomScaleType 
{


	[NVP_Manifest(
		Id = "3CC124A3-D336-45B5-8257-0C07C7F4B6B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcZoomScaleType.enum_acZoomScaledAbsolute", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcZoomScaleType", 
		NodeName = "enum_acZoomScaledAbsolute", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acZoomScaledAbsolute : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcZoomScaleType.acZoomScaledAbsolute);

		}
	}


	[NVP_Manifest(
		Id = "8CECACF5-22F8-4DEB-AE40-1B3F3BD8846B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcZoomScaleType.enum_acZoomScaledRelative", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcZoomScaleType", 
		NodeName = "enum_acZoomScaledRelative", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acZoomScaledRelative : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcZoomScaleType.acZoomScaledRelative);

		}
	}


	[NVP_Manifest(
		Id = "A27500AD-A461-4E19-B50A-3D38F443FB3A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcZoomScaleType.enum_acZoomScaledRelativePSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcZoomScaleType", 
		NodeName = "enum_acZoomScaledRelativePSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acZoomScaledRelativePSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcZoomScaleType.acZoomScaledRelativePSpace);

		}
	}
}
