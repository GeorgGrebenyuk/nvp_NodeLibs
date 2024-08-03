using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of the collection of all blocks in the drawing
///</summary>
namespace OdaX.AcadBlocks 
{

	[NVP_Manifest(
		Id = "31CF9DEE-EE44-45F5-8B9A-365792CFF0A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlocks.AcadBlocks_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlocks", 
		NodeName = "_AcadBlocks_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadBlocks_Constructor : INode 
	{
		public OdaX.IAcadBlocks _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadBlocks;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "9E2C7B51-7D54-4ADD-B4EC-EAAD48D6A934", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlocks.AcadBlocks_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlocks", 
		NodeName = "_AcadBlocks_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadBlocks_ConstructorCast : INode 
	{
		public OdaX.IAcadBlocks _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadBlocks;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2D5804A6-F623-493F-817B-3C113598D6F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlocks.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlocks", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns an object at a given index in a collection, block, group, or selection set.", 
		ViewType = "Data")]
	[NodeInput("AcadBlocks", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in a collection, block, group, or selection set.
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
		Id = "7AD68713-D4AE-46FE-87D0-7DB430B94122", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlocks.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlocks", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of items in the collection, block, dictionary, group, or selection set.", 
		ViewType = "Data")]
	[NodeInput("AcadBlocks", typeof(object))]

	///<summary>
	///Returns the number of items in the collection, block, dictionary, group, or selection set.
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
		Id = "476264EC-4080-48CE-B042-A27662C3E56B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlocks.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlocks", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an object and adds it to the collection, block, dictionary, group, or selection set.", 
		ViewType = "Data")]
	[NodeInput("AcadBlocks", typeof(object))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Creates an object and adds it to the collection, block, dictionary, group, or selection set.
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1].Value,inputs[2].Value));

		}
	}
}
