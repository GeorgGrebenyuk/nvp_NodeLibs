using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ParameterDefinition 
{

	[NVP_Manifest(
		Id = "FD43147E-C63F-40D2-B709-854E4DA8D9F0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ParameterDefinition.ParameterDefinition_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ParameterDefinition", 
		NodeName = "_ParameterDefinition_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ParameterDefinition_Constructor : INode 
	{
		public Renga.IParameterDefinition _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IParameterDefinition;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A65A2ACB-7F0E-47CB-8591-7CF7844F7AA9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ParameterDefinition.ParameterDefinition_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ParameterDefinition", 
		NodeName = "_ParameterDefinition_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ParameterDefinition_ConstructorCast : INode 
	{
		public Renga.IParameterDefinition _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IParameterDefinition;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "6FABC570-0C20-4064-8941-0D8E1CF206C0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ParameterDefinition.ParameterType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ParameterDefinition", 
		NodeName = "ParameterType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ParameterDefinition", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ParameterType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParameterType);

		}
	}


	[NVP_Manifest(
		Id = "759A0944-356B-4839-9108-9D120049DB6E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ParameterDefinition.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ParameterDefinition", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ParameterDefinition", typeof(object))]

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
}
