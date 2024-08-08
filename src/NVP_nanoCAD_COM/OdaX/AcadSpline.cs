using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///nonuniform rational B-spline) curve entity
///</summary>
namespace OdaX.AcadSpline 
{

	[NVP_Manifest(
		Id = "927F4FE1-DD51-432E-8822-5BB30BCD3CBF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.AcadSpline_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "_AcadSpline_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSpline_Constructor : INode 
	{
		public OdaX.IAcadSpline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSpline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "84D67439-D138-4E96-91C9-228A8A767F58", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.AcadSpline_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "_AcadSpline_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSpline_ConstructorCast : INode 
	{
		public OdaX.IAcadSpline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSpline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "20037D47-C9A6-4CCD-818E-439039293D2F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.NumberOfControlPoints", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "NumberOfControlPoints", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of control points defined for a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the number of control points defined for a spline.
	///</summary>
	public class NumberOfControlPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfControlPoints);

		}
	}


	[NVP_Manifest(
		Id = "F62D912D-7303-45C3-859B-184A89508541", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.ControlPoints", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "ControlPoints", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of control points defined for a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the number of control points defined for a spline.
	///</summary>
	public class ControlPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ControlPoints);

		}
	}


	[NVP_Manifest(
		Id = "F3D1339F-5685-47A5-A57D-1C961D1B5A28", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Set_ControlPoints", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Set_ControlPoints", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of control points defined for a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("controlPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of control points defined for a spline.
	///</summary>
	public class Set_ControlPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ControlPoints = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "31BE53AF-01D8-41B3-BABA-E090D13E2ED1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.NumberOfFitPoints", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "NumberOfFitPoints", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current control point of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the current control point of a spline.
	///</summary>
	public class NumberOfFitPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfFitPoints);

		}
	}


