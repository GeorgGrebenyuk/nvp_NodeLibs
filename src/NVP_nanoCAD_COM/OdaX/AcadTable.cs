using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of table object
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadTable 
{

	[NVP_Manifest(
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
