using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The standard interface for a basic TeighaX entity
///</summary>
namespace OdaX.AcadEntity 
{

	[NVP_Manifest(
		Id = "637482B5-0A24-4EFE-820A-961841776BE4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.AcadEntity_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "_AcadEntity_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadEntity_Constructor : INode 
	{
		public OdaX.IAcadEntity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadEntity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A34BC540-87AE-4289-A67B-7C207F06BDD8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.AcadEntity_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "_AcadEntity_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadEntity_ConstructorCast : INode 
	{
		public OdaX.IAcadEntity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadEntity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "B1419FB5-30D9-44B8-80BF-D74ECFCF59C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.TrueColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "TrueColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the true color of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the true color of an object.
	///</summary>
	public class TrueColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TrueColor);

		}
	}


	[NVP_Manifest(
		Id = "F55D2E01-51DA-45FC-8372-700DD526BFAC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Set_TrueColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Set_TrueColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the true color of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the true color of an object.
	///</summary>
	public class Set_TrueColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TrueColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C6BE2041-3AD9-4D21-B171-A14C7DA595B2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Layer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Layer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current layer of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the current layer of an object.
	///</summary>
	public class Layer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layer);

		}
	}


	[NVP_Manifest(
		Id = "AC2A5738-3D90-4FD1-8E64-657B6679F0ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Set_Layer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Set_Layer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current layer of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]

	///<summary>
	///Specifies or returns the current layer of an object.
	///</summary>
	public class Set_Layer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Layer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7537224D-2E30-4C40-B861-2CA15D6AA287", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current linetype of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the current linetype of an object.
	///</summary>
	public class Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Linetype);

		}
	}


	[NVP_Manifest(
		Id = "86A03B5C-F521-462E-A5EC-374300F1C539", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Set_Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Set_Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current linetype of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the current linetype of an object.
	///</summary>
	public class Set_Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Linetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0A088AAC-6139-4E23-A669-3572DE2A3B61", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.LinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "LinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype scale factor of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the linetype scale factor of an object.
	///</summary>
	public class LinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinetypeScale);

		}
	}


	[NVP_Manifest(
		Id = "F4183B48-B7E3-4C07-A7D9-AD0786C9C444", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Set_LinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Set_LinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype scale factor of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype scale factor of an object.
	///</summary>
	public class Set_LinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "588A8AF2-F55B-4860-B3BD-A838FC8F7A32", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the visibility of an object or the application.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the visibility of an object or the application.
	///</summary>
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	[NVP_Manifest(
		Id = "056FE9EF-DB39-45FA-AA74-62BAF1AA7ECB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Set_Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Set_Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the visibility of an object or the application.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("bVisible", typeof(System.Object))]

	///<summary>
	///Specifies or returns the visibility of an object or the application.
	///</summary>
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5B588E9F-2703-4405-9C09-5475E5835339", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.ArrayPolar", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "ArrayPolar", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Creates an array of selected objects in a polar pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("NumberOfObjects", typeof(System.Int32))]
	[NodeInput("AngleToFill", typeof(System.Double))]
	[NodeInput("CenterPoint", typeof(System.Object))]

	///<summary>
	///Not implemented. Creates an array of selected objects in a polar pattern.
	///</summary>
	public class ArrayPolar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrayPolar(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "BEE10982-505A-4621-B9FE-B04E5F52DA46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.ArrayRectangular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "ArrayRectangular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Creates an array of selected objects in a rectangular pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("NumberOfRows", typeof(System.Int32))]
	[NodeInput("NumberOfColumns", typeof(System.Int32))]
	[NodeInput("NumberOfLevels", typeof(System.Int32))]
	[NodeInput("DistBetweenRows", typeof(System.Double))]
	[NodeInput("DistBetweenCols", typeof(System.Double))]
	[NodeInput("DistBetweenLevels", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates an array of selected objects in a rectangular pattern.
	///</summary>
	public class ArrayRectangular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrayRectangular(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value));

		}
	}


	[NVP_Manifest(
		Id = "D022FF72-FEB2-4119-BC7C-1279CD6037D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Highlight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Highlight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Highlights or removes highlight from an entity.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("HighlightFlag", typeof(System.Object))]

	///<summary>
	///Not implemented. Highlights or removes highlight from an entity.
	///</summary>
	public class Highlight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Highlight(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FB958B65-4AC2-4326-BB1E-93E3F3A01673", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Copy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Copy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Copies a specified entity.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Copies a specified entity.
	///</summary>
	public class Copy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Copy);

		}
	}


	[NVP_Manifest(
		Id = "FD59454E-83C7-4810-A480-64308FE9848A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Move", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Move", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Moves an entity from one point to a second point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("FromPoint", typeof(System.Object))]
	[NodeInput("ToPoint", typeof(System.Object))]

	///<summary>
	///Moves an entity from one point to a second point.
	///</summary>
	public class Move : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Move(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A6CEB0DF-1602-4112-A00E-F184A6FB63FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Rotate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Rotate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Rotates an entity around a point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("BasePoint", typeof(System.Object))]
	[NodeInput("RotationAngle", typeof(System.Double))]

	///<summary>
	///Rotates an entity around a point.
	///</summary>
	public class Rotate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotate(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "849DFBD2-0789-4480-9FEC-E4E10A7BF63F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Rotate3D", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Rotate3D", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Rotates an entity around a line defined by two points, where the direction of the axis if from the first point to the second point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("RotationAngle", typeof(System.Double))]

	///<summary>
	///Rotates an entity around a line defined by two points, where the direction of the axis if from the first point to the second point.
	///</summary>
	public class Rotate3D : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotate3D(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3410BA2D-92C2-4665-B7F7-5198ACD43454", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Mirror", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Mirror", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Mirrors an object around a line defined by two points.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]

	///<summary>
	///Not implemented. Mirrors an object around a line defined by two points.
	///</summary>
	public class Mirror : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Mirror(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "69354A1D-305D-4812-8271-DD7399EF097C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Mirror3D", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Mirror3D", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Mirrors an object around a plane defined by three points.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("point3", typeof(System.Object))]

	///<summary>
	///Not implemented. Mirrors an object around a plane defined by three points.
	///</summary>
	public class Mirror3D : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Mirror3D(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "0FDC66B3-1C99-4A15-9F7F-A38F9B7E18A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.ScaleEntity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "ScaleEntity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Scales an object with respect to a base point and scale factor.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("BasePoint", typeof(System.Object))]
	[NodeInput("ScaleFactor", typeof(System.Double))]

	///<summary>
	///Scales an object with respect to a base point and scale factor.
	///</summary>
	public class ScaleEntity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleEntity(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C18AA3D9-2948-4A74-8F12-F84BDB305A61", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.TransformBy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "TransformBy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Performs the specified transformation on an entity.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("TransformationMatrix", typeof(System.Object))]

	///<summary>
	///Performs the specified transformation on an entity.
	///</summary>
	public class TransformBy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TransformBy(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "86187F58-05C2-44DC-B3BF-50B5DA019B6E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Update", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Update", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Updates the display of an entity.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Not implemented. Updates the display of an entity.
	///</summary>
	public class Update : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Update();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F20A9EAC-3F58-4655-9CDB-FAF48B1D5238", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.GetBoundingBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "GetBoundingBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the minimum and maximum point of an entity's bounding box.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("MinPoint", typeof(System.Object))]
	[NodeInput("MaxPoint", typeof(System.Object))]

	///<summary>
	///Returns the minimum and maximum point of an entity's bounding box.
	///</summary>
	public class GetBoundingBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetBoundingBox(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "45559DA1-4456-4676-B2B5-25EA82F49BDF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.IntersectWith", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "IntersectWith", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "input) IntersectObject.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("IntersectObject", typeof(System.Object))]
	[NodeInput("OdaX.AcExtendOption", typeof(System.Object))]

	///<summary>
	///input) IntersectObject.
	///</summary>
	public class IntersectWith : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectWith(inputs[1].Value,((OdaX.AcExtendOption)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Id = "E4A07993-EAB4-429B-B80F-875AA610D9DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.PlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "PlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the plot style name of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the plot style name of an object.
	///</summary>
	public class PlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotStyleName);

		}
	}


	[NVP_Manifest(
		Id = "6E8C1A26-AA00-42A5-A1D2-5C996612799C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Set_PlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Set_PlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the plot style name of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies or returns the plot style name of an object.
	///</summary>
	public class Set_PlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1A820D8B-6451-4217-8D75-0D8F4BB022AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Lineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Lineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of an object.
	///</summary>
	public class Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lineweight);

		}
	}


	[NVP_Manifest(
		Id = "A70C2172-34CA-4783-BF67-BA08B2168B19", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Set_Lineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Set_Lineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of an object.
	///</summary>
	public class Set_Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1F2E05B0-C4FC-4A2C-97C3-57EB243F9AAA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Hyperlinks", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Hyperlinks", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "if one is specified).", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///if one is specified).
	///</summary>
	public class Hyperlinks : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Hyperlinks);

		}
	}


	[NVP_Manifest(
		Id = "5D82DBF9-9968-4F7D-AD61-0FC2FE628347", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the material of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies or returns the material of an object.
	///</summary>
	public class Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Material);

		}
	}


	[NVP_Manifest(
		Id = "0FF90FE4-FF7F-41CE-B6E9-B64456366BC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Set_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Set_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the material of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("Material", typeof(System.String))]

	///<summary>
	///Specifies or returns the material of an object.
	///</summary>
	public class Set_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Material = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "87118F44-2E1B-4279-81CF-210090F7E3CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.EntityName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "EntityName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the class name of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Returns the class name of the object.
	///</summary>
	public class EntityName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EntityName);

		}
	}


	[NVP_Manifest(
		Id = "1394E73D-136A-46F9-96A7-CAB9900B2305", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.EntityType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "EntityType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the entity type of the object as an integer.", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Returns the entity type of the object as an integer.
	///</summary>
	public class EntityType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EntityType);

		}
	}


	[NVP_Manifest(
		Id = "9D51C168-47F3-4DC7-B90E-F8FE07057004", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "color", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the color for objects", 
		ViewType = "Data")]
	[NodeInput("AcadEntity", typeof(object))]

	///<summary>
	///Specifies the color for objects
	///</summary>
	public class color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.color);

		}
	}


	[NVP_Manifest(
		Id = "AD0B15C9-1F45-48A4-9F1E-3A6B00503663", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadEntity.Set_color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadEntity", 
		NodeName = "Set_color", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the color for objects", 
		ViewType = "Modifier")]
	[NodeInput("AcadEntity", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies the color for objects
	///</summary>
	public class Set_color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.color = inputs[1].Value;
			return null;
		}
	}
}
