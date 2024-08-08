using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an object appearing as a text string that describes the characteristics of an attribute reference
///</summary>
namespace OdaX.AcadAttribute 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadAttribute_Constructor : INode 
	{
		public OdaX.IAcadAttribute _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadAttribute;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadAttribute_ConstructorCast : INode 
	{
		public OdaX.IAcadAttribute _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadAttribute;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the field length of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the field length of an attribute.
	///</summary>
	public class FieldLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FieldLength);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the field length of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("fieldLen", typeof(System.Object))]

	///<summary>
	///Specifies or returns the field length of an attribute.
	///</summary>
	public class Set_FieldLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FieldLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the tag of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the tag of an attribute.
	///</summary>
	public class TagString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TagString);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the tag of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("Tag", typeof(System.String))]

	///<summary>
	///Specifies or returns the tag of an attribute.
	///</summary>
	public class Set_TagString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TagString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the prompt string of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the prompt string of an attribute.
	///</summary>
	public class PromptString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PromptString);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the prompt string of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bstrPrompt", typeof(System.String))]

	///<summary>
	///Specifies or returns the prompt string of an attribute.
	///</summary>
	public class Set_PromptString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PromptString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text that displays for an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the text that displays for an attribute.
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
		Text = "Specifies or returns the text that displays for an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies or returns the text that displays for an attribute.
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
		Text = "Specifies or returns the text style of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the text style of an attribute.
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
		Text = "Specifies or returns the text style of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the text style of an attribute.
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
		Text = "Specifies or returns the horizontal and vertical alignment of the attribute text.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the horizontal and vertical alignment of the attribute text.
	///</summary>
	public class Alignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Alignment);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the horizontal and vertical alignment of the attribute text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("OdaX.AcAlignment", typeof(System.Object))]

	///<summary>
	///Specifies or returns the horizontal and vertical alignment of the attribute text.
	///</summary>
	public class Set_Alignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Alignment = ((OdaX.AcAlignment)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the horizontal alignment of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the horizontal alignment of an attribute.
	///</summary>
	public class HorizontalAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorizontalAlignment);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the horizontal alignment of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("OdaX.AcHorizontalAlignment", typeof(System.Object))]

	///<summary>
	///Specifies or returns the horizontal alignment of an attribute.
	///</summary>
	public class Set_HorizontalAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorizontalAlignment = ((OdaX.AcHorizontalAlignment)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertical alignment of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the vertical alignment of an attribute.
	///</summary>
	public class VerticalAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalAlignment);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertical alignment of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("OdaX.AcVerticalAlignment", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertical alignment of an attribute.
	///</summary>
	public class Set_VerticalAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalAlignment = ((OdaX.AcVerticalAlignment)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the height of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the height of an attribute.
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
		Text = "Specifies or returns the height of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of an attribute.
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
		Text = "Specifies or returns the rotation angle of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of an attribute.
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
		Text = "Specifies or returns the rotation angle of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of an attribute.
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
		Text = "Specifies or returns the scale factor of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of an attribute.
	///</summary>
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("scalFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor of an attribute.
	///</summary>
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the oblique angle of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the oblique angle of an attribute.
	///</summary>
	public class ObliqueAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObliqueAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the oblique angle of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("obliAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the oblique angle of an attribute.
	///</summary>
	public class Set_ObliqueAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObliqueAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z alignment point of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z alignment point of an attribute.
	///</summary>
	public class TextAlignmentPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAlignmentPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z alignment point of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("alignPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z alignment point of an attribute.
	///</summary>
	public class Set_TextAlignmentPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAlignmentPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the attribute text insertion point.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

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
	[NodeInput("AcadAttribute", typeof(object))]
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
	[NodeInput("AcadAttribute", typeof(object))]

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
	[NodeInput("AcadAttribute", typeof(object))]
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
		Text = "Specifies or returns the text generation flag of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the text generation flag of an attribute.
	///</summary>
	public class TextGenerationFlag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextGenerationFlag);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text generation flag of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("textGenFlag", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text generation flag of an attribute.
	///</summary>
	public class Set_TextGenerationFlag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextGenerationFlag = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "z-direction value) of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///z-direction value) of an attribute.
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Text = "z-direction value) of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of an attribute.
	///</summary>
	public class Set_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the mode of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the mode of an attribute.
	///</summary>
	public class Mode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Mode);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the mode of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("Mode", typeof(System.Object))]

	///<summary>
	///Specifies or returns the mode of an attribute.
	///</summary>
	public class Set_Mode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Mode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the text of an attribute is upside down.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns whether the text of an attribute is upside down.
	///</summary>
	public class UpsideDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UpsideDown);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the text of an attribute is upside down.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bUpsideDown", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the text of an attribute is upside down.
	///</summary>
	public class Set_UpsideDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UpsideDown = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the attribute text is backward.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns whether the attribute text is backward.
	///</summary>
	public class Backward : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Backward);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the attribute text is backward.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bBackward", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the attribute text is backward.
	///</summary>
	public class Set_Backward : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Backward = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the invisible mode of the attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the invisible mode of the attribute.
	///</summary>
	public class Invisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Invisible);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the invisible mode of the attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bInvisible", typeof(System.Object))]

	///<summary>
	///Specifies or returns the invisible mode of the attribute.
	///</summary>
	public class Set_Invisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Invisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the constant mode of the attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the constant mode of the attribute.
	///</summary>
	public class Constant : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Constant);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the constant mode of the attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bConstant", typeof(System.Object))]

	///<summary>
	///Specifies or returns the constant mode of the attribute.
	///</summary>
	public class Set_Constant : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Constant = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the verify mode of the attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the verify mode of the attribute.
	///</summary>
	public class Verify : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Verify);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the verify mode of the attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bVerify", typeof(System.Object))]

	///<summary>
	///Specifies or returns the verify mode of the attribute.
	///</summary>
	public class Set_Verify : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Verify = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the preset mode of the attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the preset mode of the attribute.
	///</summary>
	public class Preset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Preset);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the preset mode of the attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bPreset", typeof(System.Object))]

	///<summary>
	///Specifies or returns the preset mode of the attribute.
	///</summary>
	public class Set_Preset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Preset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns whether an attribute is moved relative to its associated block.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns whether an attribute is moved relative to its associated block.
	///</summary>
	public class LockPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LockPosition);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns whether an attribute is moved relative to its associated block.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bLockPosition", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns whether an attribute is moved relative to its associated block.
	///</summary>
	public class Set_LockPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LockPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Determines whether if the attribute is multiline", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Determines whether if the attribute is multiline
	///</summary>
	public class MTextAttribute : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MTextAttribute);

		}
	}


	[NVP_Manifest(
		Text = "Determines whether if the attribute is multiline", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bMTextAttribute", typeof(System.Object))]

	///<summary>
	///Determines whether if the attribute is multiline
	///</summary>
	public class Set_MTextAttribute : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MTextAttribute = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the multiline attribute content", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Gets the multiline attribute content
	///</summary>
	public class MTextAttributeContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MTextAttributeContent);

		}
	}


	[NVP_Manifest(
		Text = "Gets the multiline attribute content", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("content", typeof(System.String))]

	///<summary>
	///Gets the multiline attribute content
	///</summary>
	public class Set_MTextAttributeContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MTextAttributeContent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Updates multiline MText", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Updates multiline MText
	///</summary>
	public class UpdateMTextAttribute : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UpdateMTextAttribute();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the width of text boundary of the Mtext", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Gets the width of text boundary of the Mtext
	///</summary>
	public class MTextBoundaryWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MTextBoundaryWidth);

		}
	}


	[NVP_Manifest(
		Text = "Gets the width of text boundary of the Mtext", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Gets the width of text boundary of the Mtext
	///</summary>
	public class Set_MTextBoundaryWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MTextBoundaryWidth[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the drawing direction of the Mtext", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Gets the drawing direction of the Mtext
	///</summary>
	public class MTextDrawingDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MTextDrawingDirection);

		}
	}


	[NVP_Manifest(
		Text = "Gets the drawing direction of the Mtext", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("OdaX.AcDrawingDirection", typeof(System.Object))]

	///<summary>
	///Gets the drawing direction of the Mtext
	///</summary>
	public class Set_MTextDrawingDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MTextDrawingDirection = ((OdaX.AcDrawingDirection)inputs[1].Value);
			return null;
		}
	}
}
