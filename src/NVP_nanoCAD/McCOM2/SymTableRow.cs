using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Table row
///</summary>
namespace McCOM2.SymTableRow 
{

	[NVP_Manifest(
		Id = "96500D74-D4EE-4892-AD3F-11484809C57A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.SymTableRow_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "_SymTableRow_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableRow_Constructor : INode 
	{
		public McCOM2.ISymTableRow _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTableRow;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F407C5DD-F538-49F1-96F5-6CE8A33FC118", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.SymTableRow_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "_SymTableRow_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableRow_ConstructorCast : INode 
	{
		public McCOM2.ISymTableRow _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTableRow;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C08297F1-A33C-481F-AD07-1E88D0D8929C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Cell", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Cell", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000050f", 
		ViewType = "Data")]
	[NodeInput("SymTableRow", typeof(object))]
	[NodeInput("nIndex", typeof(System.Object))]

	///<summary>
	///0x0000050f
	///</summary>
	public class Cell : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Cell(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "FEADFBBF-200C-4B59-A0DF-559DE362267C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000510", 
		ViewType = "Data")]
	[NodeInput("SymTableRow", typeof(object))]

	///<summary>
	///0x00000510
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
		Id = "54BF21A4-6008-4B08-A6B8-9C625B9807ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000517", 
		ViewType = "Data")]
	[NodeInput("SymTableRow", typeof(object))]

	///<summary>
	///0x00000517
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Id = "F1553512-80CF-4903-92A7-E23D0EEA8BB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000512", 
		ViewType = "Data")]
	[NodeInput("SymTableRow", typeof(object))]

	///<summary>
	///0x00000512
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Id = "E9677C39-6F3B-430B-85C0-D60FCE99B639", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000512", 
		ViewType = "Modifier")]
	[NodeInput("SymTableRow", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000512
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2DFEA915-F468-4434-913B-C7FDB8DDEF1B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Bounds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Bounds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000050e", 
		ViewType = "Data")]
	[NodeInput("SymTableRow", typeof(object))]

	///<summary>
	///0x0000050e
	///</summary>
	public class Bounds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bounds);

		}
	}


	[NVP_Manifest(
		Id = "E7470EB9-4D0E-499D-9805-38F2B3F593C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000513", 
		ViewType = "Data")]
	[NodeInput("SymTableRow", typeof(object))]

	///<summary>
	///0x00000513
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
		Id = "B08C9042-84FA-4ECD-8D04-35F118CE0FE2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Table", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Table", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000515", 
		ViewType = "Data")]
	[NodeInput("SymTableRow", typeof(object))]

	///<summary>
	///0x00000515
	///</summary>
	public class Table : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Table);

		}
	}


	[NVP_Manifest(
		Id = "EC923C96-FDC3-4EAF-B215-6D049784470D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Range", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Range", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000514", 
		ViewType = "Data")]
	[NodeInput("SymTableRow", typeof(object))]

	///<summary>
	///0x00000514
	///</summary>
	public class Range : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Range);

		}
	}


	[NVP_Manifest(
		Id = "6D10609D-5D45-4080-88EB-3E4A458EE2C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Title", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Title", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000516", 
		ViewType = "Data")]
	[NodeInput("SymTableRow", typeof(object))]

	///<summary>
	///0x00000516
	///</summary>
	public class Title : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Title);

		}
	}


	[NVP_Manifest(
		Id = "8BFC8922-6E31-4505-A2F2-E68648B5D2B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Set_Title", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Set_Title", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000516", 
		ViewType = "Modifier")]
	[NodeInput("SymTableRow", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x00000516
	///</summary>
	public class Set_Title : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Title = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2F09C139-942C-4390-AC8D-239B06DB2C1F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Format", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Format", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000511", 
		ViewType = "Data")]
	[NodeInput("SymTableRow", typeof(object))]

	///<summary>
	///0x00000511
	///</summary>
	public class Format : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Format);

		}
	}


	[NVP_Manifest(
		Id = "E9B73CC9-FF9D-42B6-A41A-712C9500A027", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Copy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Copy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000050b", 
		ViewType = "Modifier")]
	[NodeInput("SymTableRow", typeof(object))]
	[NodeInput("nIdxAfter", typeof(System.Object))]
	[NodeInput("vbWithFormat", typeof(System.Object))]
	[NodeInput("vbWithContent", typeof(System.Object))]

	///<summary>
	///0x0000050b
	///</summary>
	public class Copy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Copy(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CC8D3757-8BAA-4899-BFBB-965F9CB9F58D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Delete", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Delete", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000050c", 
		ViewType = "Modifier")]
	[NodeInput("SymTableRow", typeof(object))]

	///<summary>
	///0x0000050c
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8F4FEB43-1649-480E-A030-9CC4CC17C2AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Split", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Split", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000050d", 
		ViewType = "Modifier")]
	[NodeInput("SymTableRow", typeof(object))]
	[NodeInput("vHeightsArray", typeof(System.Object))]

	///<summary>
	///0x0000050d
	///</summary>
	public class Split : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Split(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "85B8E458-C875-4458-964F-6900794A316B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableRow.Object", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableRow", 
		NodeName = "Object", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000611", 
		ViewType = "Data")]
	[NodeInput("SymTableRow", typeof(object))]

	///<summary>
	///0x00000611
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
