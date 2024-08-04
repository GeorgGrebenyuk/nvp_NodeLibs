using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Mark symbol
///</summary>
namespace McCOM2.SymMark 
{

	[NVP_Manifest(
		Id = "12F3A0FA-6047-41DE-9229-952EB29EBD28", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.SymMark_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "_SymMark_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymMark_Constructor : INode 
	{
		public McCOM2.ISymMark _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymMark;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6C0058C9-C82C-4F0B-97CF-3731A95F39F1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.SymMark_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "_SymMark_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymMark_ConstructorCast : INode 
	{
		public McCOM2.ISymMark _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymMark;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "9116F517-D0FF-46FD-B904-0C4CEA0631CA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000027c", 
		ViewType = "Data")]
	[NodeInput("SymMark", typeof(object))]

	///<summary>
	///0x0000027c
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text);

		}
	}


	[NVP_Manifest(
		Id = "99F2F541-5D8A-4C04-A7F1-9217E22F2345", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000027c", 
		ViewType = "Modifier")]
	[NodeInput("SymMark", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000027c
	///</summary>
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3D7603BB-B487-4F09-9B46-1A22DA538596", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.Method", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "Method", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000276", 
		ViewType = "Data")]
	[NodeInput("SymMark", typeof(object))]

	///<summary>
	///0x00000276
	///</summary>
	public class Method : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Method);

		}
	}


	[NVP_Manifest(
		Id = "29085F36-B243-407B-BCDC-5ACAE8351D87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.Set_Method", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "Set_Method", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000276", 
		ViewType = "Modifier")]
	[NodeInput("SymMark", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000276
	///</summary>
	public class Set_Method : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Method = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FE807759-0275-4D41-849C-FEA332E99160", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.Stamp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "Stamp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000027b", 
		ViewType = "Data")]
	[NodeInput("SymMark", typeof(object))]

	///<summary>
	///0x0000027b
	///</summary>
	public class Stamp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Stamp);

		}
	}


	[NVP_Manifest(
		Id = "EE0A8B4A-508D-4B50-97D7-2206CB9C2142", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.Set_Stamp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "Set_Stamp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000027b", 
		ViewType = "Modifier")]
	[NodeInput("SymMark", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x0000027b
	///</summary>
	public class Set_Stamp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Stamp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FF9BA0CA-7DFE-42F0-9FBF-A3464A98F66E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.Documentation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "Documentation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000026f", 
		ViewType = "Data")]
	[NodeInput("SymMark", typeof(object))]

	///<summary>
	///0x0000026f
	///</summary>
	public class Documentation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Documentation);

		}
	}


	[NVP_Manifest(
		Id = "C23BB0DA-351D-474B-9B28-600FC33494F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.Set_Documentation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "Set_Documentation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000026f", 
		ViewType = "Modifier")]
	[NodeInput("SymMark", typeof(object))]
	[NodeInput("pnResult", typeof(System.String))]

	///<summary>
	///0x0000026f
	///</summary>
	public class Set_Documentation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Documentation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CD542688-FB6D-4531-B220-7A7B686DE8BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000279", 
		ViewType = "Data")]
	[NodeInput("SymMark", typeof(object))]

	///<summary>
	///0x00000279
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Id = "0F6E5DB6-42A6-4585-A5B7-B0CDA54DC338", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000279", 
		ViewType = "Modifier")]
	[NodeInput("SymMark", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000279
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0FACF018-0D91-481D-B702-BC33A70DEF3F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymMark.Leaders", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymMark", 
		NodeName = "Leaders", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000272", 
		ViewType = "Data")]
	[NodeInput("SymMark", typeof(object))]

	///<summary>
	///0x00000272
	///</summary>
	public class Leaders : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Leaders);

		}
	}
}
