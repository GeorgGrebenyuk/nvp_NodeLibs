using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ILeadersCollection interface
///</summary>
namespace McCOM2.LeadersCollection 
{

	[NVP_Manifest(
		Id = "C5E3BE02-9A73-460B-A6F2-F63AE5C60F02", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.LeadersCollection.LeadersCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.LeadersCollection", 
		NodeName = "_LeadersCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LeadersCollection_Constructor : INode 
	{
		public McCOM2.ILeadersCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ILeadersCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "26AA38AC-45B2-4760-9229-F426A506EC64", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.LeadersCollection.LeadersCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.LeadersCollection", 
		NodeName = "_LeadersCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LeadersCollection_ConstructorCast : INode 
	{
		public McCOM2.ILeadersCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ILeadersCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "7B244B68-D281-47C1-93AB-2CD1E76CB397", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.LeadersCollection.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.LeadersCollection", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000086", 
		ViewType = "Data")]
	[NodeInput("LeadersCollection", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x00000086
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
		Id = "68CD55C3-ED49-4396-AE73-B23895045E88", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.LeadersCollection.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.LeadersCollection", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000085", 
		ViewType = "Data")]
	[NodeInput("LeadersCollection", typeof(object))]

	///<summary>
	///0x00000085
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
		Id = "DCAC5F7C-C98D-4FBA-90C1-F2FE0B7D9941", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.LeadersCollection.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.LeadersCollection", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000083", 
		ViewType = "Modifier")]
	[NodeInput("LeadersCollection", typeof(object))]
	[NodeInput("vPoint", typeof(System.Object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]
	[NodeInput("rArrowSize", typeof(System.Double))]

	///<summary>
	///0x00000083
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Add(inputs[1].Value,((McCOM2.ArrowType)inputs[2].Value),inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DFF7F217-0B75-4588-94A8-9BD5F4698698", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.LeadersCollection.Remove", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.LeadersCollection", 
		NodeName = "Remove", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000084", 
		ViewType = "Modifier")]
	[NodeInput("LeadersCollection", typeof(object))]
	[NodeInput("Item", typeof(System.Object))]

	///<summary>
	///0x00000084
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
		Id = "B271ACDD-D12F-4B2C-8A48-9609ED6A56C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.LeadersCollection.Object", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.LeadersCollection", 
		NodeName = "Object", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000087", 
		ViewType = "Data")]
	[NodeInput("LeadersCollection", typeof(object))]

	///<summary>
	///0x00000087
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}
}
