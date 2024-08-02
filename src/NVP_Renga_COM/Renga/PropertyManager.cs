using NVP.API.Nodes;

namespace Renga.PropertyManager 
{
	[NodeInput("dynamic", typeof(object))]
	public class PropertyManager_Constructor : INode 
	{
		public Renga.IPropertyManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPropertyManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class PropertyManager_ConstructorCast : INode 
	{
		public Renga.IPropertyManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPropertyManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	[NodeInput("description_", typeof(System.Object))]
	public class RegisterProperty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RegisterProperty(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	public class UnregisterProperty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnregisterProperty(inputs[1]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	public class PropertyCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PropertyCount);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	public class GetPropertyId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyId(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	public class GetPropertyDescription : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyDescription(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	public class IsPropertyRegistered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPropertyRegistered(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	[NodeInput("objectType_", typeof(System.Object))]
	public class AssignPropertyToType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AssignPropertyToType(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	[NodeInput("objectType_", typeof(System.Object))]
	public class UnassignPropertyFromType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnassignPropertyFromType(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	[NodeInput("objectType_", typeof(System.Object))]
	public class IsPropertyAssignedToType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPropertyAssignedToType(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	[NodeInput("name_", typeof(System.String))]
	[NodeInput("type_", typeof(System.Object))]
	public class RegisterPropertyS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RegisterPropertyS(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	public class UnregisterPropertyS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnregisterPropertyS(inputs[1]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	public class GetPropertyIdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyIdS(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	public class GetPropertyNameS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyNameS(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	public class GetPropertyTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyTypeS(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	public class IsPropertyRegisteredS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPropertyRegisteredS(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	[NodeInput("objectType_", typeof(System.String))]
	public class AssignPropertyToTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AssignPropertyToTypeS(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	[NodeInput("objectType_", typeof(System.String))]
	public class UnassignPropertyFromTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnassignPropertyFromTypeS(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	[NodeInput("objectType_", typeof(System.String))]
	public class IsPropertyAssignedToTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPropertyAssignedToTypeS(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	public class GetPropertyName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyName(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	public class GetPropertyType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyType(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("name_", typeof(System.String))]
	[NodeInput("type_", typeof(System.Object))]
	public class CreatePropertyDescription : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreatePropertyDescription(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	[NodeInput("pDescription", typeof(System.Object))]
	public class RegisterProperty2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RegisterProperty2(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	[NodeInput("pDescription", typeof(System.Object))]
	public class RegisterPropertyS2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RegisterPropertyS2(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	public class GetPropertyDescription2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyDescription2(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	public class GetPropertyDescription2S : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyDescription2S(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	public class UpdateEnumValues : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UpdateEnumValues(inputs[1]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	[NodeInput("Name", typeof(System.String))]
	public class SetPropertyName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetPropertyName(inputs[1],inputs[2]);
			return null;
		}
	}
}
