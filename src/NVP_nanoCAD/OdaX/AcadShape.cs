using NVP.API.Nodes;

namespace OdaX.AcadShape 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadShape_Constructor : INode 
		{
		public OdaX.IAcadShape _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadShape;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadShape_ConstructorCast : INode 
		{
		public OdaX.IAcadShape _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadShape;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of the shape insertion point.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
		public class InsertionPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.InsertionPoint);

			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of the shape insertion point.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
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
		///Specifies or returns the name of a shape.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies or returns the name of a shape.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
		[NodeInput("bstrName", typeof(System.String))]
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
		///Specifies or returns the height of a shape.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
		public class Height : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Height);

			}
		}


		///<summary>
		///Specifies or returns the height of a shape.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
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
		///Specifies or returns the rotation angle of a shape.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
		public class Rotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Rotation);

			}
		}


		///<summary>
		///Specifies or returns the rotation angle of a shape.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
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
		///Specifies or returns the width scale factor of a shape.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
		public class ScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ScaleFactor);

			}
		}


		///<summary>
		///Specifies or returns the width scale factor of a shape.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
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
		///Specifies or returns the oblique angle of a shape.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
		public class ObliqueAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ObliqueAngle);

			}
		}


		///<summary>
		///Specifies or returns the oblique angle of a shape.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
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
		///Specifies or returns the x, y, and z coordinates of the normal direction vector.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
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
		[NodeInput("AcadShape", typeof(object))]
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
		///z-direction value) of a shape.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
		public class Thickness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Thickness);

			}
		}


		///<summary>
		///z-direction value) of a shape.
		///</summary>
		[NodeInput("AcadShape", typeof(object))]
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
}
