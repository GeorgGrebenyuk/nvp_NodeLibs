using NVP.API.Nodes;

namespace OdaX.AcadDynamicBlockReferenceProperty 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadDynamicBlockReferenceProperty_Constructor : INode 
		{
		public OdaX.IAcadDynamicBlockReferenceProperty _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadDynamicBlockReferenceProperty;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadDynamicBlockReferenceProperty_ConstructorCast : INode 
		{
		public OdaX.IAcadDynamicBlockReferenceProperty _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadDynamicBlockReferenceProperty;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns the name of the property.
		///</summary>
		[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]
		public class PropertyName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PropertyName);

			}
		}


		///<summary>
		///Returns whether a property is read-only.
		///</summary>
		[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]
		public class ReadOnly : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ReadOnly);

			}
		}


		///<summary>
		///Returns whether a property is available in the application user interface.
		///</summary>
		[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]
		public class Show : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Show);

			}
		}


		///<summary>
		///Returns the description of the property.
		///</summary>
		[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]
		public class Description : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Description);

			}
		}


		///<summary>
		///Returns the values that are valid for a property.
		///</summary>
		[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]
		public class AllowedValues : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AllowedValues);

			}
		}


		///<summary>
		///Specifies or returns the value of a property.
		///</summary>
		[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]
		public class Value : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Value);

			}
		}


		///<summary>
		///Specifies or returns the value of a property.
		///</summary>
		[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]
		[NodeInput("Value", typeof(System.Object))]
		public class Set_Value : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Value = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns the current units type for the display of a property.
		///</summary>
		[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]
		public class UnitsType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UnitsType);

			}
		}
}
