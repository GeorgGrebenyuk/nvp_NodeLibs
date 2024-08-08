using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Arc dimension
///</summary>
namespace McCOM2.SymDimArc 
{

	[NVP_Manifest(
		Id = "970F3D87-CE86-4804-9F38-D2C09CBC7FCA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.SymDimArc_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "_SymDimArc_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimArc_Constructor : INode 
	{
		public McCOM2.ISymDimArc _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimArc;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "48E0C0ED-53FC-4D2A-9378-FB5EE61565FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.SymDimArc_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "_SymDimArc_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimArc_ConstructorCast : INode 
	{
		public McCOM2.ISymDimArc _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimArc;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "D8AE1CD1-0411-4E0D-AE04-66A765AE7641", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.Position1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "Position1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000106", 
		ViewType = "Data")]
	[NodeInput("SymDimArc", typeof(object))]

	///<summary>
	///0x00000106
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
		Id = "6A22164D-779F-4182-A83F-26BA2DEFE6FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.Set_Position1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "Set_Position1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000106", 
		ViewType = "Modifier")]
	[NodeInput("SymDimArc", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000106
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
		Id = "2A38B9E6-0690-4BE0-AE23-77161B2B33D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.Position2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "Position2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000107", 
		ViewType = "Data")]
	[NodeInput("SymDimArc", typeof(object))]

	///<summary>
	///0x00000107
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
		Id = "97D90852-5120-4B56-9419-3069F6769A5C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.Set_Position2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "Set_Position2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000107", 
		ViewType = "Modifier")]
	[NodeInput("SymDimArc", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000107
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
		Id = "CE6F44E8-1B8E-46D0-8419-AB7E6C21BE7C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.Arrow1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "Arrow1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000f2", 
		ViewType = "Data")]
	[NodeInput("SymDimArc", typeof(object))]

	///<summary>
	///0x000000f2
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
		Id = "503088FF-A0DC-440D-AED0-39708A3721C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.Set_Arrow1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "Set_Arrow1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000f2", 
		ViewType = "Modifier")]
	[NodeInput("SymDimArc", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x000000f2
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
		Id = "CE2BBE93-8CFA-4938-8674-B571887509D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.Arrow2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "Arrow2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000f3", 
		ViewType = "Data")]
	[NodeInput("SymDimArc", typeof(object))]

	///<summary>
	///0x000000f3
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
		Id = "F2625FD4-57B1-4F07-B61C-B9BED2833BCE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.Set_Arrow2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "Set_Arrow2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000f3", 
		ViewType = "Modifier")]
	[NodeInput("SymDimArc", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x000000f3
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
		Id = "C94FFD17-8D34-4EF2-899D-1E0EDD50DC5A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000f6", 
		ViewType = "Data")]
	[NodeInput("SymDimArc", typeof(object))]

	///<summary>
	///0x000000f6
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
		Id = "8F426D44-3F5A-4822-9EB9-D2D7961DFCBE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.Set_Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "Set_Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000f6", 
		ViewType = "Modifier")]
	[NodeInput("SymDimArc", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000000f6
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


	[NVP_Manifest(
		Id = "1DC72A15-BDE9-4891-A44D-627E79941377", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.LinePosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "LinePosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000ff", 
		ViewType = "Data")]
	[NodeInput("SymDimArc", typeof(object))]

	///<summary>
	///0x000000ff
	///</summary>
	public class LinePosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinePosition);

		}
	}


	[NVP_Manifest(
		Id = "913D3F37-69F9-43EA-92ED-FD4655BCC035", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimArc.Set_LinePosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimArc", 
		NodeName = "Set_LinePosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000ff", 
		ViewType = "Modifier")]
	[NodeInput("SymDimArc", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000000ff
	///</summary>
	public class Set_LinePosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinePosition = inputs[1].Value;
			return null;
		}
	}
}
