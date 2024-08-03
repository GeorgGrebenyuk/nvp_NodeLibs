using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Provides an interface to the database resident objects in an TeighaX document
///</summary>
namespace OdaX.AcadDatabase 
{

	[NVP_Manifest(
		Id = "29FF5980-216B-47A3-8A53-884009C86681", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.AcadDatabase_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "_AcadDatabase_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDatabase_Constructor : INode 
	{
		public OdaX.IAcadDatabase _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDatabase;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C0E01BFD-BF87-473E-861A-858A029B9213", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.AcadDatabase_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "_AcadDatabase_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDatabase_ConstructorCast : INode 
	{
		public OdaX.IAcadDatabase _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDatabase;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FA9EF759-007F-4B65-B654-FC7192D1C4F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.ModelSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "ModelSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the ModelSpace collection for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the ModelSpace collection for a document.
	///</summary>
	public class ModelSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModelSpace);

		}
	}


	[NVP_Manifest(
		Id = "2E480116-0E86-44A7-AB32-863E1950B63D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.PaperSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "PaperSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the PaperSpace collection for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the PaperSpace collection for a document.
	///</summary>
	public class PaperSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PaperSpace);

		}
	}


	[NVP_Manifest(
		Id = "78ABAC87-A715-4039-8580-D06920F84751", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Blocks", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Blocks", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Blocks collection for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Blocks collection for a document.
	///</summary>
	public class Blocks : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Blocks);

		}
	}


	[NVP_Manifest(
		Id = "19AF488D-98E9-4323-AF57-0FE976B67C16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.CopyObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "CopyObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Duplicates multiple objects.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("Owner", typeof(System.Object))]
	[NodeInput("IdPairs", typeof(System.Object))]

	///<summary>
	///Duplicates multiple objects.
	///</summary>
	public class CopyObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CopyObjects(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "FD20612F-C4B2-4A31-A1BE-37DA123E11BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Groups", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Groups", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Groups Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Groups Collection object for a document.
	///</summary>
	public class Groups : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Groups);

		}
	}


	[NVP_Manifest(
		Id = "5A6E3CFF-7A51-4AD3-9343-09DD6F758803", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.DimStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "DimStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the DimStyles Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the DimStyles Collection object for a document.
	///</summary>
	public class DimStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimStyles);

		}
	}


	[NVP_Manifest(
		Id = "8EC35D91-DF1A-4586-90DE-3610BF9C41A2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Layers", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Layers", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Layers Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Layers Collection object for a document.
	///</summary>
	public class Layers : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layers);

		}
	}


	[NVP_Manifest(
		Id = "D67D3A07-33CF-4FC8-B6A4-464F64DCB201", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Linetypes", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Linetypes", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Linetypes Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Linetypes Collection object for a document.
	///</summary>
	public class Linetypes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Linetypes);

		}
	}


	[NVP_Manifest(
		Id = "57C46019-9364-4917-A70F-38FE7774DAB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Dictionaries", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Dictionaries", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Dictionaries Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Dictionaries Collection object for a document.
	///</summary>
	public class Dictionaries : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Dictionaries);

		}
	}


	[NVP_Manifest(
		Id = "0A36DB8E-4850-4A4A-9D2A-FFA7D0C72BB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.RegisteredApplications", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "RegisteredApplications", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the RegisteredApplications Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the RegisteredApplications Collection object for a document.
	///</summary>
	public class RegisteredApplications : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RegisteredApplications);

		}
	}


	[NVP_Manifest(
		Id = "26579FD6-6AFF-472C-ABDC-877627757B69", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.TextStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "TextStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the TextStyles Collection object of a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the TextStyles Collection object of a document.
	///</summary>
	public class TextStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyles);

		}
	}


	[NVP_Manifest(
		Id = "CDE21D08-579E-4552-B0EA-A6AF0AE274A7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.UserCoordinateSystems", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "UserCoordinateSystems", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the UCSs Collection object of a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the UCSs Collection object of a document.
	///</summary>
	public class UserCoordinateSystems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UserCoordinateSystems);

		}
	}


	[NVP_Manifest(
		Id = "32F2D701-FABB-40D1-985F-6BFFA6741DEF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Views", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Views", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Views Collection object of a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Views Collection object of a document.
	///</summary>
	public class Views : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Views);

		}
	}


	[NVP_Manifest(
		Id = "5D73637E-E3F7-48E3-805A-86FD1600398D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Viewports", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Viewports", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Viewports Collection object of a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Viewports Collection object of a document.
	///</summary>
	public class Viewports : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Viewports);

		}
	}


	[NVP_Manifest(
		Id = "8F48BCC6-92C9-4B26-B2F1-CEBC0EFD9D66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.ElevationModelSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "ElevationModelSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the elevation in modelspace.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Specifies or returns the elevation in modelspace.
	///</summary>
	public class ElevationModelSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElevationModelSpace);

		}
	}


	[NVP_Manifest(
		Id = "8EE5AF6C-7F4F-4EE2-8520-A4F02C34ED36", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Set_ElevationModelSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Set_ElevationModelSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the elevation in modelspace.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabase", typeof(object))]
	[NodeInput("Elevation", typeof(System.Double))]

	///<summary>
	///Specifies or returns the elevation in modelspace.
	///</summary>
	public class Set_ElevationModelSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ElevationModelSpace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F1BA3826-9BE1-4E2A-832C-5DA1B5642334", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.ElevationPaperSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "ElevationPaperSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the elevation in paperspace.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Specifies or returns the elevation in paperspace.
	///</summary>
	public class ElevationPaperSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElevationPaperSpace);

		}
	}


	[NVP_Manifest(
		Id = "98209678-55E3-405E-A369-5EFF7016142E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Set_ElevationPaperSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Set_ElevationPaperSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the elevation in paperspace.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabase", typeof(object))]
	[NodeInput("Elevation", typeof(System.Double))]

	///<summary>
	///Specifies or returns the elevation in paperspace.
	///</summary>
	public class Set_ElevationPaperSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ElevationPaperSpace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "68BC7A0C-1B09-48E4-AEF5-5D9B316A40C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Limits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Limits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the drawing limits of a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Specifies or returns the drawing limits of a document.
	///</summary>
	public class Limits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Limits);

		}
	}


	[NVP_Manifest(
		Id = "E9BF2AD6-5B65-480B-9D38-665CFDD94C54", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Set_Limits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Set_Limits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the drawing limits of a document.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabase", typeof(object))]
	[NodeInput("Limits", typeof(System.Object))]

	///<summary>
	///Specifies or returns the drawing limits of a document.
	///</summary>
	public class Set_Limits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Limits = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E55B6068-B592-4B41-B3A7-2DD97A87311C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.HandleToObject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "HandleToObject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the object that corresponds with a specified handle.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]
	[NodeInput("Handle", typeof(System.String))]

	///<summary>
	///Returns the object that corresponds with a specified handle.
	///</summary>
	public class HandleToObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HandleToObject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "69011B1F-6338-4D53-A985-E7F3E33E53FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.ObjectIdToObject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "ObjectIdToObject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the object that corresponds with a specified object ID.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]
	[NodeInput("ObjectID", typeof(System.Object))]

	///<summary>
	///Returns the object that corresponds with a specified object ID.
	///</summary>
	public class ObjectIdToObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectIdToObject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "E150B771-16B5-4960-91F7-1755AF4BFACD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Layouts", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Layouts", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Layouts Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Layouts Collection object for a document.
	///</summary>
	public class Layouts : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layouts);

		}
	}


	[NVP_Manifest(
		Id = "7548F9E6-B7A1-4B09-9F35-9A91C1C3619B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.PlotConfigurations", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "PlotConfigurations", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the PlotConfigurations Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the PlotConfigurations Collection object for a document.
	///</summary>
	public class PlotConfigurations : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotConfigurations);

		}
	}


	[NVP_Manifest(
		Id = "2C541A36-599D-448A-83AA-7D4017247B6D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Preferences", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Preferences", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Preferences object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Preferences object for a document.
	///</summary>
	public class Preferences : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Preferences);

		}
	}


	[NVP_Manifest(
		Id = "3C18ED94-4B09-4F36-BACB-2F4AEB33EF74", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.FileDependencies", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "FileDependencies", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the FileDependencies Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the FileDependencies Collection object for a document.
	///</summary>
	public class FileDependencies : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FileDependencies);

		}
	}


	[NVP_Manifest(
		Id = "91D113A0-75B2-45CC-8E90-17B1C2663FD4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.SummaryInfo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "SummaryInfo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the SummaryInfo object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the SummaryInfo object for a document.
	///</summary>
	public class SummaryInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SummaryInfo);

		}
	}


	[NVP_Manifest(
		Id = "8BC364F5-3564-4A2F-80DF-EE7CE2CD1A4F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.SectionManager", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "SectionManager", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the SectionManager Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the SectionManager Collection object for a document.
	///</summary>
	public class SectionManager : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SectionManager);

		}
	}


	[NVP_Manifest(
		Id = "7366B0B6-1160-4810-BF0B-2E0C673B4F7D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDatabase.Materials", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDatabase", 
		NodeName = "Materials", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Materials Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Materials Collection object for a document.
	///</summary>
	public class Materials : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Materials);

		}
	}
}
