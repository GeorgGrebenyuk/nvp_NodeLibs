using NVP.API.Nodes;

namespace OdaX.OdaLineType 
{
		[NodeInput("dynamic", typeof(object))]
		public class OdaLineType_Constructor : INode 
		{
		public OdaX.IOdaLineType _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IOdaLineType;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class OdaLineType_ConstructorCast : INode 
		{
		public OdaX.IOdaLineType _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IOdaLineType;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the number of dashes of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		public class NumDashes : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NumDashes);

			}
		}


		///<summary>
		///Specifies or returns the number of dashes of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		[NodeInput("Count", typeof(System.Object))]
		public class Set_NumDashes : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.NumDashes = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the text to be included as part of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		[NodeInput("Index", typeof(System.Object))]
		public class TextAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextAt(inputs[1]));

			}
		}


		///<summary>
		///Specifies or returns the text to be included as part of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		[NodeInput("Index", typeof(System.Object))]
		[NodeInput("bstrText", typeof(System.String))]
		public class Set_TextAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextAt[inputs[1]] = inputs[2];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the pattern length of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		public class PatternLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PatternLength);

			}
		}


		///<summary>
		///Specifies or returns the pattern length of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_PatternLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PatternLength = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the dash length of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		public class DashLengthAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DashLengthAt);

			}
		}


		///<summary>
		///Specifies or returns the dash length of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_DashLengthAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DashLengthAt = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the scale of a shape that is included as part of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		public class ShapeScaleAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShapeScaleAt);

			}
		}


		///<summary>
		///Specifies or returns the scale of a shape that is included as part of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_ShapeScaleAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShapeScaleAt = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the shape to be included as part of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		public class ShapeNumberAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShapeNumberAt);

			}
		}


		///<summary>
		///Specifies or returns the shape to be included as part of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_ShapeNumberAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShapeNumberAt = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the rotation angle of a shape or text that is included as part of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		public class ShapeRotationAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShapeRotationAt);

			}
		}


		///<summary>
		///Specifies or returns the rotation angle of a shape or text that is included as part of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_ShapeRotationAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShapeRotationAt = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the offset of a shape that is included as part of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		public class ShapeOffsetAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShapeOffsetAt);

			}
		}


		///<summary>
		///Specifies or returns the offset of a shape that is included as part of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_ShapeOffsetAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShapeOffsetAt = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the style of a shape or text that is included as part of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		public class ShapeStyleAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShapeStyleAt);

			}
		}


		///<summary>
		///Specifies or returns the style of a shape or text that is included as part of a linetype.
		///</summary>
		[NodeInput("OdaLineType", typeof(object))]
		[NodeInput("pStyle", typeof(System.Object))]
		public class Set_ShapeStyleAt : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShapeStyleAt = inputs[1];
				return null;
			}
		}
}
