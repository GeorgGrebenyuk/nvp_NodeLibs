using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Table column
///</summary>
namespace McCOM2.SymTableCol 
{

	[NVP_Manifest(
		Id = "E07BC420-8C9E-492F-862D-32E3D8537DB3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.SymTableCol_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "_SymTableCol_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableCol_Constructor : INode 
	{
		public McCOM2.ISymTableCol _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTableCol;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "708927E0-84C3-4B44-9DA8-7D4606C259C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.SymTableCol_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "_SymTableCol_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableCol_ConstructorCast : INode 
	{
		public McCOM2.ISymTableCol _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTableCol;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "BECA7D1E-E837-451F-B19F-4812FF288A52", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Cell", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Cell", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000050f", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]
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
		Id = "772D38A8-A442-4B35-85D0-B060ECCA391B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000510", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

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
		Id = "267E51AD-969B-45A3-8B5E-6DF36D2F1843", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000517", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

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
		Id = "D5E17203-A9EF-4E36-93C7-859B09F88FD9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000517", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCol", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000517
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "09C0C501-AEC5-42FA-AF15-BFABA83F8EB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000512", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

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
		Id = "F33E79CA-9BCF-4CEA-9F14-A7780C786C5E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Bounds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Bounds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000050e", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

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
		Id = "6B57113D-A531-4EA5-A989-6D6B71AD2ED3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000513", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

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
		Id = "8BDFD29F-2FA8-4E25-9467-B35D735654FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Table", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Table", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000515", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

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
		Id = "E7B4D534-02B1-4630-970A-9FCFE22C508B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Range", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Range", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000514", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

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
		Id = "3EF20914-DC5F-48D4-B738-2EDDA705A4F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Format", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Format", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000511", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

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
		Id = "72ECEC1C-EB30-4CD9-A934-76364255082F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Copy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Copy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000050b", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCol", typeof(object))]
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
		Id = "EDD81D9B-0446-4D48-939E-D05429887231", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Delete", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Delete", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000050c", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCol", typeof(object))]

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
		Id = "EC1878BF-AB6E-469C-BA6A-990F232FD73A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCol.Split", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCol", 
		NodeName = "Split", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000050d", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCol", typeof(object))]
	[NodeInput("vWidthsArray", typeof(System.Object))]

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
}
