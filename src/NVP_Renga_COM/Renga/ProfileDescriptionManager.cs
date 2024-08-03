using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ProfileDescriptionManager 
{

	[NVP_Manifest(
		Id = "900B528E-1BCC-4872-A99B-033561ECA7BA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProfileDescriptionManager.ProfileDescriptionManager_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProfileDescriptionManager", 
		NodeName = "_ProfileDescriptionManager_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ProfileDescriptionManager_Constructor : INode 
	{
		public Renga.IProfileDescriptionManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IProfileDescriptionManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "EBADA0CF-B105-4C9C-9205-146FBFFFB041", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProfileDescriptionManager.ProfileDescriptionManager_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProfileDescriptionManager", 
		NodeName = "_ProfileDescriptionManager_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ProfileDescriptionManager_ConstructorCast : INode 
	{
		public Renga.IProfileDescriptionManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IProfileDescriptionManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2628021B-10B3-48DD-A137-BBCE25D48A9D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProfileDescriptionManager.GetIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProfileDescriptionManager", 
		NodeName = "GetIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ProfileDescriptionManager", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetIds();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "03F69C60-F46D-428A-AAB2-2C54F645225E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProfileDescriptionManager.Contains", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProfileDescriptionManager", 
		NodeName = "Contains", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ProfileDescriptionManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]

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
		Id = "5B52FC70-7032-4A60-8CC4-09E7F4620344", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProfileDescriptionManager.GetProfileDescription", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProfileDescriptionManager", 
		NodeName = "GetProfileDescription", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ProfileDescriptionManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetProfileDescription : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetProfileDescription(inputs[1].Value));

		}
	}
}