	[NVP_Manifest(
		Id = "EB89DF63-C4C2-4592-8FE3-C9E8F1D74809", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.FitPoints", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "FitPoints", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current fit points of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the current fit points of a spline.
	///</summary>
	public class FitPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FitPoints);

		}
	}


	[NVP_Manifest(
		Id = "F0775C8C-5863-490E-AA07-AE6394E25F85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Set_FitPoints", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Set_FitPoints", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current fit points of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("fitPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the current fit points of a spline.
	///</summary>
	public class Set_FitPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FitPoints = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8A3B3F99-4E68-47EC-839F-371592ADE855", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Degree", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Degree", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the degree of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Returns the degree of a spline.
	///</summary>
	public class Degree : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Degree);

		}
	}


	[NVP_Manifest(
		Id = "F758CEEF-CB25-4016-9C91-9B835A360CD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether a spline is closed.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Returns whether a spline is closed.
	///</summary>
	public class Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Closed);

		}
	}


	[NVP_Manifest(
		Id = "77E078E6-D1B3-4FAC-A0F5-C09742E931AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.IsPlanar", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "IsPlanar", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether a spline is planar.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Returns whether a spline is planar.
	///</summary>
	public class IsPlanar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPlanar);

		}
	}


	[NVP_Manifest(
		Id = "C1D9D5E0-62BF-4A6F-8D2C-FFA8BD291D00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.IsRational", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "IsRational", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether a spline is rational.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Returns whether a spline is rational.
	///</summary>
	public class IsRational : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsRational);

		}
	}


	[NVP_Manifest(
		Id = "28D1FF60-2D19-46E4-B772-DEE86B615471", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.IsPeriodic", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "IsPeriodic", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether a spline is periodic.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Returns whether a spline is periodic.
	///</summary>
	public class IsPeriodic : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPeriodic);

		}
	}


	[NVP_Manifest(
		Id = "5902085B-A807-4712-9BBD-1945CD9384EA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.StartTangent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "StartTangent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z coordinate for the start tangent of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinate for the start tangent of a spline.
	///</summary>
	public class StartTangent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartTangent);

		}
	}


	[NVP_Manifest(
		Id = "F9C904C8-DEA1-4A65-AEF0-059A07AA8940", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Set_StartTangent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Set_StartTangent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z coordinate for the start tangent of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("StartTangent", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinate for the start tangent of a spline.
	///</summary>
	public class Set_StartTangent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartTangent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "27E98E28-CD48-43A7-9F24-2B7B0EDC1B4B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.EndTangent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "EndTangent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z coordinate for the end tangent of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinate for the end tangent of a spline.
	///</summary>
	public class EndTangent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndTangent);

		}
	}


	[NVP_Manifest(
		Id = "716C49F9-F0FE-4C6F-B535-B44EDB179526", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Set_EndTangent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Set_EndTangent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z coordinate for the end tangent of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("EndTangent", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinate for the end tangent of a spline.
	///</summary>
	public class Set_EndTangent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndTangent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6CBA4FDE-C40B-492E-9E1A-6F25E69FDEAB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.FitTolerance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "FitTolerance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the fit tolerance of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the fit tolerance of a spline.
	///</summary>
	public class FitTolerance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FitTolerance);

		}
	}


	[NVP_Manifest(
		Id = "7D18878E-A9E8-49D9-B505-C3304F4C2A1B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Set_FitTolerance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Set_FitTolerance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the fit tolerance of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("fitTol", typeof(System.Double))]

	///<summary>
	///Specifies or returns the fit tolerance of a spline.
	///</summary>
	public class Set_FitTolerance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FitTolerance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2238AA1A-EFF1-4F20-96F8-5DE6A4528CA1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Area", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Area", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the area of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Not implemented. Returns the area of a spline.
	///</summary>
	public class Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Area);

		}
	}


	[NVP_Manifest(
		Id = "6B865823-1187-4AF0-930E-942014E17EF5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.SetControlPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "SetControlPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the coordinates for a control point of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("controlPoint", typeof(System.Object))]

	///<summary>
	///Specifies the coordinates for a control point of a spline.
	///</summary>
	public class SetControlPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetControlPoint(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D7C31BC9-440D-45A8-A181-F63334FCCDED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.GetControlPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "GetControlPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the coordinates for a control point of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the coordinates for a control point of a spline.
	///</summary>
	public class GetControlPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetControlPoint(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "D322CB0D-9369-437F-A8B7-21FE8D7AAD5C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.SetFitPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "SetFitPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the fit point of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("fitPoint", typeof(System.Object))]

	///<summary>
	///Specifies the fit point of a spline.
	///</summary>
	public class SetFitPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFitPoint(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "601D97C2-86BA-4B05-8C6F-764824E2EFBA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.GetFitPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "GetFitPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the fit point of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the fit point of a spline.
	///</summary>
	public class GetFitPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFitPoint(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "89521EDB-AF2F-43C7-A147-B68518C995BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.SetWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "SetWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the weight of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("weight", typeof(System.Double))]

	///<summary>
	///Specifies the weight of a spline.
	///</summary>
	public class SetWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetWeight(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BE4EC591-A846-4990-9E51-ECBC1467ED54", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.GetWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "GetWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the weight of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the weight of a spline.
	///</summary>
	public class GetWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetWeight(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "C307FEBA-5887-4EA4-96BC-95E320CC4112", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.AddFitPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "AddFitPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds a fit point to a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("fitPoint", typeof(System.Object))]

	///<summary>
	///Adds a fit point to a spline.
	///</summary>
	public class AddFitPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddFitPoint(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0C5B6568-E61C-488E-9D67-CA22B92CBCEF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.DeleteFitPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "DeleteFitPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a fit point from a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Deletes a fit point from a spline.
	///</summary>
	public class DeleteFitPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteFitPoint(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A12562DF-0268-40EB-A5B1-2DDBB8AF690C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.ElevateOrder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "ElevateOrder", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Increases the order of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Order", typeof(System.Int32))]

	///<summary>
	///Not implemented. Increases the order of a spline.
	///</summary>
	public class ElevateOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ElevateOrder(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "78984883-F7AB-4674-99F6-A651BC152367", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Offset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Offset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Creates a new spline at a specified distance from an original spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates a new spline at a specified distance from an original spline.
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "AD156A7B-EA9D-4F14-93DA-552F3C299EF2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.PurgeFitData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "PurgeFitData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Removes the fit data of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Removes the fit data of a spline.
	///</summary>
	public class PurgeFitData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PurgeFitData();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2CDD8090-E402-47E0-BB13-B5C878F0C7A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Reverse", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Reverse", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Reverses the direction of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Reverses the direction of a spline.
	///</summary>
	public class Reverse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Reverse();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "78CA040D-32EB-4F2B-AD26-91BE64ED62FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Knots", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Knots", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the knot vector of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the knot vector of a spline.
	///</summary>
	public class Knots : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Knots);

		}
	}


	[NVP_Manifest(
		Id = "BCA4297F-E1C4-48C0-9ABC-969E4DFAC1F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Set_Knots", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Set_Knots", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the knot vector of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("KnotValues", typeof(System.Object))]

	///<summary>
	///Specifies or returns the knot vector of a spline.
	///</summary>
	public class Set_Knots : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Knots = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "48FB6186-132A-4195-958A-8E729AF2DBFB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Weights", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Weights", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the weight vector of a spline.", 
		ViewType = "Data")]
	[NodeInput("AcadSpline", typeof(object))]

	///<summary>
	///Specifies or returns the weight vector of a spline.
	///</summary>
	public class Weights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Weights);

		}
	}


	[NVP_Manifest(
		Id = "7A629030-E877-4071-8206-D540CBF08214", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSpline.Set_Weights", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSpline", 
		NodeName = "Set_Weights", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the weight vector of a spline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSpline", typeof(object))]
	[NodeInput("WeightValues", typeof(System.Object))]

	///<summary>
	///Specifies or returns the weight vector of a spline.
	///</summary>
	public class Set_Weights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Weights = inputs[1].Value;
			return null;
		}
	}
}
