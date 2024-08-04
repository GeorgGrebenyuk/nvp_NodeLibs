using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Diameter dimension
///</summary>
namespace McCOM2.SymDimDiameter 
{

	[NVP_Manifest(
		Id = "67FC795F-C726-4F9C-B467-BE6D206C6112", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimDiameter.SymDimDiameter_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimDiameter", 
		NodeName = "_SymDimDiameter_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimDiameter_Constructor : INode 
	{
		public McCOM2.ISymDimDiameter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimDiameter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A81BC77B-808B-4E13-924B-6BD81EA7E506", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimDiameter.SymDimDiameter_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimDiameter", 
		NodeName = "_SymDimDiameter_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimDiameter_ConstructorCast : INode 
	{
		public McCOM2.ISymDimDiameter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimDiameter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2631A23C-A1FC-4B10-9507-4EBEC11AB5CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimDiameter.Position1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimDiameter", 
		NodeName = "Position1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000131", 
		ViewType = "Data")]
	[NodeInput("SymDimDiameter", typeof(object))]

	///<summary>
	///0x00000131
	///</summary>
	public class Position1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position1);

		}
	}


	[NVP_Manifest(
		Id = "3A9948DD-C96F-48E2-8D51-F0D88BFF02B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimDiameter.Set_Position1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimDiameter", 
		NodeName = "Set_Position1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000131", 
		ViewType = "Modifier")]
	[NodeInput("SymDimDiameter", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000131
	///</summary>
	public class Set_Position1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C3B2F302-2C1A-46C2-A218-A5A13F53C2E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimDiameter.Position2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimDiameter", 
		NodeName = "Position2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000132", 
		ViewType = "Data")]
	[NodeInput("SymDimDiameter", typeof(object))]

	///<summary>
	///0x00000132
	///</summary>
	public class Position2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position2);

		}
	}


	[NVP_Manifest(
		Id = "6552EA10-EAB1-442D-A431-93D372A0CDCF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimDiameter.Set_Position2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimDiameter", 
		NodeName = "Set_Position2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000132", 
		ViewType = "Modifier")]
	[NodeInput("SymDimDiameter", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000132
	///</summary>
	public class Set_Position2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "830B7131-4EF2-405B-A63F-733580DBEDCF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimDiameter.Arrow1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimDiameter", 
		NodeName = "Arrow1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000011e", 
		ViewType = "Data")]
	[NodeInput("SymDimDiameter", typeof(object))]

	///<summary>
	///0x0000011e
	///</summary>
	public class Arrow1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow1);

		}
	}


	[NVP_Manifest(
		Id = "F4A694E4-5F75-4E2E-A93C-D24EC36C5E35", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimDiameter.Set_Arrow1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimDiameter", 
		NodeName = "Set_Arrow1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000011e", 
		ViewType = "Modifier")]
	[NodeInput("SymDimDiameter", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x0000011e
	///</summary>
	public class Set_Arrow1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow1 = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "134D77C1-299D-4EAE-974D-7C9F4884ED70", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimDiameter.Arrow2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimDiameter", 
		NodeName = "Arrow2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000011f", 
		ViewType = "Data")]
	[NodeInput("SymDimDiameter", typeof(object))]

	///<summary>
	///0x0000011f
	///</summary>
	public class Arrow2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow2);

		}
	}


	[NVP_Manifest(
		Id = "4E72F14D-E3E4-47AB-A871-0AF0D795F384", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimDiameter.Set_Arrow2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimDiameter", 
		NodeName = "Set_Arrow2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000011f", 
		ViewType = "Modifier")]
	[NodeInput("SymDimDiameter", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x0000011f
	///</summary>
	public class Set_Arrow2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow2 = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5BFF667F-3A8C-474C-905E-5C68BFA1F068", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimDiameter.Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimDiameter", 
		NodeName = "Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000122", 
		ViewType = "Data")]
	[NodeInput("SymDimDiameter", typeof(object))]

	///<summary>
	///0x00000122
	///</summary>
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	[NVP_Manifest(
		Id = "88246EE8-FA86-4499-B74F-D271B277B816", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimDiameter.Set_Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimDiameter", 
		NodeName = "Set_Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000122", 
		ViewType = "Modifier")]
	[NodeInput("SymDimDiameter", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000122
	///</summary>
	public class Set_Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Center = inputs[1].Value;
			return null;
		}
	}
}
