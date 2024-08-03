using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a special Block object containing all the entities in the active paper space layout
///</summary>
namespace OdaX.AcadPaperSpace 
{

	[NVP_Manifest(
		Id = "8EE6E41A-2AFE-48C6-8FE4-99DDF364E443", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPaperSpace.AcadPaperSpace_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPaperSpace", 
		NodeName = "_AcadPaperSpace_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPaperSpace_Constructor : INode 
	{
		public OdaX.IAcadPaperSpace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPaperSpace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "FC807655-44D9-4B17-918A-7EB7DA441E5C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPaperSpace.AcadPaperSpace_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPaperSpace", 
		NodeName = "_AcadPaperSpace_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPaperSpace_ConstructorCast : INode 
	{
		public OdaX.IAcadPaperSpace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPaperSpace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FF30339A-0E03-4772-A0F8-590C2626215E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPaperSpace.AddPViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPaperSpace", 
		NodeName = "AddPViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds a paperspace viewport to paperspace.", 
		ViewType = "Data")]
	[NodeInput("AcadPaperSpace", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Adds a paperspace viewport to paperspace.
	///</summary>
	public class AddPViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddPViewport(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}
}
