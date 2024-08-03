using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///Polyface mesh extended interface
///</summary>
namespace OdaX.OdaPolyfaceMesh 
{

	[NVP_Manifest(
		Id = "6FDD193A-3B91-4FE6-99DE-DE8DD055ADB4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaPolyfaceMesh.OdaPolyfaceMesh_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaPolyfaceMesh", 
		NodeName = "_OdaPolyfaceMesh_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaPolyfaceMesh_Constructor : INode 
	{
		public OdaX.IOdaPolyfaceMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaPolyfaceMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3C647134-5FF0-4DC8-9DE5-BEC11CC7E2B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaPolyfaceMesh.OdaPolyfaceMesh_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaPolyfaceMesh", 
		NodeName = "_OdaPolyfaceMesh_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaPolyfaceMesh_ConstructorCast : INode 
	{
		public OdaX.IOdaPolyfaceMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaPolyfaceMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "774B118D-F07D-48EE-B20D-62303795D2B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaPolyfaceMesh.GetFaces", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaPolyfaceMesh", 
		NodeName = "GetFaces", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaPolyfaceMesh", typeof(object))]
	[NodeInput("__MIDL__IOdaPolyfaceMesh0000", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetFaces : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetFaces(inputs[1].Value);
			return null;
		}
	}
}
