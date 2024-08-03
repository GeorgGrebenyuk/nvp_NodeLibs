using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a surface created by revolving one or more 2D objects about an axis
///</summary>
namespace OdaX.AcadRevolvedSurface 
{

	[NVP_Manifest(
		Id = "189AB19D-DC89-4C77-9173-8CB88929992B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRevolvedSurface.AcadRevolvedSurface_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRevolvedSurface", 
		NodeName = "_AcadRevolvedSurface_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRevolvedSurface_Constructor : INode 
	{
		public OdaX.IAcadRevolvedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadRevolvedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BFBF480B-83A3-4930-A64F-A1078973D02E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRevolvedSurface.AcadRevolvedSurface_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRevolvedSurface", 
		NodeName = "_AcadRevolvedSurface_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRevolvedSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadRevolvedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadRevolvedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "6096547A-5252-426B-BBAA-61F449159D0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRevolvedSurface.RevolutionAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRevolvedSurface", 
		NodeName = "RevolutionAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the angle of revolution for a revolved surface.", 
		ViewType = "Data")]
	[NodeInput("AcadRevolvedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the angle of revolution for a revolved surface.
	///</summary>
	public class RevolutionAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RevolutionAngle);

		}
	}


	[NVP_Manifest(
		Id = "F49FC383-A982-48E2-82D5-8C9D32EAD19C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRevolvedSurface.Set_RevolutionAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRevolvedSurface", 
		NodeName = "Set_RevolutionAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the angle of revolution for a revolved surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadRevolvedSurface", typeof(object))]
	[NodeInput("revAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the angle of revolution for a revolved surface.
	///</summary>
	public class Set_RevolutionAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RevolutionAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2098EEC9-90CD-4181-B078-8134D5A78A5B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRevolvedSurface.AxisPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRevolvedSurface", 
		NodeName = "AxisPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the revolution axis for a revolved surface.", 
		ViewType = "Data")]
	[NodeInput("AcadRevolvedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the start point of the revolution axis for a revolved surface.
	///</summary>
	public class AxisPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisPosition);

		}
	}


	[NVP_Manifest(
		Id = "2D132A99-1989-44D4-BD92-E5FE77BC5581", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRevolvedSurface.Set_AxisPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRevolvedSurface", 
		NodeName = "Set_AxisPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the revolution axis for a revolved surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadRevolvedSurface", typeof(object))]
	[NodeInput("AxisPosition", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start point of the revolution axis for a revolved surface.
	///</summary>
	public class Set_AxisPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AxisPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7854A8EF-EF05-4DC9-94FF-B3DBCB8EDEF7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRevolvedSurface.AxisDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRevolvedSurface", 
		NodeName = "AxisDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the direction of the revolution axis for a revolved surface.", 
		ViewType = "Data")]
	[NodeInput("AcadRevolvedSurface", typeof(object))]

	///<summary>
	///Returns the direction of the revolution axis for a revolved surface.
	///</summary>
	public class AxisDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisDirection);

		}
	}
}
