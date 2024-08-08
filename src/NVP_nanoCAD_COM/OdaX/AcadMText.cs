using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a paragraph of alphanumeric characters that fits within a nonprinting text boundary
///</summary>
namespace OdaX.AcadMText 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMText_Constructor : INode 
	{
		public OdaX.IAcadMText _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMText;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMText_ConstructorCast : INode 
	{
		public OdaX.IAcadMText _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMText;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the characters of multline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the characters of multline text.
	///</summary>
	public class TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextString);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the characters of multline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies or returns the characters of multline text.
	///</summary>
	public class Set_TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the style name of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the style name of multiline text.
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
		Text = "Specifies or returns the style name of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the style name of multiline text.
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
		Text = "Specifies or returns the position of multline text in relation to the insertion point.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the position of multline text in relation to the insertion point.
	///</summary>
	public class AttachmentPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AttachmentPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the position of multline text in relation to the insertion point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("OdaX.AcAttachmentPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the position of multline text in relation to the insertion point.
	///</summary>
	public class Set_AttachmentPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AttachmentPoint = ((OdaX.AcAttachmentPoint)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the direction in which the characters of multiline text display.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the direction in which the characters of multiline text display.
	///</summary>
	public class DrawingDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawingDirection);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the direction in which the characters of multiline text display.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("OdaX.AcDrawingDirection", typeof(System.Object))]

	///<summary>
	///Specifies or returns the direction in which the characters of multiline text display.
	///</summary>
	public class Set_DrawingDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawingDirection = ((OdaX.AcDrawingDirection)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the width of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the width of multiline text.
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
		Text = "Specifies or returns the width of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns the width of multiline text.
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
		Text = "Specifies or returns the height of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the height of multiline text.
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
		Text = "Specifies or returns the height of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of multiline text.
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
		Text = "Specifies or returns the rotation angle of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of multiline text.
	///</summary>
	public class Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation angle of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of multiline text.
	///</summary>
	public class Set_Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the attribute text insertion point.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the attribute text insertion point.
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
		Text = "Specifies or returns the x, y, and z coordinates of the attribute text insertion point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the attribute text insertion point.
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
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the line spacing factor of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the line spacing factor of multiline text.
	///</summary>
	public class LineSpacingFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineSpacingFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the line spacing factor of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("factor", typeof(System.Double))]

	///<summary>
	///Specifies or returns the line spacing factor of multiline text.
	///</summary>
	public class Set_LineSpacingFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineSpacingFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the line spacing style of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the line spacing style of multiline text.
	///</summary>
	public class LineSpacingStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineSpacingStyle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the line spacing style of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("OdaX.AcLineSpacingStyle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the line spacing style of multiline text.
	///</summary>
	public class Set_LineSpacingStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineSpacingStyle = ((OdaX.AcLineSpacingStyle)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the distance between lines of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the distance between lines of multiline text.
	///</summary>
	public class LineSpacingDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineSpacingDistance);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the distance between lines of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("Value", typeof(System.Double))]

	///<summary>
	///Specifies or returns the distance between lines of multiline text.
	///</summary>
	public class Set_LineSpacingDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineSpacingDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the multiline text is filled with a background.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns whether the multiline text is filled with a background.
	///</summary>
	public class BackgroundFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundFill);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the multiline text is filled with a background.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("bUseBackgroundFill", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the multiline text is filled with a background.
	///</summary>
	public class Set_BackgroundFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundFill = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the characters and field codes of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Returns the characters and field codes of multiline text.
	///</summary>
	public class FieldCode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FieldCode);

		}
	}
}
