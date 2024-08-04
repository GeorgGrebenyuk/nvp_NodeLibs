using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_SymDimensionType 
{


	[NVP_Manifest(
		Id = "C07F4992-4DE4-4F03-8B97-A71FC9D26362", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionType.enum_mcDimtypeUnknown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionType", 
		NodeName = "enum_mcDimtypeUnknown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtypeUnknown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionType.mcDimtypeUnknown);

		}
	}


	[NVP_Manifest(
		Id = "DCEF8B19-38D1-4131-BEEB-C2E70C5DA3D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionType.enum_mcDimtypeLinear", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionType", 
		NodeName = "enum_mcDimtypeLinear", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtypeLinear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionType.mcDimtypeLinear);

		}
	}


	[NVP_Manifest(
		Id = "DDE8B7AA-C478-408A-B6DC-B3530218F2F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionType.enum_mcDimtypeVertical", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionType", 
		NodeName = "enum_mcDimtypeVertical", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtypeVertical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionType.mcDimtypeVertical);

		}
	}


	[NVP_Manifest(
		Id = "CB3D45AF-2C80-4BEF-B0DC-749607E8989B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionType.enum_mcDimtypeHorizontal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionType", 
		NodeName = "enum_mcDimtypeHorizontal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtypeHorizontal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionType.mcDimtypeHorizontal);

		}
	}


	[NVP_Manifest(
		Id = "521055A1-927E-4899-87F5-4C06C243C6A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionType.enum_mcDimtypeAligned", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionType", 
		NodeName = "enum_mcDimtypeAligned", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtypeAligned : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionType.mcDimtypeAligned);

		}
	}


	[NVP_Manifest(
		Id = "2CEA8490-55D9-49A8-941A-69F340F26B61", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionType.enum_mcDimtypeDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionType", 
		NodeName = "enum_mcDimtypeDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtypeDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionType.mcDimtypeDiameter);

		}
	}


	[NVP_Manifest(
		Id = "A1A2ACE8-0659-4642-9F51-BD0698FED63C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionType.enum_mcDimtypeRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionType", 
		NodeName = "enum_mcDimtypeRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtypeRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionType.mcDimtypeRadius);

		}
	}


	[NVP_Manifest(
		Id = "1B66D06D-277A-4EF6-869B-24D6D4F4FC1D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionType.enum_mcDimtypeHugeRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionType", 
		NodeName = "enum_mcDimtypeHugeRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtypeHugeRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionType.mcDimtypeHugeRadius);

		}
	}


	[NVP_Manifest(
		Id = "2046AA40-85B8-4334-840F-90A2E20C2E27", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionType.enum_mcDimtypeAngular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionType", 
		NodeName = "enum_mcDimtypeAngular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtypeAngular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionType.mcDimtypeAngular);

		}
	}


	[NVP_Manifest(
		Id = "4056377F-3805-40B6-A4FE-90EF51F85CD3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionType.enum_mcDimtypeArc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionType", 
		NodeName = "enum_mcDimtypeArc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtypeArc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionType.mcDimtypeArc);

		}
	}


	[NVP_Manifest(
		Id = "D9608D9D-8EC9-45DB-9794-D4C56FBE2056", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymDimensionType.enum_mcDimtypeOrdinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymDimensionType", 
		NodeName = "enum_mcDimtypeOrdinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcDimtypeOrdinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymDimensionType.mcDimtypeOrdinate);

		}
	}
}
