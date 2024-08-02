using NVP.API.Nodes;

namespace OdaX.AcadTolerance 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadTolerance_Constructor : INode 
	{
		public OdaX.IAcadTolerance _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadTolerance;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadTolerance_ConstructorCast : INode 
	{
		public OdaX.IAcadTolerance _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadTolerance;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies the direction for the ray, tolerance, or xline through a vector
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	public class DirectionVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DirectionVector);

		}
	}


	///<summary>
	///Specifies the direction for the ray, tolerance, or xline through a vector
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("dirVector", typeof(System.Object))]
	public class Set_DirectionVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DirectionVector = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specify the X, Y, Z coordinate for insertion point of the tolerance
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	public class InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsertionPoint);

		}
	}


	///<summary>
	///Specify the X, Y, Z coordinate for insertion point of the tolerance
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
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
	///Specifies the three-dimensional normal unit vector for the entity
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	///<summary>
	///Specifies the three-dimensional normal unit vector for the entity
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the style name of the tolerance
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	public class StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleName);

		}
	}


	///<summary>
	///Specifies the style name of the tolerance
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
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
	///Specifies the color of the dimension text
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	public class TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextColor);

		}
	}


	///<summary>
	///Specifies the color of the dimension text
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("color", typeof(System.Object))]
	public class Set_TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextColor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the text string of the tolerance
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	public class TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextString);

		}
	}


	///<summary>
	///Specifies the text string of the tolerance
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]
	public class Set_TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextString = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the text style of the tolerance
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	public class TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyle);

		}
	}


	///<summary>
	///Specifies the text style of the tolerance
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("style", typeof(System.String))]
	public class Set_TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the text height of the tolerance
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	///<summary>
	///Specifies the text height of the tolerance
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the overall scale factor applied to properties that specify sizes, distances, or offsets
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	///<summary>
	///Specifies the overall scale factor applied to properties that specify sizes, distances, or offsets
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("factor", typeof(System.Object))]
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the color of the dimension lines
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	public class DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineColor);

		}
	}


	///<summary>
	///Specifies the color of the dimension lines
	///</summary>
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineColor = inputs[1];
			return null;
		}
	}
}
