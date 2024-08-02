using NVP.API.Nodes;

namespace Renga.Parameter 
{
		[NodeInput("dynamic", typeof(object))]
		public class Parameter_Constructor : INode 
		{
		public Renga.IParameter _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IParameter;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Parameter_ConstructorCast : INode 
		{
		public Renga.IParameter _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IParameter;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		public class ValueType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ValueType);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		public class Definition : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Definition);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		public class GetBoolValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetBoolValue);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		[NodeInput("value", typeof(System.Object))]
		public class SetBoolValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetBoolValue(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		public class GetIntValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetIntValue);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		[NodeInput("value", typeof(System.Int32))]
		public class SetIntValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetIntValue(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		public class GetDoubleValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetDoubleValue);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		[NodeInput("value", typeof(System.Double))]
		public class SetDoubleValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetDoubleValue(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		public class GetStringValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetStringValue);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		[NodeInput("value", typeof(System.String))]
		public class SetStringValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetStringValue(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		public class Id : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Id);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		public class IdS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IdS);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Parameter", typeof(object))]
		public class HasValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HasValue);

			}
		}
}
