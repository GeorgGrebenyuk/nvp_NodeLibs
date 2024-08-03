using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Parameter 
{

	[NVP_Manifest(
		Id = "18DFE71B-9D3B-48EE-861B-457D195CCC24", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.Parameter_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "_Parameter_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		Id = "F40C5355-5740-44D5-8910-68E3F0C72BB1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.Parameter_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "_Parameter_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Id = "A7D8F75C-A5FD-4222-8548-75D0D4B73A37", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.ValueType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "ValueType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ValueType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ValueType);

		}
	}


	[NVP_Manifest(
		Id = "3A578937-8E88-4795-AF72-0A3D3D61D6E8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.Definition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "Definition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Definition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Definition);

		}
	}


	[NVP_Manifest(
		Id = "EEAA98FC-5B18-4229-B152-51A648235200", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.GetBoolValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "GetBoolValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBoolValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBoolValue);

		}
	}


	[NVP_Manifest(
		Id = "99A08893-5A94-4750-8BD2-9EC71A7C98AB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.SetBoolValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "SetBoolValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("value", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetBoolValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBoolValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "815155CF-C42D-4CDB-936D-5A8525D132FF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.GetIntValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "GetIntValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIntValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIntValue);

		}
	}


	[NVP_Manifest(
		Id = "53248033-131D-4556-8053-D43126F972DE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.SetIntValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "SetIntValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("value", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class SetIntValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetIntValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "14D9B72C-81F3-4D33-9B6B-46C7359D4216", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.GetDoubleValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "GetDoubleValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetDoubleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDoubleValue);

		}
	}


	[NVP_Manifest(
		Id = "D6A6F5E1-8AC5-4D5B-A574-9E780FE93F5E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.SetDoubleValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "SetDoubleValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("value", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class SetDoubleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDoubleValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4B5B322C-BEF1-46F0-8D3D-367C23C4DD92", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.GetStringValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "GetStringValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetStringValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetStringValue);

		}
	}


	[NVP_Manifest(
		Id = "98074546-E9B4-4DC4-BCF9-3CB2C574DE85", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.SetStringValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "SetStringValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("value", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class SetStringValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetStringValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4E9EC632-47E7-4474-8520-B40B75B83731", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Id = "6D8F49A9-10E6-45E7-B276-A4DED25B3383", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.IdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "IdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}


	[NVP_Manifest(
		Id = "A53D0B5C-FA05-463D-AAF3-99E5E7964F27", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Parameter.HasValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Parameter", 
		NodeName = "HasValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasValue);

		}
	}
}
