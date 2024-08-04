using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an area fill consisting of a pattern of lines
///</summary>
namespace OdaX.AcadHatch 
{

	[NVP_Manifest(
		Id = "0A7F1FFA-EE4A-4E57-BA0C-805B4E6AD2CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.AcadHatch_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "_AcadHatch_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadHatch_Constructor : INode 
	{
		public OdaX.IAcadHatch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadHatch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "DA20F35D-726B-4EFC-BB04-BADA766E902F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.AcadHatch_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "_AcadHatch_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadHatch_ConstructorCast : INode 
	{
		public OdaX.IAcadHatch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadHatch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2F9AB1C6-9B11-4F43-93D4-98050764451C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
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
		Id = "F17D49D6-1855-4058-86D0-0CA9353EFE23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
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
		Id = "9E047288-0F96-4EA9-A9B6-52094A4F44AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.NumberOfLoops", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "NumberOfLoops", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of loops in a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Returns the number of loops in a hatch.
	///</summary>
	public class NumberOfLoops : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfLoops);

		}
	}


	[NVP_Manifest(
		Id = "11D115B4-1D9C-427D-BAB4-2CF50B67A78F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.PatternType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "PatternType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the pattern type of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Returns the pattern type of a hatch.
	///</summary>
	public class PatternType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternType);

		}
	}


