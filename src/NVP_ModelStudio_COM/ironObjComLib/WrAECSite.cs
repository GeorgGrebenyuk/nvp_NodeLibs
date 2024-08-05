using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECSite Interface
///</summary>
namespace ironObjComLib.WrAECSite 
{

	[NVP_Manifest(
		Id = "66882BC4-6F78-4ECB-AC1D-1ED0FE18B0F1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.WrAECSite_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "_WrAECSite_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECSite_Constructor : INode 
	{
		public ironObjComLib.IWrAECSite _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECSite;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "71704A1B-5BC7-403F-ABD0-94A607AB7663", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.WrAECSite_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "_WrAECSite_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECSite_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECSite _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECSite;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "90B18221-7781-4CAA-82D2-901E0DB37910", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Параметры
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Id = "6EB78086-B871-4F05-9737-A8E1709740B0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSite", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "42A597AE-76BB-4A99-9A63-19F22A998B9D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.SiteArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "SiteArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Площадь площадки 3D,кв.м", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Площадь площадки 3D,кв.м
	///</summary>
	public class SiteArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SiteArea);

		}
	}


	[NVP_Manifest(
		Id = "CD2BC998-6545-4B1B-B4A6-A951FD423A72", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.SiteAreaSlope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "SiteAreaSlope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Площадь откосов 3D,кв.м", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Площадь откосов 3D,кв.м
	///</summary>
	public class SiteAreaSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SiteAreaSlope);

		}
	}


	[NVP_Manifest(
		Id = "97BF01C2-D7B9-4950-872F-BB7CFBCEC5CC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.SiteAreaFull", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "SiteAreaFull", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Площадь полная 3D,кв.м", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Площадь полная 3D,кв.м
	///</summary>
	public class SiteAreaFull : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SiteAreaFull);

		}
	}


	[NVP_Manifest(
		Id = "87F582A1-F63F-40E6-9828-8746A342C2C2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.SiteArea2DFull", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "SiteArea2DFull", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Площадь полная 2D,кв.м", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Площадь полная 2D,кв.м
	///</summary>
	public class SiteArea2DFull : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SiteArea2DFull);

		}
	}


	[NVP_Manifest(
		Id = "6FC4C4C9-918A-49C0-832D-741A24204FE3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.SitePerimeter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "SitePerimeter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Периметр в плане,м", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Периметр в плане,м
	///</summary>
	public class SitePerimeter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SitePerimeter);

		}
	}


	[NVP_Manifest(
		Id = "3760B5CB-EE31-4B0A-9596-137D550B1346", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.SitePerimeterFull", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "SitePerimeterFull", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Периметр внешний в плане,м", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Периметр внешний в плане,м
	///</summary>
	public class SitePerimeterFull : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SitePerimeterFull);

		}
	}


	[NVP_Manifest(
		Id = "2994A163-0579-467B-8EBA-81529E488664", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.DrawSite", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "DrawSite", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рисовать контур площадки", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Рисовать контур площадки
	///</summary>
	public class DrawSite : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawSite);

		}
	}


	[NVP_Manifest(
		Id = "AABB0EF3-28D3-430C-A1F1-06B62CC1A535", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.Set_DrawSite", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "Set_DrawSite", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рисовать контур площадки", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSite", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рисовать контур площадки
	///</summary>
	public class Set_DrawSite : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawSite = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "203C564D-7230-4868-AF65-AA58A3121CBC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.DrawSlope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "DrawSlope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рисовать откосы", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Рисовать откосы
	///</summary>
	public class DrawSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawSlope);

		}
	}


	[NVP_Manifest(
		Id = "FBD21647-1032-4591-9FDC-76AA8C31A489", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.Set_DrawSlope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "Set_DrawSlope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рисовать откосы", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSite", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рисовать откосы
	///</summary>
	public class Set_DrawSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawSlope = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BBB5FCCF-79F1-42CB-9449-612A83D28BF6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.DrawGrid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "DrawGrid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рисовать сетку", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Рисовать сетку
	///</summary>
	public class DrawGrid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawGrid);

		}
	}


	[NVP_Manifest(
		Id = "DD3DAD24-F656-4255-9A0F-63548F445819", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.Set_DrawGrid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "Set_DrawGrid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рисовать сетку", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSite", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рисовать сетку
	///</summary>
	public class Set_DrawGrid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawGrid = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F60C9418-F2D1-4E78-A595-BA141F286DD9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.SlopeAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "SlopeAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол откоса,град", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Угол откоса,град
	///</summary>
	public class SlopeAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlopeAngle);

		}
	}


	[NVP_Manifest(
		Id = "7C08495F-A520-4369-B9B5-098A8A9B9A27", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.Set_SlopeAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "Set_SlopeAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол откоса,град", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSite", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол откоса,град
	///</summary>
	public class Set_SlopeAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SlopeAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1614B6BD-C24C-43D7-BECE-F8433B15D9E4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.GridAngleXY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "GridAngleXY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол сетки в плане", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Угол сетки в плане
	///</summary>
	public class GridAngleXY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GridAngleXY);

		}
	}


	[NVP_Manifest(
		Id = "FC2A9CF6-F410-43BE-A702-AAE3DB8DAFFF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSite.Set_GridAngleXY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSite", 
		NodeName = "Set_GridAngleXY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол сетки в плане", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSite", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол сетки в плане
	///</summary>
	public class Set_GridAngleXY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GridAngleXY = inputs[1].Value;
			return null;
		}
	}
}
