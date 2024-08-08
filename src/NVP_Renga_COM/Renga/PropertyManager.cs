using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.PropertyManager 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	[NodeInput("description_", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class RegisterProperty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RegisterProperty(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class UnregisterProperty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnregisterProperty(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PropertyCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PropertyCount);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetPropertyId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyId(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetPropertyDescription : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyDescription(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class IsPropertyRegistered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPropertyRegistered(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	[NodeInput("objectType_", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AssignPropertyToType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AssignPropertyToType(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	[NodeInput("objectType_", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class UnassignPropertyFromType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnassignPropertyFromType(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	[NodeInput("objectType_", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class IsPropertyAssignedToType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPropertyAssignedToType(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	[NodeInput("name_", typeof(System.String))]
	[NodeInput("Renga.PropertyType", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class RegisterPropertyS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RegisterPropertyS(inputs[1].Value,inputs[2].Value,((Renga.PropertyType)inputs[3].Value));
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class UnregisterPropertyS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnregisterPropertyS(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetPropertyIdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyIdS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetPropertyNameS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyNameS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetPropertyTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyTypeS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class IsPropertyRegisteredS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPropertyRegisteredS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	[NodeInput("objectType_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class AssignPropertyToTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AssignPropertyToTypeS(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	[NodeInput("objectType_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class UnassignPropertyFromTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnassignPropertyFromTypeS(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	[NodeInput("objectType_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class IsPropertyAssignedToTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPropertyAssignedToTypeS(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetPropertyName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyName(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetPropertyType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyType(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("name_", typeof(System.String))]
	[NodeInput("Renga.PropertyType", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class CreatePropertyDescription : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreatePropertyDescription(inputs[1].Value,((Renga.PropertyType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	[NodeInput("pDescription", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class RegisterProperty2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RegisterProperty2(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]
	[NodeInput("pDescription", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class RegisterPropertyS2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RegisterPropertyS2(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetPropertyDescription2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyDescription2(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetPropertyDescription2S : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPropertyDescription2S(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class UpdateEnumValues : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UpdateEnumValues(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PropertyManager", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class SetPropertyName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetPropertyName(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
