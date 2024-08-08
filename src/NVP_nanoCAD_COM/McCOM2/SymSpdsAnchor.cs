using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsAnchor interface
///</summary>
namespace McCOM2.SymSpdsAnchor 
{

	[NVP_Manifest(
		Id = "369BDF4C-F09A-445E-90B4-A517A9D5BFB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsAnchor.SymSpdsAnchor_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsAnchor", 
		NodeName = "_SymSpdsAnchor_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsAnchor_Constructor : INode 
	{
		public McCOM2.ISymSpdsAnchor _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsAnchor;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "82140C06-FD20-44E3-BC45-499EA290C968", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsAnchor.SymSpdsAnchor_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsAnchor", 
		NodeName = "_SymSpdsAnchor_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsAnchor_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsAnchor _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsAnchor;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "7C8C1AFF-0C93-4904-BC30-80DEFBC9810F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsAnchor.ArrowFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsAnchor", 
		NodeName = "ArrowFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000319", 
		ViewType = "Data")]
	[NodeInput("SymSpdsAnchor", typeof(object))]

	///<summary>
	///0x00000319
	///</summary>
	public class ArrowFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowFirst);

		}
	}


	[NVP_Manifest(
		Id = "F3F40C14-C7EC-4FEF-95FB-EEB913600181", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsAnchor.Set_ArrowFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsAnchor", 
		NodeName = "Set_ArrowFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000319", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsAnchor", typeof(object))]
	[NodeInput("McCOM2.SymAnchorType", typeof(System.Object))]

	///<summary>
	///0x00000319
	///</summary>
	public class Set_ArrowFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowFirst = ((McCOM2.SymAnchorType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7CC5ECE9-5F94-43E2-A0E9-1FFF54DAD09E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsAnchor.ArrowLast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsAnchor", 
		NodeName = "ArrowLast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000031a", 
		ViewType = "Data")]
	[NodeInput("SymSpdsAnchor", typeof(object))]

	///<summary>
	///0x0000031a
	///</summary>
	public class ArrowLast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowLast);

		}
	}


	[NVP_Manifest(
		Id = "BF20145C-AEAD-4365-B7B0-9E0E71C951D5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsAnchor.Set_ArrowLast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsAnchor", 
		NodeName = "Set_ArrowLast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000031a", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsAnchor", typeof(object))]
	[NodeInput("McCOM2.SymAnchorType", typeof(System.Object))]

	///<summary>
	///0x0000031a
	///</summary>
	public class Set_ArrowLast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowLast = ((McCOM2.SymAnchorType)inputs[1].Value);
			return null;
		}
	}
}
