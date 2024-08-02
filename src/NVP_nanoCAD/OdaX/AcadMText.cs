using NVP.API.Nodes;

namespace OdaX.AcadMText 
{
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


		///<summary>
		///Specifies or returns the characters of multline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		public class TextString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextString);

			}
		}


		///<summary>
		///Specifies or returns the characters of multline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
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
		///Specifies or returns the style name of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		public class StyleName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StyleName);

			}
		}


		///<summary>
		///Specifies or returns the style name of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
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
		///Specifies or returns the position of multline text in relation to the insertion point.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		public class AttachmentPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AttachmentPoint);

			}
		}


		///<summary>
		///Specifies or returns the position of multline text in relation to the insertion point.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		[NodeInput("attPoint", typeof(System.Object))]
		public class Set_AttachmentPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AttachmentPoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the direction in which the characters of multiline text display.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		public class DrawingDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DrawingDirection);

			}
		}


		///<summary>
		///Specifies or returns the direction in which the characters of multiline text display.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		[NodeInput("drawDir", typeof(System.Object))]
		public class Set_DrawingDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DrawingDirection = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the width of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		public class Width : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Width);

			}
		}


		///<summary>
		///Specifies or returns the width of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		[NodeInput("Width", typeof(System.Double))]
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
		///Specifies or returns the height of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		public class Height : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Height);

			}
		}


		///<summary>
		///Specifies or returns the height of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
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
		///Specifies or returns the rotation angle of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		public class Rotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Rotation);

			}
		}


		///<summary>
		///Specifies or returns the rotation angle of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
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
		///Specifies or returns the x, y, and z coordinates of the attribute text insertion point.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
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
		[NodeInput("AcadMText", typeof(object))]
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
		[NodeInput("AcadMText", typeof(object))]
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
		[NodeInput("AcadMText", typeof(object))]
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
		///Specifies or returns the line spacing factor of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		public class LineSpacingFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LineSpacingFactor);

			}
		}


		///<summary>
		///Specifies or returns the line spacing factor of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		[NodeInput("factor", typeof(System.Double))]
		public class Set_LineSpacingFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LineSpacingFactor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the line spacing style of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		public class LineSpacingStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LineSpacingStyle);

			}
		}


		///<summary>
		///Specifies or returns the line spacing style of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		[NodeInput("style", typeof(System.Object))]
		public class Set_LineSpacingStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LineSpacingStyle = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the distance between lines of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		public class LineSpacingDistance : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LineSpacingDistance);

			}
		}


		///<summary>
		///Specifies or returns the distance between lines of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		[NodeInput("Value", typeof(System.Double))]
		public class Set_LineSpacingDistance : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LineSpacingDistance = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the multiline text is filled with a background.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		public class BackgroundFill : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BackgroundFill);

			}
		}


		///<summary>
		///Specifies or returns whether the multiline text is filled with a background.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		[NodeInput("bUseBackgroundFill", typeof(System.Object))]
		public class Set_BackgroundFill : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.BackgroundFill = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns the characters and field codes of multiline text.
		///</summary>
		[NodeInput("AcadMText", typeof(object))]
		public class FieldCode : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FieldCode);

			}
		}
}
