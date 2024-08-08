using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_PolymorphShape 
{


	[NVP_Manifest(
		Id = "881819FE-10EB-4BBA-AA24-FBB74FC923B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PolymorphShape.enum_mcMarkerShapeCircle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PolymorphShape", 
		NodeName = "enum_mcMarkerShapeCircle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcMarkerShapeCircle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PolymorphShape.mcMarkerShapeCircle);

		}
	}


	[NVP_Manifest(
		Id = "E8917BE2-77C7-4568-A392-9366DC1BDE6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PolymorphShape.enum_mcMarkerShapeSquare", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PolymorphShape", 
		NodeName = "enum_mcMarkerShapeSquare", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcMarkerShapeSquare : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PolymorphShape.mcMarkerShapeSquare);

		}
	}


	[NVP_Manifest(
		Id = "1748D768-6D1B-426B-8C8B-F41E7E73B7D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PolymorphShape.enum_mcMarkerShapeRomb", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PolymorphShape", 
		NodeName = "enum_mcMarkerShapeRomb", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcMarkerShapeRomb : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PolymorphShape.mcMarkerShapeRomb);

		}
	}
}
