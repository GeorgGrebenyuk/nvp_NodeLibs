using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ObjectWithMaterial 
{

	[NVP_Manifest(
		Id = "0DD1137B-0F1A-4D5E-B8FB-DE0BEF23E0A1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithMaterial.ObjectWithMaterial_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithMaterial", 
		NodeName = "_ObjectWithMaterial_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectWithMaterial_Constructor : INode 
	{
		public Renga.IObjectWithMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IObjectWithMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "260B73C5-48A2-4C4F-B503-8F6DCD9945DB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithMaterial.ObjectWithMaterial_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithMaterial", 
		NodeName = "_ObjectWithMaterial_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectWithMaterial_ConstructorCast : INode 
	{
		public Renga.IObjectWithMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IObjectWithMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0DED777E-4C4D-4692-A7FB-803A750483B8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithMaterial.MaterialId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithMaterial", 
		NodeName = "MaterialId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ObjectWithMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MaterialId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaterialId);

		}
	}


	[NVP_Manifest(
		Id = "C891550C-3AF2-48B2-A808-427AD5CFC79C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithMaterial.HasMaterial", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithMaterial", 
		NodeName = "HasMaterial", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ObjectWithMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasMaterial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasMaterial);

		}
	}
}
