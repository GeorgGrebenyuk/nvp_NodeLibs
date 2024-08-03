using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a bounded planar face consisting of lines, circles, arcs, elliptical arcs, and spline curves
///</summary>
namespace OdaX.AcadRegion 
{

	[NVP_Manifest(
		Id = "9EC41BE8-75CB-4E8E-BB81-92C122F0588B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.AcadRegion_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "_AcadRegion_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRegion_Constructor : INode 
	{
		public OdaX.IAcadRegion _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadRegion;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "254BE39C-5EFC-4613-9FB3-0B43ED72D245", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.AcadRegion_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "_AcadRegion_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRegion_ConstructorCast : INode 
	{
		public OdaX.IAcadRegion _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadRegion;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "8A87940D-D680-4474-9CAD-70590D9C8858", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.Area", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "Area", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the area of a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the area of a region.
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
		Id = "98062A37-D1A7-40F1-8638-9B7B29CD5DF4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.Centroid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "Centroid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the center point of the area for a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the center point of the area for a region.
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
		Id = "E5BA16FF-9222-4A07-B4B1-6315CFB41651", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.MomentOfInertia", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "MomentOfInertia", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the moment of inertia for a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the moment of inertia for a region.
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
		Id = "69BA9D94-70B1-4CFF-968C-CFB15083B737", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Id = "346D9DB0-DA78-4D4F-9864-27258E514C35", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.Perimeter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "Perimeter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the perimeter of a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the perimeter of a region.
	///</summary>
	public class Perimeter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Perimeter);

		}
	}


	[NVP_Manifest(
		Id = "25AD4A84-2255-437B-A994-787D1DB6396F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.PrincipalDirections", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "PrincipalDirections", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the set of principal direction points for a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the set of principal direction points for a region.
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
		Id = "9EE5DAF7-73E6-4D26-BE6D-8972B58E441B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.PrincipalMoments", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "PrincipalMoments", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the set of principal moment points for a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the set of principal moment points for a region.
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
		Id = "8752E44C-BB58-4D7D-9B0D-CBB0B9C55D73", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.ProductOfInertia", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "ProductOfInertia", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the product of inertia for a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the product of inertia for a region.
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
		Id = "E994041E-EB3A-4449-B06C-D66DFE3BD11F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.RadiiOfGyration", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "RadiiOfGyration", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the radius of gyration for a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the radius of gyration for a region.
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
		Id = "EF92A34F-7820-4942-9C34-74A22C14ED87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.Boolean", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "Boolean", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Performs a Boolean operation with another region.", 
		ViewType = "Modifier")]
	[NodeInput("AcadRegion", typeof(object))]
	[NodeInput("OdaX.AcBoolean", typeof(System.Object))]
	[NodeInput("Object", typeof(System.Object))]

	///<summary>
	///Not implemented. Performs a Boolean operation with another region.
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
		Id = "CE6FD591-5697-48D8-943C-74A62C02E720", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadRegion.Explode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadRegion", 
		NodeName = "Explode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Explodes the region and returns the individual entities as an array of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Explodes the region and returns the individual entities as an array of the object.
	///</summary>
	public class Explode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explode);

		}
	}
}
