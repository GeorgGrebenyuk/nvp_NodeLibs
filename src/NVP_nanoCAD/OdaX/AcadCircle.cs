using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a full circle entity
///</summary>
namespace OdaX.AcadCircle 
{

	[NVP_Manifest(
		Id = "82B65CD3-B967-47C8-8505-0645D0C7B383", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.AcadCircle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "_AcadCircle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadCircle_Constructor : INode 
	{
		public OdaX.IAcadCircle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadCircle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A4B4ACFE-A0ED-4C99-86F4-95A592FE76B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.AcadCircle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "_AcadCircle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadCircle_ConstructorCast : INode 
	{
		public OdaX.IAcadCircle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadCircle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A8537DB6-9827-4E37-BA03-FDBB1C17F8C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z coordinates of the center of a circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates of the center of a circle.
	///</summary>
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	[NVP_Manifest(
		Id = "02BC1623-4CC8-4D80-9706-E298C192F5D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Set_Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Set_Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z coordinates of the center of a circle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("CenterPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates of the center of a circle.
	///</summary>
	public class Set_Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Center = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "131F6349-4D9C-49C5-B23D-D5A9AA4103EA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the radius of a circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///Specifies or returns the radius of a circle.
	///</summary>
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	[NVP_Manifest(
		Id = "1BEE2369-5BAD-49A1-8424-819C8DDFAB90", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Set_Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Set_Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the radius of a circle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Radius", typeof(System.Double))]

	///<summary>
	///Specifies or returns the radius of a circle.
	///</summary>
	public class Set_Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Radius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5DB4283E-308E-4D6E-B405-A80F792FDF97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Diameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Diameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the diameter of a circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///Specifies or returns the diameter of a circle.
	///</summary>
	public class Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Diameter);

		}
	}


	[NVP_Manifest(
		Id = "F83CE6C4-5FCC-4D6C-A887-85E23068DD97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Set_Diameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Set_Diameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the diameter of a circle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Diameter", typeof(System.Double))]

	///<summary>
	///Specifies or returns the diameter of a circle.
	///</summary>
	public class Set_Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Diameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6C3F5AA1-9086-440A-AAE0-A73B7BBEFD16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Circumference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Circumference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the circumference of a circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///Specifies or returns the circumference of a circle.
	///</summary>
	public class Circumference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Circumference);

		}
	}


	[NVP_Manifest(
		Id = "86DD1318-7B54-4112-9467-42DD46563F15", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Set_Circumference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Set_Circumference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the circumference of a circle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Circumference", typeof(System.Double))]

	///<summary>
	///Specifies or returns the circumference of a circle.
	///</summary>
	public class Set_Circumference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Circumference = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9254B4C8-5B79-4755-8C38-9E383C8D6CC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Area", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Area", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the area of a circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///Specifies or returns the area of a circle.
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
		Id = "C5924733-6405-4592-9F8E-9E638613AE7B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Set_Area", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Set_Area", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the area of a circle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Area", typeof(System.Double))]

	///<summary>
	///Specifies or returns the area of a circle.
	///</summary>
	public class Set_Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Area = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8B79F6DF-43DF-4C99-8908-AC7915F9D49D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates of the normal direction vector.
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
		Id = "F78B6825-CE00-43D7-8538-4D82822B0D85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates of the normal direction vector.
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7035F734-8525-41E8-84C4-803EE5F9AAC6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of a circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///z-direction value) of a circle.
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
		Id = "8BE72BED-DA69-4FAE-ACB2-6732A3594499", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Set_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Set_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of a circle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of a circle.
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
		Id = "A9C14FC8-616F-455A-9279-7176D7A76C82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadCircle.Offset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadCircle", 
		NodeName = "Offset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Creates a new circle at a specified distance from an original circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates a new circle at a specified distance from an original circle.
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1].Value));

		}
	}
}
