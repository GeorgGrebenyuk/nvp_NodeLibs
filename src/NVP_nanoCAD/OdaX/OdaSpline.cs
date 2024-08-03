using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///ODA extended spline interface, for roundtrip purposes
///</summary>
namespace OdaX.OdaSpline 
{

	[NVP_Manifest(
		Id = "3C977592-C299-4F99-94A9-1F0DA14EFF65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaSpline.OdaSpline_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaSpline", 
		NodeName = "_OdaSpline_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaSpline_Constructor : INode 
	{
		public OdaX.IOdaSpline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaSpline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "CB3FE6FC-AD8B-413D-BFCB-BD838F5757F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaSpline.OdaSpline_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaSpline", 
		NodeName = "_OdaSpline_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaSpline_ConstructorCast : INode 
	{
		public OdaX.IOdaSpline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaSpline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E519292E-06A4-477B-9859-13F24D1C0050", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaSpline.SetNurbsData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaSpline", 
		NodeName = "SetNurbsData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Set all nurbs data to the spline", 
		ViewType = "Modifier")]
	[NodeInput("OdaSpline", typeof(object))]
	[NodeInput("Degree", typeof(System.Int32))]
	[NodeInput("ControlPoints", typeof(System.Object))]
	[NodeInput("Knots", typeof(System.Object))]
	[NodeInput("Weights", typeof(System.Object))]
	[NodeInput("controlPtTolerance", typeof(System.Double))]
	[NodeInput("knotTolerance", typeof(System.Double))]
	[NodeInput("periodic", typeof(System.Object))]

	///<summary>
	///Set all nurbs data to the spline
	///</summary>
	public class SetNurbsData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetNurbsData(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value,inputs[7].Value);
			return null;
		}
	}
}
