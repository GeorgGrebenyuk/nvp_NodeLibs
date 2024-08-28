using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for adding, modifing and deleting table styles
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadTableStyle 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadTableStyle_Constructor : INode 
	{
		public OdaX.IAcadTableStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadTableStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadTableStyle_ConstructorCast : INode 
	{
		public OdaX.IAcadTableStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadTableStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the name of a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the name of a table style.
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the name of a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrValue", typeof(System.String))]

	///<summary>
	///Not implemented. Specifies or returns the name of a table style.
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the description of a tables tyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns the description of a tables tyle.
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the description of a tables tyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstr", typeof(System.String))]

	///<summary>
	///Specifies or returns the description of a tables tyle.
	///</summary>
	public class Set_Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Description = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the operation bit set of a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns the operation bit set of a table style.
	///</summary>
	public class BitFlags : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BitFlags);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the operation bit set of a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bitFlag", typeof(System.Object))]

	///<summary>
	///Specifies or returns the operation bit set of a table style.
	///</summary>
	public class Set_BitFlags : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BitFlags = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the flow direction of a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns the flow direction of a table style.
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
		Text = "Specifies or returns the flow direction of a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcTableDirection", typeof(System.Object))]

	///<summary>
	///Specifies or returns the flow direction of a table style.
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
		Text = "Specifies or returns the horizontal cell margin of a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns the horizontal cell margin of a table style.
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
		Text = "Specifies or returns the horizontal cell margin of a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("dHorzCellMargin", typeof(System.Double))]

	///<summary>
	///Specifies or returns the horizontal cell margin of a table style.
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
		Text = "Specifies or returns the vertical cell margin of a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns the vertical cell margin of a table style.
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
		Text = "Specifies or returns the vertical cell margin of a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("dVertCellMargin", typeof(System.Double))]

	///<summary>
	///Specifies or returns the vertical cell margin of a table style.
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
		Text = "Specifies or returns whether the table title is visible for a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether the table title is visible for a table style.
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
		Text = "Specifies or returns whether the table title is visible for a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the table title is visible for a table style.
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
		Text = "Specifies or returns whether the header titles are visible for a table style.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether the header titles are visible for a table style.
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
		Text = "Specifies or returns whether the header titles are visible for a table style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the header titles are visible for a table style.
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
		Text = "Returns the text style name of a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the text style name of a row type.
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
		Text = "Specifies the text style name of row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the text style name of row types.
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
		Text = "Returns the text height of a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the text height of a row type.
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
		Text = "Specifies the text height of row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("TextHeight", typeof(System.Double))]

	///<summary>
	///Specifies the text height of row types.
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
		Text = "Returns the cell alignment of a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the cell alignment of a row type.
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
		Text = "Specifies the cell alignment of row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("OdaX.AcCellAlignment", typeof(System.Object))]

	///<summary>
	///Specifies the cell alignment of row types.
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
		Text = "Returns the color value of a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the color value of a row type.
	///</summary>
	public class GetColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetColor(((OdaX.AcRowType)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Text = "Specifies the color value of row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies the color value of row types.
	///</summary>
	public class SetColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetColor(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the background color value of a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns the background color value of a row type.
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
		Text = "Specifies the background color value of row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies the background color value of row types.
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
		Text = "Returns whether the background color is set to None for a row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns whether the background color is set to None for a row type.
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
		Text = "Specifies whether the background color is set to None for row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies whether the background color is set to None for row types.
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
		Text = "Returns the grid lineweight value for a grid linetype and row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
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
		Text = "Specifies the grid lineweight value for grid linetypes and row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("gridLineTypes", typeof(System.Int32))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies the grid lineweight value for grid linetypes and row types.
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
	[NodeInput("AcadTableStyle", typeof(object))]
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
		Text = "Specifies the grid color value for grid linetypes and row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("gridLineTypes", typeof(System.Int32))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies the grid color value for grid linetypes and row types.
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
		Text = "Returns whether the grid is visible for a grid linetype and row type.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]

	///<summary>
	///Returns whether the grid is visible for a grid linetype and row type.
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
		Text = "Specifies whether the grid is visible for grid linetypes and row types.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("gridLineTypes", typeof(System.Int32))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Specifies whether the grid is visible for grid linetypes and row types.
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
		Text = "Not implemented. Returns the data type and unit type of a row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("OdaX.AcRowType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Not implemented. Returns the data type and unit type of a row type.
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
		Text = "Not implemented. Specifies the data type and unit type of a row type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies the data type and unit type of a row type.
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
	[NodeInput("AcadTableStyle", typeof(object))]
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
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("rowTypes", typeof(System.Int32))]
	[NodeInput("val", typeof(System.String))]

	///<summary>
	///Not implemented. Specifies the format of a row type.
	///</summary>
	public class SetFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFormat(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class CreateCellStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateCellStyle(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("bstrSourceCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class CreateCellStyleFromStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateCellStyleFromStyle(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrOldName", typeof(System.String))]
	[NodeInput("bstrNewName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class RenameCellStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RenameCellStyle(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class DeleteCellStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteCellStyle(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("pszBaseName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetUniqueCellStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUniqueCellStyleName(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("pszCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetIsCellStyleInUse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIsCellStyleInUse(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class NumCellStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumCellStyles);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("cellStylesArray", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetCellStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCellStyles(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the text style name for the specified cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///Returns the text style name for the specified cellStyle.
	///</summary>
	public class GetTextStyleId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextStyleId(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Sets the text style name for the specified cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Sets the text style name for the specified cellStyle.
	///</summary>
	public class SetTextStyleId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextStyleId(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the text height for the specified cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///Returns the text height for the specified cellStyle.
	///</summary>
	public class GetTextHeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextHeight2(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Sets the text height for the specified cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Sets the text height for the specified cellStyle.
	///</summary>
	public class SetTextHeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTextHeight2(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the cell alignment for the specified cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///Returns the cell alignment for the specified cellStyle.
	///</summary>
	public class GetAlignment2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAlignment2(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Sets the cell alignment for the specified cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcCellAlignment", typeof(System.Object))]

	///<summary>
	///Sets the cell alignment for the specified cellStyle.
	///</summary>
	public class SetAlignment2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAlignment2(inputs[1].Value,((OdaX.AcCellAlignment)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the true color value for the specified cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///Returns the true color value for the specified cellStyle.
	///</summary>
	public class GetColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetColor2(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Sets the true color value for the specified cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Sets the true color value for the specified cellStyle.
	///</summary>
	public class SetColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetColor2(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the background true color value for the specified cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///Returns the background true color value for the specified cellStyle.
	///</summary>
	public class GetBackgroundColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBackgroundColor2(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Sets the background true color value for the specified cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Sets the background true color value for the specified cellStyle.
	///</summary>
	public class SetBackgroundColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBackgroundColor2(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the data type and unit type for the specifed cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Returns the data type and unit type for the specifed cellStyle.
	///</summary>
	public class GetDataType2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetDataType2(inputs[1].Value,((OdaX.AcValueDataType)inputs[2].Value),((OdaX.AcValueUnitType)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Sets the data type and unit type for the specifed cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcValueDataType", typeof(System.Object))]
	[NodeInput("OdaX.AcValueUnitType", typeof(System.Object))]

	///<summary>
	///Sets the data type and unit type for the specifed cellStyle.
	///</summary>
	public class SetDataType2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDataType2(inputs[1].Value,((OdaX.AcValueDataType)inputs[2].Value),((OdaX.AcValueUnitType)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the format for the specifed cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("pbstrFormat", typeof(System.String))]

	///<summary>
	///Returns the format for the specifed cellStyle.
	///</summary>
	public class GetFormat2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetFormat2(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Sets the format for the specifed cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("bstrFormat", typeof(System.String))]

	///<summary>
	///Sets the format for the specifed cellStyle.
	///</summary>
	public class SetFormat2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFormat2(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetCellClass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellClass(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("cellClass", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class SetCellClass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCellClass(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRotation(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("Rotation", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class SetRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetRotation(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetIsMergeAllEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIsMergeAllEnabled(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("bEnable", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class EnableMergeAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableMergeAll(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "s) and cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]

	///<summary>
	///s) and cellStyle.
	///</summary>
	public class GetGridLineWeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridLineWeight2(inputs[1].Value,((OdaX.AcGridLineType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Text = "s) and cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///s) and cellStyle.
	///</summary>
	public class SetGridLineWeight2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridLineWeight2(inputs[1].Value,((OdaX.AcGridLineType)inputs[2].Value),inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the gridColor value for the specified gridLineType and cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]

	///<summary>
	///Returns the gridColor value for the specified gridLineType and cellStyle.
	///</summary>
	public class GetGridColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridColor2(inputs[1].Value,((OdaX.AcGridLineType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Text = "Sets the gridColor value for the specified gridLineType and cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Sets the gridColor value for the specified gridLineType and cellStyle.
	///</summary>
	public class SetGridColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridColor2(inputs[1].Value,((OdaX.AcGridLineType)inputs[2].Value),inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the gridVisibility value for the specified gridLineType and cellStyle.", 
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]

	///<summary>
	///Returns the gridVisibility value for the specified gridLineType and cellStyle.
	///</summary>
	public class GetGridVisibility2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGridVisibility2(inputs[1].Value,((OdaX.AcGridLineType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Text = "Sets the gridVisibility value for the specified gridLineType and cellStyle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("bstrCellStyle", typeof(System.String))]
	[NodeInput("OdaX.AcGridLineType", typeof(System.Object))]
	[NodeInput("bValue", typeof(System.Object))]

	///<summary>
	///Sets the gridVisibility value for the specified gridLineType and cellStyle.
	///</summary>
	public class SetGridVisibility2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridVisibility2(inputs[1].Value,((OdaX.AcGridLineType)inputs[2].Value),inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("AcadTableStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class TemplateId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TemplateId);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_TemplateId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TemplateId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("AcadTableStyle", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetTemplateId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetTemplateId(inputs[1].Value);
			return null;
		}
	}
}
