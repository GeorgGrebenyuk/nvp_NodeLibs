using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IElements Interface
///</summary>
namespace mdsUnitsLib.Elements 
{

	[NVP_Manifest(
		Id = "DA191C76-71FA-4509-92F3-555161839CED", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Elements.Elements_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Elements", 
		NodeName = "_Elements_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Elements_Constructor : INode 
	{
		public mdsUnitsLib.IElements _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IElements;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "DB0B733D-B03F-4854-9B7F-A21B4D887F8C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Elements.Elements_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Elements", 
		NodeName = "_Elements_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Elements_ConstructorCast : INode 
	{
		public mdsUnitsLib.IElements _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IElements;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C3736E4E-F068-4B71-BE3C-7652BB3B5A99", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Elements.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Elements", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Item", 
		ViewType = "Data")]
	[NodeInput("Elements", typeof(object))]

	///<summary>
	///method Item
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item);

		}
	}


	[NVP_Manifest(
		Id = "F647B539-28D8-4A84-AA6A-FC7D4D337A5C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Elements.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Elements", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Count", 
		ViewType = "Data")]
	[NodeInput("Elements", typeof(object))]

	///<summary>
	///property Count
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
		Id = "5DCE099A-B253-4D08-8C56-89D06EED9B6F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Elements.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Elements", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Add", 
		ViewType = "Modifier")]
	[NodeInput("Elements", typeof(object))]
	[NodeInput("Item", typeof(System.Object))]

	///<summary>
	///method Add
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Add(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6FC19B71-54ED-473F-B724-5A1F79807462", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Elements.Remove", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Elements", 
		NodeName = "Remove", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Remove", 
		ViewType = "Modifier")]
	[NodeInput("Elements", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///method Remove
	///</summary>
	public class Remove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Remove(inputs[1].Value);
			return null;
		}
	}
}
