using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a surface created by lofting through a set of two or more curves
///</summary>
namespace OdaX.AcadLoftedSurface 
{

	[NVP_Manifest(
		Id = "A64701E7-9B42-4A2F-8CDE-BFCEF1B598C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.AcadLoftedSurface_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "_AcadLoftedSurface_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLoftedSurface_Constructor : INode 
	{
		public OdaX.IAcadLoftedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadLoftedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D60E8B4E-595D-467F-B1AE-CA98B0D33EA8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.AcadLoftedSurface_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "_AcadLoftedSurface_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLoftedSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadLoftedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadLoftedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "F46B577A-180F-401F-AAD6-C712324D40D5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.NumCrossSections", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "NumCrossSections", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of cross-sections used to create a lofted surface.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Returns the number of cross-sections used to create a lofted surface.
	///</summary>
	public class NumCrossSections : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumCrossSections);

		}
	}


	[NVP_Manifest(
		Id = "63730641-F949-4EF1-B29F-55653EA182D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.NumGuidePaths", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "NumGuidePaths", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of guide paths used to create a lofted surface.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Returns the number of guide paths used to create a lofted surface.
	///</summary>
	public class NumGuidePaths : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumGuidePaths);

		}
	}


	[NVP_Manifest(
		Id = "75FF8689-27F4-4E86-B947-441FD17EDA96", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.SurfaceNormals", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "SurfaceNormals", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns which curves are normal to the cross-sections.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Specifies or returns which curves are normal to the cross-sections.
	///</summary>
	public class SurfaceNormals : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SurfaceNormals);

		}
	}


	[NVP_Manifest(
		Id = "6DA626D9-3D43-48B3-903B-3F7CCE3D28FE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.Set_SurfaceNormals", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "Set_SurfaceNormals", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns which curves are normal to the cross-sections.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLoftedSurface", typeof(object))]
	[NodeInput("OdaX.AcLoftedSurfaceNormalType", typeof(System.Object))]

	///<summary>
	///Specifies or returns which curves are normal to the cross-sections.
	///</summary>
	public class Set_SurfaceNormals : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SurfaceNormals = ((OdaX.AcLoftedSurfaceNormalType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "293B8A61-BE5C-446E-B3C1-FFE18DE7B8AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.StartDraftAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "StartDraftAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the angle of the first cross-section surface.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the angle of the first cross-section surface.
	///</summary>
	public class StartDraftAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartDraftAngle);

		}
	}


	[NVP_Manifest(
		Id = "300286FD-422E-4620-B9DB-F6FD68DC6973", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.Set_StartDraftAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "Set_StartDraftAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the angle of the first cross-section surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLoftedSurface", typeof(object))]
	[NodeInput("StartDraftAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the angle of the first cross-section surface.
	///</summary>
	public class Set_StartDraftAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartDraftAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "867607A5-5187-410A-A404-CCA3FAB19929", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.StartDraftMagnitude", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "StartDraftMagnitude", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the magnitude of the first cross-section surface.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the magnitude of the first cross-section surface.
	///</summary>
	public class StartDraftMagnitude : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartDraftMagnitude);

		}
	}


	[NVP_Manifest(
		Id = "0483EE1B-3E34-42CE-97D3-ECD5B814CACA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.Set_StartDraftMagnitude", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "Set_StartDraftMagnitude", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the magnitude of the first cross-section surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLoftedSurface", typeof(object))]
	[NodeInput("startDraftMag", typeof(System.Double))]

	///<summary>
	///Specifies or returns the magnitude of the first cross-section surface.
	///</summary>
	public class Set_StartDraftMagnitude : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartDraftMagnitude = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6A85936B-E477-4B70-940F-F0942C21A8D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.EndDraftAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "EndDraftAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the angle of the last cross-section surface.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the angle of the last cross-section surface.
	///</summary>
	public class EndDraftAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndDraftAngle);

		}
	}


	[NVP_Manifest(
		Id = "EB937A74-8F15-4369-ACDD-84199011E347", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.Set_EndDraftAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "Set_EndDraftAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the angle of the last cross-section surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLoftedSurface", typeof(object))]
	[NodeInput("EndDraftAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the angle of the last cross-section surface.
	///</summary>
	public class Set_EndDraftAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndDraftAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F9762AA8-F014-450D-8CD7-2090B477F2C8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.EndDraftMagnitude", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "EndDraftMagnitude", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the magnitude of the last cross-section surface.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the magnitude of the last cross-section surface.
	///</summary>
	public class EndDraftMagnitude : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndDraftMagnitude);

		}
	}


	[NVP_Manifest(
		Id = "706DDD92-38DC-465D-81B1-FA4D8B3C2FEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.Set_EndDraftMagnitude", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "Set_EndDraftMagnitude", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the magnitude of the last cross-section surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLoftedSurface", typeof(object))]
	[NodeInput("endDraftMag", typeof(System.Double))]

	///<summary>
	///Specifies or returns the magnitude of the last cross-section surface.
	///</summary>
	public class Set_EndDraftMagnitude : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndDraftMagnitude = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D3FBDDCC-1955-4F46-A0C8-820B3A503BB0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specfies or returns whether the lofted surface is open or closed.", 
		ViewType = "Data")]
	[NodeInput("AcadLoftedSurface", typeof(object))]

	///<summary>
	///Specfies or returns whether the lofted surface is open or closed.
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
		Id = "E37A42B4-20C1-42AF-AEFC-1F0C83859EB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadLoftedSurface.Set_Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadLoftedSurface", 
		NodeName = "Set_Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specfies or returns whether the lofted surface is open or closed.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLoftedSurface", typeof(object))]
	[NodeInput("bClosed", typeof(System.Object))]

	///<summary>
	///Specfies or returns whether the lofted surface is open or closed.
	///</summary>
	public class Set_Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Closed = inputs[1].Value;
			return null;
		}
	}
}
