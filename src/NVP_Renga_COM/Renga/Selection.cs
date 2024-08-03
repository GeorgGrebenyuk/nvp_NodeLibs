using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Selection 
{

	[NVP_Manifest(
		Id = "93518F1B-1804-4B4B-9C5E-C39CB286B636", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Selection.Selection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Selection", 
		NodeName = "_Selection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Selection_Constructor : INode 
	{
		public Renga.ISelection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ISelection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "08978AB9-5D75-464D-9311-012033B1D59C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Selection.Selection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Selection", 
		NodeName = "_Selection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Selection_ConstructorCast : INode 
	{
		public Renga.ISelection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ISelection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "7BFF490B-6068-450D-A052-71B91C042A40", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Selection.GetSelectedObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Selection", 
		NodeName = "GetSelectedObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Selection", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetSelectedObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetSelectedObjects();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "192C4152-9BC2-48A9-8215-E6749C917B94", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Selection.SetSelectedObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Selection", 
		NodeName = "SetSelectedObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Selection", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SetSelectedObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetSelectedObjects();
			return null;
		}
	}
}
