using NVP.API.Nodes;

namespace OdaX.AcadTable 
{
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


	///<summary>
	///Specifies or returns the name of the table style assigned to a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleName);

		}
	}


	///<summary>
	///Specifies or returns the name of the table style assigned to a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]
	public class Set_StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the number of rows in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rows);

		}
	}


	///<summary>
	///Specifies or returns the number of rows in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pRows", typeof(System.Int32))]
	public class Set_Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rows = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the number of columns in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Columns);

		}
	}


	///<summary>
	///Specifies or returns the number of columns in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pColumns", typeof(System.Int32))]
	public class Set_Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Columns = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the position a table's title and row headings.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class FlowDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FlowDirection);

		}
	}


	///<summary>
	///Specifies or returns the position a table's title and row headings.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pFlow", typeof(System.Object))]
	public class Set_FlowDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FlowDirection = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the width of a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	///<summary>
	///Specifies or returns the width of a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pWidth", typeof(System.Double))]
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the height of a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	///<summary>
	///Specifies or returns the height of a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pHeight", typeof(System.Double))]
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the distance between cell text and the top/bottom cell edge.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class VertCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VertCellMargin);

		}
	}


	///<summary>
	///Specifies or returns the distance between cell text and the top/bottom cell edge.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pGap", typeof(System.Double))]
	public class Set_VertCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VertCellMargin = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the distance between cell text and the left/right cell edge.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class HorzCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorzCellMargin);

		}
	}


	///<summary>
	///Specifies or returns the distance between cell text and the left/right cell edge.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pGap", typeof(System.Double))]
	public class Set_HorzCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorzCellMargin = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates of the table insertion point.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsertionPoint);

		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates of the table insertion point.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]
	public class Set_InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertionPoint = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the width of a column in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetColumnWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetColumnWidth(inputs[1]));

		}
	}


	///<summary>
	///Sets the width of a column in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("Width", typeof(System.Double))]
	public class SetColumnWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetColumnWidth(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Sets the width of all columns in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rhs", typeof(System.Double))]
	public class Set_ColumnWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColumnWidth = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the height of a row in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	public class GetRowHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRowHeight(inputs[1]));

		}
	}


	///<summary>
	///Sets the height of a row in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("Height", typeof(System.Double))]
	public class SetRowHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetRowHeight(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Sets the height of all rows in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rhs", typeof(System.Double))]
	public class Set_RowHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RowHeight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the minimum width of a column in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetMinimumColumnWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMinimumColumnWidth(inputs[1]));

		}
	}


	///<summary>
	///Returns the minimum height of a row in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	public class GetMinimumRowHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMinimumRowHeight(inputs[1]));

		}
	}


	///<summary>
	///Returns the minimum width of a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class MinimumTableWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinimumTableWidth);

		}
	}


	///<summary>
	///Returns the minimum height of a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class MinimumTableHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinimumTableHeight);

		}
	}


	///<summary>
	///Specifies or returns the x plane where a table is positioned.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	///<summary>
	///Specifies or returns the x plane where a table is positioned.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("DirectionVector", typeof(System.Object))]
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether the title of a table is visible.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class TitleSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TitleSuppressed);

		}
	}


	///<summary>
	///Specifies or returns whether the title of a table is visible.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bValue", typeof(System.Object))]
	public class Set_TitleSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TitleSuppressed = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether row headings of a table are visible.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class HeaderSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HeaderSuppressed);

		}
	}


	///<summary>
	///Specifies or returns whether row headings of a table are visible.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bValue", typeof(System.Object))]
	public class Set_HeaderSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HeaderSuppressed = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns how the cells of a row type are aligned.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowType", typeof(System.Object))]
	public class GetAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAlignment(inputs[1]));

		}
	}


	///<summary>
	///Specifies how the cells of a row type are aligned.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("cellAlignment", typeof(System.Object))]
	public class SetAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAlignment(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether the row type of a table has a background color.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowType", typeof(System.Object))]
	public class GetBackgroundColorNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBackgroundColorNone(inputs[1]));

		}
	}


	///<summary>
	///Specifies or returns whether the row type of a table has a background color.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]
	public class SetBackgroundColorNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBackgroundColorNone(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Returns the background color value of a table's row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowType", typeof(System.Object))]
	public class GetBackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBackgroundColor(inputs[1]));

		}
	}


	///<summary>
	///Specifies the background color value of a table's row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]
	public class SetBackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBackgroundColor(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Returns the color value of a table's row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowType", typeof(System.Object))]
	public class GetContentColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContentColor(inputs[1]));

		}
	}


	///<summary>
	///Specifies the color value of a table's row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]
	public class SetContentColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetContentColor(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Returns the name of the text style assigned to the row type of a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowType", typeof(System.Object))]
	public class GetTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextStyle(inputs[1]));

		}
	}


	///<summary>
	///Specifies the text style assigned to the row type of a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("bstrName", typeof(System.String))]
	public class SetTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextStyle(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Returns the text height of a table's row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowType", typeof(System.Object))]
	public class GetTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextHeight(inputs[1]));

		}
	}


	///<summary>
	///Specifies the text height of a table's row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("TextHeight", typeof(System.Double))]
	public class SetTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextHeight(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Returns the grid lineweight value for a grid linetype and row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("gridLineType", typeof(System.Object))]
	[NodeInput("rowType", typeof(System.Object))]
	public class GetGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridLineWeight(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the grid lineweight value for a grid linetype and row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("gridLineTypes", typeof(System.Int32))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("Lineweight", typeof(System.Object))]
	public class SetGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridLineWeight(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the grid color value for a grid linetype and row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("gridLineType", typeof(System.Object))]
	[NodeInput("rowType", typeof(System.Object))]
	public class GetGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridColor(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the grid color value for a grid linetype and row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("gridLineTypes", typeof(System.Int32))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]
	public class SetGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridColor(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the grid visibility value for a Returns the grid color value for a grid linetype and row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("gridLineType", typeof(System.Object))]
	[NodeInput("rowType", typeof(System.Object))]
	public class GetGridVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridVisibility(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the grid visibility value for a grid linetype and row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("gridLineTypes", typeof(System.Int32))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]
	public class SetGridVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridVisibility(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the overrides of a table style.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class TableStyleOverrides : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TableStyleOverrides);

		}
	}


	///<summary>
	///Removes the overrides of a table style.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("flag", typeof(System.Int32))]
	public class ClearTableStyleOverrides : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClearTableStyleOverrides(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Returns the cell type of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetCellType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellType(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the cell type of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("CellType", typeof(System.Object))]
	public class SetCellType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellType(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns whether a table cell is in the inner part of a table or on the outer edge.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("bOuterCell", typeof(System.Object))]
	public class GetCellExtents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellExtents(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Returns the attachment point of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetAttachmentPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAttachmentPoint(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Returns the alignment of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetCellAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellAlignment(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the cell alignment of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("cellAlignment", typeof(System.Object))]
	public class SetCellAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellAlignment(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns whether the background color is set to None for a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetCellBackgroundColorNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellBackgroundColorNone(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies whether the background color is set to None for a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]
	public class SetCellBackgroundColorNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellBackgroundColorNone(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the background color for a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetCellBackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellBackgroundColor(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the background color for a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]
	public class SetCellBackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellBackgroundColor(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the cell content color for a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetCellContentColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellContentColor(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the cell content color for a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]
	public class SetCellContentColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellContentColor(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the overrides of a cell style.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetCellStyleOverrides : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellStyleOverrides(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Deletes all cell content for a row and coluumn.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class DeleteCellContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteCellContent(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Returns the row type of a row.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	public class GetRowType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRowType(inputs[1]));

		}
	}


	///<summary>
	///Returns the text of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetText(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the text of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("pStr", typeof(System.String))]
	public class SetText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetText(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the text style name of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetCellTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellTextStyle(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the text style name of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("bstrName", typeof(System.String))]
	public class SetCellTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellTextStyle(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the text height of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetCellTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellTextHeight(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the text height of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("TextHeight", typeof(System.Double))]
	public class SetCellTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellTextHeight(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the text rotation of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetTextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextRotation(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the text rotation of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("TextRotation", typeof(System.Object))]
	public class SetTextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextRotation(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns whether auto scaling is turned on for a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetAutoScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAutoScale(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies whether auto scaling is turned on for a row nad column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]
	public class SetAutoScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAutoScale(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the block table record ID associated with the block-type cell.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetBlockTableRecordId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockTableRecordId(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the block table record ID associated with the block-type cell.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("blkId", typeof(System.Object))]
	[NodeInput("bAutoFit", typeof(System.Object))]
	public class SetBlockTableRecordId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockTableRecordId(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Returns the block scale value for a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetBlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockScale(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the block scale value for a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("blkScale", typeof(System.Double))]
	public class SetBlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockScale(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the block rotation of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetBlockRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockRotation(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the block rotation of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("blkRotation", typeof(System.Double))]
	public class SetBlockRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockRotation(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the attribute value of a block cell.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("attdefId", typeof(System.Object))]
	public class GetBlockAttributeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockAttributeValue(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Specifies the attribute value of a block cell.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("attdefId", typeof(System.Object))]
	[NodeInput("bstrValue", typeof(System.String))]
	public class SetBlockAttributeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockAttributeValue(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Returns the grid lineweight value for the edge of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("edge", typeof(System.Object))]
	public class GetCellGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellGridLineWeight(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Specifies the grid lineweight value for the edges of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("edges", typeof(System.Int32))]
	[NodeInput("Lineweight", typeof(System.Object))]
	public class SetCellGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellGridLineWeight(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Returns the grid color value for the edge of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("edge", typeof(System.Object))]
	public class GetCellGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellGridColor(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Specifies the grid color value for the edges of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("edges", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]
	public class SetCellGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellGridColor(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Returns whether the grid is visible for the edge of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("edge", typeof(System.Object))]
	public class GetCellGridVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellGridVisibility(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Specifies whether the grid is visible for the edges of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("edges", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]
	public class SetCellGridVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellGridVisibility(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Adds columns to a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("cols", typeof(System.Int32))]
	public class InsertColumns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertColumns(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Deletes columns from a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("cols", typeof(System.Int32))]
	public class DeleteColumns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteColumns(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Adds rows to a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("Height", typeof(System.Double))]
	[NodeInput("Rows", typeof(System.Int32))]
	public class InsertRows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertRows(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Deletes rows from a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("Rows", typeof(System.Int32))]
	public class DeleteRows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteRows(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Merges cells together into a single cell.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("minRow", typeof(System.Int32))]
	[NodeInput("maxRow", typeof(System.Int32))]
	[NodeInput("minCol", typeof(System.Int32))]
	[NodeInput("maxCol", typeof(System.Int32))]
	public class MergeCells : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MergeCells(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Unmerges cells.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("minRow", typeof(System.Int32))]
	[NodeInput("maxRow", typeof(System.Int32))]
	[NodeInput("minCol", typeof(System.Int32))]
	[NodeInput("maxCol", typeof(System.Int32))]
	public class UnmergeCells : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnmergeCells(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Returns whether the specified cells are merged.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("minRow", typeof(System.Int32))]
	[NodeInput("maxRow", typeof(System.Int32))]
	[NodeInput("minCol", typeof(System.Int32))]
	[NodeInput("maxCol", typeof(System.Int32))]
	public class IsMergedCell : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsMergedCell(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5],inputs[6]));

		}
	}


	///<summary>
	///Returns the field object ID that corresponds to a cell.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetFieldId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFieldId(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the field object ID for a cell.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("fieldId", typeof(System.Object))]
	public class SetFieldId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFieldId(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Generates the layout and content of a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class GenerateLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GenerateLayout();
			return null;
		}
	}


	///<summary>
	///Recomputes the referenced table block with changes made to the table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bForceUpdate", typeof(System.Object))]
	public class RecomputeTableBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RecomputeTableBlock(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Not implemented. Determines whether a vertex is on a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("wpt", typeof(System.Object))]
	[NodeInput("wviewVec", typeof(System.Object))]
	[NodeInput("resultRowIndex", typeof(System.Int32))]
	[NodeInput("resultColumnIndex", typeof(System.Int32))]
	public class HitTest : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HitTest(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Not implemented. Selects a cell in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("wpt", typeof(System.Object))]
	[NodeInput("wvwVec", typeof(System.Object))]
	[NodeInput("wvwxVec", typeof(System.Object))]
	[NodeInput("wxaper", typeof(System.Double))]
	[NodeInput("wyaper", typeof(System.Double))]
	[NodeInput("allowOutside", typeof(System.Object))]
	[NodeInput("resultRowIndex", typeof(System.Int32))]
	[NodeInput("resultColumnIndex", typeof(System.Int32))]
	public class Select : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Select(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5],inputs[6],inputs[7],inputs[8]));

		}
	}


	///<summary>
	///Not implemented. Selects a subregion in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("wpt1", typeof(System.Object))]
	[NodeInput("wpt2", typeof(System.Object))]
	[NodeInput("wvwVec", typeof(System.Object))]
	[NodeInput("wvwxVec", typeof(System.Object))]
	[NodeInput("seltype", typeof(System.Object))]
	[NodeInput("bIncludeCurrentSelection", typeof(System.Object))]
	[NodeInput("rowMin", typeof(System.Int32))]
	[NodeInput("rowMax", typeof(System.Int32))]
	[NodeInput("colMin", typeof(System.Int32))]
	[NodeInput("colMax", typeof(System.Int32))]
	public class SelectSubRegion : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SelectSubRegion(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5],inputs[6],inputs[7],inputs[8],inputs[9],inputs[10]));

		}
	}


	///<summary>
	///Not implemented. Reselects a subregion in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class ReselectSubRegion : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReselectSubRegion);

		}
	}


	///<summary>
	///Not implemented. Returns a subregion in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowMin", typeof(System.Int32))]
	[NodeInput("rowMax", typeof(System.Int32))]
	[NodeInput("colMin", typeof(System.Int32))]
	[NodeInput("colMax", typeof(System.Int32))]
	public class GetSubSelection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetSubSelection(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Not implemented. Specifies a subregion in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowMin", typeof(System.Int32))]
	[NodeInput("rowMax", typeof(System.Int32))]
	[NodeInput("colMin", typeof(System.Int32))]
	[NodeInput("colMax", typeof(System.Int32))]
	public class SetSubSelection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetSubSelection(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Not implemented. Clears a subregion in a table.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class ClearSubSelection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClearSubSelection();
			return null;
		}
	}


	///<summary>
	///Not implemented. Determines whether a table has a subselection set.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class HasSubSelection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasSubSelection);

		}
	}


	///<summary>
	///Not implemented. Determines whether a table can be regenerated.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class RegenerateTableSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RegenerateTableSuppressed);

		}
	}


	///<summary>
	///Not implemented. Determines whether a table can be regenerated.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bValue", typeof(System.Object))]
	public class Set_RegenerateTableSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RegenerateTableSuppressed = inputs[1];
			return null;
		}
	}


	///<summary>
	///Not implemented. Returns the row data type and unit type for the specified row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowType", typeof(System.Object))]
	[NodeInput("pDataType", typeof(System.Object))]
	[NodeInput("pUnitType", typeof(System.Object))]
	public class GetDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetDataType(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Not implemented. Specifies the row data type and unit type for a row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("dataType", typeof(System.Object))]
	[NodeInput("unitType", typeof(System.Object))]
	public class SetDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDataType(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Not implemented. Returns the format of a row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowType", typeof(System.Object))]
	public class GetFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFormat(inputs[1]));

		}
	}


	///<summary>
	///Not implemented. Specifies the format of a row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	public class SetFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFormat(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Not implemented. Returns the formatted text string of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class FormatValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FormatValue(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Not implemented. Returns the cell data type and unit type of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("pDataType", typeof(System.Object))]
	[NodeInput("pUnitType", typeof(System.Object))]
	public class GetCellDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCellDataType(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Not implemented. Specifies the cell data type and unit type of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class SetCellDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellDataType(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Not implemented. Returns the cell format for the specified row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetCellFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellFormat(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Not implemented. Specifies the cell format of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class SetCellFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellFormat(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Not implemented. Returns the cell value of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetCellValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellValue(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Not implemented. Specifies the cell value of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class SetCellValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellValue(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Not implemented. Specifies the cell value from existing text in a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("val", typeof(System.String))]
	[NodeInput("nOption", typeof(System.Object))]
	public class SetCellValueFromText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellValueFromText(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Not implemented. Resets the cell value of a row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class ResetCellValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ResetCellValue(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Checks if the content of the specified cell is empty.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	public class IsEmpty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsEmpty(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Creates new content in a cell
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nIndex", typeof(System.Int32))]
	public class CreateContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateContent(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Moves a content in a cell from one position to another position within the cell
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nFromIndex", typeof(System.Int32))]
	[NodeInput("nToIndex", typeof(System.Int32))]
	public class MoveContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveContent(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Deletes a content from a cell
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	public class DeleteContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteContent(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Gets the cell value for the specified row and column and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetValue(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the cell value by parsing the text for the specified row and column and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("acValue", typeof(System.Object))]
	public class SetValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetValue(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Sets the value of the content at the specified content index.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("szText", typeof(System.String))]
	[NodeInput("nOption", typeof(System.Object))]
	public class SetValueFromText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetValueFromText(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]);
			return null;
		}
	}


	///<summary>
	///Gets the cell format for the specified row and column and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetDataFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDataFormat(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the cell format for the specified row and column and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("szFormat", typeof(System.String))]
	public class SetDataFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDataFormat(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Gets the text value value for the specified row and column  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetTextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextString(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the text value value for the specified row and column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("Text", typeof(System.String))]
	public class SetTextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextString(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Returns the field object id associated to the specifed cell  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetFieldId2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFieldId2(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets  the field object id associated to the specifed cell  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("acDbObjectId", typeof(System.Object))]
	[NodeInput("nflag", typeof(System.Object))]
	public class SetFieldId2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFieldId2(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]);
			return null;
		}
	}


	///<summary>
	///Gets the block table record id associated to the block-type cell  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetBlockTableRecordId2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockTableRecordId2(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the block table record id associated to the block-type cell  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("blkId", typeof(System.Object))]
	[NodeInput("autoFit", typeof(System.Object))]
	public class SetBlockTableRecordId2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockTableRecordId2(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]);
			return null;
		}
	}


	///<summary>
	///Returns the attribute value from the Specified block cell for the attribute definition object contained in the block  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("blkId", typeof(System.Object))]
	public class GetBlockAttributeValue2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockAttributeValue2(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Sets the attribute value from the Specified block cell for the attribute definition object contained in the block  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("blkId", typeof(System.Object))]
	[NodeInput("Value", typeof(System.String))]
	public class SetBlockAttributeValue2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockAttributeValue2(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]);
			return null;
		}
	}


	///<summary>
	///Gets the custom data value set in cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("szKey", typeof(System.String))]
	[NodeInput("pData", typeof(System.Object))]
	public class GetCustomData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCustomData(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Sets the custom data value set in cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("szKey", typeof(System.String))]
	[NodeInput("data", typeof(System.Object))]
	public class SetCustomData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCustomData(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Gets the cell style of cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	public class GetCellStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellStyle(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Sets the the cell style of cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("szCellStyle", typeof(System.String))]
	public class SetCellStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellStyle(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the true color value for the specified row type  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetContentColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContentColor2(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the true color value for the specified row type  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]
	public class SetContentColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetContentColor2(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Gets the row data type and unit type for the specified row type  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("pDataType", typeof(System.Object))]
	[NodeInput("pUnitType", typeof(System.Object))]
	public class GetDataType2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetDataType2(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]);
			return null;
		}
	}


	///<summary>
	///Sets the row data type and unit type for the specified row type  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("dataType", typeof(System.Object))]
	[NodeInput("unitType", typeof(System.Object))]
	public class SetDataType2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDataType2(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]);
			return null;
		}
	}


	///<summary>
	///Gets the text style name for the specified row and column  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetTextStyle2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextStyle2(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the text style name for the specified row and column  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("bstrStyleName", typeof(System.String))]
	public class SetTextStyle2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextStyle2(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Returns the text height for the specified row and column  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetTextHeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextHeight2(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Gets the text height for the specified row and column  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("Height", typeof(System.Double))]
	public class SetTextHeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextHeight2(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Gets the rotation angle of the content at the specified content index.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRotation(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the rotation angle of the content at the specified content index.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("Value", typeof(System.Double))]
	public class SetRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetRotation(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Returns the auto scale flag value for the specified row and column  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetAutoScale2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAutoScale2(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the auto scale flag value for the specified row and column  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("bAutoFit", typeof(System.Object))]
	public class SetAutoScale2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAutoScale2(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Gets the scale of the content at the specified content index.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetScale(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the scale of the content at the specified content index.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("scale", typeof(System.Double))]
	public class SetScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetScale(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Removes all the overrides in cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	public class RemoveAllOverrides : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveAllOverrides(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///s)   and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nGridLineType", typeof(System.Object))]
	public class GetGridLineWeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridLineWeight2(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///s)   and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nGridLineType", typeof(System.Object))]
	[NodeInput("Lineweight", typeof(System.Object))]
	public class SetGridLineWeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridLineWeight2(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Gets the grid line type of cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nGridLineType", typeof(System.Object))]
	public class GetGridLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridLinetype(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the grid line type of cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nGridLineType", typeof(System.Object))]
	[NodeInput("idLinetype", typeof(System.Object))]
	public class SetGridLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridLinetype(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Returns the gridColor value for the specified gridLineType and row type  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nGridLineType", typeof(System.Object))]
	public class GetGridColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridColor2(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the gridColor value for the specified gridLineType and row type  and nContent.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nGridLineType", typeof(System.Object))]
	[NodeInput("pColor", typeof(System.Object))]
	public class SetGridColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridColor2(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Returns the gridVisibility value for the specified gridLineType and row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nGridLineType", typeof(System.Object))]
	public class GetGridVisibility2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridVisibility2(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the gridVisibility value for the specified gridLineType and row type.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nGridLineType", typeof(System.Object))]
	[NodeInput("bVisible", typeof(System.Object))]
	public class SetGridVisibility2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridVisibility2(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Gets the grid double line spacing from cell, row, or column
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nGridLineType", typeof(System.Object))]
	public class GetGridDoubleLineSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridDoubleLineSpacing(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the grid double line spacing in cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nGridLineType", typeof(System.Object))]
	[NodeInput("fSpacing", typeof(System.Double))]
	public class SetGridDoubleLineSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridDoubleLineSpacing(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Enables or disables table breaking
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]
	public class Set_EnableBreak : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableBreak = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the break height of the specified table when table breaking is enabled.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]
	public class GetBreakHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBreakHeight(inputs[1]));

		}
	}


	///<summary>
	///Sets the break height of the specified table when table breaking is enabled.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]
	[NodeInput("Height", typeof(System.Double))]
	public class SetBreakHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBreakHeight(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Gets the content type of the content at the specified content index.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	public class GetContentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContentType(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Gets the margin of cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nMargin", typeof(System.Object))]
	public class GetMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMargin(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the margin of cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nMargins", typeof(System.Object))]
	[NodeInput("fMargin", typeof(System.Double))]
	public class SetMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetMargin(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Gets the content layout of the cell.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	public class GetContentLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContentLayout(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Sets the content layout of the cell.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("row", typeof(System.Int32))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("nLayout", typeof(System.Object))]
	public class SetContentLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetContentLayout(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Gets the override in cell, row, column, or content.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetOverride : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetOverride(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the override in cell, row, column, or content.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("nProp", typeof(System.Object))]
	public class SetOverride : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetOverride(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Gets the grid line style of cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nGridLineType", typeof(System.Object))]
	public class GetGridLineStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridLineStyle(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the grid line style of cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nGridLineTypes", typeof(System.Object))]
	[NodeInput("nLineStyle", typeof(System.Object))]
	public class SetGridLineStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridLineStyle(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Inserts one or more rows at the specified index and inherits the row properties from specified row.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]
	[NodeInput("nInheritFrom", typeof(System.Int32))]
	[NodeInput("nNumRows", typeof(System.Int32))]
	public class InsertRowsAndInherit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertRowsAndInherit(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Inserts one or more columns at the specified index and inherits the column properties from specified column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("col", typeof(System.Int32))]
	[NodeInput("nInheritFrom", typeof(System.Int32))]
	[NodeInput("nNumCols", typeof(System.Int32))]
	public class InsertColumnsAndInherit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertColumnsAndInherit(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns true if the content at the specified index is a formula.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetHasFormula : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetHasFormula(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Gets the formula if the content at the specified content index has a formula.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	public class GetFormula : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFormula(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Sets the formula at the specified content index.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nContent", typeof(System.Int32))]
	[NodeInput("pszFormula", typeof(System.String))]
	public class SetFormula : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFormula(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Checks if the content of the specified cell can be modified.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	public class IsContentEditable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsContentEditable(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Checks if the format of the specified cell can be modified.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	public class IsFormatEditable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsFormatEditable(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Gets the cell state.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	public class GetCellState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellState(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Sets the cell state.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("nLock", typeof(System.Object))]
	public class SetCellState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellState(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Enables or disables the merge all flag in row or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("bEnable", typeof(System.Object))]
	public class EnableMergeAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableMergeAll(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns whether merge all flag is enabled or not in row or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	public class IsMergeAllEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsMergeAllEnabled(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Determines whether table breaking is in use. When enabled, the table will break automatically at the current specified height.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class BreaksEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BreaksEnabled);

		}
	}


	///<summary>
	///Determines whether table breaking is in use. When enabled, the table will break automatically at the current specified height.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bEnabled", typeof(System.Object))]
	public class Set_BreaksEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BreaksEnabled = inputs[1];
			return null;
		}
	}


	///<summary>
	///Determines whether the first set of label rows will be repeated at the top of each broken table part.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class RepeatTopLabels : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RepeatTopLabels);

		}
	}


	///<summary>
	///Determines whether the first set of label rows will be repeated at the top of each broken table part.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bEnabled", typeof(System.Object))]
	public class Set_RepeatTopLabels : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RepeatTopLabels = inputs[1];
			return null;
		}
	}


	///<summary>
	///Determines whether the bottom set of label rows is repeated at the bottom of each broken table part.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class RepeatBottomLabels : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RepeatBottomLabels);

		}
	}


	///<summary>
	///Determines whether the bottom set of label rows is repeated at the bottom of each broken table part.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bEnabled", typeof(System.Object))]
	public class Set_RepeatBottomLabels : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RepeatBottomLabels = inputs[1];
			return null;
		}
	}


	///<summary>
	///Determines the direction that parts of the table flow.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class TableBreakFlowDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TableBreakFlowDirection);

		}
	}


	///<summary>
	///Determines the direction that parts of the table flow.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pDir", typeof(System.Object))]
	public class Set_TableBreakFlowDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TableBreakFlowDirection = inputs[1];
			return null;
		}
	}


	///<summary>
	///When enabled, each table part can be moved outside of the boundary. When not enabled, the table parts are contained within a rectangular boundary.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class AllowManualPositions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AllowManualPositions);

		}
	}


	///<summary>
	///When enabled, each table part can be moved outside of the boundary. When not enabled, the table parts are contained within a rectangular boundary.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bEnabled", typeof(System.Object))]
	public class Set_AllowManualPositions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AllowManualPositions = inputs[1];
			return null;
		}
	}


	///<summary>
	///Allows the heights of broken table parts to have their own breaking height. When set to No, all table parts will break at the height of the initial table part.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class AllowManualHeights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AllowManualHeights);

		}
	}


	///<summary>
	///Allows the heights of broken table parts to have their own breaking height. When set to No, all table parts will break at the height of the initial table part.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("bEnabled", typeof(System.Object))]
	public class Set_AllowManualHeights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AllowManualHeights = inputs[1];
			return null;
		}
	}


	///<summary>
	///Sets the breaking height for the initial table part and any other table parts that do not have manual heights set.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class TableBreakHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TableBreakHeight);

		}
	}


	///<summary>
	///Sets the breaking height for the initial table part and any other table parts that do not have manual heights set.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pHeight", typeof(System.Double))]
	public class Set_TableBreakHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TableBreakHeight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Controls the spacing between the broken table parts. Depending on the break direction this will be a horizontal or vertical spacing.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	public class BreakSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BreakSpacing);

		}
	}


	///<summary>
	///Controls the spacing between the broken table parts. Depending on the break direction this will be a horizontal or vertical spacing.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("pSpacing", typeof(System.Double))]
	public class Set_BreakSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BreakSpacing = inputs[1];
			return null;
		}
	}


	///<summary>
	///Gets the columns name.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]
	public class GetColumnName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetColumnName(inputs[1]));

		}
	}


	///<summary>
	///Sets the columns name.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nIndex", typeof(System.Int32))]
	[NodeInput("Name", typeof(System.String))]
	public class SetColumnName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetColumnName(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Sets the tooltip string for cell, row, or column.
	///</summary>
	[NodeInput("AcadTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Int32))]
	[NodeInput("nCol", typeof(System.Int32))]
	[NodeInput("tip", typeof(System.String))]
	public class SetToolTip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetToolTip(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}
}
