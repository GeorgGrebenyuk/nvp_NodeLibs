using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Port 
{

	[NVP_Manifest(
		Id = "5C59398C-3C7D-4172-BBCC-C109444C9204", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Port.Port_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Port", 
		NodeName = "_Port_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Port_Constructor : INode 
	{
		public Renga.IPort _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPort;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "90F2F8E9-ABBB-47AB-89F6-D6EB1700C658", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Port.Port_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Port", 
		NodeName = "_Port_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Port_ConstructorCast : INode 
	{
		public Renga.IPort _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPort;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "8A1E9754-BB2A-49B4-9F22-8E0D9B980240", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Port.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Port", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Port", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "5F530E81-108E-44FB-8159-C7843E726922", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Port.FlowDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Port", 
		NodeName = "FlowDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Port", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FlowDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FlowDirection);

		}
	}


	[NVP_Manifest(
		Id = "703B3C44-3FBD-4222-91AC-AF66BCCB818A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Port.AvailableSystemCategories", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Port", 
		NodeName = "AvailableSystemCategories", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Port", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AvailableSystemCategories : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AvailableSystemCategories);

		}
	}


	[NVP_Manifest(
		Id = "08FEFC36-CFD2-4335-A1D0-82717A82124D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Port.PortConnectionParams", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Port", 
		NodeName = "PortConnectionParams", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Port", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PortConnectionParams : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PortConnectionParams);

		}
	}
}
