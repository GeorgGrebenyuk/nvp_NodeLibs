using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///Interface for an Wipeout Raster Image
///</summary>
namespace OdaX.AcadWipeout 
{

	[NVP_Manifest(
		Id = "B7C9F878-4F12-4B92-A992-DBA08CD6ECED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadWipeout.AcadWipeout_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadWipeout", 
		NodeName = "_AcadWipeout_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadWipeout_Constructor : INode 
	{
		public OdaX.IAcadWipeout _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadWipeout;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BA1886F9-1704-4BBA-A291-15EA049ED60D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadWipeout.AcadWipeout_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadWipeout", 
		NodeName = "_AcadWipeout_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadWipeout_ConstructorCast : INode 
	{
		public OdaX.IAcadWipeout _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadWipeout;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
