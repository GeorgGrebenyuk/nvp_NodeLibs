using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ToolButton 
{

	[NVP_Manifest(
		Id = "4162D17D-4BD0-4D08-B01B-2BD87F8FCB38", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ToolButton.ToolButton_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ToolButton", 
		NodeName = "_ToolButton_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ToolButton_Constructor : INode 
	{
		public Renga.IToolButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IToolButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "DCB3B845-DAC0-42C9-8BA9-E5375088BE1B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ToolButton.ToolButton_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ToolButton", 
		NodeName = "_ToolButton_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ToolButton_ConstructorCast : INode 
	{
		public Renga.IToolButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IToolButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2C83793E-9E7C-41F2-A84A-06C3AFC57E98", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ToolButton.Action", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ToolButton", 
		NodeName = "Action", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ToolButton", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Action : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Action);

		}
	}


	[NVP_Manifest(
		Id = "8CC13AF7-ACFD-406E-A5B9-9C1FA2829304", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ToolButton.Set_Action", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ToolButton", 
		NodeName = "Set_Action", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ToolButton", typeof(object))]
	[NodeInput("ppAction", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Action : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Action = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D3FBA57E-CEC9-46B3-A91F-112F42E57B5D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ToolButton.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ToolButton", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ToolButton", typeof(object))]

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
		Id = "3DECF2EF-46C4-4526-A960-B26BA5199463", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ToolButton.IdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ToolButton", 
		NodeName = "IdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ToolButton", typeof(object))]

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
}
