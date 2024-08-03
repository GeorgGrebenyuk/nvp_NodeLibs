using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a surface created by extruding an object or a planar face a specified distance and direction
///</summary>
namespace OdaX.AcadExtrudedSurface 
{

	[NVP_Manifest(
		Id = "4330C65C-E567-4E3E-BDED-3144A60F383C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadExtrudedSurface.AcadExtrudedSurface_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadExtrudedSurface", 
		NodeName = "_AcadExtrudedSurface_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadExtrudedSurface_Constructor : INode 
	{
		public OdaX.IAcadExtrudedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadExtrudedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "CC98CFE4-D952-456B-9C04-686EC4ACEB15", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadExtrudedSurface.AcadExtrudedSurface_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadExtrudedSurface", 
		NodeName = "_AcadExtrudedSurface_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadExtrudedSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadExtrudedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadExtrudedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "D0210A89-9971-4E7C-94CB-6FC8250FBEBD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadExtrudedSurface.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadExtrudedSurface", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of the extruded surface.", 
		ViewType = "Data")]
	[NodeInput("AcadExtrudedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the height of the extruded surface.
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Id = "3C1B9F10-FCC7-4246-A0EC-8DB6DB3EB74B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadExtrudedSurface.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadExtrudedSurface", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of the extruded surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadExtrudedSurface", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of the extruded surface.
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "22CEDE9C-C5E5-40BE-A1EB-A94EB8C83FEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadExtrudedSurface.TaperAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadExtrudedSurface", 
		NodeName = "TaperAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the taper angle of the extruded surface.", 
		ViewType = "Data")]
	[NodeInput("AcadExtrudedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the taper angle of the extruded surface.
	///</summary>
	public class TaperAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TaperAngle);

		}
	}


	[NVP_Manifest(
		Id = "2879ADCE-EF2A-4341-81B2-5DF61EAAF7AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadExtrudedSurface.Set_TaperAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadExtrudedSurface", 
		NodeName = "Set_TaperAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the taper angle of the extruded surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadExtrudedSurface", typeof(object))]
	[NodeInput("TaperAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the taper angle of the extruded surface.
	///</summary>
	public class Set_TaperAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TaperAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "39B416BE-BC42-48CA-99B9-0B4A58C0A325", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadExtrudedSurface.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadExtrudedSurface", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the direction of the extruded surface.", 
		ViewType = "Data")]
	[NodeInput("AcadExtrudedSurface", typeof(object))]

	///<summary>
	///Returns the direction of the extruded surface.
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}
}
