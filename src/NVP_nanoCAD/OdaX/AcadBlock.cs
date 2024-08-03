using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a block definition containing a name and a set of objects
///</summary>
namespace OdaX.AcadBlock 
{

	[NVP_Manifest(
		Id = "2B398CEE-EC8D-4185-8D23-E9B4FC4E1204", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AcadBlock_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "_AcadBlock_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadBlock_Constructor : INode 
	{
		public OdaX.IAcadBlock _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadBlock;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "148B6B9F-E891-459B-A4E7-07A507659C2F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AcadBlock_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "_AcadBlock_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadBlock_ConstructorCast : INode 
	{
		public OdaX.IAcadBlock _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadBlock;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "ED64E70B-8FB9-491A-A845-0EA97CAB9E02", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns an object at a given index in a collection.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in a collection.
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "08FC1B67-14E6-49B0-A54D-D845166A784B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of items in a collection.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Returns the number of items in a collection.
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "1BEE094B-4F43-4F69-9DDD-6F73C5732A37", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Specifies or returns the name of an object.
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "B41022DF-6B4B-4A26-9E89-F8AA5040AA9D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of an object.
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "09EDAF34-79DF-4712-9A4E-013CE66A36D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinates for the origin of a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Specifies or returns the coordinates for the origin of a block.
	///</summary>
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	[NVP_Manifest(
		Id = "3D5FE3AF-51BC-424D-BAC5-744E338D77D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Set_Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Set_Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinates for the origin of a block.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Origin", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinates for the origin of a block.
	///</summary>
	public class Set_Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Origin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8BCA2C01-21B9-4A1B-87DB-B91C3E09C6B2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddCustomObject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddCustomObject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a custom object.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ClassName", typeof(System.String))]

	///<summary>
	///Creates a custom object.
	///</summary>
	public class AddCustomObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddCustomObject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "4CD08CD8-C089-46BB-ADCC-B1149C78574E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Add3DFace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Add3DFace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a 3DFace object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("point3", typeof(System.Object))]
	[NodeInput("Point4", typeof(System.Object))]

	///<summary>
	///Creates a 3DFace object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class Add3DFace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add3DFace(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "BE5127A2-F005-46A5-98DC-D17521062A68", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Add3DMesh", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Add3DMesh", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a PolyfaceMesh object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("M", typeof(System.Int32))]
	[NodeInput("N", typeof(System.Int32))]
	[NodeInput("PointsMatrix", typeof(System.Object))]

	///<summary>
	///Creates a PolyfaceMesh object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class Add3DMesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add3DMesh(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "F64E8121-860E-4BAF-9E44-CB39DF24A4B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Add3DPoly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Add3DPoly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a 3DPolyline object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PointsArray", typeof(System.Object))]

	///<summary>
	///Creates a 3DPolyline object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class Add3DPoly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add3DPoly(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "11EF00CD-34DD-4DF1-A34A-FB9ED37B86BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddArc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddArc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an Arc object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Radius", typeof(System.Double))]
	[NodeInput("StartAngle", typeof(System.Double))]
	[NodeInput("EndAngle", typeof(System.Double))]

	///<summary>
	///Creates an Arc object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddArc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddArc(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "E131E64C-EB42-4C89-A4FE-4F85B0C9D360", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddAttribute", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddAttribute", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an Attribute object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]
	[NodeInput("OdaX.AcAttributeMode", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Tag", typeof(System.String))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///Creates an Attribute object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddAttribute : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddAttribute(inputs[1].Value,((OdaX.AcAttributeMode)inputs[2].Value),inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value));

		}
	}


	[NVP_Manifest(
		Id = "5D9AA5D8-C582-4F28-8F9D-7696ABD341EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a 3D solid box and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Origin", typeof(System.Object))]
	[NodeInput("Length", typeof(System.Double))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Creates a 3D solid box and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddBox(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "1F99A78A-2FEC-4166-A71E-03C506C55D8D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddCircle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddCircle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Circle object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Radius", typeof(System.Double))]

	///<summary>
	///Creates a Circle object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddCircle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddCircle(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "3F10633E-E985-4550-92AA-1D8DE54A9572", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddCone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddCone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a 3D solid cone and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("BaseRadius", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Creates a 3D solid cone and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddCone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddCone(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "0B1C8EB6-4ADC-4F04-B34E-EBD6228D8443", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddCylinder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddCylinder", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a 3D solid cylinder and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Radius", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Creates a 3D solid cylinder and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddCylinder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddCylinder(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "C330780E-C494-4BA6-931A-96349B16CFF3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddDimAligned", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddDimAligned", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an aligned dimension object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ExtLine1Point", typeof(System.Object))]
	[NodeInput("ExtLine2Point", typeof(System.Object))]
	[NodeInput("TextPosition", typeof(System.Object))]

	///<summary>
	///Creates an aligned dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddDimAligned : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimAligned(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "328F72B7-E570-4871-89FA-1A0072B013B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddDimAngular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddDimAngular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an angular dimension object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("AngleVertex", typeof(System.Object))]
	[NodeInput("FirstEndPoint", typeof(System.Object))]
	[NodeInput("SecondEndPoint", typeof(System.Object))]
	[NodeInput("TextPoint", typeof(System.Object))]

	///<summary>
	///Creates an angular dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddDimAngular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimAngular(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "C97ADDED-95FD-4E34-A226-ACEC4006BF6D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddDimDiametric", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddDimDiametric", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a diametric dimension object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ChordPoint", typeof(System.Object))]
	[NodeInput("FarChordPoint", typeof(System.Object))]
	[NodeInput("LeaderLength", typeof(System.Double))]

	///<summary>
	///Creates a diametric dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddDimDiametric : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimDiametric(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "AD35C60E-8468-46AA-A8C6-A883A67329A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddDimRotated", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddDimRotated", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a rotated linear dimension object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ExtLine1Point", typeof(System.Object))]
	[NodeInput("ExtLine2Point", typeof(System.Object))]
	[NodeInput("DimLineLocation", typeof(System.Object))]
	[NodeInput("RotationAngle", typeof(System.Double))]

	///<summary>
	///Creates a rotated linear dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddDimRotated : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimRotated(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "D866AE7B-0AA0-46D0-BA5A-E6F97D90A314", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddDimOrdinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddDimOrdinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an ordinate dimension object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("DefinitionPoint", typeof(System.Object))]
	[NodeInput("LeaderEndPoint", typeof(System.Object))]
	[NodeInput("UseXAxis", typeof(System.Int32))]

	///<summary>
	///Creates an ordinate dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddDimOrdinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimOrdinate(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "41AC331A-CF89-473D-ABB4-DC9012838C4F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddDimRadial", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddDimRadial", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a radial dimension object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("ChordPoint", typeof(System.Object))]
	[NodeInput("LeaderLength", typeof(System.Double))]

	///<summary>
	///Creates a radial dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddDimRadial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimRadial(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "B445D570-4789-4F39-BCB4-7D1CC5E293C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddEllipse", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddEllipse", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an Ellipse object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("MajorAxis", typeof(System.Object))]
	[NodeInput("RadiusRatio", typeof(System.Double))]

	///<summary>
	///Creates an Ellipse object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddEllipse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddEllipse(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "8239357E-C00D-4691-8DD7-BC4492B80D2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddEllipticalCone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddEllipticalCone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a 3D solid elliptical cone object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("MajorRadius", typeof(System.Double))]
	[NodeInput("MinorRadius", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Creates a 3D solid elliptical cone object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddEllipticalCone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddEllipticalCone(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "77514FAE-0D0C-40C6-8105-7C7413FA31E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddEllipticalCylinder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddEllipticalCylinder", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a 3D solid elliptical cylinder object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("MajorRadius", typeof(System.Double))]
	[NodeInput("MinorRadius", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Creates a 3D solid elliptical cylinder object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddEllipticalCylinder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddEllipticalCylinder(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "21064E24-D7EC-45E3-9976-493C12656930", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddExtrudedSolid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddExtrudedSolid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an extruded solid object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Profile", typeof(System.Object))]
	[NodeInput("Height", typeof(System.Double))]
	[NodeInput("TaperAngle", typeof(System.Double))]

	///<summary>
	///Creates an extruded solid object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddExtrudedSolid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddExtrudedSolid(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "C7E6AC7C-D6DF-45BC-80EA-ACEB8C0AFCEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddExtrudedSolidAlongPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddExtrudedSolidAlongPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an extruded solid object along a path and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Profile", typeof(System.Object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Creates an extruded solid object along a path and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddExtrudedSolidAlongPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddExtrudedSolidAlongPath(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "C606089F-607D-4A04-AB9F-83BC9F6774D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Leader object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PointsArray", typeof(System.Object))]
	[NodeInput("Annotation", typeof(System.Object))]
	[NodeInput("OdaX.AcLeaderType", typeof(System.Object))]

	///<summary>
	///Creates a Leader object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddLeader(inputs[1].Value,inputs[2].Value,((OdaX.AcLeaderType)inputs[3].Value)));

		}
	}


	[NVP_Manifest(
		Id = "F0EA81E6-B1A8-4391-9AE6-A05DD1E67DD9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddMText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddMText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an Multiline Text object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Text", typeof(System.String))]

	///<summary>
	///Creates an Multiline Text object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddMText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddMText(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "B4E7E97D-E121-46C6-B5D2-32C92936C667", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Point object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]

	///<summary>
	///Creates a Point object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddPoint(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "71E5DB83-4FBE-4125-BC22-758C17E5D5D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddLightWeightPolyline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddLightWeightPolyline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Lightweight Polyline object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("VerticesList", typeof(System.Object))]

	///<summary>
	///Creates a Lightweight Polyline object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddLightWeightPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddLightWeightPolyline(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "DA099652-64C5-45EE-B954-101B4171A4F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddPolyline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddPolyline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Polyline object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("VerticesList", typeof(System.Object))]

	///<summary>
	///Creates a Polyline object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddPolyline(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "1A88A4BB-2DD7-4947-B19D-C77E5A6E1A2C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddRay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddRay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Ray object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]

	///<summary>
	///Creates a Ray object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddRay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddRay(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "163E46EF-AB1D-44AA-93C5-FA42E2559E07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddRegion", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddRegion", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Region object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ObjectList", typeof(System.Object))]

	///<summary>
	///Creates a Region object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddRegion : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddRegion(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "4C055964-3AB0-4724-BE73-F1E32703F073", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddRevolvedSolid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddRevolvedSolid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a revolved solid object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Profile", typeof(System.Object))]
	[NodeInput("AxisPoint", typeof(System.Object))]
	[NodeInput("AxisDir", typeof(System.Object))]
	[NodeInput("Angle", typeof(System.Double))]

	///<summary>
	///Creates a revolved solid object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddRevolvedSolid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddRevolvedSolid(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "FF6F20AC-EAB4-4F4B-A343-D807262B881D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddShape", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddShape", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Shape object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("ScaleFactor", typeof(System.Double))]
	[NodeInput("RotationAngle", typeof(System.Double))]

	///<summary>
	///Creates a Shape object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddShape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddShape(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "498FB314-3AA6-4C91-AFAD-62DD1500DCFC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddSolid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddSolid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a 2D solid polygon object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("point3", typeof(System.Object))]
	[NodeInput("Point4", typeof(System.Object))]

	///<summary>
	///Creates a 2D solid polygon object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddSolid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddSolid(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "6A3E1E18-46CD-4B24-866E-D8709268650F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddSphere", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddSphere", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Sphere object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Radius", typeof(System.Double))]

	///<summary>
	///Creates a Sphere object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddSphere : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddSphere(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "F83CFEEB-9E3E-45DF-A9F2-C0A957741850", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddSpline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddSpline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Spline object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PointsArray", typeof(System.Object))]
	[NodeInput("StartTangent", typeof(System.Object))]
	[NodeInput("EndTangent", typeof(System.Object))]

	///<summary>
	///Creates a Spline object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddSpline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddSpline(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "8A056F7B-19D2-45A5-8557-E161548A39CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Text object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("TextString", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Creates a Text object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddText(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "23333BAF-40BF-4FA2-A85B-4E4E10952C1E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddTolerance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddTolerance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Tolerance object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Text", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Direction", typeof(System.Object))]

	///<summary>
	///Creates a Tolerance object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddTolerance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddTolerance(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "6BA8032D-520A-445A-898A-83BA3986BC3A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddTorus", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddTorus", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Torus object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("TorusRadius", typeof(System.Double))]
	[NodeInput("TubeRadius", typeof(System.Double))]

	///<summary>
	///Creates a Torus object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddTorus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddTorus(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "55DCABCB-C6B1-44D1-8799-59B2AE82D27D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddTrace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddTrace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Trace object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PointsArray", typeof(System.Object))]

	///<summary>
	///Creates a Trace object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddTrace(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "5C5871C0-EAB7-4269-A26F-B3D5D9D4B9B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddWedge", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddWedge", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Wedge object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Length", typeof(System.Double))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Creates a Wedge object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddWedge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddWedge(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "1B834972-0DE3-4B38-BC94-628F9952DC3F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddXline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddXline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an XLine object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]

	///<summary>
	///Creates an XLine object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddXline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddXline(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "772A9E29-6CED-40E6-B7B6-9BD51F57316A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.InsertBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "InsertBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Inserts a drawing or named block to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Xscale", typeof(System.Double))]
	[NodeInput("Yscale", typeof(System.Double))]
	[NodeInput("Zscale", typeof(System.Double))]
	[NodeInput("Rotation", typeof(System.Double))]
	[NodeInput("Password", typeof(System.Object))]

	///<summary>
	///Inserts a drawing or named block to modelspace, paperspace, or a block.
	///</summary>
	public class InsertBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsertBlock(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value,inputs[7].Value));

		}
	}


	[NVP_Manifest(
		Id = "5345050D-F280-4B64-903D-2D9E72127844", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddHatch", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddHatch", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Hatch object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PatternType", typeof(System.Int32))]
	[NodeInput("PatternName", typeof(System.String))]
	[NodeInput("Associativity", typeof(System.Object))]
	[NodeInput("HatchObjectType", typeof(System.Object))]

	///<summary>
	///Creates a Hatch object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddHatch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddHatch(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "9E1C5ED4-0180-47B3-A7FC-B7458E1AFBF6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddRaster", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddRaster", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds a raster image as a Raster object to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("imageFileName", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("ScaleFactor", typeof(System.Double))]
	[NodeInput("RotationAngle", typeof(System.Double))]

	///<summary>
	///Adds a raster image as a Raster object to modelspace, paperspace, or a block.
	///</summary>
	public class AddRaster : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddRaster(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "9EA3E4C2-20EA-48CA-89E3-07B3918EC336", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Line object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("StartPoint", typeof(System.Object))]
	[NodeInput("EndPoint", typeof(System.Object))]

	///<summary>
	///Creates a Line object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddLine(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "DF22D188-F4B6-4EB5-BE26-E1EDDDECD7EA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.IsLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "IsLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether a specified block is a layout block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Returns whether a specified block is a layout block.
	///</summary>
	public class IsLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsLayout);

		}
	}


	[NVP_Manifest(
		Id = "793FD78B-AA0A-41EF-9BDF-4F9FFE2B17E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Layout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Layout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the layout associated with the specified block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Returns the layout associated with the specified block.
	///</summary>
	public class Layout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layout);

		}
	}


	[NVP_Manifest(
		Id = "3D5A42F4-11F8-40B6-A0E9-824A34A8FF93", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.IsXRef", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "IsXRef", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether a specified block is an external reference block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Returns whether a specified block is an external reference block.
	///</summary>
	public class IsXRef : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsXRef);

		}
	}


	[NVP_Manifest(
		Id = "0EA20895-E165-4E83-8DE0-0D00C5266C67", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddMInsertBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddMInsertBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds an array of blocks to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Xscale", typeof(System.Double))]
	[NodeInput("Yscale", typeof(System.Double))]
	[NodeInput("Zscale", typeof(System.Double))]
	[NodeInput("Rotation", typeof(System.Double))]
	[NodeInput("NumRows", typeof(System.Object))]
	[NodeInput("NumColumns", typeof(System.Object))]
	[NodeInput("RowSpacing", typeof(System.Object))]
	[NodeInput("ColumnSpacing", typeof(System.Object))]
	[NodeInput("Password", typeof(System.Object))]

	///<summary>
	///Adds an array of blocks to modelspace, paperspace, or a block.
	///</summary>
	public class AddMInsertBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddMInsertBlock(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value,inputs[7].Value,inputs[8].Value,inputs[9].Value,inputs[10].Value,inputs[11].Value));

		}
	}


	[NVP_Manifest(
		Id = "FA347635-D81F-4E8F-9061-191A0715F62D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddPolyfaceMesh", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddPolyfaceMesh", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Polyface Mesh object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("VertexList", typeof(System.Object))]
	[NodeInput("FaceList", typeof(System.Object))]

	///<summary>
	///Creates a Polyface Mesh object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddPolyfaceMesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddPolyfaceMesh(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "7FB8AFDF-2E75-4533-9835-1C6FD4B05E97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddMLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddMLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Multiline object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("VertexList", typeof(System.Object))]

	///<summary>
	///Creates a Multiline object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddMLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddMLine(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "94B784D3-CDD4-4CC9-AECA-B5D9E9B92D84", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddDim3PointAngular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddDim3PointAngular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a 3-point angular dimension object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("AngleVertex", typeof(System.Object))]
	[NodeInput("FirstEndPoint", typeof(System.Object))]
	[NodeInput("SecondEndPoint", typeof(System.Object))]
	[NodeInput("TextPoint", typeof(System.Object))]

	///<summary>
	///Creates a 3-point angular dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddDim3PointAngular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDim3PointAngular(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "2AF485F7-D21D-4EE9-AB44-E4C9C923EEFC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.XRefDatabase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "XRefDatabase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Database object.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Returns the Database object.
	///</summary>
	public class XRefDatabase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XRefDatabase);

		}
	}


	[NVP_Manifest(
		Id = "34186888-3366-4AE2-91C1-63238F8AD049", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AttachExternalReference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AttachExternalReference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Attaches an external reference to a drawing.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PathName", typeof(System.String))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Xscale", typeof(System.Double))]
	[NodeInput("Yscale", typeof(System.Double))]
	[NodeInput("Zscale", typeof(System.Double))]
	[NodeInput("Rotation", typeof(System.Double))]
	[NodeInput("bOverlay", typeof(System.Object))]
	[NodeInput("Password", typeof(System.Object))]

	///<summary>
	///Attaches an external reference to a drawing.
	///</summary>
	public class AttachExternalReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AttachExternalReference(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value,inputs[7].Value,inputs[8].Value,inputs[9].Value));

		}
	}


	[NVP_Manifest(
		Id = "E2CB0AF5-5A9D-4B83-AB92-8BB03DE615A3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Unload", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Unload", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Unloads an external reference from a drawing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Unloads an external reference from a drawing.
	///</summary>
	public class Unload : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Unload();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9B3238FF-1EA7-49B9-BD4F-226A691BAAB4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Reload", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Reload", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Reloads an external reference to a drawing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Reloads an external reference to a drawing.
	///</summary>
	public class Reload : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Reload();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EE964A78-A956-4F5E-B7C0-F7F08470A911", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Bind", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Bind", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Binds an external reference to a drawing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("bPrefixName", typeof(System.Object))]

	///<summary>
	///Binds an external reference to a drawing.
	///</summary>
	public class Bind : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bind(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C72E08BD-894C-403C-AD84-10F376E37496", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Detach", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Detach", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Detachs an external reference from a drawing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Detachs an external reference from a drawing.
	///</summary>
	public class Detach : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Detach();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7BC98CF9-CE88-4F29-A7A9-5E213629069B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddTable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddTable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Table object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("NumRows", typeof(System.Int32))]
	[NodeInput("NumColumns", typeof(System.Int32))]
	[NodeInput("RowHeight", typeof(System.Double))]
	[NodeInput("ColWidth", typeof(System.Double))]

	///<summary>
	///Creates a Table object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddTable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddTable(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value));

		}
	}


	[NVP_Manifest(
		Id = "1A10372F-DDC6-405F-8AEE-E684C45ED0CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Path", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Path", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path of an external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Specifies or returns the path of an external reference.
	///</summary>
	public class Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Path);

		}
	}


	[NVP_Manifest(
		Id = "37AF9C26-C619-4BFD-8438-C7B4EF0B4FFF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Set_Path", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Set_Path", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path of an external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the path of an external reference.
	///</summary>
	public class Set_Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Path = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B98BCA75-02D3-4B26-86E0-34CE016260AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Comments", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Comments", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the comments of a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Specifies or returns the comments of a block.
	///</summary>
	public class Comments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Comments);

		}
	}


	[NVP_Manifest(
		Id = "8085E919-B5BB-4F0C-A4E6-F2964DD5E8E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Set_Comments", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Set_Comments", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the comments of a block.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the comments of a block.
	///</summary>
	public class Set_Comments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Comments = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D33A37F8-33E9-4C4A-9DF8-98667861476F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Units", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Units", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the units of measure for a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Specifies or returns the units of measure for a block.
	///</summary>
	public class Units : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Units);

		}
	}


	[NVP_Manifest(
		Id = "C42D911C-C69A-4C80-92E2-11720F45AB31", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Set_Units", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Set_Units", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the units of measure for a block.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("OdaX.AcInsertUnits", typeof(System.Object))]

	///<summary>
	///Specifies or returns the units of measure for a block.
	///</summary>
	public class Set_Units : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Units = ((OdaX.AcInsertUnits)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DD9BDC70-7B43-41E9-993C-729FA742B1F1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Explodable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Explodable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a block can be exploded.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Specifies or returns whether a block can be exploded.
	///</summary>
	public class Explodable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explodable);

		}
	}


	[NVP_Manifest(
		Id = "5CDE6C91-531E-4A15-9FD3-8DAC3BAF124C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Set_Explodable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Set_Explodable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a block can be exploded.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("bExplodable", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a block can be exploded.
	///</summary>
	public class Set_Explodable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explodable = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AFBE463A-BC2B-49AD-9BA7-C6C7B1AFD63C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.BlockScaling", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "BlockScaling", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a block can be scaled.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Specifies or returns whether a block can be scaled.
	///</summary>
	public class BlockScaling : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BlockScaling);

		}
	}


	[NVP_Manifest(
		Id = "26092E1F-2E5C-49ED-85D9-34D903349960", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.Set_BlockScaling", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "Set_BlockScaling", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a block can be scaled.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("OdaX.AcBlockScaling", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a block can be scaled.
	///</summary>
	public class Set_BlockScaling : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BlockScaling = ((OdaX.AcBlockScaling)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1FABE073-3181-431A-B3E8-B7656C02ED82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.IsDynamicBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "IsDynamicBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether the block is a dynamic block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]

	///<summary>
	///Returns whether the block is a dynamic block.
	///</summary>
	public class IsDynamicBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsDynamicBlock);

		}
	}


	[NVP_Manifest(
		Id = "FEA6C026-AB2F-424E-BDA8-AEB89EFFDDF1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddDimArc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddDimArc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an arc length dimension object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ArcCenter", typeof(System.Object))]
	[NodeInput("FirstEndPoint", typeof(System.Object))]
	[NodeInput("SecondEndPoint", typeof(System.Object))]
	[NodeInput("ArcPoint", typeof(System.Object))]

	///<summary>
	///Creates an arc length dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddDimArc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimArc(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Id = "D3C83ED9-E220-4940-A956-1DFDA3E55AF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddDimRadialLarge", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddDimRadialLarge", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a jogged radial dimension object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("ChordPoint", typeof(System.Object))]
	[NodeInput("OverrideCenter", typeof(System.Object))]
	[NodeInput("JogPoint", typeof(System.Object))]
	[NodeInput("JogAngle", typeof(System.Double))]

	///<summary>
	///Creates a jogged radial dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddDimRadialLarge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimRadialLarge(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value));

		}
	}


	[NVP_Manifest(
		Id = "4E69D435-101D-4B4A-9F87-8C581F7D89C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddSection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddSection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a Section object and adds it to modelspace, paperspace, or a block.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("FromPoint", typeof(System.Object))]
	[NodeInput("ToPoint", typeof(System.Object))]
	[NodeInput("planeVector", typeof(System.Object))]

	///<summary>
	///Creates a Section object and adds it to modelspace, paperspace, or a block.
	///</summary>
	public class AddSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddSection(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "4EA393EA-2FB2-43CD-B342-4FD305220A84", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddMLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddMLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a multileader", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PointsArray", typeof(System.Object))]
	[NodeInput("leaderLineIndex", typeof(System.Int32))]

	///<summary>
	///Creates a multileader
	///</summary>
	public class AddMLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddMLeader(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "94A91845-B18E-4F9B-80A9-17ADB94897FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadBlock.AddEmbeddedRaster", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadBlock", 
		NodeName = "AddEmbeddedRaster", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Embed raster as an OLE item.", 
		ViewType = "Data")]
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ImagePath", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Height", typeof(System.Double))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Embed raster as an OLE item.
	///</summary>
	public class AddEmbeddedRaster : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddEmbeddedRaster(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}
}
