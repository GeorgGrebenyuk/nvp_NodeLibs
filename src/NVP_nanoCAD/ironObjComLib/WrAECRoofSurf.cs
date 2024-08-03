using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECRoofSurf Interface
///</summary>
namespace ironObjComLib.WrAECRoofSurf 
{

	[NVP_Manifest(
		Id = "E7B7A467-05C4-4BAF-AF8F-CDA0476305CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.WrAECRoofSurf_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "_WrAECRoofSurf_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECRoofSurf_Constructor : INode 
	{
		public ironObjComLib.IWrAECRoofSurf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECRoofSurf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BCA3B483-F618-4BFD-BF29-8FB45D4F1CBD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.WrAECRoofSurf_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "_WrAECRoofSurf_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECRoofSurf_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECRoofSurf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECRoofSurf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "AD4D25ED-2CBF-4D41-A7EB-13A9E8A552D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrAECRoofSurf", typeof(object))]

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
		Id = "B9F81EFA-7C09-47D6-A0F0-CE265280AA22", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("WrAECRoofSurf", typeof(object))]
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
		Id = "D900A585-2688-4B37-9D51-2977767A0947", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property UnitPosition", 
		ViewType = "Data")]
	[NodeInput("WrAECRoofSurf", typeof(object))]

	///<summary>
	///property UnitPosition
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Id = "C639AD8E-EC19-4188-9A49-40512F97830A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property UnitPosition", 
		ViewType = "Modifier")]
	[NodeInput("WrAECRoofSurf", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property UnitPosition
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "087EA9EF-6719-4CD4-99D5-B47EBB0FFE63", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ROOF_ANGLE", 
		ViewType = "Data")]
	[NodeInput("WrAECRoofSurf", typeof(object))]

	///<summary>
	///property ROOF_ANGLE
	///</summary>
	public class Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Angle);

		}
	}


	[NVP_Manifest(
		Id = "79AFF737-DC07-405D-9644-D9C6FB98F7A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.Set_Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "Set_Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ROOF_ANGLE", 
		ViewType = "Modifier")]
	[NodeInput("WrAECRoofSurf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ROOF_ANGLE
	///</summary>
	public class Set_Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Angle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "89695DC7-9FB5-47B9-A240-005218BE1E8A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_THICKNESS", 
		ViewType = "Data")]
	[NodeInput("WrAECRoofSurf", typeof(object))]

	///<summary>
	///property AEC_PART_THICKNESS
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Id = "29636E06-6482-43C0-B005-93A5AADFFB74", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.Set_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "Set_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_THICKNESS", 
		ViewType = "Modifier")]
	[NodeInput("WrAECRoofSurf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property AEC_PART_THICKNESS
	///</summary>
	public class Set_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E3C33EE1-9F67-4E33-A4E6-6C3662FF2F28", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.BottomOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "BottomOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ROOF_BOTTOM_OFFSET", 
		ViewType = "Data")]
	[NodeInput("WrAECRoofSurf", typeof(object))]

	///<summary>
	///property ROOF_BOTTOM_OFFSET
	///</summary>
	public class BottomOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BottomOffset);

		}
	}


	[NVP_Manifest(
		Id = "D18801F4-E32D-4BC8-B4E1-98F22118A78F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.Set_BottomOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "Set_BottomOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ROOF_BOTTOM_OFFSET", 
		ViewType = "Modifier")]
	[NodeInput("WrAECRoofSurf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ROOF_BOTTOM_OFFSET
	///</summary>
	public class Set_BottomOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BottomOffset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A873B9BC-9CEB-4584-BEEB-9D251E7AD01A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.VetrSide", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "VetrSide", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ROOF_SIDE_VERT", 
		ViewType = "Data")]
	[NodeInput("WrAECRoofSurf", typeof(object))]

	///<summary>
	///property ROOF_SIDE_VERT
	///</summary>
	public class VetrSide : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VetrSide);

		}
	}


	[NVP_Manifest(
		Id = "F0345AB1-8195-4544-9314-B7E43192B5D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECRoofSurf.Set_VetrSide", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECRoofSurf", 
		NodeName = "Set_VetrSide", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ROOF_SIDE_VERT", 
		ViewType = "Modifier")]
	[NodeInput("WrAECRoofSurf", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///property ROOF_SIDE_VERT
	///</summary>
	public class Set_VetrSide : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VetrSide = inputs[1].Value;
			return null;
		}
	}
}
