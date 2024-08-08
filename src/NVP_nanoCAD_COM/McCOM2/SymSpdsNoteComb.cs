using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsNoteComb interface
///</summary>
namespace McCOM2.SymSpdsNoteComb 
{

	[NVP_Manifest(
		Id = "2114B9C8-C92D-459F-B633-46CEF4087214", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.SymSpdsNoteComb_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "_SymSpdsNoteComb_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteComb_Constructor : INode 
	{
		public McCOM2.ISymSpdsNoteComb _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsNoteComb;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "2EDB8F8B-F330-43E7-895E-BB7D0E91E564", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.SymSpdsNoteComb_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "_SymSpdsNoteComb_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteComb_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsNoteComb _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsNoteComb;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "B94CDAAB-E1FC-4CDE-B011-E1B5430E0027", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003e6", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003e6
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
		Id = "670D3CD3-C22D-4967-8713-11A6F9FA8855", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003e6", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x000003e6
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
		Id = "6E2A8D5D-8CBA-463B-8C76-79B33191EB1A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003db", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003db
	///</summary>
	public class Footer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Footer);

		}
	}


	[NVP_Manifest(
		Id = "84FA00F0-2737-431F-9146-F204B86CEF07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.Set_Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "Set_Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003db", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x000003db
	///</summary>
	public class Set_Footer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Footer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E4D91323-4643-4E1A-8D9D-25803FCF0D46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.Align", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "Align", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003d4", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003d4
	///</summary>
	public class Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Align);

		}
	}


	[NVP_Manifest(
		Id = "A526A9CA-2EA9-419E-A2EA-E1A997B4BAD6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.Set_Align", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "Set_Align", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003d4", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x000003d4
	///</summary>
	public class Set_Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Align = ((McCOM2.TextAlignment)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "83F2CA94-2ABD-4796-AD1C-4737661029BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.Start", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "Start", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003e5", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003e5
	///</summary>
	public class Start : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Start);

		}
	}


	[NVP_Manifest(
		Id = "34EE3E2B-1606-4660-8C96-56DFB60F6567", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.Set_Start", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "Set_Start", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003e5", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x000003e5
	///</summary>
	public class Set_Start : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Start = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CC655743-F046-4DAB-B897-7FF43D8CDE11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.End", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "End", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003da", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003da
	///</summary>
	public class End : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.End);

		}
	}


	[NVP_Manifest(
		Id = "5029D88C-DF65-4A1E-B569-CB2BEADFF6A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.Set_End", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "Set_End", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003da", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x000003da
	///</summary>
	public class Set_End : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.End = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CD12C10A-7573-4288-869B-8E988B469AD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003d9", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003d9
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
		Id = "CFF419FB-98A6-43A9-B37E-7728F3A55C81", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003d9", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x000003d9
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
		Id = "1654DC6B-E53B-4CB5-BF70-257AF64873EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteComb.Leaders", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteComb", 
		NodeName = "Leaders", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003de", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003de
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
