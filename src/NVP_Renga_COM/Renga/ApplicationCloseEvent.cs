using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ApplicationCloseEvent 
{

	[NVP_Manifest(
		Id = "30CAEEDA-BC8D-4F76-8C5A-10D937A40540", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ApplicationCloseEvent.ApplicationCloseEvent_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ApplicationCloseEvent", 
		NodeName = "_ApplicationCloseEvent_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ApplicationCloseEvent_Constructor : INode 
	{
		public Renga.IApplicationCloseEvent _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IApplicationCloseEvent;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "61921E1B-708A-4DE4-A499-10D5130FC2A8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ApplicationCloseEvent.ApplicationCloseEvent_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ApplicationCloseEvent", 
		NodeName = "_ApplicationCloseEvent_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ApplicationCloseEvent_ConstructorCast : INode 
	{
		public Renga.IApplicationCloseEvent _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IApplicationCloseEvent;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2FB13335-540B-4CEB-ACB6-C509386BA6C7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ApplicationCloseEvent.Prevent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ApplicationCloseEvent", 
		NodeName = "Prevent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ApplicationCloseEvent", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Prevent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Prevent();
			return null;
		}
	}
}
