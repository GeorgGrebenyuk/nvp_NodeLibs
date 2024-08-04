using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_SymDimensionTolView 
{


	[NVP_Manifest(
		Id = "51A16144-426C-43DA-A896-17E3E52954B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionTolView.enum_mcDimtolAll", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionTolView", 
		NodeName = "enum_mcDimtolAll", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtolAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionTolView.mcDimtolAll);

		}
	}


	[NVP_Manifest(
		Id = "9CCE184F-C26D-4651-B1ED-CF6B019020B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionTolView.enum_mcDimtolValuesOnly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionTolView", 
		NodeName = "enum_mcDimtolValuesOnly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtolValuesOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionTolView.mcDimtolValuesOnly);

		}
	}


	[NVP_Manifest(
		Id = "34C5B48B-72C3-44F4-B4E6-16DEDE493031", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionTolView.enum_mcDimtolFitInLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionTolView", 
		NodeName = "enum_mcDimtolFitInLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtolFitInLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionTolView.mcDimtolFitInLine);

		}
	}


	[NVP_Manifest(
		Id = "9E322A51-E90C-42DE-8D4A-0AAAE38CB36F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionTolView.enum_mcDimtolFitInStack", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionTolView", 
		NodeName = "enum_mcDimtolFitInStack", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtolFitInStack : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionTolView.mcDimtolFitInStack);

		}
	}


	[NVP_Manifest(
		Id = "C66F7EC9-C00B-4BD8-B124-B9AD7C5DAF8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionTolView.enum_mcDimtolFieldOnly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionTolView", 
		NodeName = "enum_mcDimtolFieldOnly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtolFieldOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionTolView.mcDimtolFieldOnly);

		}
	}


	[NVP_Manifest(
		Id = "6DA08115-AA8D-427A-B8FF-B2D533B0DC7A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionTolView.enum_mcDimtolNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionTolView", 
		NodeName = "enum_mcDimtolNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtolNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionTolView.mcDimtolNone);

		}
	}
}
