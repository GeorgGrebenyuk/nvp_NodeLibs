using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_PropertyType 
{


	[NVP_Manifest(
		Id = "1EF7BD12-0A82-4B90-8D15-FDB0D81CC922", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PropertyType.enum_mcPtEmpty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PropertyType", 
		NodeName = "enum_mcPtEmpty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcPtEmpty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PropertyType.mcPtEmpty);

		}
	}


	[NVP_Manifest(
		Id = "1E7230C1-CCD8-40CD-A83C-2EFD779CE1FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PropertyType.enum_mcPtInteger", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PropertyType", 
		NodeName = "enum_mcPtInteger", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcPtInteger : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PropertyType.mcPtInteger);

		}
	}


	[NVP_Manifest(
		Id = "D447E53C-8038-49DE-B734-043A5E386720", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PropertyType.enum_mcPtIntegerArray", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PropertyType", 
		NodeName = "enum_mcPtIntegerArray", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcPtIntegerArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PropertyType.mcPtIntegerArray);

		}
	}


	[NVP_Manifest(
		Id = "BF985CD7-BE36-43A3-8B48-D64FEDE39FE8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PropertyType.enum_mcPtString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PropertyType", 
		NodeName = "enum_mcPtString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcPtString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PropertyType.mcPtString);

		}
	}


	[NVP_Manifest(
		Id = "F8754B9F-5733-4126-9747-0C1E5ECF7844", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PropertyType.enum_mcPtStringArray", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PropertyType", 
		NodeName = "enum_mcPtStringArray", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcPtStringArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PropertyType.mcPtStringArray);

		}
	}


	[NVP_Manifest(
		Id = "6A3EBC84-BDA5-4601-B65B-57406023890F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PropertyType.enum_mcPtDouble", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PropertyType", 
		NodeName = "enum_mcPtDouble", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcPtDouble : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PropertyType.mcPtDouble);

		}
	}


	[NVP_Manifest(
		Id = "57D79BB2-DE77-43AB-B2AA-270530C994BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PropertyType.enum_mcPtDoubleArray", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PropertyType", 
		NodeName = "enum_mcPtDoubleArray", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcPtDoubleArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PropertyType.mcPtDoubleArray);

		}
	}


	[NVP_Manifest(
		Id = "93015890-765F-45B8-B07E-D62EE4DCCE8E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PropertyType.enum_mcPtPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PropertyType", 
		NodeName = "enum_mcPtPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcPtPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PropertyType.mcPtPoint);

		}
	}


	[NVP_Manifest(
		Id = "7F506ECF-DE91-41F8-AE13-F9DCE9FD2355", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PropertyType.enum_mcPtVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PropertyType", 
		NodeName = "enum_mcPtVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcPtVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PropertyType.mcPtVector);

		}
	}


	[NVP_Manifest(
		Id = "6E0A2914-36DB-43D3-9E5D-A0345B7EE95B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PropertyType.enum_mcPtBoolean", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PropertyType", 
		NodeName = "enum_mcPtBoolean", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcPtBoolean : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PropertyType.mcPtBoolean);

		}
	}


	[NVP_Manifest(
		Id = "B8ADAB9C-48F6-4274-8C70-DEF6B1D4440A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PropertyType.enum_mcPtObject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PropertyType", 
		NodeName = "enum_mcPtObject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcPtObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PropertyType.mcPtObject);

		}
	}


	[NVP_Manifest(
		Id = "AAF596AB-206F-46B3-8650-7710676D1423", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PropertyType.enum_mcPtPlane", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PropertyType", 
		NodeName = "enum_mcPtPlane", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcPtPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PropertyType.mcPtPlane);

		}
	}
}
