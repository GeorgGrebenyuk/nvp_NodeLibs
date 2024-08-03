using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.LevelObject 
{

	[NVP_Manifest(
		Id = "A91D7186-9CD0-414C-9FB2-7ED3E94ACF8D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LevelObject.LevelObject_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LevelObject", 
		NodeName = "_LevelObject_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LevelObject_Constructor : INode 
	{
		public Renga.ILevelObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILevelObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8DD2CB54-973D-45AE-9466-C5EDC5ECD981", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LevelObject.LevelObject_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LevelObject", 
		NodeName = "_LevelObject_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LevelObject_ConstructorCast : INode 
	{
		public Renga.ILevelObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILevelObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "6C11D466-4D8D-4F4B-A3F6-BDD9F8992D29", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LevelObject.LevelId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LevelObject", 
		NodeName = "LevelId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LevelObject", typeof(object))]

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


	[NVP_Manifest(
		Id = "38D0F2A2-246F-4DDE-A5C7-0184F2A7FE11", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LevelObject.VerticalOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LevelObject", 
		NodeName = "VerticalOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LevelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class VerticalOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalOffset);

		}
	}


	[NVP_Manifest(
		Id = "549277FD-94D4-4763-BF68-C229F1775CEA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LevelObject.PlacementElevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LevelObject", 
		NodeName = "PlacementElevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LevelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PlacementElevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlacementElevation);

		}
	}


	[NVP_Manifest(
		Id = "EEF2FB88-911F-40B8-BED7-2638EB1ADFC2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LevelObject.ElevationAboveLevel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LevelObject", 
		NodeName = "ElevationAboveLevel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LevelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ElevationAboveLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElevationAboveLevel);

		}
	}
}