	[NVP_Manifest(
		Id = "F161CB99-6BF3-4913-B068-37DA992A9A43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.PatternName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "PatternName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the pattern name of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Returns the pattern name of a hatch.
	///</summary>
	public class PatternName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternName);

		}
	}


	[NVP_Manifest(
		Id = "1A5F7A35-E298-4656-904C-38DD847D7E2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.PatternAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "PatternAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the pattern angle of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the pattern angle of a hatch.
	///</summary>
	public class PatternAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternAngle);

		}
	}


	[NVP_Manifest(
		Id = "5CAF56FB-3F98-4DC8-B4ED-21C760147CBD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_PatternAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_PatternAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the pattern angle of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("PatternAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the pattern angle of a hatch.
	///</summary>
	public class Set_PatternAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3C559E8E-0AA4-4A3C-828B-9B2AB1955100", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.PatternScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "PatternScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the pattern scale of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the pattern scale of a hatch.
	///</summary>
	public class PatternScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternScale);

		}
	}


	[NVP_Manifest(
		Id = "39D40EA2-4172-4B8A-8118-6D3FD9840660", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_PatternScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_PatternScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the pattern scale of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("PatternScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the pattern scale of a hatch.
	///</summary>
	public class Set_PatternScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D11B309C-C1D2-484C-8545-78BDFEB01FE7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.PatternSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "PatternSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the pattern spacing of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the pattern spacing of a hatch.
	///</summary>
	public class PatternSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternSpace);

		}
	}


	[NVP_Manifest(
		Id = "B2BF8E4A-78AA-42D3-A910-02196F4B9254", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_PatternSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_PatternSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the pattern spacing of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("PatternSpace", typeof(System.Double))]

	///<summary>
	///Specifies or returns the pattern spacing of a hatch.
	///</summary>
	public class Set_PatternSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternSpace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8F59079C-84BB-4E8E-A1B2-A0DB2F2E2981", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.ISOPenWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "ISOPenWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the ISO pen width of an ISO hatch pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the ISO pen width of an ISO hatch pattern.
	///</summary>
	public class ISOPenWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ISOPenWidth);

		}
	}


	[NVP_Manifest(
		Id = "5C877F26-588E-487F-BB64-06B58B9F7852", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_ISOPenWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_ISOPenWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the ISO pen width of an ISO hatch pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("OdaX.AcISOPenWidth", typeof(System.Object))]

	///<summary>
	///Specifies or returns the ISO pen width of an ISO hatch pattern.
	///</summary>
	public class Set_ISOPenWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ISOPenWidth = ((OdaX.AcISOPenWidth)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F7A11AE0-C649-4ED6-A94B-F31783D032A1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.PatternDouble", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "PatternDouble", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether cross-hatching is used to create a double pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns whether cross-hatching is used to create a double pattern.
	///</summary>
	public class PatternDouble : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternDouble);

		}
	}


	[NVP_Manifest(
		Id = "CD9DC47C-C0C7-466E-9583-03D4203259EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_PatternDouble", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_PatternDouble", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether cross-hatching is used to create a double pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("bDouble", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether cross-hatching is used to create a double pattern.
	///</summary>
	public class Set_PatternDouble : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternDouble = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8A22EB2A-2CF1-4010-B3BA-B9F11B075782", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the elevation of the hatch relative to the z-axis of the object's coordinate system.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the elevation of the hatch relative to the z-axis of the object's coordinate system.
	///</summary>
	public class Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Elevation);

		}
	}


	[NVP_Manifest(
		Id = "D4E7120A-5742-4488-82F3-6757F605043E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the elevation of the hatch relative to the z-axis of the object's coordinate system.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Elevation", typeof(System.Double))]

	///<summary>
	///Specifies or returns the elevation of the hatch relative to the z-axis of the object's coordinate system.
	///</summary>
	public class Set_Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Elevation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0F808201-D58D-4A39-9A6F-8C76F884EBBA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.AssociativeHatch", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "AssociativeHatch", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a hatch updates automatically when its boundary changes.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns whether a hatch updates automatically when its boundary changes.
	///</summary>
	public class AssociativeHatch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AssociativeHatch);

		}
	}


	[NVP_Manifest(
		Id = "3AF6A359-ED22-40CE-AF39-4A3D26DBA3E2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_AssociativeHatch", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_AssociativeHatch", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a hatch updates automatically when its boundary changes.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("fAssoc", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a hatch updates automatically when its boundary changes.
	///</summary>
	public class Set_AssociativeHatch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AssociativeHatch = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A4558C7A-0821-4FAC-9E23-EDBF7F87399C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.HatchStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "HatchStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch style.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the hatch style.
	///</summary>
	public class HatchStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HatchStyle);

		}
	}


	[NVP_Manifest(
		Id = "AA201C18-E97A-40AF-A6A1-8A503EC1F08A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_HatchStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_HatchStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("OdaX.AcHatchStyle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the hatch style.
	///</summary>
	public class Set_HatchStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HatchStyle = ((OdaX.AcHatchStyle)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0B909F10-12D3-4F23-9AFD-34CD71CE6BA2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.SetPattern", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "SetPattern", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the pattern of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("PatternType", typeof(System.Int32))]
	[NodeInput("PatternName", typeof(System.String))]

	///<summary>
	///Specifies the pattern of a hatch.
	///</summary>
	public class SetPattern : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetPattern(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2D08A507-8BB5-4FAF-8550-992E22161897", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.AppendOuterLoop_Single", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "AppendOuterLoop_Single", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds the outer loop (one entity) to a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("AcadEntity", typeof(System.Object))]

	///<summary>
	///Adds the outer loop to a hatch for one entity
	///</summary>
	public class AppendOuterLoop_Single : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			object[] ents = new object[1] { inputs[1].Value };
			_input0._i.AppendOuterLoop(ents);
			return null;
		}
	}

    [NVP_Manifest(
    Id = "C2BAE7AF-984E-4E70-B775-F60622C88B22",
    PathAssembly = "NVP_nanoCAD_COM.dll",
    PathExecuteClass = "OdaX.AcadHatch.AppendOuterLoop_Group",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch",
    NodeName = "AppendOuterLoop_Group",
    NodeType = "Loaded",
    CADType = "None",
    Text = "Adds the outer loop (some entities) to a hatch.",
    ViewType = "Modifier")]
    [NodeInput("AcadHatch", typeof(object))]
    [NodeInput("The array of AcadEntity", typeof(System.Object))]

    ///<summary>
    ///Adds the outer loop to a hatch fro some entities
    ///</summary>
    public class AppendOuterLoop_Group : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            _input0._i.AppendOuterLoop(inputs[1].Value);
            return null;
        }
    }


    [NVP_Manifest(
		Id = "28B435FE-3766-4E4D-B33B-274EAF039F4E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.AppendInnerLoop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "AppendInnerLoop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds an inner loop to a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("ObjectArray", typeof(System.Object))]

	///<summary>
	///Adds an inner loop to a hatch.
	///</summary>
	public class AppendInnerLoop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AppendInnerLoop(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "34BD6A88-AFDC-4DF3-97AC-DA762894F2A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.InsertLoopAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "InsertLoopAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds a loop at a specified index of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("OdaX.AcLoopType", typeof(System.Object))]
	[NodeInput("ObjectArray", typeof(System.Object))]

	///<summary>
	///Adds a loop at a specified index of a hatch.
	///</summary>
	public class InsertLoopAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertLoopAt(inputs[1].Value,((OdaX.AcLoopType)inputs[2].Value),inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7E63522B-248C-4490-BA2B-B7DC9B577FFE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.GetLoopAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "GetLoopAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns a loop at a specified index of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("ObjectArray", typeof(System.Object))]

	///<summary>
	///Returns a loop at a specified index of a hatch.
	///</summary>
	public class GetLoopAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetLoopAt(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D4D0A14A-7E04-48CF-9E0E-C376ACC1541A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Evaluate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Evaluate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Calculates and fills the pattern of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Calculates and fills the pattern of a hatch.
	///</summary>
	public class Evaluate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Evaluate();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5FEC07E6-ADF0-4111-A20C-E48432E58D05", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.GradientColor1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "GradientColor1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the gradient start color of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the gradient start color of a hatch.
	///</summary>
	public class GradientColor1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientColor1);

		}
	}


	[NVP_Manifest(
		Id = "97C28818-C2A2-4C8C-8351-D6DB7B44F010", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_GradientColor1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_GradientColor1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the gradient start color of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the gradient start color of a hatch.
	///</summary>
	public class Set_GradientColor1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientColor1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "136E5811-5B89-4473-8414-C2EF4AAED451", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.GradientColor2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "GradientColor2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the gradient end color of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the gradient end color of a hatch.
	///</summary>
	public class GradientColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientColor2);

		}
	}


	[NVP_Manifest(
		Id = "7CE47C0C-6DBE-441F-A3F0-4DA4899CCAA8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_GradientColor2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_GradientColor2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the gradient end color of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the gradient end color of a hatch.
	///</summary>
	public class Set_GradientColor2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientColor2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BBFB85AB-4D72-4622-B752-89C31C0C6B54", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.GradientAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "GradientAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the gradient angle of a hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the gradient angle of a hatch.
	///</summary>
	public class GradientAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientAngle);

		}
	}


	[NVP_Manifest(
		Id = "068A1093-5403-458D-A473-745E4B4ECA09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_GradientAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_GradientAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the gradient angle of a hatch.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("GradientAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the gradient angle of a hatch.
	///</summary>
	public class Set_GradientAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4CA05E6B-899A-496C-B2FB-CF27C7E7F54E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.GradientCentered", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "GradientCentered", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the gradient is centered.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns whether the gradient is centered.
	///</summary>
	public class GradientCentered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientCentered);

		}
	}


	[NVP_Manifest(
		Id = "F6F787D2-6A0D-48DF-8017-FDAA24B72B55", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_GradientCentered", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_GradientCentered", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the gradient is centered.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("fCentered", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the gradient is centered.
	///</summary>
	public class Set_GradientCentered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientCentered = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6953DB7F-A172-4D51-9914-E9E0598A2FBD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.GradientName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "GradientName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the pattern name of the gradient.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the pattern name of the gradient.
	///</summary>
	public class GradientName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradientName);

		}
	}


	[NVP_Manifest(
		Id = "0FAE30DA-EA1C-46C8-99A1-705D5AD1B51C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_GradientName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_GradientName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the pattern name of the gradient.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the pattern name of the gradient.
	///</summary>
	public class Set_GradientName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GradientName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "57CBC139-44D0-4125-9C13-CC7EBC1C1DB7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.HatchObjectType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "HatchObjectType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch type.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the hatch type.
	///</summary>
	public class HatchObjectType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HatchObjectType);

		}
	}


	[NVP_Manifest(
		Id = "CFD6209F-24EB-48FE-AD5E-6F861B7FD0E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_HatchObjectType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_HatchObjectType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch type.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("OdaX.AcHatchObjectType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the hatch type.
	///</summary>
	public class Set_HatchObjectType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HatchObjectType = ((OdaX.AcHatchObjectType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "03B2D36F-E07F-4EEE-B86D-76CD56FFB79C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Area", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Area", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Returns the area of the hatch.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Not implemented. Returns the area of the hatch.
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
		Id = "F2F29807-672F-46E6-B163-3B37E0CFCEB0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinates for the origin of the hatch pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch", typeof(object))]

	///<summary>
	///Specifies or returns the coordinates for the origin of the hatch pattern.
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
		Id = "C7704010-0D2B-4AA2-AACD-870ABCDCA3BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHatch.Set_Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHatch", 
		NodeName = "Set_Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinates for the origin of the hatch pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch", typeof(object))]
	[NodeInput("Origin", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinates for the origin of the hatch pattern.
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
}
