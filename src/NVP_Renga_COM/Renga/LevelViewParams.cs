using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.LevelViewParams 
{

	[NVP_Manifest(
		Id = "5D7151AB-370B-4426-8A16-AB39F277F876", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LevelViewParams.LevelViewParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LevelViewParams", 
		NodeName = "_LevelViewParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LevelViewParams_Constructor : INode 
	{
		public Renga.ILevelViewParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILevelViewParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "75A53C7E-D03F-417D-9B3D-470FB62E00D9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LevelViewParams.LevelViewParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LevelViewParams", 
		NodeName = "_LevelViewParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LevelViewParams_ConstructorCast : INode 
	{
		public Renga.ILevelViewParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILevelViewParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "99F542B1-7DA7-494A-89D2-85C7B763CC7A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LevelViewParams.LevelId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LevelViewParams", 
		NodeName = "LevelId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LevelViewParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LevelId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LevelId);

		}
	}
}
