using NVP.API.Nodes;

namespace OdaX.OdaMLineStyle 
{
	[NodeInput("dynamic", typeof(object))]
	public class OdaMLineStyle_Constructor : INode 
	{
		public OdaX.IOdaMLineStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaMLineStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class OdaMLineStyle_ConstructorCast : INode 
	{
		public OdaX.IOdaMLineStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaMLineStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies the name of the object
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///Specifies the name of the object
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pName", typeof(System.String))]
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
	///Specifies the style description
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	///<summary>
	///Specifies the style description
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("bstrDes", typeof(System.String))]
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
	///property StartAngle
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartAngle);

		}
	}


	///<summary>
	///property StartAngle
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartAngle = inputs[1];
			return null;
		}
	}


	///<summary>
	///property EndAngle
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndAngle);

		}
	}


	///<summary>
	///property EndAngle
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndAngle = inputs[1];
			return null;
		}
	}


	///<summary>
	///property FillColor
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class FillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FillColor);

		}
	}


	///<summary>
	///property FillColor
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_FillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FillColor = inputs[1];
			return null;
		}
	}


	///<summary>
	///returns the number of elements in style
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class ElementsCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElementsCount);

		}
	}


	///<summary>
	///DXF 70, bit 0x01)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class Filled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Filled);

		}
	}


	///<summary>
	///DXF 70, bit 0x01)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_Filled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Filled = inputs[1];
			return null;
		}
	}


	///<summary>
	///DXF 70, bit 0x02)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class ShowMiters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowMiters);

		}
	}


	///<summary>
	///DXF 70, bit 0x02)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_ShowMiters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowMiters = inputs[1];
			return null;
		}
	}


	///<summary>
	///DXF 70, bit 0x10)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class StartSquareCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartSquareCap);

		}
	}


	///<summary>
	///DXF 70, bit 0x10)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_StartSquareCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartSquareCap = inputs[1];
			return null;
		}
	}


	///<summary>
	///DXF 70, bit 0x40)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class StartRoundCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartRoundCap);

		}
	}


	///<summary>
	///DXF 70, bit 0x40)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_StartRoundCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartRoundCap = inputs[1];
			return null;
		}
	}


	///<summary>
	///DXF 70, bit 0x20)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class StartInnerArcs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartInnerArcs);

		}
	}


	///<summary>
	///DXF 70, bit 0x20)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_StartInnerArcs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartInnerArcs = inputs[1];
			return null;
		}
	}


	///<summary>
	///DXF 70, bit 0x80)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class EndSquareCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndSquareCap);

		}
	}


	///<summary>
	///DXF 70, bit 0x80)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_EndSquareCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndSquareCap = inputs[1];
			return null;
		}
	}


	///<summary>
	///DXF 70, bit 0x200)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class EndRoundCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndRoundCap);

		}
	}


	///<summary>
	///DXF 70, bit 0x200)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_EndRoundCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndRoundCap = inputs[1];
			return null;
		}
	}


	///<summary>
	///DXF 70, bit 0x100)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	public class EndInnerArcs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndInnerArcs);

		}
	}


	///<summary>
	///DXF 70, bit 0x100)
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_EndInnerArcs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndInnerArcs = inputs[1];
			return null;
		}
	}


	///<summary>
	///Adds an element to this MLine Style
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Offset", typeof(System.Double))]
	[NodeInput("color", typeof(System.Object))]
	[NodeInput("pLinetype", typeof(System.Object))]
	public class AddElement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddElement(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Returns the offset values for an existing element in this MLine Style
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	public class OffsetAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetAt(inputs[1]));

		}
	}


	///<summary>
	///Returns the offset values for an existing element in this MLine Style
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("Value", typeof(System.Double))]
	public class Set_OffsetAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetAt[inputs[1]] = inputs[2];
			return null;
		}
	}


	///<summary>
	///Returns the Color object for an existing element in this MLine Style
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	public class ColorAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorAt(inputs[1]));

		}
	}


	///<summary>
	///Returns the Color object for an existing element in this MLine Style
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("color", typeof(System.Object))]
	public class Set_ColorAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorAt[inputs[1]] = inputs[2];
			return null;
		}
	}


	///<summary>
	///Returns the Line Type object for an existing element in this MLine Style
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	public class LineTypeAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeAt(inputs[1]));

		}
	}


	///<summary>
	///Returns the Line Type object for an existing element in this MLine Style
	///</summary>
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("Linetype", typeof(System.Object))]
	public class Set_LineTypeAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeAt[inputs[1]] = inputs[2];
			return null;
		}
	}
}
