using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.EquipmentStyle 
{

	[NVP_Manifest(
		Id = "3CB3520B-9E22-497E-98DC-473A36B28F32", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EquipmentStyle.EquipmentStyle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EquipmentStyle", 
		NodeName = "_EquipmentStyle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class EquipmentStyle_Constructor : INode 
	{
		public Renga.IEquipmentStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IEquipmentStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F202A3F4-0172-4D11-86A8-750D9749E2EB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EquipmentStyle.EquipmentStyle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EquipmentStyle", 
		NodeName = "_EquipmentStyle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class EquipmentStyle_ConstructorCast : INode 
	{
		public Renga.IEquipmentStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IEquipmentStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "B2D4C0D7-E2C1-4A4C-BA08-38E227CDD3FE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EquipmentStyle.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EquipmentStyle", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("EquipmentStyle", typeof(object))]

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
		Id = "5D1E0F8C-BC1D-4E64-9BB7-CB0CD17E94D7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EquipmentStyle.Category", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EquipmentStyle", 
		NodeName = "Category", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("EquipmentStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Category : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Category);

		}
	}
}
