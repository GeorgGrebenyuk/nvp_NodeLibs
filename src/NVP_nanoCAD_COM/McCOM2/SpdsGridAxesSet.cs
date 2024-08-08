using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Set of axes with the same properites
///</summary>
namespace McCOM2.SpdsGridAxesSet 
{

	[NVP_Manifest(
		Id = "1BDD324B-E694-4684-B927-E1929529A5B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesSet.SpdsGridAxesSet_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesSet", 
		NodeName = "_SpdsGridAxesSet_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SpdsGridAxesSet_Constructor : INode 
	{
		public McCOM2.ISpdsGridAxesSet _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISpdsGridAxesSet;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "335C855A-D895-4483-B6A3-B5F51C73DD3E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesSet.SpdsGridAxesSet_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesSet", 
		NodeName = "_SpdsGridAxesSet_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SpdsGridAxesSet_ConstructorCast : INode 
	{
		public McCOM2.ISpdsGridAxesSet _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISpdsGridAxesSet;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "69A84F1B-77D0-4D1F-941A-4B6D91E43F5B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesSet.Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesSet", 
		NodeName = "Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005f4", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]

	///<summary>
	///0x000005f4
	///</summary>
	public class Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Index);

		}
	}


	[NVP_Manifest(
		Id = "E42BB912-12B0-4892-8468-FD379C158D22", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesSet.Set_Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesSet", 
		NodeName = "Set_Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005f4", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x000005f4
	///</summary>
	public class Set_Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Index = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C2E21FAA-368A-4DD7-95FB-7C133D173E61", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesSet.Distance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesSet", 
		NodeName = "Distance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005f5", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]

	///<summary>
	///0x000005f5
	///</summary>
	public class Distance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Distance);

		}
	}


	[NVP_Manifest(
		Id = "52EBD93A-ED23-4CD5-B8BE-6E6C2440B27E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesSet.Set_Distance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesSet", 
		NodeName = "Set_Distance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005f5", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x000005f5
	///</summary>
	public class Set_Distance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Distance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BC12C9D4-2383-4A90-AF86-29A97A7F54ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesSet.Owner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesSet", 
		NodeName = "Owner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005f6", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]

	///<summary>
	///0x000005f6
	///</summary>
	public class Owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Owner);

		}
	}


	[NVP_Manifest(
		Id = "A7D6A8E8-B1C0-4630-B78F-B8D5CF6A71E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesSet.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesSet", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005f7", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]

	///<summary>
	///0x000005f7
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
		Id = "E7B609AE-8EAF-452C-A7E2-90FB361185FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesSet.Set_Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesSet", 
		NodeName = "Set_Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005f7", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005f7
	///</summary>
	public class Set_Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Count = inputs[1].Value;
			return null;
		}
	}
}
