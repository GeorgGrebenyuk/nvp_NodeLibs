using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Interafce of object collection
///</summary>
namespace McCOM2.ObjectsCollection 
{

	[NVP_Manifest(
		Id = "FB9F819A-EADE-4B8C-8BCF-77619DFF46C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ObjectsCollection.ObjectsCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ObjectsCollection", 
		NodeName = "_ObjectsCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectsCollection_Constructor : INode 
	{
		public McCOM2.IObjectsCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IObjectsCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "EE0E1426-A67B-43BA-BF83-B49B49412A26", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ObjectsCollection.ObjectsCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ObjectsCollection", 
		NodeName = "_ObjectsCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectsCollection_ConstructorCast : INode 
	{
		public McCOM2.IObjectsCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IObjectsCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "31AF0B92-8169-445C-BBB1-3D82460ADAF2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ObjectsCollection.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ObjectsCollection", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000a6", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x000000a6
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
		Id = "C2B19067-ACF3-4566-AC1F-19037FC6DFF5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ObjectsCollection.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ObjectsCollection", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000a5", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]

	///<summary>
	///0x000000a5
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
		Id = "00D2196E-95DC-46D1-9A8A-726113FC54B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ObjectsCollection.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ObjectsCollection", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000009e", 
		ViewType = "Modifier")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("pItem", typeof(System.Object))]

	///<summary>
	///0x0000009e
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
		Id = "B602080B-F91C-4409-8DBF-BDA934AAC250", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ObjectsCollection.Remove", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ObjectsCollection", 
		NodeName = "Remove", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000a3", 
		ViewType = "Modifier")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("Item", typeof(System.Object))]

	///<summary>
	///0x000000a3
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


	[NVP_Manifest(
		Id = "5AF036FB-7AA2-483E-9BEF-207202BE72EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ObjectsCollection.Contains", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ObjectsCollection", 
		NodeName = "Contains", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000a0", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("pValue", typeof(System.Object))]

	///<summary>
	///0x000000a0
	///</summary>
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "792C5BE0-13AA-442C-B540-90BA327FDCEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ObjectsCollection.Or", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ObjectsCollection", 
		NodeName = "Or", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000a2", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("vSecond", typeof(System.Object))]

	///<summary>
	///0x000000a2
	///</summary>
	public class Or : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Or(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "DC938D00-8B7E-4CB0-B5C2-6DFC9637F89E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ObjectsCollection.And", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ObjectsCollection", 
		NodeName = "And", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000009f", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("vSecond", typeof(System.Object))]

	///<summary>
	///0x0000009f
	///</summary>
	public class And : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.And(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "8E828094-CB9B-4B06-9A8C-F1DF92B53D9C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ObjectsCollection.Not", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ObjectsCollection", 
		NodeName = "Not", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000a1", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("vSecond", typeof(System.Object))]

	///<summary>
	///0x000000a1
	///</summary>
	public class Not : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Not(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "57563056-1E72-4C48-9CEA-495BCEE1C378", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.ObjectsCollection.Xor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.ObjectsCollection", 
		NodeName = "Xor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000a4", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("vSecond", typeof(System.Object))]

	///<summary>
	///0x000000a4
	///</summary>
	public class Xor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Xor(inputs[1].Value));

		}
	}
}
