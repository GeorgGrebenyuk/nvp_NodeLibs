using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an object containing text that links to a block
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadAttributeReference 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadAttributeReference_Constructor : INode 
	{
		public OdaX.IAcadAttributeReference _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadAttributeReference;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadAttributeReference_ConstructorCast : INode 
	{
		public OdaX.IAcadAttributeReference _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadAttributeReference;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the height of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the height of an attribute reference.
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
		Text = "Specifies or returns the height of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of an attribute reference.
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
		Text = "Specifies or returns the horizontal alignment of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the horizontal alignment of an attribute reference.
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
		Text = "Specifies or returns the horizontal alignment of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("OdaX.AcHorizontalAlignment", typeof(System.Object))]

	///<summary>
	///Specifies or returns the horizontal alignment of an attribute reference.
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
		Text = "Specifies or returns the insertion point of attribute reference text.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the insertion point of attribute reference text.
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
		Text = "Specifies or returns the insertion point of attribute reference text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the insertion point of attribute reference text.
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
	[NodeInput("AcadAttributeReference", typeof(object))]

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
	[NodeInput("AcadAttributeReference", typeof(object))]
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
		Text = "Specifies or returns the oblique angle of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the oblique angle of an attribute reference.
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
		Text = "Specifies or returns the oblique angle of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("obliAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the oblique angle of an attribute reference.
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
		Text = "Specifies or returns the rotation angle of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of an attribute reference.
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
		Text = "Specifies or returns the rotation angle of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of an attribute reference.
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
		Text = "Specifies or returns the scale factor of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of an attribute reference.
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
		Text = "Specifies or returns the scale factor of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("scalFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor of an attribute reference.
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
		Text = "Specifies or returns the style name of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the style name of an attribute reference.
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
		Text = "Specifies or returns the style name of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the style name of an attribute reference.
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
		Text = "Specifies or returns the tag of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the tag of an attribute reference.
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
		Text = "Specifies or returns the tag of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("bstrTag", typeof(System.String))]

	///<summary>
	///Specifies or returns the tag of an attribute reference.
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
		Text = "Specifies or returns the x, y, z alignment point of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z alignment point of an attribute reference.
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
		Text = "Specifies or returns the x, y, z alignment point of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("alignPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z alignment point of an attribute reference.
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
		Text = "Specifies or returns the text generation flag of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the text generation flag of an attribute reference.
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
		Text = "Specifies or returns the text generation flag of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("textGenFlag", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text generation flag of an attribute reference.
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
		Text = "Specifies or returns the text of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the text of an attribute reference.
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
		Text = "Specifies or returns the text of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies or returns the text of an attribute reference.
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
		Text = "z-direction value) of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///z-direction value) of an attribute reference.
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
		Text = "z-direction value) of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of an attribute reference.
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
		Text = "Specifies or returns the vertical alignment of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the vertical alignment of an attribute reference.
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
		Text = "Specifies or returns the vertical alignment of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("OdaX.AcVerticalAlignment", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertical alignment of an attribute reference.
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
		Text = "Specifies or returns the field length of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the field length of an attribute reference.
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
		Text = "Specifies or returns the field length of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("fieldLen", typeof(System.Object))]

	///<summary>
	///Specifies or returns the field length of an attribute reference.
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
		Text = "Specifies or returns the horizontal and vertical alignment of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the horizontal and vertical alignment of an attribute reference.
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
		Text = "Specifies or returns the horizontal and vertical alignment of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("OdaX.AcAlignment", typeof(System.Object))]

	///<summary>
	///Specifies or returns the horizontal and vertical alignment of an attribute reference.
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
		Text = "Specifies or returns whether the text of an attribute reference is upside down.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns whether the text of an attribute reference is upside down.
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
		Text = "Specifies or returns whether the text of an attribute reference is upside down.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("bUpsideDown", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the text of an attribute reference is upside down.
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
		Text = "Specifies or returns whether the text of an attribute reference is backward.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns whether the text of an attribute reference is backward.
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
		Text = "Specifies or returns whether the text of an attribute reference is backward.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("bBackward", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the text of an attribute reference is backward.
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
		Text = "Specifies or returns the invisible mode of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the invisible mode of an attribute reference.
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
		Text = "Specifies or returns the invisible mode of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("bInvisible", typeof(System.Object))]

	///<summary>
	///Specifies or returns the invisible mode of an attribute reference.
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
		Text = "Returns the constant mode of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Returns the constant mode of an attribute reference.
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
		Text = "Specifies whether the attribute may be moved relative to the geometry in the block", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies whether the attribute may be moved relative to the geometry in the block
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
		Text = "Determines whether if the attribute reference is multiline", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Determines whether if the attribute reference is multiline
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
		Text = "Determines whether if the attribute reference is multiline", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("bMTextAttribute", typeof(System.Object))]

	///<summary>
	///Determines whether if the attribute reference is multiline
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
		Text = "Gets the multiline attribute reference content", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Gets the multiline attribute reference content
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
		Text = "Gets the multiline attribute reference content", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("content", typeof(System.String))]

	///<summary>
	///Gets the multiline attribute reference content
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
		Text = "Updates attribute reference from the multiline mtext and vice versa", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Updates attribute reference from the multiline mtext and vice versa
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
	[NodeInput("AcadAttributeReference", typeof(object))]

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
	[NodeInput("AcadAttributeReference", typeof(object))]

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
	[NodeInput("AcadAttributeReference", typeof(object))]

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
	[NodeInput("AcadAttributeReference", typeof(object))]
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
