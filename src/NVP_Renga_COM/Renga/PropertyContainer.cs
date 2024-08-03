using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.PropertyContainer 
{

	[NVP_Manifest(
		Id = "1E9E3260-0E2E-4101-8924-3BA7988048EC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyContainer.PropertyContainer_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyContainer", 
		NodeName = "_PropertyContainer_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropertyContainer_Constructor : INode 
	{
		public Renga.IPropertyContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPropertyContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "2254BB6E-CB64-4E86-9907-2F2ACEF09308", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyContainer.PropertyContainer_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyContainer", 
		NodeName = "_PropertyContainer_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropertyContainer_ConstructorCast : INode 
	{
		public Renga.IPropertyContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPropertyContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "6ED80E2D-0C81-43A5-9FB5-AAC0934C32CD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyContainer.Get", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyContainer", 
		NodeName = "Get", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PropertyContainer", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "0F502C9E-6755-46A2-A6F7-81170E601422", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyContainer.Contains", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyContainer", 
		NodeName = "Contains", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PropertyContainer", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "D33F10CD-B8F9-49D4-B68E-50A2CFF2C467", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyContainer.GetS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyContainer", 
		NodeName = "GetS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PropertyContainer", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "0AC3102C-2ACA-4333-96CD-1E9A79D1B592", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyContainer.ContainsS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyContainer", 
		NodeName = "ContainsS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PropertyContainer", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class ContainsS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContainsS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "FE8B89F6-A98E-4032-8C15-67BB59F181E5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PropertyContainer.GetIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PropertyContainer", 
		NodeName = "GetIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PropertyContainer", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIds);

		}
	}
}
