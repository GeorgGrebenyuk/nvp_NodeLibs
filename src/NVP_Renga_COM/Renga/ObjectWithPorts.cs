using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ObjectWithPorts 
{

	[NVP_Manifest(
		Id = "97AB94E1-B1F4-4D61-9E4E-5FF1B0AAF15E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithPorts.ObjectWithPorts_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithPorts", 
		NodeName = "_ObjectWithPorts_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectWithPorts_Constructor : INode 
	{
		public Renga.IObjectWithPorts _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IObjectWithPorts;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "AADBF573-8E2F-4276-A1A9-AAF9DEC12664", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithPorts.ObjectWithPorts_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithPorts", 
		NodeName = "_ObjectWithPorts_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectWithPorts_ConstructorCast : INode 
	{
		public Renga.IObjectWithPorts _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IObjectWithPorts;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3ECED132-FFD6-42D2-A9A9-8102888B0A64", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithPorts.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithPorts", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ObjectWithPorts", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "44BE1F1A-75BF-426C-9EAF-076D8D8CB4AA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithPorts.GetByIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithPorts", 
		NodeName = "GetByIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ObjectWithPorts", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetByIndex(inputs[1].Value));

		}
	}
}
