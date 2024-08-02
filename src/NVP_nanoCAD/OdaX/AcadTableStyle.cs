using NVP.API.Nodes;

namespace OdaX.AcadTableStyle 
{
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


		///<summary>
		///Not implemented. Specifies or returns the name of a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Not implemented. Specifies or returns the name of a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrValue", typeof(System.String))]
		public class Set_Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Name = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the description of a tables tyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		public class Description : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Description);

			}
		}


		///<summary>
		///Specifies or returns the description of a tables tyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstr", typeof(System.String))]
		public class Set_Description : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Description = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the operation bit set of a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		public class BitFlags : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BitFlags);

			}
		}


		///<summary>
		///Specifies or returns the operation bit set of a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bitFlag", typeof(System.Object))]
		public class Set_BitFlags : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.BitFlags = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the flow direction of a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		public class FlowDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FlowDirection);

			}
		}


		///<summary>
		///Specifies or returns the flow direction of a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Specifies or returns the horizontal cell margin of a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		public class HorzCellMargin : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HorzCellMargin);

			}
		}


		///<summary>
		///Specifies or returns the horizontal cell margin of a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("dHorzCellMargin", typeof(System.Double))]
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
		///Specifies or returns the vertical cell margin of a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		public class VertCellMargin : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.VertCellMargin);

			}
		}


		///<summary>
		///Specifies or returns the vertical cell margin of a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("dVertCellMargin", typeof(System.Double))]
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
		///Specifies or returns whether the table title is visible for a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		public class TitleSuppressed : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TitleSuppressed);

			}
		}


		///<summary>
		///Specifies or returns whether the table title is visible for a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Specifies or returns whether the header titles are visible for a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		public class HeaderSuppressed : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HeaderSuppressed);

			}
		}


		///<summary>
		///Specifies or returns whether the header titles are visible for a table style.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Returns the text style name of a row type.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Specifies the text style name of row types.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Returns the text height of a row type.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Specifies the text height of row types.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Returns the cell alignment of a row type.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Specifies the cell alignment of row types.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Returns the color value of a row type.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("rowType", typeof(System.Object))]
		public class GetColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetColor(inputs[1]));

			}
		}


		///<summary>
		///Specifies the color value of row types.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("rowTypes", typeof(System.Int32))]
		[NodeInput("pColor", typeof(System.Object))]
		public class SetColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetColor(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Returns the background color value of a row type.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Specifies the background color value of row types.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Returns whether the background color is set to None for a row type.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Specifies whether the background color is set to None for row types.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Returns the grid lineweight value for a grid linetype and row type.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Specifies the grid lineweight value for grid linetypes and row types.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Specifies the grid color value for grid linetypes and row types.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Returns whether the grid is visible for a grid linetype and row type.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Specifies whether the grid is visible for grid linetypes and row types.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Not implemented. Returns the data type and unit type of a row type.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
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
		///Not implemented. Specifies the data type and unit type of a row type.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("rowTypes", typeof(System.Int32))]
		[NodeInput("nDataType", typeof(System.Object))]
		[NodeInput("nUnitType", typeof(System.Object))]
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
		[NodeInput("AcadTableStyle", typeof(object))]
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
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("rowTypes", typeof(System.Int32))]
		[NodeInput("val", typeof(System.String))]
		public class SetFormat : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetFormat(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		public class CreateCellStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.CreateCellStyle(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("bstrSourceCellStyle", typeof(System.String))]
		public class CreateCellStyleFromStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.CreateCellStyleFromStyle(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrOldName", typeof(System.String))]
		[NodeInput("bstrNewName", typeof(System.String))]
		public class RenameCellStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RenameCellStyle(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		public class DeleteCellStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DeleteCellStyle(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("pszBaseName", typeof(System.String))]
		public class GetUniqueCellStyleName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetUniqueCellStyleName(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("pszCellStyle", typeof(System.String))]
		public class GetIsCellStyleInUse : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetIsCellStyleInUse(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		public class NumCellStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NumCellStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("cellStylesArray", typeof(System.Object))]
		public class GetCellStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetCellStyles(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Returns the text style name for the specified cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		public class GetTextStyleId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetTextStyleId(inputs[1]));

			}
		}


		///<summary>
		///Sets the text style name for the specified cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("val", typeof(System.Object))]
		public class SetTextStyleId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetTextStyleId(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Returns the text height for the specified cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		public class GetTextHeight2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetTextHeight2(inputs[1]));

			}
		}


		///<summary>
		///Sets the text height for the specified cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("Height", typeof(System.Double))]
		public class SetTextHeight2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetTextHeight2(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Returns the cell alignment for the specified cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		public class GetAlignment2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetAlignment2(inputs[1]));

			}
		}


		///<summary>
		///Sets the cell alignment for the specified cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("cellAlignment", typeof(System.Object))]
		public class SetAlignment2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetAlignment2(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Returns the true color value for the specified cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		public class GetColor2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetColor2(inputs[1]));

			}
		}


		///<summary>
		///Sets the true color value for the specified cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("color", typeof(System.Object))]
		public class SetColor2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetColor2(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Returns the background true color value for the specified cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		public class GetBackgroundColor2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetBackgroundColor2(inputs[1]));

			}
		}


		///<summary>
		///Sets the background true color value for the specified cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("color", typeof(System.Object))]
		public class SetBackgroundColor2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetBackgroundColor2(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Returns the data type and unit type for the specifed cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("pDataType", typeof(System.Object))]
		[NodeInput("pUnitType", typeof(System.Object))]
		public class GetDataType2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetDataType2(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///Sets the data type and unit type for the specifed cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("nDataType", typeof(System.Object))]
		[NodeInput("nUnitType", typeof(System.Object))]
		public class SetDataType2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetDataType2(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///Returns the format for the specifed cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("pbstrFormat", typeof(System.String))]
		public class GetFormat2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetFormat2(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Sets the format for the specifed cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("bstrFormat", typeof(System.String))]
		public class SetFormat2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetFormat2(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		public class GetCellClass : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetCellClass(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("cellClass", typeof(System.Int32))]
		public class SetCellClass : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetCellClass(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		public class GetRotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetRotation(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("Rotation", typeof(System.Double))]
		public class SetRotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetRotation(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		public class GetIsMergeAllEnabled : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetIsMergeAllEnabled(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("bEnable", typeof(System.Object))]
		public class EnableMergeAll : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EnableMergeAll(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///s) and cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("gridLineType", typeof(System.Object))]
		public class GetGridLineWeight2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetGridLineWeight2(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///s) and cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("gridLineTypes", typeof(System.Object))]
		[NodeInput("Lineweight", typeof(System.Object))]
		public class SetGridLineWeight2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetGridLineWeight2(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///Returns the gridColor value for the specified gridLineType and cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("gridLineType", typeof(System.Object))]
		public class GetGridColor2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetGridColor2(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///Sets the gridColor value for the specified gridLineType and cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("gridLineTypes", typeof(System.Object))]
		[NodeInput("pColor", typeof(System.Object))]
		public class SetGridColor2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetGridColor2(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///Returns the gridVisibility value for the specified gridLineType and cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("gridLineType", typeof(System.Object))]
		public class GetGridVisibility2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetGridVisibility2(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///Sets the gridVisibility value for the specified gridLineType and cellStyle.
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("bstrCellStyle", typeof(System.String))]
		[NodeInput("gridLineTypes", typeof(System.Object))]
		[NodeInput("bValue", typeof(System.Object))]
		public class SetGridVisibility2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetGridVisibility2(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		public class TemplateId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TemplateId);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_TemplateId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TemplateId = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadTableStyle", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class SetTemplateId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetTemplateId(inputs[1]);
				return null;
			}
		}
}
