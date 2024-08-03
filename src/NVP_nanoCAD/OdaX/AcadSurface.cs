using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of Surface entity
///</summary>
namespace OdaX.AcadSurface 
{

	[NVP_Manifest(
		Id = "78AD7BC4-C21D-4F60-BA6C-943C82626CEF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSurface.AcadSurface_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSurface", 
		NodeName = "_AcadSurface_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSurface_Constructor : INode 
	{
		public OdaX.IAcadSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E7A5ABFB-F4CF-4E8C-BFCD-74B5DBD32EF3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSurface.AcadSurface_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSurface", 
		NodeName = "_AcadSurface_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "48CD93F1-3D26-444C-8D32-7676804B7A9E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSurface.SurfaceType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSurface", 
		NodeName = "SurfaceType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the type of a surface.", 
		ViewType = "Data")]
	[NodeInput("AcadSurface", typeof(object))]

	///<summary>
	///Returns the type of a surface.
	///</summary>
	public class SurfaceType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SurfaceType);

		}
	}


	[NVP_Manifest(
		Id = "63009771-861A-4BAB-AAA0-A4704D4F8108", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSurface.UIsolineDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSurface", 
		NodeName = "UIsolineDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of U isolines per surface that display.", 
		ViewType = "Data")]
	[NodeInput("AcadSurface", typeof(object))]

	///<summary>
	///Specifies or returns the number of U isolines per surface that display.
	///</summary>
	public class UIsolineDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UIsolineDensity);

		}
	}


	[NVP_Manifest(
		Id = "E58855CE-B7D4-4D2A-B799-D334E1EC7E9E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSurface.Set_UIsolineDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSurface", 
		NodeName = "Set_UIsolineDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of U isolines per surface that display.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSurface", typeof(object))]
	[NodeInput("density", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of U isolines per surface that display.
	///</summary>
	public class Set_UIsolineDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UIsolineDensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "10BDE91A-E264-444A-A14E-34A57BD20F6E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSurface.VIsolineDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSurface", 
		NodeName = "VIsolineDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of V isolines per surface that display.", 
		ViewType = "Data")]
	[NodeInput("AcadSurface", typeof(object))]

	///<summary>
	///Specifies or returns the number of V isolines per surface that display.
	///</summary>
	public class VIsolineDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VIsolineDensity);

		}
	}


	[NVP_Manifest(
		Id = "00C50FB6-7E26-4384-BF62-2FD5D3A3351A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSurface.Set_VIsolineDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSurface", 
		NodeName = "Set_VIsolineDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of V isolines per surface that display.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSurface", typeof(object))]
	[NodeInput("density", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of V isolines per surface that display.
	///</summary>
	public class Set_VIsolineDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VIsolineDensity = inputs[1].Value;
			return null;
		}
	}
}
