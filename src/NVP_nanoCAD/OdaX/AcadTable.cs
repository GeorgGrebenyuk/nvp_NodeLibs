using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of table object
///</summary>
namespace OdaX.AcadTable 
{

	[NVP_Manifest(
		Id = "3313CFA5-7AB0-458D-9E35-31905D25B922", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.AcadTable_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "_AcadTable_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadTable_Constructor : INode 
	{
		public OdaX.IAcadTable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadTable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "4E1B88EE-61EA-4310-8DDE-5A133BA0A4F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.AcadTable_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "_AcadTable_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadTable_ConstructorCast : INode 
	{
		public OdaX.IAcadTable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadTable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2BA2438C-D558-40E8-B8E0-9205B0C9906C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the table style assigned to a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Specifies or returns the name of the table style assigned to a table.
	///</summary>
	public class StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleName);

		}
	}


	[NVP_Manifest(
		Id = "10FA194B-CDF8-4490-BAC1-9FE8FEC7947C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the table style assigned to a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the table style assigned to a table.
	///</summary>
	public class Set_StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "33F930D0-5FF6-464E-A024-41B5CEA0E009", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Rows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Rows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of rows in a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Specifies or returns the number of rows in a table.
	///</summary>
	public class Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rows);

		}
	}


	[NVP_Manifest(
		Id = "D3A973F3-A7F5-4EFF-BC2D-74507EE6C966", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_Rows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_Rows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of rows in a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pRows", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the number of rows in a table.
	///</summary>
	public class Set_Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rows = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7B8E410E-7734-4BC6-B021-4768D485156E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Columns", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Columns", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of columns in a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Specifies or returns the number of columns in a table.
	///</summary>
	public class Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Columns);

		}
	}


	[NVP_Manifest(
		Id = "74343A15-4ACD-40D6-BD79-9ADB90C623E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_Columns", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_Columns", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of columns in a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pColumns", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the number of columns in a table.
	///</summary>
	public class Set_Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Columns = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A8DBF1BD-3CC3-48EB-8E7D-AFA54EFB6990", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.FlowDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "FlowDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the position a table's title and row headings.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Specifies or returns the position a table's title and row headings.
	///</summary>
	public class FlowDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FlowDirection);

		}
	}


	[NVP_Manifest(
		Id = "2AA9D03B-EC0E-499E-A27C-DFDA2004D2F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_FlowDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_FlowDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the position a table's title and row headings.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcTableDirection", typeof(System.Object))]

	///<summary>
	///Specifies or returns the position a table's title and row headings.
	///</summary>
	public class Set_FlowDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FlowDirection = ((OdaX.AcTableDirection)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3095BD8A-8861-45AD-BF64-345A9BEBE194", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the width of a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Specifies or returns the width of a table.
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
		Id = "14E03547-BB48-4FA3-B66B-5093F8C99ABB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the width of a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pWidth", typeof(System.Double))]

	///<summary>
	///Specifies or returns the width of a table.
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
		Id = "2408E6C9-987F-471D-8FDA-CD83311353DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Specifies or returns the height of a table.
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
		Id = "F7658DD2-125A-4BE6-83D7-7400A63B6C98", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pHeight", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of a table.
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
		Id = "58BD88C2-1910-4351-9B05-9F08E732E51B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.VertCellMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "VertCellMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the distance between cell text and the top/bottom cell edge.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Specifies or returns the distance between cell text and the top/bottom cell edge.
	///</summary>
	public class VertCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VertCellMargin);

		}
	}


	[NVP_Manifest(
		Id = "7F07623B-0EAD-458E-BB8C-5E1033F40550", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_VertCellMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_VertCellMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the distance between cell text and the top/bottom cell edge.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pGap", typeof(System.Double))]

	///<summary>
	///Specifies or returns the distance between cell text and the top/bottom cell edge.
	///</summary>
	public class Set_VertCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VertCellMargin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C49AAD50-7C40-4E54-98E7-CF50434D42A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.HorzCellMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "HorzCellMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the distance between cell text and the left/right cell edge.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Specifies or returns the distance between cell text and the left/right cell edge.
	///</summary>
	public class HorzCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorzCellMargin);

		}
	}


	[NVP_Manifest(
		Id = "0F9329A3-99EA-40D4-8B37-F8C69A348DAD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_HorzCellMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_HorzCellMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the distance between cell text and the left/right cell edge.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pGap", typeof(System.Double))]

	///<summary>
	///Specifies or returns the distance between cell text and the left/right cell edge.
	///</summary>
	public class Set_HorzCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorzCellMargin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3C39FEA4-44A2-4E34-BD1D-0BD39F54A049", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the table insertion point.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the table insertion point.
	///</summary>
	public class InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsertionPoint);

		}
	}


	[NVP_Manifest(
		Id = "962AC170-0107-4102-81E9-1E687E6EDC11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the table insertion point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the table insertion point.
	///</summary>
	public class Set_InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertionPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2B5D9CB9-B13C-4757-BCB4-21C36AD3607A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetColumnWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetColumnWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the width of a column in a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the width of a column in a table.
	///</summary>
	public class GetColumnWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetColumnWidth(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "AAA0F8E0-387E-4523-B258-A6E242DD7E24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetColumnWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetColumnWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the width of a column in a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Sets the width of a column in a table.
	///</summary>
	public class SetColumnWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetColumnWidth(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7AE6DBF4-B1D7-408C-9222-B6D21E3AA100", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_ColumnWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_ColumnWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the width of all columns in a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rhs", typeof(System.Double))]

	///<summary>
	///Sets the width of all columns in a table.
	///</summary>
	public class Set_ColumnWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColumnWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2432AA32-4A04-4BFE-A4EF-0F33863454FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetRowHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetRowHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the height of a row in a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]

	///<summary>
	///Returns the height of a row in a table.
	///</summary>
	public class GetRowHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRowHeight(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "C4B7CF72-2F77-4DF3-8810-A5EF32E6E895", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetRowHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetRowHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the height of a row in a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Sets the height of a row in a table.
	///</summary>
	public class SetRowHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetRowHeight(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A0C754BA-D063-440D-8D36-7FA08C60B56B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_RowHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_RowHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the height of all rows in a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rhs", typeof(System.Double))]

	///<summary>
	///Sets the height of all rows in a table.
	///</summary>
	public class Set_RowHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RowHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "21E8D63D-890A-4A08-841A-8E2DA3086762", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetMinimumColumnWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetMinimumColumnWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the minimum width of a column in a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the minimum width of a column in a table.
	///</summary>
	public class GetMinimumColumnWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMinimumColumnWidth(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "F68A1E2E-4672-49C3-B707-9F50ABF3924F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetMinimumRowHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetMinimumRowHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the minimum height of a row in a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]

	///<summary>
	///Returns the minimum height of a row in a table.
	///</summary>
	public class GetMinimumRowHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMinimumRowHeight(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "C3A929A7-7435-49FF-9088-5ED6E9E866FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.MinimumTableWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "MinimumTableWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the minimum width of a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Returns the minimum width of a table.
	///</summary>
	public class MinimumTableWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinimumTableWidth);

		}
	}


	[NVP_Manifest(
		Id = "180CBE8B-074A-4C08-ABC2-4ED8657472CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.MinimumTableHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "MinimumTableHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the minimum height of a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Returns the minimum height of a table.
	///</summary>
	public class MinimumTableHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinimumTableHeight);

		}
	}


	[NVP_Manifest(
		Id = "A474B641-0729-40DE-8369-B8AC2E033F0F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x plane where a table is positioned.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Specifies or returns the x plane where a table is positioned.
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
		Id = "C762CC3F-7BD0-4BCF-A9EA-E45AFBB3F84A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x plane where a table is positioned.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("DirectionVector", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x plane where a table is positioned.
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
		Id = "3632D1E9-9BB8-4CD0-A05D-C16A0E825729", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.TitleSuppressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "TitleSuppressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the title of a table is visible.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Specifies or returns whether the title of a table is visible.
	///</summary>
	public class TitleSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TitleSuppressed);

		}
	}


	[NVP_Manifest(
		Id = "EBE9650A-7D32-486C-BC83-BA8E9C0BC3C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_TitleSuppressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_TitleSuppressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the title of a table is visible.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the title of a table is visible.
	///</summary>
	public class Set_TitleSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TitleSuppressed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "734AA37F-D429-4061-ACB1-D6C365774AE5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.HeaderSuppressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "HeaderSuppressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether row headings of a table are visible.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Specifies or returns whether row headings of a table are visible.
	///</summary>
	public class HeaderSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HeaderSuppressed);

		}
	}


	[NVP_Manifest(
		Id = "791D7A2B-C21E-46C7-9CF2-83F446766942", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_HeaderSuppressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_HeaderSuppressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether row headings of a table are visible.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether row headings of a table are visible.
	///</summary>
	public class Set_HeaderSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HeaderSuppressed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5833C693-6293-4C04-AD52-04EE51654A7F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns how the cells of a row type are aligned.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns how the cells of a row type are aligned.
	///</summary>
	public class GetAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAlignment(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "CAE9192C-D996-41AC-A016-F8DE97A428D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies how the cells of a row type are aligned.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellAlignment", typeof(System.Object))]

	///<summary>
	///Specifies how the cells of a row type are aligned.
	///</summary>
	public class SetAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAlignment(inputs[1].Value,((OdaX.AcCellAlignment)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "05680DF3-933A-49A2-B12D-F5C75294D7C0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetBackgroundColorNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetBackgroundColorNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the row type of a table has a background color.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the row type of a table has a background color.
	///</summary>
	public class GetBackgroundColorNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBackgroundColorNone(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "E403030E-CF1E-4756-8BD0-29DE065446B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetBackgroundColorNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetBackgroundColorNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the row type of a table has a background color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the row type of a table has a background color.
	///</summary>
	public class SetBackgroundColorNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBackgroundColorNone(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2A23B64B-4236-40CC-9CC2-ED20D0369E60", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetBackgroundColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetBackgroundColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the background color value of a table's row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the background color value of a table's row type.
	///</summary>
	public class GetBackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBackgroundColor(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "CFDBB21F-9081-486F-AB88-D228332E9A8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetBackgroundColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetBackgroundColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the background color value of a table's row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies the background color value of a table's row type.
	///</summary>
	public class SetBackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBackgroundColor(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8D780E72-45B0-4C75-813B-495D2AC63363", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetContentColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetContentColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the color value of a table's row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the color value of a table's row type.
	///</summary>
	public class GetContentColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContentColor(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "65007D75-FD1F-4C23-B5D1-3DFD7FF8EBC0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetContentColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetContentColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the color value of a table's row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies the color value of a table's row type.
	///</summary>
	public class SetContentColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetContentColor(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5478A251-7B06-4803-8AFE-5CB232652B2F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the name of the text style assigned to the row type of a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the name of the text style assigned to the row type of a table.
	///</summary>
	public class GetTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextStyle(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "EB7F235C-07F4-4AD1-8F8E-6DB5E13C7A2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text style assigned to the row type of a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the text style assigned to the row type of a table.
	///</summary>
	public class SetTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextStyle(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "45F243F7-A423-4CC5-8171-7F75F0FE970C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetTextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetTextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the text height of a table's row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the text height of a table's row type.
	///</summary>
	public class GetTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextHeight(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "75B9D885-A5D4-435B-8CB5-5C4C84C32C5F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetTextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetTextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text height of a table's row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("TextHeight", typeof(System.Double))]

	///<summary>
	///Specifies the text height of a table's row type.
	///</summary>
	public class SetTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextHeight(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7726118F-DBC2-4FE2-9FD6-2F1332894F21", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetGridLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetGridLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the grid lineweight value for a grid linetype and row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the grid lineweight value for a grid linetype and row type.
	///</summary>
	public class GetGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridLineWeight(((OdaX.AcGridLineType)inputs[1].Value),((OdaX.AcRowType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Id = "EC0B58D9-DAC1-4501-B4AE-09F2C5D40B7D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetGridLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetGridLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the grid lineweight value for a grid linetype and row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("gridLineTypes", typeof(System.Int32))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies the grid lineweight value for a grid linetype and row type.
	///</summary>
	public class SetGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridLineWeight(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8CAC4D05-DB4E-4A68-AB81-252009B060E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetGridColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetGridColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the grid color value for a grid linetype and row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the grid color value for a grid linetype and row type.
	///</summary>
	public class GetGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridColor(((OdaX.AcGridLineType)inputs[1].Value),((OdaX.AcRowType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Id = "1E923FCD-4F42-4AAC-892A-A57030063347", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetGridColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetGridColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the grid color value for a grid linetype and row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("gridLineTypes", typeof(System.Int32))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies the grid color value for a grid linetype and row type.
	///</summary>
	public class SetGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridColor(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C6D8566D-75B1-450E-A170-0E75E4B0F2BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetGridVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetGridVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the grid visibility value for a Returns the grid color value for a grid linetype and row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the grid visibility value for a Returns the grid color value for a grid linetype and row type.
	///</summary>
	public class GetGridVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridVisibility(((OdaX.AcGridLineType)inputs[1].Value),((OdaX.AcRowType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Id = "727EC9E4-BDE7-453B-9C94-03BCE5781DE0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetGridVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetGridVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the grid visibility value for a grid linetype and row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("gridLineTypes", typeof(System.Int32))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies the grid visibility value for a grid linetype and row type.
	///</summary>
	public class SetGridVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridVisibility(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "077DD43C-D99B-4028-BBB0-E8882687E037", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.TableStyleOverrides", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "TableStyleOverrides", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the overrides of a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Returns the overrides of a table style.
	///</summary>
	public class TableStyleOverrides : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TableStyleOverrides);

		}
	}


	[NVP_Manifest(
		Id = "03ED12B1-48B4-4FE2-888D-BE7B1FAC4DF5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.ClearTableStyleOverrides", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "ClearTableStyleOverrides", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Removes the overrides of a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("flag", typeof(System.Int32))]

	///<summary>
	///Removes the overrides of a table style.
	///</summary>
	public class ClearTableStyleOverrides : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClearTableStyleOverrides(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7C79AF79-13D7-441F-A637-C2F3D92A78AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the cell type of a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the cell type of a row and column.
	///</summary>
	public class GetCellType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellType(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "931FF165-4AD8-49D2-BBE2-EEB77EB88E20", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the cell type of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellType", typeof(System.Object))]

	///<summary>
	///Specifies the cell type of a row and column.
	///</summary>
	public class SetCellType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellType(inputs[1].Value,inputs[2].Value,((OdaX.AcCellType)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "787F94E0-CE15-4BAE-8EED-FF76B64349BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellExtents", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellExtents", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether a table cell is in the inner part of a table or on the outer edge.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("bOuterCell", typeof(System.Object))]

	///<summary>
	///Returns whether a table cell is in the inner part of a table or on the outer edge.
	///</summary>
	public class GetCellExtents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellExtents(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "D890E76A-AB37-4143-9216-0238E91AFA89", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetAttachmentPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetAttachmentPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the attachment point of a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the attachment point of a row and column.
	///</summary>
	public class GetAttachmentPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAttachmentPoint(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "BEE0A8DA-6377-4CDB-AF23-9FEDFCD874F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the alignment of a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the alignment of a row and column.
	///</summary>
	public class GetCellAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellAlignment(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "093F9F8F-47C5-4A05-B322-3630BF75D55D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the cell alignment of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellAlignment", typeof(System.Object))]

	///<summary>
	///Specifies the cell alignment of a row and column.
	///</summary>
	public class SetCellAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellAlignment(inputs[1].Value,inputs[2].Value,((OdaX.AcCellAlignment)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "96E65FA4-42E6-49C2-98CB-0988D0371A53", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellBackgroundColorNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellBackgroundColorNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether the background color is set to None for a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns whether the background color is set to None for a row and column.
	///</summary>
	public class GetCellBackgroundColorNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellBackgroundColorNone(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "2EFDA243-6086-4000-A54E-80BF3EEA8AE6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellBackgroundColorNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellBackgroundColorNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the background color is set to None for a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies whether the background color is set to None for a row and column.
	///</summary>
	public class SetCellBackgroundColorNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellBackgroundColorNone(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7EA32BE9-253E-48AB-A2BA-942FFE3016B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellBackgroundColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellBackgroundColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the background color for a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the background color for a row and column.
	///</summary>
	public class GetCellBackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellBackgroundColor(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "2A33B6A3-BCF2-4E7E-85A2-BB24E3AD976E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellBackgroundColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellBackgroundColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the background color for a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies the background color for a row and column.
	///</summary>
	public class SetCellBackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellBackgroundColor(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AB8A6553-4A55-4099-866B-ADCD014284B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellContentColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellContentColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the cell content color for a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the cell content color for a row and column.
	///</summary>
	public class GetCellContentColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellContentColor(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "4B820494-C23A-430E-9243-C4764D73552F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellContentColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellContentColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the cell content color for a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies the cell content color for a row and column.
	///</summary>
	public class SetCellContentColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellContentColor(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D87ACECE-1D33-4274-A5C4-91DCC10F2D69", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellStyleOverrides", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellStyleOverrides", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the overrides of a cell style.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the overrides of a cell style.
	///</summary>
	public class GetCellStyleOverrides : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellStyleOverrides(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "44BC368D-4205-4B57-9206-82FD5D5BF617", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.DeleteCellContent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "DeleteCellContent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes all cell content for a row and coluumn.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Deletes all cell content for a row and coluumn.
	///</summary>
	public class DeleteCellContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteCellContent(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1D84B133-BCBB-4705-8962-F4EF2AAAFC72", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetRowType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetRowType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the row type of a row.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]

	///<summary>
	///Returns the row type of a row.
	///</summary>
	public class GetRowType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRowType(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "78B18430-751B-446D-B4F3-C8B4451D1881", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the text of a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the text of a row and column.
	///</summary>
	public class GetText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetText(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "E35F5186-0CCA-464A-A58B-7C37E1677B14", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("pStr", typeof(System.String))]

	///<summary>
	///Specifies the text of a row and column.
	///</summary>
	public class SetText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetText(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A50F0DCA-C170-4816-99EB-56E5FABFB36E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the text style name of a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the text style name of a row and column.
	///</summary>
	public class GetCellTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellTextStyle(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "5765FC91-3C07-4EEF-BDC1-1F2718B3D524", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text style name of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the text style name of a row and column.
	///</summary>
	public class SetCellTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellTextStyle(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "59C025C1-E08C-4874-838B-6D5F1A80B59C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellTextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellTextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the text height of a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the text height of a row and column.
	///</summary>
	public class GetCellTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellTextHeight(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "177AB595-2D71-4B50-AD16-D7F533C7EC22", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellTextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellTextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text height of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("TextHeight", typeof(System.Double))]

	///<summary>
	///Specifies the text height of a row and column.
	///</summary>
	public class SetCellTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellTextHeight(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "406F5926-C4A2-466B-B888-D4F05AB15ECB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetTextRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetTextRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the text rotation of a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the text rotation of a row and column.
	///</summary>
	public class GetTextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextRotation(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "5355CDBE-35AA-4481-A102-6A2DDE3F8332", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetTextRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetTextRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text rotation of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("OdaX.AcRotationAngle", typeof(System.Object))]

	///<summary>
	///Specifies the text rotation of a row and column.
	///</summary>
	public class SetTextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextRotation(inputs[1].Value,inputs[2].Value,((OdaX.AcRotationAngle)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7CA5B9EF-56EC-4587-80CB-2E2F83EF6835", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetAutoScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetAutoScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether auto scaling is turned on for a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns whether auto scaling is turned on for a row and column.
	///</summary>
	public class GetAutoScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAutoScale(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "52B049BD-773D-46D1-8AAA-A17F925C456E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetAutoScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetAutoScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether auto scaling is turned on for a row nad column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies whether auto scaling is turned on for a row nad column.
	///</summary>
	public class SetAutoScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAutoScale(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4F810226-F41C-4341-956D-6A35D3699155", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetBlockTableRecordId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetBlockTableRecordId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the block table record ID associated with the block-type cell.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the block table record ID associated with the block-type cell.
	///</summary>
	public class GetBlockTableRecordId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockTableRecordId(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "9C632338-EDD9-4AAA-80B6-C30D659749CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetBlockTableRecordId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetBlockTableRecordId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the block table record ID associated with the block-type cell.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("blkId", typeof(System.Object))]
	[NodeInput("bAutoFit", typeof(System.Object))]

	///<summary>
	///Specifies the block table record ID associated with the block-type cell.
	///</summary>
	public class SetBlockTableRecordId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockTableRecordId(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1D73014E-53DE-4A3E-8E66-3E51398F0D71", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetBlockScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetBlockScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the block scale value for a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the block scale value for a row and column.
	///</summary>
	public class GetBlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockScale(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "3B19A180-74E4-4D97-B2C9-3B1DC52552B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetBlockScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetBlockScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the block scale value for a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("blkScale", typeof(System.Double))]

	///<summary>
	///Specifies the block scale value for a row and column.
	///</summary>
	public class SetBlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockScale(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "10F52F60-F6FF-449E-961D-028A9F4757DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetBlockRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetBlockRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the block rotation of a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the block rotation of a row and column.
	///</summary>
	public class GetBlockRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockRotation(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "0C25BB46-5AB3-4EF0-94E9-068D6E42BDA0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetBlockRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetBlockRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the block rotation of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("blkRotation", typeof(System.Double))]

	///<summary>
	///Specifies the block rotation of a row and column.
	///</summary>
	public class SetBlockRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockRotation(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1CAD241D-458F-4752-931B-FD1A26031023", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetBlockAttributeValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetBlockAttributeValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the attribute value of a block cell.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("attdefId", typeof(System.Object))]

	///<summary>
	///Returns the attribute value of a block cell.
	///</summary>
	public class GetBlockAttributeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockAttributeValue(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "D97E8B53-8E56-4819-BCFA-248A42B72B80", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetBlockAttributeValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetBlockAttributeValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the attribute value of a block cell.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("attdefId", typeof(System.Object))]
	[NodeInput("bstrValue", typeof(System.String))]

	///<summary>
	///Specifies the attribute value of a block cell.
	///</summary>
	public class SetBlockAttributeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockAttributeValue(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8E09779B-5575-432F-BE73-59D47DDF0490", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellGridLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellGridLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the grid lineweight value for the edge of a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellEdgeMask", typeof(System.Object))]

	///<summary>
	///Returns the grid lineweight value for the edge of a row and column.
	///</summary>
	public class GetCellGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellGridLineWeight(inputs[1].Value,inputs[2].Value,((OdaX.AcCellEdgeMask)inputs[3].Value)));

		}
	}


	[NVP_Manifest(
		Id = "5BDD9B0E-D17E-46AF-B4D6-7F15EDF401FE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellGridLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellGridLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the grid lineweight value for the edges of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("edges", typeof(System.Int32))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies the grid lineweight value for the edges of a row and column.
	///</summary>
	public class SetCellGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellGridLineWeight(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C7270BCE-4B3C-4221-9E0C-28E65BA04F6B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellGridColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellGridColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the grid color value for the edge of a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellEdgeMask", typeof(System.Object))]

	///<summary>
	///Returns the grid color value for the edge of a row and column.
	///</summary>
	public class GetCellGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellGridColor(inputs[1].Value,inputs[2].Value,((OdaX.AcCellEdgeMask)inputs[3].Value)));

		}
	}


	[NVP_Manifest(
		Id = "399C85D9-CD18-4066-BD05-BAE890E6BE11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellGridColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellGridColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the grid color value for the edges of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("edges", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies the grid color value for the edges of a row and column.
	///</summary>
	public class SetCellGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellGridColor(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B99B9C2C-532B-49B6-8DD7-76B6820D3E33", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellGridVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellGridVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether the grid is visible for the edge of a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellEdgeMask", typeof(System.Object))]

	///<summary>
	///Returns whether the grid is visible for the edge of a row and column.
	///</summary>
	public class GetCellGridVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellGridVisibility(inputs[1].Value,inputs[2].Value,((OdaX.AcCellEdgeMask)inputs[3].Value)));

		}
	}


	[NVP_Manifest(
		Id = "5F50BF58-2C2C-4913-B62B-405E94E457BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellGridVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellGridVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the grid is visible for the edges of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("edges", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies whether the grid is visible for the edges of a row and column.
	///</summary>
	public class SetCellGridVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellGridVisibility(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BF85420A-5868-4DF1-AC0E-D42C7DF27BB3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.InsertColumns", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "InsertColumns", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds columns to a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("cols", typeof(System.Int32))]

	///<summary>
	///Adds columns to a table.
	///</summary>
	public class InsertColumns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertColumns(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "31AE1135-E8FC-43D8-AB30-FDC0F6052A62", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.DeleteColumns", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "DeleteColumns", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes columns from a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("cols", typeof(System.Int32))]

	///<summary>
	///Deletes columns from a table.
	///</summary>
	public class DeleteColumns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteColumns(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "16C9ECD0-14D0-452E-9630-A63355389388", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.InsertRows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "InsertRows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds rows to a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("Height", typeof(System.Double))]
	[NodeInput("Rows", typeof(System.Int32))]

	///<summary>
	///Adds rows to a table.
	///</summary>
	public class InsertRows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertRows(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B599AF66-806D-4515-B72C-7B3F8ADD796E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.DeleteRows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "DeleteRows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes rows from a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("Rows", typeof(System.Int32))]

	///<summary>
	///Deletes rows from a table.
	///</summary>
	public class DeleteRows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteRows(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CA70CE5D-F964-4539-B8EC-C8D26BD2EFAE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.MergeCells", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "MergeCells", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Merges cells together into a single cell.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("minRow", typeof(System.Int32))]
	[NodeInput("maxRow", typeof(System.Int32))]
	[NodeInput("minCol", typeof(System.Int32))]
	[NodeInput("maxCol", typeof(System.Int32))]

	///<summary>
	///Merges cells together into a single cell.
	///</summary>
	public class MergeCells : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MergeCells(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "58B1AC7A-C579-4710-9181-50C450491E3D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.UnmergeCells", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "UnmergeCells", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Unmerges cells.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("minRow", typeof(System.Int32))]
	[NodeInput("maxRow", typeof(System.Int32))]
	[NodeInput("minCol", typeof(System.Int32))]
	[NodeInput("maxCol", typeof(System.Int32))]

	///<summary>
	///Unmerges cells.
	///</summary>
	public class UnmergeCells : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnmergeCells(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D9B02E35-53F8-4B24-9CC5-0BE788E70A4C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.IsMergedCell", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "IsMergedCell", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether the specified cells are merged.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("minRow", typeof(System.Int32))]
	[NodeInput("maxRow", typeof(System.Int32))]
	[NodeInput("minCol", typeof(System.Int32))]
	[NodeInput("maxCol", typeof(System.Int32))]

	///<summary>
	///Returns whether the specified cells are merged.
	///</summary>
	public class IsMergedCell : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsMergedCell(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value));

		}
	}


	[NVP_Manifest(
		Id = "CF9E1247-33FE-4307-A5EF-701C3B111C7B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetFieldId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetFieldId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the field object ID that corresponds to a cell.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Returns the field object ID that corresponds to a cell.
	///</summary>
	public class GetFieldId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFieldId(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "534CD7FB-4588-462C-9BF8-0923FBFAE05A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetFieldId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetFieldId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the field object ID for a cell.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("fieldId", typeof(System.Object))]

	///<summary>
	///Specifies the field object ID for a cell.
	///</summary>
	public class SetFieldId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFieldId(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D1F6A24A-DE6A-4D42-8CFC-59D8C70E3E21", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GenerateLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GenerateLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Generates the layout and content of a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Generates the layout and content of a table.
	///</summary>
	public class GenerateLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GenerateLayout();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7C5636BF-4534-4C2D-A4C1-6BA71D66F9F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.RecomputeTableBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "RecomputeTableBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Recomputes the referenced table block with changes made to the table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bForceUpdate", typeof(System.Object))]

	///<summary>
	///Recomputes the referenced table block with changes made to the table.
	///</summary>
	public class RecomputeTableBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RecomputeTableBlock(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2E3613AE-CD50-4B4F-81E2-9553A5927F9E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.HitTest", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "HitTest", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Determines whether a vertex is on a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("wpt", typeof(System.Object))]
	[NodeInput("wviewVec", typeof(System.Object))]
	[NodeInput("resultRowIndex", typeof(System.Int32))]
	[NodeInput("resultColumnIndex", typeof(System.Int32))]

	///<summary>
	///Not implemented. Determines whether a vertex is on a table.
	///</summary>
	public class HitTest : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HitTest(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "066538C1-7FED-4740-AD2E-ECCD16FC1F89", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Select", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Select", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Selects a cell in a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("wpt", typeof(System.Object))]
	[NodeInput("wvwVec", typeof(System.Object))]
	[NodeInput("wvwxVec", typeof(System.Object))]
	[NodeInput("wxaper", typeof(System.Double))]
	[NodeInput("wyaper", typeof(System.Double))]
	[NodeInput("allowOutside", typeof(System.Object))]
	[NodeInput("resultRowIndex", typeof(System.Int32))]
	[NodeInput("resultColumnIndex", typeof(System.Int32))]

	///<summary>
	///Not implemented. Selects a cell in a table.
	///</summary>
	public class Select : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Select(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value,inputs[7].Value,inputs[8].Value));

		}
	}


	[NVP_Manifest(
		Id = "7996AD96-51E0-4C77-9BF8-1797112B2ACF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SelectSubRegion", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SelectSubRegion", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Selects a subregion in a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("wpt1", typeof(System.Object))]
	[NodeInput("wpt2", typeof(System.Object))]
	[NodeInput("wvwVec", typeof(System.Object))]
	[NodeInput("wvwxVec", typeof(System.Object))]
	[NodeInput("OdaX.AcSelect", typeof(System.Object))]
	[NodeInput("bIncludeCurrentSelection", typeof(System.Object))]
	[NodeInput("rowMin", typeof(System.Int32))]
	[NodeInput("rowMax", typeof(System.Int32))]
	[NodeInput("colMin", typeof(System.Int32))]
	[NodeInput("colMax", typeof(System.Int32))]

	///<summary>
	///Not implemented. Selects a subregion in a table.
	///</summary>
	public class SelectSubRegion : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SelectSubRegion(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,((OdaX.AcSelect)inputs[5].Value),inputs[6].Value,inputs[7].Value,inputs[8].Value,inputs[9].Value,inputs[10].Value));

		}
	}


	[NVP_Manifest(
		Id = "2C814558-39ED-4581-88C6-1AFDF0AF0B1C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.ReselectSubRegion", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "ReselectSubRegion", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Reselects a subregion in a table.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Not implemented. Reselects a subregion in a table.
	///</summary>
	public class ReselectSubRegion : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReselectSubRegion);

		}
	}


	[NVP_Manifest(
		Id = "D930ABD7-6E37-4ABC-969E-AEF2DF274390", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetSubSelection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetSubSelection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns a subregion in a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowMin", typeof(System.Int32))]
	[NodeInput("rowMax", typeof(System.Int32))]
	[NodeInput("colMin", typeof(System.Int32))]
	[NodeInput("colMax", typeof(System.Int32))]

	///<summary>
	///Not implemented. Returns a subregion in a table.
	///</summary>
	public class GetSubSelection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetSubSelection(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "619806CC-8E31-4F80-A40D-1192EA0DE974", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetSubSelection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetSubSelection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies a subregion in a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowMin", typeof(System.Int32))]
	[NodeInput("rowMax", typeof(System.Int32))]
	[NodeInput("colMin", typeof(System.Int32))]
	[NodeInput("colMax", typeof(System.Int32))]

	///<summary>
	///Not implemented. Specifies a subregion in a table.
	///</summary>
	public class SetSubSelection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetSubSelection(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A8CE06E4-F494-4747-9890-CF280BF974FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.ClearSubSelection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "ClearSubSelection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Clears a subregion in a table.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Not implemented. Clears a subregion in a table.
	///</summary>
	public class ClearSubSelection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClearSubSelection();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5757FA5E-C020-4B36-817F-D5A993A502EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.HasSubSelection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "HasSubSelection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Determines whether a table has a subselection set.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Not implemented. Determines whether a table has a subselection set.
	///</summary>
	public class HasSubSelection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasSubSelection);

		}
	}


	[NVP_Manifest(
		Id = "511C0693-EE69-4E73-8041-74E277A31A89", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.RegenerateTableSuppressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "RegenerateTableSuppressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Determines whether a table can be regenerated.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Not implemented. Determines whether a table can be regenerated.
	///</summary>
	public class RegenerateTableSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RegenerateTableSuppressed);

		}
	}


	[NVP_Manifest(
		Id = "C8AF083F-CCD9-4DD8-97B3-9C042A3A95DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_RegenerateTableSuppressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_RegenerateTableSuppressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Determines whether a table can be regenerated.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Not implemented. Determines whether a table can be regenerated.
	///</summary>
	public class Set_RegenerateTableSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RegenerateTableSuppressed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "607FD0FC-B604-4387-8AF9-A2D3A1AD03DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetDataType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetDataType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the row data type and unit type for the specified row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Not implemented. Returns the row data type and unit type for the specified row type.
	///</summary>
	public class GetDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetDataType(((OdaX.AcRowType)inputs[1].Value),((OdaX.AcValueDataType)inputs[2].Value),((OdaX.AcValueUnitType)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F8A89F81-601D-4009-ADEC-7E0D11DF3784", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetDataType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetDataType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies the row data type and unit type for a row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies the row data type and unit type for a row type.
	///</summary>
	public class SetDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDataType(inputs[1].Value,((OdaX.AcValueDataType)inputs[2].Value),((OdaX.AcValueUnitType)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6278393F-2297-4D56-8933-ECC2AE236611", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the format of a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Not implemented. Returns the format of a row type.
	///</summary>
	public class GetFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFormat(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "00AAA878-EDA9-4A2D-9D65-71ED1A6B7518", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies the format of a row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]

	///<summary>
	///Not implemented. Specifies the format of a row type.
	///</summary>
	public class SetFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFormat(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BD65DB1E-DDC9-4C98-9247-A2BEE0750093", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.FormatValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "FormatValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the formatted text string of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Not implemented. Returns the formatted text string of a row and column.
	///</summary>
	public class FormatValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FormatValue(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9281AD43-95E3-4E5A-A089-5701937D8870", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellDataType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellDataType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the cell data type and unit type of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Not implemented. Returns the cell data type and unit type of a row and column.
	///</summary>
	public class GetCellDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCellDataType(inputs[1].Value,inputs[2].Value,((OdaX.AcValueDataType)inputs[3].Value),((OdaX.AcValueUnitType)inputs[4].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2A444552-EE56-49D0-A908-BE4C3F230795", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellDataType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellDataType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies the cell data type and unit type of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Not implemented. Specifies the cell data type and unit type of a row and column.
	///</summary>
	public class SetCellDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellDataType(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "280F789F-A1E2-45E9-9D86-3605D74425A7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the cell format for the specified row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Not implemented. Returns the cell format for the specified row and column.
	///</summary>
	public class GetCellFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellFormat(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "30ADF9E0-BBDB-41ED-A25C-168AB5F161D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies the cell format of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Not implemented. Specifies the cell format of a row and column.
	///</summary>
	public class SetCellFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellFormat(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DA4F2DDA-5F03-42E2-8167-E8C1CFC8DF9D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the cell value of a row and column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Not implemented. Returns the cell value of a row and column.
	///</summary>
	public class GetCellValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellValue(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "A1108E89-4CA4-4D16-8F73-A357CACDE008", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies the cell value of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Not implemented. Specifies the cell value of a row and column.
	///</summary>
	public class SetCellValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellValue(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C6FCE654-BDBA-4188-A54D-1B514F2A846D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellValueFromText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellValueFromText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies the cell value from existing text in a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("val", typeof(System.String))]
	[NodeInput("OdaX.AcParseOption", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies the cell value from existing text in a row and column.
	///</summary>
	public class SetCellValueFromText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellValueFromText(inputs[1].Value,inputs[2].Value,inputs[3].Value,((OdaX.AcParseOption)inputs[4].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "83F6C6A1-2501-41BC-B5B9-7D5AB8B934B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.ResetCellValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "ResetCellValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Resets the cell value of a row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Not implemented. Resets the cell value of a row and column.
	///</summary>
	public class ResetCellValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ResetCellValue(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "072D6C38-E8E8-48F5-8BC3-2E7E9475FD9B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.IsEmpty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "IsEmpty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Checks if the content of the specified cell is empty.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]

	///<summary>
	///Checks if the content of the specified cell is empty.
	///</summary>
	public class IsEmpty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsEmpty(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "38721835-354E-428C-B1BE-013C2F83A451", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.CreateContent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "CreateContent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates new content in a cell", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nIndex", typeof(System.Int32))]

	///<summary>
	///Creates new content in a cell
	///</summary>
	public class CreateContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateContent(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "5A228B2A-AB3B-4896-9A22-75C0B18C48BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.MoveContent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "MoveContent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Moves a content in a cell from one position to another position within the cell", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nFromIndex", typeof(System.Int32))]
	[NodeInput("nToIndex", typeof(System.Int32))]

	///<summary>
	///Moves a content in a cell from one position to another position within the cell
	///</summary>
	public class MoveContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveContent(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DA225E19-EFAF-49CA-A045-5655B59D3D25", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.DeleteContent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "DeleteContent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a content from a cell", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]

	///<summary>
	///Deletes a content from a cell
	///</summary>
	public class DeleteContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteContent(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "24522465-BC91-42AA-AEC4-2ECAD36C6EE2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the cell value for the specified row and column and nContent.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Gets the cell value for the specified row and column and nContent.
	///</summary>
	public class GetValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetValue(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "B3E56B86-9DF7-41A3-A549-43E780519EFE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the cell value by parsing the text for the specified row and column and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("acValue", typeof(System.Object))]

	///<summary>
	///Sets the cell value by parsing the text for the specified row and column and nContent.
	///</summary>
	public class SetValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetValue(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D0C60943-7BED-4F3B-8E7C-D1BB087E9375", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetValueFromText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetValueFromText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the value of the content at the specified content index.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("szText", typeof(System.String))]
	[NodeInput("OdaX.AcParseOption", typeof(System.Object))]

	///<summary>
	///Sets the value of the content at the specified content index.
	///</summary>
	public class SetValueFromText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetValueFromText(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,((OdaX.AcParseOption)inputs[5].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DE52257C-BB69-407E-A681-255A9164C791", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetDataFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetDataFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the cell format for the specified row and column and nContent.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Gets the cell format for the specified row and column and nContent.
	///</summary>
	public class GetDataFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDataFormat(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "D81C09B6-317B-4213-A1BD-A9EFFBAC1A03", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetDataFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetDataFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the cell format for the specified row and column and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("szFormat", typeof(System.String))]

	///<summary>
	///Sets the cell format for the specified row and column and nContent.
	///</summary>
	public class SetDataFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDataFormat(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5BF0D975-B75F-4563-A6CC-65F46FF4F44E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetTextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetTextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the text value value for the specified row and column  and nContent.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Gets the text value value for the specified row and column  and nContent.
	///</summary>
	public class GetTextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextString(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "A5C21506-FD14-4063-8E9B-B856E19BF931", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetTextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetTextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the text value value for the specified row and column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("Text", typeof(System.String))]

	///<summary>
	///Sets the text value value for the specified row and column.
	///</summary>
	public class SetTextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextString(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "31453527-7B02-41DC-9C6F-3D392AC1B638", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetFieldId2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetFieldId2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the field object id associated to the specifed cell  and nContent.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Returns the field object id associated to the specifed cell  and nContent.
	///</summary>
	public class GetFieldId2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFieldId2(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "022DE9E7-A7B6-47A8-8AB7-704BCE783B92", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetFieldId2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetFieldId2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets  the field object id associated to the specifed cell  and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("acDbObjectId", typeof(System.Object))]
	[NodeInput("OdaX.AcCellOption", typeof(System.Object))]

	///<summary>
	///Sets  the field object id associated to the specifed cell  and nContent.
	///</summary>
	public class SetFieldId2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFieldId2(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,((OdaX.AcCellOption)inputs[5].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B8CA48AA-1E11-4F94-BC8D-87BB9233832D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetBlockTableRecordId2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetBlockTableRecordId2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the block table record id associated to the block-type cell  and nContent.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Gets the block table record id associated to the block-type cell  and nContent.
	///</summary>
	public class GetBlockTableRecordId2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockTableRecordId2(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "03D29201-E532-455C-B868-766A3D84B9F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetBlockTableRecordId2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetBlockTableRecordId2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the block table record id associated to the block-type cell  and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("blkId", typeof(System.Object))]
	[NodeInput("autoFit", typeof(System.Object))]

	///<summary>
	///Sets the block table record id associated to the block-type cell  and nContent.
	///</summary>
	public class SetBlockTableRecordId2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockTableRecordId2(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9EDE244B-908E-43E5-9C39-745DDB57EEC6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetBlockAttributeValue2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetBlockAttributeValue2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the attribute value from the Specified block cell for the attribute definition object contained in the block  and nContent.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("blkId", typeof(System.Object))]

	///<summary>
	///Returns the attribute value from the Specified block cell for the attribute definition object contained in the block  and nContent.
	///</summary>
	public class GetBlockAttributeValue2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockAttributeValue2(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "8A6F83AC-91B2-4AE3-9216-FD48875B926A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetBlockAttributeValue2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetBlockAttributeValue2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the attribute value from the Specified block cell for the attribute definition object contained in the block  and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("blkId", typeof(System.Object))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///Sets the attribute value from the Specified block cell for the attribute definition object contained in the block  and nContent.
	///</summary>
	public class SetBlockAttributeValue2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockAttributeValue2(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "20EE962F-FC5D-4A15-8E33-74A66975D6D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCustomData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCustomData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the custom data value set in cell, row, or column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("szKey", typeof(System.String))]
	[NodeInput("pData", typeof(System.Object))]

	///<summary>
	///Gets the custom data value set in cell, row, or column.
	///</summary>
	public class GetCustomData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCustomData(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1AD74A0B-95AF-4A84-AF89-BE075048054A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCustomData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCustomData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the custom data value set in cell, row, or column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("szKey", typeof(System.String))]
	[NodeInput("data", typeof(System.Object))]

	///<summary>
	///Sets the custom data value set in cell, row, or column.
	///</summary>
	public class SetCustomData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCustomData(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B3EACE54-9909-480E-8463-A80CE0D65531", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the cell style of cell, row, or column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]

	///<summary>
	///Gets the cell style of cell, row, or column.
	///</summary>
	public class GetCellStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellStyle(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "C8FFA79A-1E79-4819-9C88-85C6AE2A62C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the the cell style of cell, row, or column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("szCellStyle", typeof(System.String))]

	///<summary>
	///Sets the the cell style of cell, row, or column.
	///</summary>
	public class SetCellStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellStyle(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2BE4573D-4C34-46D5-B266-4B452D4DEC82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetContentColor2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetContentColor2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the true color value for the specified row type  and nContent.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Returns the true color value for the specified row type  and nContent.
	///</summary>
	public class GetContentColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContentColor2(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "24CFCE9E-F93A-4EAB-B86D-CA5A16EFF0A7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetContentColor2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetContentColor2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the true color value for the specified row type  and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Sets the true color value for the specified row type  and nContent.
	///</summary>
	public class SetContentColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetContentColor2(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B45F0A67-3B1C-4F44-9AF6-24EEEDA26FB8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetDataType2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetDataType2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the row data type and unit type for the specified row type  and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Gets the row data type and unit type for the specified row type  and nContent.
	///</summary>
	public class GetDataType2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetDataType2(inputs[1].Value,inputs[2].Value,inputs[3].Value,((OdaX.AcValueDataType)inputs[4].Value),((OdaX.AcValueUnitType)inputs[5].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7E72C78D-BFC6-4739-AC30-83B2473DD453", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetDataType2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetDataType2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the row data type and unit type for the specified row type  and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Sets the row data type and unit type for the specified row type  and nContent.
	///</summary>
	public class SetDataType2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDataType2(inputs[1].Value,inputs[2].Value,inputs[3].Value,((OdaX.AcValueDataType)inputs[4].Value),((OdaX.AcValueUnitType)inputs[5].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "834458E4-644B-4E87-85F6-78A80355024E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetTextStyle2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetTextStyle2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the text style name for the specified row and column  and nContent.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Gets the text style name for the specified row and column  and nContent.
	///</summary>
	public class GetTextStyle2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextStyle2(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "D434B894-761E-4AD8-88F0-DB74831EB0E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetTextStyle2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetTextStyle2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the text style name for the specified row and column  and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("bstrStyleName", typeof(System.String))]

	///<summary>
	///Sets the text style name for the specified row and column  and nContent.
	///</summary>
	public class SetTextStyle2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextStyle2(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8320F224-A024-4915-854D-D7DFF076F7C9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetTextHeight2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetTextHeight2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the text height for the specified row and column  and nContent.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Returns the text height for the specified row and column  and nContent.
	///</summary>
	public class GetTextHeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextHeight2(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "CFEAF691-063E-4FE0-A829-75187C98329D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetTextHeight2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetTextHeight2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the text height for the specified row and column  and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Gets the text height for the specified row and column  and nContent.
	///</summary>
	public class SetTextHeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextHeight2(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2278A469-CA3B-4B07-9D32-A3B735917200", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the rotation angle of the content at the specified content index.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Gets the rotation angle of the content at the specified content index.
	///</summary>
	public class GetRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRotation(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "D0C96D69-8A26-4C02-A4DC-F16282F8B697", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the rotation angle of the content at the specified content index.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("Value", typeof(System.Double))]

	///<summary>
	///Sets the rotation angle of the content at the specified content index.
	///</summary>
	public class SetRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetRotation(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4FF88061-5886-4D89-84A4-155BC12DA96D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetAutoScale2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetAutoScale2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the auto scale flag value for the specified row and column  and nContent.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Returns the auto scale flag value for the specified row and column  and nContent.
	///</summary>
	public class GetAutoScale2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAutoScale2(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "01129299-8533-4044-A3E2-19EC380F4C2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetAutoScale2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetAutoScale2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the auto scale flag value for the specified row and column  and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("bAutoFit", typeof(System.Object))]

	///<summary>
	///Sets the auto scale flag value for the specified row and column  and nContent.
	///</summary>
	public class SetAutoScale2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAutoScale2(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "461FF67F-5769-4B49-8C1E-40CEC2F8DFFC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the scale of the content at the specified content index.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Gets the scale of the content at the specified content index.
	///</summary>
	public class GetScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetScale(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "81803057-3B73-4F15-A689-E3482EA067ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the scale of the content at the specified content index.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("scale", typeof(System.Double))]

	///<summary>
	///Sets the scale of the content at the specified content index.
	///</summary>
	public class SetScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetScale(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BB36C4F4-C23C-45AE-9AD8-18BFE58D51EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.RemoveAllOverrides", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "RemoveAllOverrides", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Removes all the overrides in cell, row, or column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]

	///<summary>
	///Removes all the overrides in cell, row, or column.
	///</summary>
	public class RemoveAllOverrides : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveAllOverrides(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3C6312C5-2A4E-493E-B528-CF3FBF02407A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetGridLineWeight2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetGridLineWeight2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "s)   and nContent.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]

	///<summary>
	///s)   and nContent.
	///</summary>
	public class GetGridLineWeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridLineWeight2(inputs[1].Value,inputs[2].Value,((OdaX.AcGridLineType)inputs[3].Value)));

		}
	}


	[NVP_Manifest(
		Id = "089FB112-C2AB-430E-8B78-73D7FDBB29E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetGridLineWeight2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetGridLineWeight2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "s)   and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///s)   and nContent.
	///</summary>
	public class SetGridLineWeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridLineWeight2(inputs[1].Value,inputs[2].Value,((OdaX.AcGridLineType)inputs[3].Value),inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "32B58FC0-15B7-4E3C-A651-332FDA7A7E52", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetGridLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetGridLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the grid line type of cell, row, or column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]

	///<summary>
	///Gets the grid line type of cell, row, or column.
	///</summary>
	public class GetGridLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridLinetype(inputs[1].Value,inputs[2].Value,((OdaX.AcGridLineType)inputs[3].Value)));

		}
	}


	[NVP_Manifest(
		Id = "175A2A12-A6CA-4C8A-A31E-B55D0E5203AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetGridLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetGridLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the grid line type of cell, row, or column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("idLinetype", typeof(System.Object))]

	///<summary>
	///Sets the grid line type of cell, row, or column.
	///</summary>
	public class SetGridLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridLinetype(inputs[1].Value,inputs[2].Value,((OdaX.AcGridLineType)inputs[3].Value),inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C84E3680-C0C4-4F59-9B65-F656B6658439", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetGridColor2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetGridColor2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the gridColor value for the specified gridLineType and row type  and nContent.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]

	///<summary>
	///Returns the gridColor value for the specified gridLineType and row type  and nContent.
	///</summary>
	public class GetGridColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridColor2(inputs[1].Value,inputs[2].Value,((OdaX.AcGridLineType)inputs[3].Value)));

		}
	}


	[NVP_Manifest(
		Id = "ED132FDC-577D-412D-81D6-B9758EE99379", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetGridColor2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetGridColor2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the gridColor value for the specified gridLineType and row type  and nContent.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Sets the gridColor value for the specified gridLineType and row type  and nContent.
	///</summary>
	public class SetGridColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridColor2(inputs[1].Value,inputs[2].Value,((OdaX.AcGridLineType)inputs[3].Value),inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "436CC173-58BD-4C82-B0AF-ABEE8D19D75B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetGridVisibility2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetGridVisibility2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the gridVisibility value for the specified gridLineType and row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]

	///<summary>
	///Returns the gridVisibility value for the specified gridLineType and row type.
	///</summary>
	public class GetGridVisibility2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridVisibility2(inputs[1].Value,inputs[2].Value,((OdaX.AcGridLineType)inputs[3].Value)));

		}
	}


	[NVP_Manifest(
		Id = "B2DC7ECE-1420-44BF-9021-9E5582F4C7ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetGridVisibility2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetGridVisibility2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the gridVisibility value for the specified gridLineType and row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("bVisible", typeof(System.Object))]

	///<summary>
	///Sets the gridVisibility value for the specified gridLineType and row type.
	///</summary>
	public class SetGridVisibility2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridVisibility2(inputs[1].Value,inputs[2].Value,((OdaX.AcGridLineType)inputs[3].Value),inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0A9AF2EB-14C4-465C-97F8-5235786BC649", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetGridDoubleLineSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetGridDoubleLineSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the grid double line spacing from cell, row, or column", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]

	///<summary>
	///Gets the grid double line spacing from cell, row, or column
	///</summary>
	public class GetGridDoubleLineSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridDoubleLineSpacing(inputs[1].Value,inputs[2].Value,((OdaX.AcGridLineType)inputs[3].Value)));

		}
	}


	[NVP_Manifest(
		Id = "6300CCC2-BE62-46F9-BBB8-55AFE5A551F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetGridDoubleLineSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetGridDoubleLineSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the grid double line spacing in cell, row, or column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("fSpacing", typeof(System.Double))]

	///<summary>
	///Sets the grid double line spacing in cell, row, or column.
	///</summary>
	public class SetGridDoubleLineSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridDoubleLineSpacing(inputs[1].Value,inputs[2].Value,((OdaX.AcGridLineType)inputs[3].Value),inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1E371710-6417-4D3D-95DE-1F5414051868", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_EnableBreak", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_EnableBreak", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Enables or disables table breaking", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///Enables or disables table breaking
	///</summary>
	public class Set_EnableBreak : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableBreak = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DA194DB7-4D7C-48FA-80DF-AF2842261983", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetBreakHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetBreakHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the break height of the specified table when table breaking is enabled.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]

	///<summary>
	///Returns the break height of the specified table when table breaking is enabled.
	///</summary>
	public class GetBreakHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBreakHeight(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "BA5000FC-C9DE-424A-8004-9B6227E6FC66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetBreakHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetBreakHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the break height of the specified table when table breaking is enabled.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Sets the break height of the specified table when table breaking is enabled.
	///</summary>
	public class SetBreakHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBreakHeight(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C71E417A-A73D-4722-9F18-1324439A6CCA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetContentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetContentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the content type of the content at the specified content index.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]

	///<summary>
	///Gets the content type of the content at the specified content index.
	///</summary>
	public class GetContentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContentType(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "9EFDDDBF-1B1D-4F48-B8D2-57AE45C55573", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the margin of cell, row, or column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellMargin", typeof(System.Object))]

	///<summary>
	///Gets the margin of cell, row, or column.
	///</summary>
	public class GetMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMargin(inputs[1].Value,inputs[2].Value,((OdaX.AcCellMargin)inputs[3].Value)));

		}
	}


	[NVP_Manifest(
		Id = "31C077BB-9AE3-4052-B392-70227E6E08EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the margin of cell, row, or column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellMargin", typeof(System.Object))]
	[NodeInput("fMargin", typeof(System.Double))]

	///<summary>
	///Sets the margin of cell, row, or column.
	///</summary>
	public class SetMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetMargin(inputs[1].Value,inputs[2].Value,((OdaX.AcCellMargin)inputs[3].Value),inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "306BE8FB-E9EE-40A4-8FEA-59D9C0E175A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetContentLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetContentLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the content layout of the cell.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]

	///<summary>
	///Gets the content layout of the cell.
	///</summary>
	public class GetContentLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContentLayout(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "73A88160-35CF-4307-B74C-4F6E0BE50DE9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetContentLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetContentLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the content layout of the cell.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellContentLayout", typeof(System.Object))]

	///<summary>
	///Sets the content layout of the cell.
	///</summary>
	public class SetContentLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetContentLayout(inputs[1].Value,inputs[2].Value,((OdaX.AcCellContentLayout)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4AF1A150-7205-4FCD-AB1A-BDF8FAD55E88", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetOverride", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetOverride", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the override in cell, row, column, or content.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Gets the override in cell, row, column, or content.
	///</summary>
	public class GetOverride : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetOverride(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "94E0BDEF-9D11-432C-9A66-90A616DBD04D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetOverride", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetOverride", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the override in cell, row, column, or content.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellProperty", typeof(System.Object))]

	///<summary>
	///Sets the override in cell, row, column, or content.
	///</summary>
	public class SetOverride : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetOverride(inputs[1].Value,inputs[2].Value,inputs[3].Value,((OdaX.AcCellProperty)inputs[4].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D835DA12-EF33-483C-8F92-F0DFE1638B82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetGridLineStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetGridLineStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the grid line style of cell, row, or column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]

	///<summary>
	///Gets the grid line style of cell, row, or column.
	///</summary>
	public class GetGridLineStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridLineStyle(inputs[1].Value,inputs[2].Value,((OdaX.AcGridLineType)inputs[3].Value)));

		}
	}


	[NVP_Manifest(
		Id = "4C5CEAFB-D1D2-4A86-B195-535CD0396C2F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetGridLineStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetGridLineStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the grid line style of cell, row, or column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("OdaX.AcGridLineStyle", typeof(System.Object))]

	///<summary>
	///Sets the grid line style of cell, row, or column.
	///</summary>
	public class SetGridLineStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridLineStyle(inputs[1].Value,inputs[2].Value,((OdaX.AcGridLineType)inputs[3].Value),((OdaX.AcGridLineStyle)inputs[4].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5C365842-7202-4193-989E-9BF299CC4DFC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.InsertRowsAndInherit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "InsertRowsAndInherit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Inserts one or more rows at the specified index and inherits the row properties from specified row.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]
	[NodeInput("nInheritFrom", typeof(System.Int32))]
	[NodeInput("nNumRows", typeof(System.Int32))]

	///<summary>
	///Inserts one or more rows at the specified index and inherits the row properties from specified row.
	///</summary>
	public class InsertRowsAndInherit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertRowsAndInherit(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9E8C2FCF-597B-48FC-B185-F2C3F1DEC42D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.InsertColumnsAndInherit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "InsertColumnsAndInherit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Inserts one or more columns at the specified index and inherits the column properties from specified column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("nInheritFrom", typeof(System.Int32))]
	[NodeInput("nNumCols", typeof(System.Int32))]

	///<summary>
	///Inserts one or more columns at the specified index and inherits the column properties from specified column.
	///</summary>
	public class InsertColumnsAndInherit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertColumnsAndInherit(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "11973473-AF79-4439-B96E-2BB804C8CFE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetHasFormula", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetHasFormula", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns true if the content at the specified index is a formula.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Returns true if the content at the specified index is a formula.
	///</summary>
	public class GetHasFormula : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetHasFormula(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "C49931FF-0F30-42C6-A5EC-483C59958372", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetFormula", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetFormula", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the formula if the content at the specified content index has a formula.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]

	///<summary>
	///Gets the formula if the content at the specified content index has a formula.
	///</summary>
	public class GetFormula : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFormula(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "A6058ADD-C80F-4DAC-90DE-4B66DB2A7C4C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetFormula", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetFormula", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the formula at the specified content index.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("pszFormula", typeof(System.String))]

	///<summary>
	///Sets the formula at the specified content index.
	///</summary>
	public class SetFormula : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFormula(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1114BBBD-5678-4A7F-8BFC-DC7A3B8B2017", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.IsContentEditable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "IsContentEditable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Checks if the content of the specified cell can be modified.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]

	///<summary>
	///Checks if the content of the specified cell can be modified.
	///</summary>
	public class IsContentEditable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsContentEditable(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "B4515A78-2131-4D94-B4D7-4C9B3B331453", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.IsFormatEditable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "IsFormatEditable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Checks if the format of the specified cell can be modified.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]

	///<summary>
	///Checks if the format of the specified cell can be modified.
	///</summary>
	public class IsFormatEditable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsFormatEditable(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "90E59D43-601E-45B8-88AF-0B75BE6222E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetCellState", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetCellState", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the cell state.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]

	///<summary>
	///Gets the cell state.
	///</summary>
	public class GetCellState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellState(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "E88757A2-F9AD-4832-A40C-D315A7B4F21B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetCellState", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetCellState", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the cell state.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellState", typeof(System.Object))]

	///<summary>
	///Sets the cell state.
	///</summary>
	public class SetCellState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellState(inputs[1].Value,inputs[2].Value,((OdaX.AcCellState)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0627D8C9-FD5E-4F11-8536-49D1EAE541EA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.EnableMergeAll", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "EnableMergeAll", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Enables or disables the merge all flag in row or column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("bEnable", typeof(System.Object))]

	///<summary>
	///Enables or disables the merge all flag in row or column.
	///</summary>
	public class EnableMergeAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableMergeAll(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B24AA458-4096-468F-B3C2-A17E1AE978F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.IsMergeAllEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "IsMergeAllEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether merge all flag is enabled or not in row or column.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]

	///<summary>
	///Returns whether merge all flag is enabled or not in row or column.
	///</summary>
	public class IsMergeAllEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsMergeAllEnabled(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "5F6FD16B-5AF3-4B4D-AEB3-4D64CEA4EBAC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.BreaksEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "BreaksEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether table breaking is in use. When enabled, the table will break automatically at the current specified height.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Determines whether table breaking is in use. When enabled, the table will break automatically at the current specified height.
	///</summary>
	public class BreaksEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BreaksEnabled);

		}
	}


	[NVP_Manifest(
		Id = "116DB47A-C5B9-4D5D-AD4B-D78AC19DA387", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_BreaksEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_BreaksEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether table breaking is in use. When enabled, the table will break automatically at the current specified height.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bEnabled", typeof(System.Object))]

	///<summary>
	///Determines whether table breaking is in use. When enabled, the table will break automatically at the current specified height.
	///</summary>
	public class Set_BreaksEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BreaksEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "00C0DB97-7DEC-4C44-B05E-58F591049D10", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.RepeatTopLabels", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "RepeatTopLabels", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether the first set of label rows will be repeated at the top of each broken table part.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Determines whether the first set of label rows will be repeated at the top of each broken table part.
	///</summary>
	public class RepeatTopLabels : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RepeatTopLabels);

		}
	}


	[NVP_Manifest(
		Id = "867BDF42-53A2-4F3E-9FEC-418F7F69BD0F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_RepeatTopLabels", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_RepeatTopLabels", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether the first set of label rows will be repeated at the top of each broken table part.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bEnabled", typeof(System.Object))]

	///<summary>
	///Determines whether the first set of label rows will be repeated at the top of each broken table part.
	///</summary>
	public class Set_RepeatTopLabels : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RepeatTopLabels = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A899BC93-6373-4030-BAAA-49E61627DEC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.RepeatBottomLabels", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "RepeatBottomLabels", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether the bottom set of label rows is repeated at the bottom of each broken table part.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Determines whether the bottom set of label rows is repeated at the bottom of each broken table part.
	///</summary>
	public class RepeatBottomLabels : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RepeatBottomLabels);

		}
	}


	[NVP_Manifest(
		Id = "DC0CCB05-9BA8-4ABC-90B3-0A233670822F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_RepeatBottomLabels", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_RepeatBottomLabels", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether the bottom set of label rows is repeated at the bottom of each broken table part.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bEnabled", typeof(System.Object))]

	///<summary>
	///Determines whether the bottom set of label rows is repeated at the bottom of each broken table part.
	///</summary>
	public class Set_RepeatBottomLabels : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RepeatBottomLabels = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D13CCE3F-BCF8-404E-9BD3-ABA8B83FD552", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.TableBreakFlowDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "TableBreakFlowDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines the direction that parts of the table flow.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Determines the direction that parts of the table flow.
	///</summary>
	public class TableBreakFlowDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TableBreakFlowDirection);

		}
	}


	[NVP_Manifest(
		Id = "3BAF90D2-1A9E-4326-8983-10275711C229", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_TableBreakFlowDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_TableBreakFlowDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines the direction that parts of the table flow.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("OdaX.AcTableFlowDirection", typeof(System.Object))]

	///<summary>
	///Determines the direction that parts of the table flow.
	///</summary>
	public class Set_TableBreakFlowDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TableBreakFlowDirection = ((OdaX.AcTableFlowDirection)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EA97CCCC-AC55-4010-A2B9-9A5137E7E047", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.AllowManualPositions", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "AllowManualPositions", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "When enabled, each table part can be moved outside of the boundary. When not enabled, the table parts are contained within a rectangular boundary.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///When enabled, each table part can be moved outside of the boundary. When not enabled, the table parts are contained within a rectangular boundary.
	///</summary>
	public class AllowManualPositions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AllowManualPositions);

		}
	}


	[NVP_Manifest(
		Id = "159E9B6C-1E38-490A-98EB-38A901DB8C22", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_AllowManualPositions", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_AllowManualPositions", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "When enabled, each table part can be moved outside of the boundary. When not enabled, the table parts are contained within a rectangular boundary.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bEnabled", typeof(System.Object))]

	///<summary>
	///When enabled, each table part can be moved outside of the boundary. When not enabled, the table parts are contained within a rectangular boundary.
	///</summary>
	public class Set_AllowManualPositions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AllowManualPositions = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "702CFDC4-14FB-4C19-9782-B8BA9C729D4D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.AllowManualHeights", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "AllowManualHeights", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Allows the heights of broken table parts to have their own breaking height. When set to No, all table parts will break at the height of the initial table part.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Allows the heights of broken table parts to have their own breaking height. When set to No, all table parts will break at the height of the initial table part.
	///</summary>
	public class AllowManualHeights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AllowManualHeights);

		}
	}


	[NVP_Manifest(
		Id = "74F174D4-C22E-4B59-82E4-09F01D1EFA7C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_AllowManualHeights", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_AllowManualHeights", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Allows the heights of broken table parts to have their own breaking height. When set to No, all table parts will break at the height of the initial table part.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bEnabled", typeof(System.Object))]

	///<summary>
	///Allows the heights of broken table parts to have their own breaking height. When set to No, all table parts will break at the height of the initial table part.
	///</summary>
	public class Set_AllowManualHeights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AllowManualHeights = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7E80A966-C20D-437C-8D4E-52E64C835DCC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.TableBreakHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "TableBreakHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the breaking height for the initial table part and any other table parts that do not have manual heights set.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Sets the breaking height for the initial table part and any other table parts that do not have manual heights set.
	///</summary>
	public class TableBreakHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TableBreakHeight);

		}
	}


	[NVP_Manifest(
		Id = "0BF7129D-1738-4E30-925B-7134D50EFDCB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_TableBreakHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_TableBreakHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the breaking height for the initial table part and any other table parts that do not have manual heights set.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pHeight", typeof(System.Double))]

	///<summary>
	///Sets the breaking height for the initial table part and any other table parts that do not have manual heights set.
	///</summary>
	public class Set_TableBreakHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TableBreakHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6FFBC6B4-86C5-40D3-8846-8CA01624C6AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.BreakSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "BreakSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Controls the spacing between the broken table parts. Depending on the break direction this will be a horizontal or vertical spacing.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]

	///<summary>
	///Controls the spacing between the broken table parts. Depending on the break direction this will be a horizontal or vertical spacing.
	///</summary>
	public class BreakSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BreakSpacing);

		}
	}


	[NVP_Manifest(
		Id = "CC0A1612-8C56-44D6-8AF8-1772803D5301", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.Set_BreakSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "Set_BreakSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Controls the spacing between the broken table parts. Depending on the break direction this will be a horizontal or vertical spacing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pSpacing", typeof(System.Double))]

	///<summary>
	///Controls the spacing between the broken table parts. Depending on the break direction this will be a horizontal or vertical spacing.
	///</summary>
	public class Set_BreakSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BreakSpacing = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B1BA187B-7CEB-401C-B1EB-F12D43FFD202", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.GetColumnName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "GetColumnName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the columns name.", 
		ViewType = "Data")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]

	///<summary>
	///Gets the columns name.
	///</summary>
	public class GetColumnName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetColumnName(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "2C833AFF-EEFC-494F-B2DF-B8D749FF3D69", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetColumnName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetColumnName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the columns name.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Sets the columns name.
	///</summary>
	public class SetColumnName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetColumnName(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "081172DC-A372-424C-B5C4-6D90BBAFE15B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTable.SetToolTip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTable", 
		NodeName = "SetToolTip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the tooltip string for cell, row, or column.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("tip", typeof(System.String))]

	///<summary>
	///Sets the tooltip string for cell, row, or column.
	///</summary>
	public class SetToolTip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetToolTip(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}
}
