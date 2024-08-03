using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.PropertyManager 
{

	[NVP_Manifest(
		Id = "43300F92-8D6A-4B78-9183-ED3FF4825BDC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.PropertyManager_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "_PropertyManager_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "F6E4AD31-7ECA-4202-BCC5-95055BE4E770", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.PropertyManager_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "_PropertyManager_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "DDFBB639-6148-46B3-B209-8793408C56AB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.RegisterProperty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "RegisterProperty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "9FDBFFBD-D404-41A8-9604-5D7C5E947375", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.UnregisterProperty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "UnregisterProperty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "8D184FC3-606C-4C01-980B-9CE037C7FA2F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.PropertyCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "PropertyCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "9F51D54A-292D-4100-ABB6-BDC03651B175", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.GetPropertyId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "GetPropertyId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "73CC901D-6A2C-435E-BDCB-FC62726E5BBB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.GetPropertyDescription", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "GetPropertyDescription", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "73C60D43-5A7D-4B8C-8246-253D53BF78AC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.IsPropertyRegistered", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "IsPropertyRegistered", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "E9BDD7C1-2FB3-4D88-B848-ECE9A3676537", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.AssignPropertyToType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "AssignPropertyToType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "6CDA6887-5EE2-4C28-AFC8-FCEBF0DB240C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.UnassignPropertyFromType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "UnassignPropertyFromType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "182F717C-12FF-413B-9017-777C730D7708", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.IsPropertyAssignedToType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "IsPropertyAssignedToType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "AF527F79-56E7-4BFE-B6FE-A5A04044EB4D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.RegisterPropertyS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "RegisterPropertyS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "2E7799B5-F858-433F-ACBE-CC32BFD89B0D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.UnregisterPropertyS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "UnregisterPropertyS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "D8055AE6-03E1-4AFD-8D3F-E363B19E1583", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.GetPropertyIdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "GetPropertyIdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "F8901DEC-F425-45AA-9392-27A4E9B28E75", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.GetPropertyNameS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "GetPropertyNameS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "C88FDA2B-1464-403B-9BD9-CFCE777DBFE4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.GetPropertyTypeS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "GetPropertyTypeS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "EAB41E20-B76F-4073-8EE4-AE73B7A53F64", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.IsPropertyRegisteredS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "IsPropertyRegisteredS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "CEC9B775-4D9A-41B8-AB82-75E6C56AAD1B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.AssignPropertyToTypeS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "AssignPropertyToTypeS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "2197CA88-D969-4795-A4BC-E2BE0D520133", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.UnassignPropertyFromTypeS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "UnassignPropertyFromTypeS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "51CB3281-2A9A-4ACC-940D-4C4A59C175A7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.IsPropertyAssignedToTypeS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "IsPropertyAssignedToTypeS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "7BE6391C-CFE4-46AB-93D8-0C198B3750F4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.GetPropertyName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "GetPropertyName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "FD272CDD-F27C-454B-B73F-4235508868C7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.GetPropertyType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "GetPropertyType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "F1FF1FA6-3BF8-4834-9459-FD1274F96452", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.CreatePropertyDescription", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "CreatePropertyDescription", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "748D3DA6-764B-46D0-A45C-DE410B1DF63F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.RegisterProperty2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "RegisterProperty2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "6300829D-3C07-4A03-82BA-04B3043894C2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.RegisterPropertyS2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "RegisterPropertyS2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "8B27A848-BCE5-4B0F-B4AE-38DCF0D79004", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.GetPropertyDescription2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "GetPropertyDescription2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "4BB292F8-0E42-4EA9-99CB-F0D28D35216E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.GetPropertyDescription2S", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "GetPropertyDescription2S", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "C3FBC41D-B9F7-46E9-9416-2B409EDB44F4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.UpdateEnumValues", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "UpdateEnumValues", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "478A3DE2-75DA-44BD-B367-CC0940B77B2C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyManager.SetPropertyName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyManager", 
		NodeName = "SetPropertyName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
