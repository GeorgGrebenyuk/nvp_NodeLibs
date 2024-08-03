using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an area fill consisting of a pattern of lines
///</summary>
namespace OdaX.AcadHatch2 
{

	[NVP_Manifest(
		Id = "1902200F-2FFD-4F22-A598-9F02A3A7F76E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch2.AcadHatch2_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch2", 
		NodeName = "_AcadHatch2_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadHatch2_Constructor : INode 
	{
		public OdaX.IAcadHatch2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadHatch2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "15129B46-3FA9-468F-A04E-FF821CAD9856", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch2.AcadHatch2_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch2", 
		NodeName = "_AcadHatch2_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadHatch2_ConstructorCast : INode 
	{
		public OdaX.IAcadHatch2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadHatch2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "9097D201-6A07-4CAB-9CCA-347B4845E880", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch2.BackgroundColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch2", 
		NodeName = "BackgroundColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the hatch background color.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch2", typeof(object))]

	///<summary>
	///Returns the hatch background color.
	///</summary>
	public class BackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundColor);

		}
	}


	[NVP_Manifest(
		Id = "A6CEF000-616E-44AE-94EF-8F03A346790B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch2.Set_BackgroundColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch2", 
		NodeName = "Set_BackgroundColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the hatch background color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch2", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Returns the hatch background color.
	///</summary>
	public class Set_BackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundColor = inputs[1].Value;
			return null;
		}
	}
}
