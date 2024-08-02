using NVP.API.Nodes;

namespace Renga.Transform2D 
{
		[NodeInput("dynamic", typeof(object))]
		public class Transform2D_Constructor : INode 
		{
		public Renga.ITransform2D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.ITransform2D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Transform2D_ConstructorCast : INode 
		{
		public Renga.ITransform2D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.ITransform2D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Transform2D", typeof(object))]
		[NodeInput("rowIndex", typeof(System.Int32))]
		[NodeInput("columnIndex", typeof(System.Int32))]
		public class GetElement : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetElement(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Transform2D", typeof(object))]
		[NodeInput("rowIndex", typeof(System.Int32))]
		[NodeInput("columnIndex", typeof(System.Int32))]
		[NodeInput("value", typeof(System.Double))]
		public class SetElement : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetElement(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Transform2D", typeof(object))]
		[NodeInput("translation", typeof(System.Object))]
		public class AddTranslation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddTranslation(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Transform2D", typeof(object))]
		[NodeInput("pivot", typeof(System.Object))]
		[NodeInput("angle", typeof(System.Double))]
		public class AddRotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddRotation(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Transform2D", typeof(object))]
		public class GetCopy : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetCopy);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Transform2D", typeof(object))]
		[NodeInput("pPoint", typeof(System.Object))]
		public class TransformPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TransformPoint(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Transform2D", typeof(object))]
		[NodeInput("pVector", typeof(System.Object))]
		public class TransformVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TransformVector(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Transform2D", typeof(object))]
		public class CreateTransform3D : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateTransform3D);

			}
		}
}
