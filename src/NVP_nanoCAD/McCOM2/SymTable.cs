using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Table object
///</summary>
namespace McCOM2.SymTable 
{

	[NVP_Manifest(
		Id = "37815249-B470-4169-8708-B1DBD70F6499", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.SymTable_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "_SymTable_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTable_Constructor : INode 
	{
		public McCOM2.ISymTable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3FE49A70-D7C1-46A7-BBE9-BF52E2C1607B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.SymTable_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "_SymTable_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTable_ConstructorCast : INode 
	{
		public McCOM2.ISymTable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E2C6E426-89D2-4170-A34B-67E86C89A6CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Cell", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Cell", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004ce", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Object))]
	[NodeInput("nCol", typeof(System.Object))]

	///<summary>
	///0x000004ce
	///</summary>
	public class Cell : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Cell(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "A76187BC-A968-48F0-85FF-B4E760074D76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Format", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Format", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004d5", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]

	///<summary>
	///0x000004d5
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
		Id = "080B8DF2-1120-4709-B746-007E52669189", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Rows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Rows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004e1", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x000004e1
	///</summary>
	public class Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rows(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "91E72DD5-77CB-4B23-B193-0622125ADAB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Cols", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Cols", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004d3", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x000004d3
	///</summary>
	public class Cols : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Cols(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "CE5F6098-901B-45B3-B367-E675A86C1F6C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.RowCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "RowCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004e0", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]

	///<summary>
	///0x000004e0
	///</summary>
	public class RowCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RowCount);

		}
	}


	[NVP_Manifest(
		Id = "85C0D3FD-712D-41D0-A81D-17F1257F5123", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Set_RowCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Set_RowCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004e0", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000004e0
	///</summary>
	public class Set_RowCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RowCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9D312563-E78E-4A8B-8C10-30769C43A2FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.ColCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "ColCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004d1", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]

	///<summary>
	///0x000004d1
	///</summary>
	public class ColCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColCount);

		}
	}


	[NVP_Manifest(
		Id = "00BFFD69-D312-4538-91EF-20FC8B7C85B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Set_ColCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Set_ColCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004d1", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000004d1
	///</summary>
	public class Set_ColCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3EE817BB-F37B-4B40-B0ED-9A7390CC9C95", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Save", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Save", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004ca", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("vDestination", typeof(System.Object))]

	///<summary>
	///0x000004ca
	///</summary>
	public class Save : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Save(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0A216A35-4867-47A8-A3F9-F72EFC14D03B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Load", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Load", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004c8", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("vSource", typeof(System.Object))]

	///<summary>
	///0x000004c8
	///</summary>
	public class Load : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Load(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "39E5DFA8-FB31-4DA7-9FF6-D324183158E8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004de", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]

	///<summary>
	///0x000004de
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
		Id = "EBB2B7EA-CAE8-41C1-B1D8-1A43230621D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004de", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000004de
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
		Id = "9D2C5EB6-547F-4784-B521-82A6B194345D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.CellFromPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "CellFromPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004cf", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("vPoint", typeof(System.Object))]

	///<summary>
	///0x000004cf
	///</summary>
	public class CellFromPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CellFromPoint(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "9F565E16-F32A-4080-A162-33F33E0A0B70", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004e4", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]

	///<summary>
	///0x000004e4
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
		Id = "34367547-E0EE-46BE-9BD6-5C8F669E75EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004d6", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]

	///<summary>
	///0x000004d6
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
		Id = "11C72ECA-6E74-4D70-9D95-A60E6E44C554", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004c6", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("iRow", typeof(System.Object))]
	[NodeInput("iCol", typeof(System.Object))]
	[NodeInput("iRowCount", typeof(System.Object))]
	[NodeInput("iColCount", typeof(System.Object))]

	///<summary>
	///0x000004c6
	///</summary>
	public class Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Group(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3AE86D4E-1249-4886-A8F0-0E0109C6164A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Ungroup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Ungroup", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004cc", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("iRow", typeof(System.Object))]
	[NodeInput("iCol", typeof(System.Object))]
	[NodeInput("iRowCount", typeof(System.Object))]
	[NodeInput("iColCount", typeof(System.Object))]

	///<summary>
	///0x000004cc
	///</summary>
	public class Ungroup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Ungroup(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "97F5F020-C517-4AE8-A708-AE76A7B651E7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTable.Insert", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTable", 
		NodeName = "Insert", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000610", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("pSubtable", typeof(System.Object))]
	[NodeInput("iRowFrom", typeof(System.Object))]
	[NodeInput("iColFrom", typeof(System.Object))]
	[NodeInput("McCOM2.SymSubtableMode", typeof(System.Object))]

	///<summary>
	///0x00000610
	///</summary>
	public class Insert : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Insert(inputs[1].Value,inputs[2].Value,inputs[3].Value,((McCOM2.SymSubtableMode)inputs[4].Value));
			return null;
		}
	}
}
