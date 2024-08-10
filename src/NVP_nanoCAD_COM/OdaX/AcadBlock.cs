using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using System.Linq;
using NVP_nanoCAD_COM;

///<summary>
///TeighaX Interface of a block definition containing a name and a set of objects
///</summary>
namespace OdaX.AcadBlock 
{

	[NVP_Manifest(
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

    [NVP_Manifest(
        Text = "Возвращает все Объекты модели в данном блоке в виде OdaX.AcadEntity",
        ViewType = "Data")]
    [NodeInput("AcadBlock", typeof(object))]
    public class GetAll_Entities : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as OdaX.IAcadBlock;
            List<OdaX.AcadEntity.AcadEntity_Constructor> items = new List<OdaX.AcadEntity.AcadEntity_Constructor>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                OdaX.AcadEntity.AcadEntity_Constructor item = new OdaX.AcadEntity.AcadEntity_Constructor();
                item._i = _input0.Item(item_counter);
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }

    

    [NVP_Manifest(
        Text = "Возвращает все Объекты модели в данном блоке в виде OdaX.AcadEntity для данного Типа и с режимом сравнения типа (true: ==, false: Contains)",
        ViewType = "Data")]
    [NodeInput("AcadBlock", typeof(object))]
    [NodeInput("Тип", typeof(string))]
    [NodeInput("Точное соответствие", typeof(bool))]
    public class GetAll_EntitiesByName : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as OdaX.IAcadBlock;
			string _input1 = inputs[1].Value.ToString();
			bool _input2 = (bool)inputs[2].Value;
            List<OdaX.AcadEntity.AcadEntity_Constructor> items = new List<OdaX.AcadEntity.AcadEntity_Constructor>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                OdaX.AcadEntity.AcadEntity_Constructor item = new OdaX.AcadEntity.AcadEntity_Constructor();
                item._i = _input0.Item(item_counter);

				bool can_add = false;
				string entName = item._i.EntityName;

				if (_input2 && entName == _input1) can_add = true;
				else if (!_input2 && entName.Contains(_input1)) can_add = true;

                if (can_add) items.Add(item);
            }
            return new NodeResult(items);

        }
    }

    [NVP_Manifest(
        Text = "Возвращает все Объекты модели в данном блоке в виде OdaX.AcadEntity для данного Типа и с режимом сравнения типов (true: ==, false: Contains)",
        ViewType = "Data")]
    [NodeInput("AcadBlock", typeof(object))]
    [NodeInput("Список типов", typeof(List<string>))]
    [NodeInput("Точное соответствие", typeof(bool))]
    public class GetAll_EntitiesByNames : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as OdaX.IAcadBlock;
            List<string> _input1 = inputs[1].Value as List<string>;
            bool _input2 = (bool)inputs[2].Value;
            List<OdaX.AcadEntity.AcadEntity_Constructor> items = new List<OdaX.AcadEntity.AcadEntity_Constructor>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                OdaX.AcadEntity.AcadEntity_Constructor item = new OdaX.AcadEntity.AcadEntity_Constructor();
                item._i = _input0.Item(item_counter);

                bool can_add = false;
                string entName = item._i.EntityName;

				foreach (string _input1_str in _input1)
				{
                    if (_input2 && entName == _input1_str) can_add = true;
                    else if (!_input2 && entName.Contains(_input1_str)) can_add = true;
					if (can_add) break;
                }

                if (can_add) items.Add(item);
            }
            return new NodeResult(items);

        }
    }
}
