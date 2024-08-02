using NVP.API.Nodes;

namespace OdaX.AcadAttribute 
{
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


		///<summary>
		///Specifies or returns the field length of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class FieldLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FieldLength);

			}
		}


		///<summary>
		///Specifies or returns the field length of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("fieldLen", typeof(System.Object))]
		public class Set_FieldLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FieldLength = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the tag of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class TagString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TagString);

			}
		}


		///<summary>
		///Specifies or returns the tag of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("Tag", typeof(System.String))]
		public class Set_TagString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TagString = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the prompt string of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class PromptString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PromptString);

			}
		}


		///<summary>
		///Specifies or returns the prompt string of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("bstrPrompt", typeof(System.String))]
		public class Set_PromptString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PromptString = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the text that displays for an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class TextString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextString);

			}
		}


		///<summary>
		///Specifies or returns the text that displays for an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
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
		///Specifies or returns the text style of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class StyleName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StyleName);

			}
		}


		///<summary>
		///Specifies or returns the text style of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
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
		///Specifies or returns the horizontal and vertical alignment of the attribute text.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class Alignment : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Alignment);

			}
		}


		///<summary>
		///Specifies or returns the horizontal and vertical alignment of the attribute text.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("align", typeof(System.Object))]
		public class Set_Alignment : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Alignment = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the horizontal alignment of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class HorizontalAlignment : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HorizontalAlignment);

			}
		}


		///<summary>
		///Specifies or returns the horizontal alignment of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("horizAlign", typeof(System.Object))]
		public class Set_HorizontalAlignment : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.HorizontalAlignment = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the vertical alignment of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class VerticalAlignment : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.VerticalAlignment);

			}
		}


		///<summary>
		///Specifies or returns the vertical alignment of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("vertiAlign", typeof(System.Object))]
		public class Set_VerticalAlignment : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.VerticalAlignment = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the height of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class Height : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Height);

			}
		}


		///<summary>
		///Specifies or returns the height of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("Height", typeof(System.Double))]
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
		///Specifies or returns the rotation angle of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class Rotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Rotation);

			}
		}


		///<summary>
		///Specifies or returns the rotation angle of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("rotAngle", typeof(System.Object))]
		public class Set_Rotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Rotation = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the scale factor of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class ScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ScaleFactor);

			}
		}


		///<summary>
		///Specifies or returns the scale factor of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("scalFactor", typeof(System.Object))]
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
		///Specifies or returns the oblique angle of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class ObliqueAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ObliqueAngle);

			}
		}


		///<summary>
		///Specifies or returns the oblique angle of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("obliAngle", typeof(System.Object))]
		public class Set_ObliqueAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ObliqueAngle = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the x, y, z alignment point of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class TextAlignmentPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextAlignmentPoint);

			}
		}


		///<summary>
		///Specifies or returns the x, y, z alignment point of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("alignPoint", typeof(System.Object))]
		public class Set_TextAlignmentPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextAlignmentPoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of the attribute text insertion point.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class InsertionPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.InsertionPoint);

			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of the attribute text insertion point.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
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
		///Specifies or returns the x, y, and z coordinates of the normal direction vector.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class Normal : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Normal);

			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of the normal direction vector.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
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
		///Specifies or returns the text generation flag of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class TextGenerationFlag : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextGenerationFlag);

			}
		}


		///<summary>
		///Specifies or returns the text generation flag of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("textGenFlag", typeof(System.Object))]
		public class Set_TextGenerationFlag : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextGenerationFlag = inputs[1];
				return null;
			}
		}


		///<summary>
		///z-direction value) of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class Thickness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Thickness);

			}
		}


		///<summary>
		///z-direction value) of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("Thickness", typeof(System.Double))]
		public class Set_Thickness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Thickness = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the mode of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class Mode : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Mode);

			}
		}


		///<summary>
		///Specifies or returns the mode of an attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("Mode", typeof(System.Object))]
		public class Set_Mode : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Mode = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the text of an attribute is upside down.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class UpsideDown : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UpsideDown);

			}
		}


		///<summary>
		///Specifies or returns whether the text of an attribute is upside down.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("bUpsideDown", typeof(System.Object))]
		public class Set_UpsideDown : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UpsideDown = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the attribute text is backward.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class Backward : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Backward);

			}
		}


		///<summary>
		///Specifies or returns whether the attribute text is backward.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("bBackward", typeof(System.Object))]
		public class Set_Backward : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Backward = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the invisible mode of the attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class Invisible : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Invisible);

			}
		}


		///<summary>
		///Specifies or returns the invisible mode of the attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("bInvisible", typeof(System.Object))]
		public class Set_Invisible : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Invisible = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the constant mode of the attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class Constant : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Constant);

			}
		}


		///<summary>
		///Specifies or returns the constant mode of the attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("bConstant", typeof(System.Object))]
		public class Set_Constant : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Constant = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the verify mode of the attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class Verify : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Verify);

			}
		}


		///<summary>
		///Specifies or returns the verify mode of the attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("bVerify", typeof(System.Object))]
		public class Set_Verify : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Verify = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the preset mode of the attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class Preset : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Preset);

			}
		}


		///<summary>
		///Specifies or returns the preset mode of the attribute.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("bPreset", typeof(System.Object))]
		public class Set_Preset : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Preset = inputs[1];
				return null;
			}
		}


		///<summary>
		///Not implemented. Specifies or returns whether an attribute is moved relative to its associated block.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class LockPosition : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LockPosition);

			}
		}


		///<summary>
		///Not implemented. Specifies or returns whether an attribute is moved relative to its associated block.
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("bLockPosition", typeof(System.Object))]
		public class Set_LockPosition : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LockPosition = inputs[1];
				return null;
			}
		}


		///<summary>
		///Determines whether if the attribute is multiline
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class MTextAttribute : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MTextAttribute);

			}
		}


		///<summary>
		///Determines whether if the attribute is multiline
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("bMTextAttribute", typeof(System.Object))]
		public class Set_MTextAttribute : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.MTextAttribute = inputs[1];
				return null;
			}
		}


		///<summary>
		///Gets the multiline attribute content
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class MTextAttributeContent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MTextAttributeContent);

			}
		}


		///<summary>
		///Gets the multiline attribute content
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("content", typeof(System.String))]
		public class Set_MTextAttributeContent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.MTextAttributeContent = inputs[1];
				return null;
			}
		}


		///<summary>
		///Updates multiline MText
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class UpdateMTextAttribute : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UpdateMTextAttribute();
				return null;
			}
		}


		///<summary>
		///Gets the width of text boundary of the Mtext
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class MTextBoundaryWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MTextBoundaryWidth);

			}
		}


		///<summary>
		///Gets the width of text boundary of the Mtext
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class Set_MTextBoundaryWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.MTextBoundaryWidth[inputs[1]] = inputs[2];
				return null;
			}
		}


		///<summary>
		///Gets the drawing direction of the Mtext
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		public class MTextDrawingDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MTextDrawingDirection);

			}
		}


		///<summary>
		///Gets the drawing direction of the Mtext
		///</summary>
		[NodeInput("AcadAttribute", typeof(object))]
		[NodeInput("drawDir", typeof(System.Object))]
		public class Set_MTextDrawingDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.MTextDrawingDirection = inputs[1];
				return null;
			}
		}
}
