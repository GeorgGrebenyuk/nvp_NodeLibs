using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcCellContentLayout 
{


	[NVP_Manifest(
		Id = "D418CD28-76DB-485B-B315-852870D299A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellContentLayout.enum_acCellContentLayoutFlow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellContentLayout", 
		NodeName = "enum_acCellContentLayoutFlow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellContentLayoutFlow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellContentLayout.acCellContentLayoutFlow);

		}
	}


	[NVP_Manifest(
		Id = "4B89BE03-B13D-4943-82FC-5BCCC4ECB060", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellContentLayout.enum_acCellContentLayoutStackedHorizontal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellContentLayout", 
		NodeName = "enum_acCellContentLayoutStackedHorizontal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellContentLayoutStackedHorizontal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellContentLayout.acCellContentLayoutStackedHorizontal);

		}
	}


	[NVP_Manifest(
		Id = "E9842323-5146-4090-AC5E-F46F74165A61", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellContentLayout.enum_acCellContentLayoutStackedVertical", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellContentLayout", 
		NodeName = "enum_acCellContentLayoutStackedVertical", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellContentLayoutStackedVertical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellContentLayout.acCellContentLayoutStackedVertical);

		}
	}
}
