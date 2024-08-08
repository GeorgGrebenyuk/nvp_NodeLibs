using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcOlePlotQuality 
{


	[NVP_Manifest(
		Id = "52124751-594F-4261-B862-A08667B9BF19", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcOlePlotQuality.enum_acOPQMonochrome", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcOlePlotQuality", 
		NodeName = "enum_acOPQMonochrome", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acOPQMonochrome : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcOlePlotQuality.acOPQMonochrome);

		}
	}


	[NVP_Manifest(
		Id = "9D72AD72-2E23-4743-91D2-F6C9CF94F25B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcOlePlotQuality.enum_acOPQLowGraphics", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcOlePlotQuality", 
		NodeName = "enum_acOPQLowGraphics", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acOPQLowGraphics : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcOlePlotQuality.acOPQLowGraphics);

		}
	}


	[NVP_Manifest(
		Id = "FC62DE74-41BF-4C95-A0DB-86F62E86987E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcOlePlotQuality.enum_acOPQHighGraphics", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcOlePlotQuality", 
		NodeName = "enum_acOPQHighGraphics", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acOPQHighGraphics : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcOlePlotQuality.acOPQHighGraphics);

		}
	}
}
