using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface to define a style for multiple parallel lines
///</summary>
namespace OdaX.OdaMLineStyle 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///Specifies the name of the object
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
		Text = "Specifies the name of the object", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies the name of the object
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
		Text = "Specifies the style description", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///Specifies the style description
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
		Text = "Specifies the style description", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("bstrDes", typeof(System.String))]

	///<summary>
	///Specifies the style description
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
		Text = "property StartAngle", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///property StartAngle
	///</summary>
	public class StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartAngle);

		}
	}


	[NVP_Manifest(
		Text = "property StartAngle", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property StartAngle
	///</summary>
	public class Set_StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property EndAngle", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///property EndAngle
	///</summary>
	public class EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndAngle);

		}
	}


	[NVP_Manifest(
		Text = "property EndAngle", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property EndAngle
	///</summary>
	public class Set_EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property FillColor", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///property FillColor
	///</summary>
	public class FillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FillColor);

		}
	}


	[NVP_Manifest(
		Text = "property FillColor", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property FillColor
	///</summary>
	public class Set_FillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FillColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "returns the number of elements in style", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///returns the number of elements in style
	///</summary>
	public class ElementsCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElementsCount);

		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x01)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x01)
	///</summary>
	public class Filled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Filled);

		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x01)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x01)
	///</summary>
	public class Set_Filled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Filled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x02)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x02)
	///</summary>
	public class ShowMiters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowMiters);

		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x02)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x02)
	///</summary>
	public class Set_ShowMiters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowMiters = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x10)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x10)
	///</summary>
	public class StartSquareCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartSquareCap);

		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x10)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x10)
	///</summary>
	public class Set_StartSquareCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartSquareCap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x40)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x40)
	///</summary>
	public class StartRoundCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartRoundCap);

		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x40)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x40)
	///</summary>
	public class Set_StartRoundCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartRoundCap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x20)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x20)
	///</summary>
	public class StartInnerArcs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartInnerArcs);

		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x20)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x20)
	///</summary>
	public class Set_StartInnerArcs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartInnerArcs = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x80)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x80)
	///</summary>
	public class EndSquareCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndSquareCap);

		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x80)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x80)
	///</summary>
	public class Set_EndSquareCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndSquareCap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x200)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x200)
	///</summary>
	public class EndRoundCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndRoundCap);

		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x200)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x200)
	///</summary>
	public class Set_EndRoundCap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndRoundCap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x100)", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]

	///<summary>
	///DXF 70, bit 0x100)
	///</summary>
	public class EndInnerArcs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndInnerArcs);

		}
	}


	[NVP_Manifest(
		Text = "DXF 70, bit 0x100)", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///DXF 70, bit 0x100)
	///</summary>
	public class Set_EndInnerArcs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndInnerArcs = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Adds an element to this MLine Style", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Offset", typeof(System.Double))]
	[NodeInput("color", typeof(System.Object))]
	[NodeInput("pLinetype", typeof(System.Object))]

	///<summary>
	///Adds an element to this MLine Style
	///</summary>
	public class AddElement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddElement(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the offset values for an existing element in this MLine Style", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the offset values for an existing element in this MLine Style
	///</summary>
	public class OffsetAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the offset values for an existing element in this MLine Style", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("Value", typeof(System.Double))]

	///<summary>
	///Returns the offset values for an existing element in this MLine Style
	///</summary>
	public class Set_OffsetAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetAt[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the Color object for an existing element in this MLine Style", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the Color object for an existing element in this MLine Style
	///</summary>
	public class ColorAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the Color object for an existing element in this MLine Style", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Returns the Color object for an existing element in this MLine Style
	///</summary>
	public class Set_ColorAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorAt[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the Line Type object for an existing element in this MLine Style", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the Line Type object for an existing element in this MLine Style
	///</summary>
	public class LineTypeAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the Line Type object for an existing element in this MLine Style", 
		ViewType = "Modifier")]
	[NodeInput("OdaMLineStyle", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("Linetype", typeof(System.Object))]

	///<summary>
	///Returns the Line Type object for an existing element in this MLine Style
	///</summary>
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
