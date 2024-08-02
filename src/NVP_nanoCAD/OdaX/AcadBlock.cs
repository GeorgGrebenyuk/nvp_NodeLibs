using NVP.API.Nodes;

namespace OdaX.AcadBlock 
{
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


	///<summary>
	///Returns an object at a given index in a collection.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1]));

		}
	}


	///<summary>
	///Returns the number of items in a collection.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	///<summary>
	///Specifies or returns the name of an object.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///Specifies or returns the name of an object.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the coordinates for the origin of a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	///<summary>
	///Specifies or returns the coordinates for the origin of a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Origin", typeof(System.Object))]
	public class Set_Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Origin = inputs[1];
			return null;
		}
	}


	///<summary>
	///Creates a custom object.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ClassName", typeof(System.String))]
	public class AddCustomObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddCustomObject(inputs[1]));

		}
	}


	///<summary>
	///Creates a 3DFace object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("point3", typeof(System.Object))]
	[NodeInput("Point4", typeof(System.Object))]
	public class Add3DFace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add3DFace(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates a PolyfaceMesh object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("M", typeof(System.Int32))]
	[NodeInput("N", typeof(System.Int32))]
	[NodeInput("PointsMatrix", typeof(System.Object))]
	public class Add3DMesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add3DMesh(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates a 3DPolyline object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PointsArray", typeof(System.Object))]
	public class Add3DPoly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add3DPoly(inputs[1]));

		}
	}


	///<summary>
	///Creates an Arc object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Radius", typeof(System.Double))]
	[NodeInput("StartAngle", typeof(System.Double))]
	[NodeInput("EndAngle", typeof(System.Double))]
	public class AddArc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddArc(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates an Attribute object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]
	[NodeInput("Mode", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Tag", typeof(System.String))]
	[NodeInput("Value", typeof(System.String))]
	public class AddAttribute : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddAttribute(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5],inputs[6]));

		}
	}


	///<summary>
	///Creates a 3D solid box and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Origin", typeof(System.Object))]
	[NodeInput("Length", typeof(System.Double))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]
	public class AddBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddBox(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates a Circle object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Radius", typeof(System.Double))]
	public class AddCircle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddCircle(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Creates a 3D solid cone and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("BaseRadius", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]
	public class AddCone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddCone(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates a 3D solid cylinder and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Radius", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]
	public class AddCylinder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddCylinder(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates an aligned dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ExtLine1Point", typeof(System.Object))]
	[NodeInput("ExtLine2Point", typeof(System.Object))]
	[NodeInput("TextPosition", typeof(System.Object))]
	public class AddDimAligned : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimAligned(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates an angular dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("AngleVertex", typeof(System.Object))]
	[NodeInput("FirstEndPoint", typeof(System.Object))]
	[NodeInput("SecondEndPoint", typeof(System.Object))]
	[NodeInput("TextPoint", typeof(System.Object))]
	public class AddDimAngular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimAngular(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates a diametric dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ChordPoint", typeof(System.Object))]
	[NodeInput("FarChordPoint", typeof(System.Object))]
	[NodeInput("LeaderLength", typeof(System.Double))]
	public class AddDimDiametric : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimDiametric(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates a rotated linear dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ExtLine1Point", typeof(System.Object))]
	[NodeInput("ExtLine2Point", typeof(System.Object))]
	[NodeInput("DimLineLocation", typeof(System.Object))]
	[NodeInput("RotationAngle", typeof(System.Double))]
	public class AddDimRotated : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimRotated(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates an ordinate dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("DefinitionPoint", typeof(System.Object))]
	[NodeInput("LeaderEndPoint", typeof(System.Object))]
	[NodeInput("UseXAxis", typeof(System.Int32))]
	public class AddDimOrdinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimOrdinate(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates a radial dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("ChordPoint", typeof(System.Object))]
	[NodeInput("LeaderLength", typeof(System.Double))]
	public class AddDimRadial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimRadial(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates an Ellipse object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("MajorAxis", typeof(System.Object))]
	[NodeInput("RadiusRatio", typeof(System.Double))]
	public class AddEllipse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddEllipse(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates a 3D solid elliptical cone object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("MajorRadius", typeof(System.Double))]
	[NodeInput("MinorRadius", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]
	public class AddEllipticalCone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddEllipticalCone(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates a 3D solid elliptical cylinder object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("MajorRadius", typeof(System.Double))]
	[NodeInput("MinorRadius", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]
	public class AddEllipticalCylinder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddEllipticalCylinder(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates an extruded solid object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Profile", typeof(System.Object))]
	[NodeInput("Height", typeof(System.Double))]
	[NodeInput("TaperAngle", typeof(System.Double))]
	public class AddExtrudedSolid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddExtrudedSolid(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates an extruded solid object along a path and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Profile", typeof(System.Object))]
	[NodeInput("Path", typeof(System.Object))]
	public class AddExtrudedSolidAlongPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddExtrudedSolidAlongPath(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Creates a Leader object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PointsArray", typeof(System.Object))]
	[NodeInput("Annotation", typeof(System.Object))]
	[NodeInput("Type", typeof(System.Object))]
	public class AddLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddLeader(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates an Multiline Text object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Text", typeof(System.String))]
	public class AddMText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddMText(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates a Point object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	public class AddPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddPoint(inputs[1]));

		}
	}


	///<summary>
	///Creates a Lightweight Polyline object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("VerticesList", typeof(System.Object))]
	public class AddLightWeightPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddLightWeightPolyline(inputs[1]));

		}
	}


	///<summary>
	///Creates a Polyline object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("VerticesList", typeof(System.Object))]
	public class AddPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddPolyline(inputs[1]));

		}
	}


	///<summary>
	///Creates a Ray object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	public class AddRay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddRay(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Creates a Region object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ObjectList", typeof(System.Object))]
	public class AddRegion : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddRegion(inputs[1]));

		}
	}


	///<summary>
	///Creates a revolved solid object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Profile", typeof(System.Object))]
	[NodeInput("AxisPoint", typeof(System.Object))]
	[NodeInput("AxisDir", typeof(System.Object))]
	[NodeInput("Angle", typeof(System.Double))]
	public class AddRevolvedSolid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddRevolvedSolid(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates a Shape object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("ScaleFactor", typeof(System.Double))]
	[NodeInput("RotationAngle", typeof(System.Double))]
	public class AddShape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddShape(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates a 2D solid polygon object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("point3", typeof(System.Object))]
	[NodeInput("Point4", typeof(System.Object))]
	public class AddSolid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddSolid(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates a Sphere object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Radius", typeof(System.Double))]
	public class AddSphere : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddSphere(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Creates a Spline object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PointsArray", typeof(System.Object))]
	[NodeInput("StartTangent", typeof(System.Object))]
	[NodeInput("EndTangent", typeof(System.Object))]
	public class AddSpline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddSpline(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates a Text object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("TextString", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Height", typeof(System.Double))]
	public class AddText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddText(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates a Tolerance object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Text", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Direction", typeof(System.Object))]
	public class AddTolerance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddTolerance(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates a Torus object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("TorusRadius", typeof(System.Double))]
	[NodeInput("TubeRadius", typeof(System.Double))]
	public class AddTorus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddTorus(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates a Trace object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PointsArray", typeof(System.Object))]
	public class AddTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddTrace(inputs[1]));

		}
	}


	///<summary>
	///Creates a Wedge object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Length", typeof(System.Double))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]
	public class AddWedge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddWedge(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates an XLine object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	public class AddXline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddXline(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Inserts a drawing or named block to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Xscale", typeof(System.Double))]
	[NodeInput("Yscale", typeof(System.Double))]
	[NodeInput("Zscale", typeof(System.Double))]
	[NodeInput("Rotation", typeof(System.Double))]
	[NodeInput("Password", typeof(System.Object))]
	public class InsertBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsertBlock(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5],inputs[6],inputs[7]));

		}
	}


	///<summary>
	///Creates a Hatch object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PatternType", typeof(System.Int32))]
	[NodeInput("PatternName", typeof(System.String))]
	[NodeInput("Associativity", typeof(System.Object))]
	[NodeInput("HatchObjectType", typeof(System.Object))]
	public class AddHatch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddHatch(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Adds a raster image as a Raster object to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("imageFileName", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("ScaleFactor", typeof(System.Double))]
	[NodeInput("RotationAngle", typeof(System.Double))]
	public class AddRaster : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddRaster(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates a Line object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("StartPoint", typeof(System.Object))]
	[NodeInput("EndPoint", typeof(System.Object))]
	public class AddLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddLine(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Returns whether a specified block is a layout block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class IsLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsLayout);

		}
	}


	///<summary>
	///Returns the layout associated with the specified block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class Layout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layout);

		}
	}


	///<summary>
	///Returns whether a specified block is an external reference block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class IsXRef : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsXRef);

		}
	}


	///<summary>
	///Adds an array of blocks to modelspace, paperspace, or a block.
	///</summary>
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
	public class AddMInsertBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddMInsertBlock(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5],inputs[6],inputs[7],inputs[8],inputs[9],inputs[10],inputs[11]));

		}
	}


	///<summary>
	///Creates a Polyface Mesh object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("VertexList", typeof(System.Object))]
	[NodeInput("FaceList", typeof(System.Object))]
	public class AddPolyfaceMesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddPolyfaceMesh(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Creates a Multiline object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("VertexList", typeof(System.Object))]
	public class AddMLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddMLine(inputs[1]));

		}
	}


	///<summary>
	///Creates a 3-point angular dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("AngleVertex", typeof(System.Object))]
	[NodeInput("FirstEndPoint", typeof(System.Object))]
	[NodeInput("SecondEndPoint", typeof(System.Object))]
	[NodeInput("TextPoint", typeof(System.Object))]
	public class AddDim3PointAngular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDim3PointAngular(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Returns the Database object.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class XRefDatabase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XRefDatabase);

		}
	}


	///<summary>
	///Attaches an external reference to a drawing.
	///</summary>
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
	public class AttachExternalReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AttachExternalReference(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5],inputs[6],inputs[7],inputs[8],inputs[9]));

		}
	}


	///<summary>
	///Unloads an external reference from a drawing.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class Unload : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Unload();
			return null;
		}
	}


	///<summary>
	///Reloads an external reference to a drawing.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class Reload : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Reload();
			return null;
		}
	}


	///<summary>
	///Binds an external reference to a drawing.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("bPrefixName", typeof(System.Object))]
	public class Bind : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bind(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Detachs an external reference from a drawing.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class Detach : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Detach();
			return null;
		}
	}


	///<summary>
	///Creates a Table object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("NumRows", typeof(System.Int32))]
	[NodeInput("NumColumns", typeof(System.Int32))]
	[NodeInput("RowHeight", typeof(System.Double))]
	[NodeInput("ColWidth", typeof(System.Double))]
	public class AddTable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddTable(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]));

		}
	}


	///<summary>
	///Specifies or returns the path of an external reference.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Path);

		}
	}


	///<summary>
	///Specifies or returns the path of an external reference.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]
	public class Set_Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Path = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the comments of a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class Comments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Comments);

		}
	}


	///<summary>
	///Specifies or returns the comments of a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]
	public class Set_Comments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Comments = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the units of measure for a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class Units : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Units);

		}
	}


	///<summary>
	///Specifies or returns the units of measure for a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("pIU", typeof(System.Object))]
	public class Set_Units : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Units = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether a block can be exploded.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class Explodable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explodable);

		}
	}


	///<summary>
	///Specifies or returns whether a block can be exploded.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("bExplodable", typeof(System.Object))]
	public class Set_Explodable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explodable = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether a block can be scaled.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class BlockScaling : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BlockScaling);

		}
	}


	///<summary>
	///Specifies or returns whether a block can be scaled.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("pBS", typeof(System.Object))]
	public class Set_BlockScaling : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BlockScaling = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns whether the block is a dynamic block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	public class IsDynamicBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsDynamicBlock);

		}
	}


	///<summary>
	///Creates an arc length dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ArcCenter", typeof(System.Object))]
	[NodeInput("FirstEndPoint", typeof(System.Object))]
	[NodeInput("SecondEndPoint", typeof(System.Object))]
	[NodeInput("ArcPoint", typeof(System.Object))]
	public class AddDimArc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimArc(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Creates a jogged radial dimension object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("ChordPoint", typeof(System.Object))]
	[NodeInput("OverrideCenter", typeof(System.Object))]
	[NodeInput("JogPoint", typeof(System.Object))]
	[NodeInput("JogAngle", typeof(System.Double))]
	public class AddDimRadialLarge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddDimRadialLarge(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]));

		}
	}


	///<summary>
	///Creates a Section object and adds it to modelspace, paperspace, or a block.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("FromPoint", typeof(System.Object))]
	[NodeInput("ToPoint", typeof(System.Object))]
	[NodeInput("planeVector", typeof(System.Object))]
	public class AddSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddSection(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates a multileader
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("PointsArray", typeof(System.Object))]
	[NodeInput("leaderLineIndex", typeof(System.Int32))]
	public class AddMLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddMLeader(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Embed raster as an OLE item.
	///</summary>
	[NodeInput("AcadBlock", typeof(object))]
	[NodeInput("ImagePath", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("Height", typeof(System.Double))]
	[NodeInput("Width", typeof(System.Double))]
	public class AddEmbeddedRaster : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddEmbeddedRaster(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}
}
