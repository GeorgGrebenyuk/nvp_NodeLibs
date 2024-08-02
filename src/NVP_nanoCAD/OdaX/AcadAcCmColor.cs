using NVP.API.Nodes;

namespace OdaX.AcadAcCmColor 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadAcCmColor_Constructor : INode 
		{
		public OdaX.IAcadAcCmColor _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadAcCmColor;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadAcCmColor_ConstructorCast : INode 
		{
		public OdaX.IAcadAcCmColor _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadAcCmColor;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the AcCmEntityColor of a true color.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		[NodeInput("eColor", typeof(System.Object))]
		public class Set_EntityColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EntityColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the AcCmEntityColor of a true color.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		public class EntityColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EntityColor);

			}
		}


		///<summary>
		///Returns the name of a color.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		public class ColorName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ColorName);

			}
		}


		///<summary>
		///Returns the book name of a color.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		public class BookName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BookName);

			}
		}


		///<summary>
		///Specifies the color name and book name of a color.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		[NodeInput("ColorName", typeof(System.String))]
		[NodeInput("BookName", typeof(System.String))]
		public class SetNames : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetNames(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Deletes a true color.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		public class Delete : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Delete();
				return null;
			}
		}


		///<summary>
		///Returns the red component of a true color.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		public class Red : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Red);

			}
		}


		///<summary>
		///Returns the blue component of a true color.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		public class Blue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Blue);

			}
		}


		///<summary>
		///Returns the green component of a true color.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		public class Green : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Green);

			}
		}


		///<summary>
		///Specifies the RGB values of a true color.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		[NodeInput("Red", typeof(System.Object))]
		[NodeInput("Green", typeof(System.Object))]
		[NodeInput("Blue", typeof(System.Object))]
		public class SetRGB : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetRGB(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///Specifies or returns the color method.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		[NodeInput("Flags", typeof(System.Object))]
		public class Set_ColorMethod : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ColorMethod = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the color method.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		public class ColorMethod : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ColorMethod);

			}
		}


		///<summary>
		///Specifies or returns the color index of an object.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		public class ColorIndex : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ColorIndex);

			}
		}


		///<summary>
		///Specifies or returns the color index of an object.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		[NodeInput("color", typeof(System.Object))]
		public class Set_ColorIndex : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ColorIndex = inputs[1];
				return null;
			}
		}


		///<summary>
		///Sets the color to a color from a color book.
		///</summary>
		[NodeInput("AcadAcCmColor", typeof(object))]
		[NodeInput("BookName", typeof(System.String))]
		[NodeInput("ColorName", typeof(System.String))]
		public class SetColorBookColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetColorBookColor(inputs[1],inputs[2]);
				return null;
			}
		}
}
