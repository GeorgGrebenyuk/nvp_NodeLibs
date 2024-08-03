using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a solid object with free-form surface support
///</summary>
namespace OdaX.Acad3DSolid 
{

	[NVP_Manifest(
		Id = "26A24384-8F55-45F4-A96F-B6C4F921722F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.Acad3DSolid_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "_Acad3DSolid_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Acad3DSolid_Constructor : INode 
	{
		public OdaX.IAcad3DSolid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcad3DSolid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5A3499F2-EDE1-42C5-BE27-4A171E498BAE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.Acad3DSolid_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "_Acad3DSolid_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Acad3DSolid_ConstructorCast : INode 
	{
		public OdaX.IAcad3DSolid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcad3DSolid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "79FD3B5D-14C0-4267-ABAB-56D30334AB57", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.Centroid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "Centroid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the center of the area or mass for a 3D solid or region.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the center of the area or mass for a 3D solid or region.
	///</summary>
	public class Centroid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Centroid);

		}
	}


	[NVP_Manifest(
		Id = "55687D88-C6EE-40A5-AEB1-3D18958F33AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.MomentOfInertia", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "MomentOfInertia", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the moment of inertia for a 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the moment of inertia for a 3D solid.
	///</summary>
	public class MomentOfInertia : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MomentOfInertia);

		}
	}


	[NVP_Manifest(
		Id = "6C256DBC-0B00-4A8B-9B39-69032D59D04F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.PrincipalDirections", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "PrincipalDirections", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the principal directions of a 3D solid or region.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the principal directions of a 3D solid or region.
	///</summary>
	public class PrincipalDirections : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrincipalDirections);

		}
	}


	[NVP_Manifest(
		Id = "A1C1E2D7-B2D5-445F-9E68-729B83E818D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.PrincipalMoments", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "PrincipalMoments", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the principal moments of a 3D solid or region.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the principal moments of a 3D solid or region.
	///</summary>
	public class PrincipalMoments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrincipalMoments);

		}
	}


	[NVP_Manifest(
		Id = "CE1C30A4-8258-499E-90BC-F61490534D23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.ProductOfInertia", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "ProductOfInertia", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the product of inertia of a 3D solid or region.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the product of inertia of a 3D solid or region.
	///</summary>
	public class ProductOfInertia : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProductOfInertia);

		}
	}


	[NVP_Manifest(
		Id = "DA9DE3B5-2B91-4994-8E20-0BF5217E5D47", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.RadiiOfGyration", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "RadiiOfGyration", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the radius of gyration of a 3D solid or region.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the radius of gyration of a 3D solid or region.
	///</summary>
	public class RadiiOfGyration : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RadiiOfGyration);

		}
	}


	[NVP_Manifest(
		Id = "887AD078-346E-4B50-B67E-D3E026DF8316", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.Volume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "Volume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the volume of a 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the volume of a 3D solid.
	///</summary>
	public class Volume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Volume);

		}
	}


	[NVP_Manifest(
		Id = "D7943C20-FA2A-4DCF-ADAA-41F5D063C3D8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.Boolean", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "Boolean", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Performs a boolean operation on an object and another 3D solid or region.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("OdaX.AcBoolean", typeof(System.Object))]
	[NodeInput("SolidObject", typeof(System.Object))]

	///<summary>
	///Not implemented. Performs a boolean operation on an object and another 3D solid or region.
	///</summary>
	public class Boolean : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Boolean(((OdaX.AcBoolean)inputs[1].Value),inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E832D0B9-ACA3-405D-BACA-02CE2274BBA1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.CheckInterference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "CheckInterference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Checks the interference between two 3D solids.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]
	[NodeInput("CreateInterferenceSolid", typeof(System.Object))]

	///<summary>
	///Not implemented. Checks the interference between two 3D solids.
	///</summary>
	public class CheckInterference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CheckInterference(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "FAF18037-B639-4203-8370-6B3A2D532515", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.SectionSolid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "SectionSolid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Creates a section of a 3D solid; the resulting section is a region.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("point3", typeof(System.Object))]

	///<summary>
	///Not implemented. Creates a section of a 3D solid; the resulting section is a region.
	///</summary>
	public class SectionSolid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SectionSolid(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "C1D3D322-30CC-46F0-A10A-8CC0F063299F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.SliceSolid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "SliceSolid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Creates a slice of a 3D solid; the resulting slice is an array of the 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("point3", typeof(System.Object))]
	[NodeInput("Negative", typeof(System.Object))]

	///<summary>
	///Not implemented. Creates a slice of a 3D solid; the resulting slice is an array of the 3D solid.
	///</summary>
	public class SliceSolid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SliceSolid(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "EA375073-5F94-47A0-A22F-D679CB873D08", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.SolidType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "SolidType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the type of 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Returns the type of 3D solid.
	///</summary>
	public class SolidType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SolidType);

		}
	}


	[NVP_Manifest(
		Id = "5CAA3CB9-2A88-467D-967D-F9A71A1A2C15", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the center of a 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the center of a 3D solid.
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
		Id = "06CD509E-09A3-469D-9112-2F7E54288A74", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the center of a 3D solid.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("Position", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the center of a 3D solid.
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
		Id = "31DE4D58-E9D7-438A-BE86-661FAC2237BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.History", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "History", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns whether history is saved for a 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns whether history is saved for a 3D solid.
	///</summary>
	public class History : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.History);

		}
	}


	[NVP_Manifest(
		Id = "3101FA39-F35D-440A-8F4A-3F29B42C2735", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.Set_History", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "Set_History", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns whether history is saved for a 3D solid.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("bHistory", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns whether history is saved for a 3D solid.
	///</summary>
	public class Set_History : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.History = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5FE5ADA2-87F0-410A-9C29-B4FFC1159FEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.ShowHistory", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "ShowHistory", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns whether to show the history of a 3D solid.", 
		ViewType = "Data")]
	[NodeInput("Acad3DSolid", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns whether to show the history of a 3D solid.
	///</summary>
	public class ShowHistory : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowHistory);

		}
	}


	[NVP_Manifest(
		Id = "2D20372B-81FC-4122-928F-8C8446DF2686", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.Acad3DSolid.Set_ShowHistory", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.Acad3DSolid", 
		NodeName = "Set_ShowHistory", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns whether to show the history of a 3D solid.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DSolid", typeof(object))]
	[NodeInput("Position", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns whether to show the history of a 3D solid.
	///</summary>
	public class Set_ShowHistory : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowHistory = inputs[1].Value;
			return null;
		}
	}
}
