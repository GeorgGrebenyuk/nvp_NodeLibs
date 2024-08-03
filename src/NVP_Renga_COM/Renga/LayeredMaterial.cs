using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.LayeredMaterial 
{

	[NVP_Manifest(
		Id = "5759E376-E4FB-4CDE-9CE4-F974F7851747", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayeredMaterial.LayeredMaterial_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayeredMaterial", 
		NodeName = "_LayeredMaterial_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LayeredMaterial_Constructor : INode 
	{
		public Renga.ILayeredMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILayeredMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "382530C8-ADCD-4506-BC0C-C5D4A768957C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayeredMaterial.LayeredMaterial_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayeredMaterial", 
		NodeName = "_LayeredMaterial_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LayeredMaterial_ConstructorCast : INode 
	{
		public Renga.ILayeredMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILayeredMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C7D5B185-4F60-4B7A-8E23-27BACC05FE5A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayeredMaterial.GetIdGroupPair", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayeredMaterial", 
		NodeName = "GetIdGroupPair", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIdGroupPair : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIdGroupPair);

		}
	}


	[NVP_Manifest(
		Id = "B413BC49-8172-4558-817C-1D3642BB8404", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayeredMaterial.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayeredMaterial", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LayeredMaterial", typeof(object))]

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
		Id = "8FF42908-5DC4-46AD-AE8A-937236F8617D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayeredMaterial.Layers", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayeredMaterial", 
		NodeName = "Layers", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Layers : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layers);

		}
	}


	[NVP_Manifest(
		Id = "46B76BE3-1049-4D16-8DF3-9AB7AE4931F3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayeredMaterial.GetBaseLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayeredMaterial", 
		NodeName = "GetBaseLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBaseLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBaseLayer);

		}
	}


	[NVP_Manifest(
		Id = "823C941B-A8AF-4E58-B6AC-B011578B278D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayeredMaterial.BaseLayerIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayeredMaterial", 
		NodeName = "BaseLayerIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class BaseLayerIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BaseLayerIndex);

		}
	}


	[NVP_Manifest(
		Id = "3276BC26-3AB0-42E8-85BB-243C8E1B2674", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayeredMaterial.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayeredMaterial", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LayeredMaterial", typeof(object))]

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
}
