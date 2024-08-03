using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Assembly loader
///</summary>
namespace nanoCAD.ALoader 
{

	[NVP_Manifest(
		Id = "F2DA7474-E0C8-42B9-98A5-9D8974325C53", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ALoader.ALoader_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ALoader", 
		NodeName = "_ALoader_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ALoader_Constructor : INode 
	{
		public nanoCAD.IALoader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IALoader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8FDB9406-D99B-4D5B-8BCE-9A253477CEB0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ALoader.ALoader_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ALoader", 
		NodeName = "_ALoader_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ALoader_ConstructorCast : INode 
	{
		public nanoCAD.IALoader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IALoader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "D8971452-CF1F-4C2B-84AA-C4D35A2F41D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ALoader.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ALoader", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves the command item from assembly", 
		ViewType = "Data")]
	[NodeInput("ALoader", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Retrieves the command item from assembly
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "9849CE84-E1A9-4A69-9980-084891B668B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ALoader.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ALoader", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the number of commands in assembly", 
		ViewType = "Data")]
	[NodeInput("ALoader", typeof(object))]

	///<summary>
	///Gets the number of commands in assembly
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "4379EB2C-5027-4D9E-8018-D06F97C8E8F1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ALoader.Load", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ALoader", 
		NodeName = "Load", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Loads the assembly", 
		ViewType = "Modifier")]
	[NodeInput("ALoader", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Loads the assembly
	///</summary>
	public class Load : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Load(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E9EF76F3-6828-4959-BD80-5E9CED6B4960", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.ALoader.Unload", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.ALoader", 
		NodeName = "Unload", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "unLoads the assembly", 
		ViewType = "Modifier")]
	[NodeInput("ALoader", typeof(object))]

	///<summary>
	///unLoads the assembly
	///</summary>
	public class Unload : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Unload();
			return null;
		}
	}
}
