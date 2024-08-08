using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Table cell object
///</summary>
namespace McCOM2.SymTableCell 
{

	[NVP_Manifest(
		Id = "A899BE9D-CEE9-441D-A955-6D266531F1CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.SymTableCell_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "_SymTableCell_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableCell_Constructor : INode 
	{
		public McCOM2.ISymTableCell _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTableCell;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B2810853-ABD9-48E7-9119-6D15D995DB58", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.SymTableCell_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "_SymTableCell_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableCell_ConstructorCast : INode 
	{
		public McCOM2.ISymTableCell _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTableCell;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "752FCD6F-F842-4E99-85F1-4FA6C5EBEC53", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004ef", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004ef
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
		Id = "46AEBC33-262C-44BB-BD42-04F4D57C3E0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004ef", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCell", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x000004ef
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
		Id = "CC6483C0-5ED4-4CAA-A122-E0229E46A513", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.DisplayText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "DisplayText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005f2", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000005f2
	///</summary>
	public class DisplayText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayText);

		}
	}


	[NVP_Manifest(
		Id = "E3273B70-E7C6-4EC9-9761-205F8F830665", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Source", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Source", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004ed", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004ed
	///</summary>
	public class Source : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Source);

		}
	}


	[NVP_Manifest(
		Id = "2001DECE-0202-405D-BFA1-39665D0B65C8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Set_Source", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Set_Source", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004ed", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCell", typeof(object))]
	[NodeInput("ppResult", typeof(System.Object))]

	///<summary>
	///0x000004ed
	///</summary>
	public class Set_Source : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Source = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FBBEF53F-9156-4BD8-9D84-E17575D02C20", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004f0", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004f0
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
		Id = "61431061-ACDE-4068-81AD-6537E2BF3D93", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004f0", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004f0
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
		Id = "C5C6268D-1CE6-4368-9DD1-A4AB27CF416D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Bounds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Bounds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004e7", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004e7
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
		Id = "52C421E5-88CC-45B5-93F7-4C8EE043B93E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Row", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Row", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004ec", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004ec
	///</summary>
	public class Row : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Row);

		}
	}


	[NVP_Manifest(
		Id = "CC34FA8E-F067-4A11-9E3B-5EB27886FF80", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Col", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Col", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004e8", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004e8
	///</summary>
	public class Col : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Col);

		}
	}


	[NVP_Manifest(
		Id = "1DB567E4-1FDC-4305-9890-58613C4C07F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Table", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Table", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004ee", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004ee
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
		Id = "C89178E0-D001-40F1-99CF-24271E3F3652", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Range", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Range", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004eb", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004eb
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
		Id = "FBD8C508-F62A-41C9-8FE0-A8182960ED46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Format", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Format", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004e9", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004e9
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
		Id = "15BC9189-99E6-437F-BDE6-94910A3312F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableCell.Split", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableCell", 
		NodeName = "Split", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004e6", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCell", typeof(object))]
	[NodeInput("vWidthsArray", typeof(System.Object))]
	[NodeInput("vHeightsArray", typeof(System.Object))]

	///<summary>
	///0x000004e6
	///</summary>
	public class Split : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Split(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
