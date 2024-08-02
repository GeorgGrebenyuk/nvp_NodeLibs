using NVP.API.Nodes;

namespace Renga.Property 
{
		[NodeInput("dynamic", typeof(object))]
		public class Property_Constructor : INode 
		{
		public Renga.IProperty _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IProperty;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Property_ConstructorCast : INode 
		{
		public Renga.IProperty _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IProperty;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("value_", typeof(System.Double))]
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
		[NodeInput("Property", typeof(object))]
		[NodeInput("value_", typeof(System.String))]
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
		[NodeInput("Property", typeof(object))]
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
		[NodeInput("Property", typeof(object))]
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
		[NodeInput("Property", typeof(object))]
		public class Type : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Type);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		public class ResetValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ResetValue();
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		public class HasValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HasValue);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
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
		[NodeInput("Property", typeof(object))]
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
		[NodeInput("Property", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("value_", typeof(System.Double))]
		[NodeInput("unit", typeof(System.Object))]
		public class SetAngleValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetAngleValue(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("value_", typeof(System.Double))]
		[NodeInput("unit", typeof(System.Object))]
		public class SetAreaValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetAreaValue(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("value_", typeof(System.Object))]
		public class SetBooleanValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetBooleanValue(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("value_", typeof(System.String))]
		public class SetEnumerationValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetEnumerationValue(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("value_", typeof(System.Int32))]
		public class SetIntegerValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetIntegerValue(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("value_", typeof(System.Double))]
		[NodeInput("unit", typeof(System.Object))]
		public class SetLengthValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetLengthValue(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("value_", typeof(System.Object))]
		public class SetLogicalValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetLogicalValue(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("value_", typeof(System.Double))]
		[NodeInput("unit", typeof(System.Object))]
		public class SetMassValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetMassValue(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("value_", typeof(System.Double))]
		[NodeInput("unit", typeof(System.Object))]
		public class SetVolumeValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetVolumeValue(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("unit", typeof(System.Object))]
		public class GetAngleValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetAngleValue(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("unit", typeof(System.Object))]
		public class GetAreaValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetAreaValue(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		public class GetBooleanValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetBooleanValue);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		public class GetEnumerationValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetEnumerationValue);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		public class GetIntegerValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetIntegerValue);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("unit", typeof(System.Object))]
		public class GetLengthValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetLengthValue(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		public class GetLogicalValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetLogicalValue);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("unit", typeof(System.Object))]
		public class GetMassValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetMassValue(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Property", typeof(object))]
		[NodeInput("unit", typeof(System.Object))]
		public class GetVolumeValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetVolumeValue(inputs[1]));

			}
		}
}
