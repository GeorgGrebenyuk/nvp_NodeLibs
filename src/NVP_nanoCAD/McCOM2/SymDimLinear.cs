using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Linear dimension
///</summary>
namespace McCOM2.SymDimLinear 
{

	[NVP_Manifest(
		Id = "8B29D4B9-778D-463C-9B53-98206DDC7676", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.SymDimLinear_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "_SymDimLinear_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimLinear_Constructor : INode 
	{
		public McCOM2.ISymDimLinear _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimLinear;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "2CDF6B31-BF82-422A-A2A9-AEC97072FE53", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.SymDimLinear_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "_SymDimLinear_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimLinear_ConstructorCast : INode 
	{
		public McCOM2.ISymDimLinear _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimLinear;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "5EF75B19-5CD8-4807-AEB5-6FE974FEA331", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Position1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Position1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001ae", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x000001ae
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
		Id = "D5529B09-077B-4665-AE28-2D0C983A2F18", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Set_Position1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Set_Position1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001ae", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000001ae
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
		Id = "31776FA2-CDCA-4894-80B5-91141E9645A1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Position2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Position2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001af", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x000001af
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
		Id = "C1F72767-121B-4D73-9BD1-17347C3CEE46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Set_Position2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Set_Position2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001af", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000001af
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
		Id = "F6F2AE28-F178-43BC-B709-55840CA26F87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Arrow1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Arrow1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000019a", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x0000019a
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
		Id = "359393DB-5C57-421F-ABAB-935AA1858911", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Set_Arrow1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Set_Arrow1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000019a", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x0000019a
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
		Id = "1381CF2F-EEF8-4810-B3E4-177B5020ED8A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Arrow2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Arrow2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000019b", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x0000019b
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
		Id = "312DE01D-6C8D-4996-B369-120D51372493", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Set_Arrow2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Set_Arrow2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000019b", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x0000019b
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
		Id = "5D12C530-11C7-42D0-B1B1-AFBB16429A74", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.LinePosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "LinePosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001a7", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x000001a7
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
		Id = "BB138FD8-10F5-423C-86DC-BB77CA435B71", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Set_LinePosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Set_LinePosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001a7", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000001a7
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


	[NVP_Manifest(
		Id = "24DE639B-1FE3-4767-A726-690F947773C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001a1", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x000001a1
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Id = "AA208AF0-FF1A-4C87-99F6-2366D67C6060", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001a1", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("pvVector", typeof(System.Object))]

	///<summary>
	///0x000001a1
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "124F0143-7EFE-44FA-8E61-0E6F7EC1CD43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000163", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x00000163
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Id = "3C7D1A53-6D22-42C5-A963-7E3E83ADA990", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimLinear.Set_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimLinear", 
		NodeName = "Set_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000163", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("McCOM2.SymDimensionType", typeof(System.Object))]

	///<summary>
	///0x00000163
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((McCOM2.SymDimensionType)inputs[1].Value);
			return null;
		}
	}
}
