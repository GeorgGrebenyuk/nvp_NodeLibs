using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a linear dimension, measuring the distance between two points, that is displayed parallel to the points being measured
///</summary>
namespace OdaX.AcadDimAligned 
{

	[NVP_Manifest(
		Id = "4DB4DB9B-EC61-44ED-8652-610731701289", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AcadDimAligned_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "_AcadDimAligned_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimAligned_Constructor : INode 
	{
		public OdaX.IAcadDimAligned _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDimAligned;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5C3689CF-1CFB-4BBF-81A7-20A744810463", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AcadDimAligned_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "_AcadDimAligned_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimAligned_ConstructorCast : INode 
	{
		public OdaX.IAcadDimAligned _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDimAligned;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FC60D68E-4062-48B0-873F-BA9744DCA2F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ExtLine1Point", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ExtLine1Point", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the first extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the start point of the first extension line.
	///</summary>
	public class ExtLine1Point : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine1Point);

		}
	}


	[NVP_Manifest(
		Id = "5DD1D5C2-0BAB-46FE-BC14-F3CC2BA493C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ExtLine1Point", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ExtLine1Point", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the first extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("xLine1Point", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start point of the first extension line.
	///</summary>
	public class Set_ExtLine1Point : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine1Point = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5F2E9BAD-92C9-4FBB-94A4-150B04548224", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ExtLine2Point", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ExtLine2Point", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the second extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the start point of the second extension line.
	///</summary>
	public class ExtLine2Point : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine2Point);

		}
	}


	[NVP_Manifest(
		Id = "F56774BB-353C-4257-BF5E-2EED0CFEC8C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ExtLine2Point", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ExtLine2Point", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the second extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("xLine2Point", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start point of the second extension line.
	///</summary>
	public class Set_ExtLine2Point : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine2Point = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "95ED1F9D-67EA-4C6D-AA30-BD2181515378", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether alternate units are used for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether alternate units are used for dimensions.
	///</summary>
	public class AltUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltUnits);

		}
	}


	[NVP_Manifest(
		Id = "67B181A2-E1A4-4A7D-BA5A-55CC2F2F2388", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether alternate units are used for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bAlternate", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether alternate units are used for dimensions.
	///</summary>
	public class Set_AltUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltUnits = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FBB8A90E-CAFE-49EE-8CFC-068E7F66D8FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltUnitsPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltUnitsPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for alternate unit dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the number of decimal places for alternate unit dimension.
	///</summary>
	public class AltUnitsPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltUnitsPrecision);

		}
	}


	[NVP_Manifest(
		Id = "22D3AB6E-7238-4878-8480-6B117B5C9A3B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltUnitsPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltUnitsPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for alternate unit dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("OdaX.AcDimPrecision", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of decimal places for alternate unit dimension.
	///</summary>
	public class Set_AltUnitsPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltUnitsPrecision = ((OdaX.AcDimPrecision)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E5EA8DA7-C4CA-409A-9513-3DCCAE977FA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltUnitsScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltUnitsScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor for alternate unit dimensions.
	///</summary>
	public class AltUnitsScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltUnitsScale);

		}
	}


	[NVP_Manifest(
		Id = "DD1D7C48-0333-49FD-97ED-A4E3472FF50C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltUnitsScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltUnitsScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("scale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor for alternate unit dimensions.
	///</summary>
	public class Set_AltUnitsScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltUnitsScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "45C41D4F-A19A-4029-B024-117C4E9253C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltRoundDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltRoundDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rounding value for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the rounding value for alternate unit dimensions.
	///</summary>
	public class AltRoundDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltRoundDistance);

		}
	}


	[NVP_Manifest(
		Id = "D9EC1856-A814-4221-A552-38EC238F1CBF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltRoundDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltRoundDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rounding value for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Specifies or returns the rounding value for alternate unit dimensions.
	///</summary>
	public class Set_AltRoundDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltRoundDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9AC83D96-EB50-4D30-80CA-56D715D7650C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltTolerancePrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltTolerancePrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.
	///</summary>
	public class AltTolerancePrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltTolerancePrecision);

		}
	}


	[NVP_Manifest(
		Id = "92ECDB76-A897-4590-9E6E-FA57D3CCD131", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltTolerancePrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltTolerancePrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("OdaX.AcDimPrecision", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.
	///</summary>
	public class Set_AltTolerancePrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltTolerancePrecision = ((OdaX.AcDimPrecision)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "122F6926-3235-4C9A-8D49-F2AD7A5B1E97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltUnitsFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltUnitsFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///not including angular dimensions).
	///</summary>
	public class AltUnitsFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltUnitsFormat);

		}
	}


	[NVP_Manifest(
		Id = "75E2B63F-56DC-4746-B807-5CF3AF41D007", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltUnitsFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltUnitsFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("OdaX.AcDimUnits", typeof(System.Object))]

	///<summary>
	///not including angular dimensions).
	///</summary>
	public class Set_AltUnitsFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltUnitsFormat = ((OdaX.AcDimUnits)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6F52D52A-F307-4E8F-A0A2-15E72E91C0C0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltTextPrefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltTextPrefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///not including angular dimensions).
	///</summary>
	public class AltTextPrefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltTextPrefix);

		}
	}


	[NVP_Manifest(
		Id = "E0251720-9AD1-4B51-98D3-5163A3B1082D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltTextPrefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltTextPrefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("prefix", typeof(System.String))]

	///<summary>
	///not including angular dimensions).
	///</summary>
	public class Set_AltTextPrefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltTextPrefix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "74847C19-3331-42A8-9605-6F1FCF4D16EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltTextSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltTextSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///not including angular dimensions).
	///</summary>
	public class AltTextSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltTextSuffix);

		}
	}


	[NVP_Manifest(
		Id = "4D07B763-14DF-4D2D-868E-F9ECD3277CD8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltTextSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltTextSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("suffix", typeof(System.String))]

	///<summary>
	///not including angular dimensions).
	///</summary>
	public class Set_AltTextSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltTextSuffix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "94053DAA-B446-480E-86EF-D540A384ED9E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimensionLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimensionLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the color of dimension lines.
	///</summary>
	public class DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineColor);

		}
	}


	[NVP_Manifest(
		Id = "483BF44C-839C-4D63-9F95-84887A5A8D76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimensionLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimensionLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of dimension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of dimension lines.
	///</summary>
	public class Set_DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E3D884E8-2D71-447E-BC7D-891F8A8D0A25", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ExtensionLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ExtensionLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the color of extension lines.
	///</summary>
	public class ExtensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtensionLineColor);

		}
	}


	[NVP_Manifest(
		Id = "36AF86BC-836A-4591-8927-A8CED70473AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ExtensionLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ExtensionLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of extension lines.
	///</summary>
	public class Set_ExtensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtensionLineColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E7E20550-3254-4A5B-8982-6C3825D19653", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.PrimaryUnitsPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "PrimaryUnitsPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for the primary units of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the number of decimal places for the primary units of dimensions.
	///</summary>
	public class PrimaryUnitsPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrimaryUnitsPrecision);

		}
	}


	[NVP_Manifest(
		Id = "2AF5B058-3510-41A3-9668-C9624CD12AB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_PrimaryUnitsPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_PrimaryUnitsPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for the primary units of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("OdaX.AcDimPrecision", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of decimal places for the primary units of dimensions.
	///</summary>
	public class Set_PrimaryUnitsPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrimaryUnitsPrecision = ((OdaX.AcDimPrecision)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4FB8B2F6-38D6-4101-B497-F4150B53C96E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimensionLineExtend", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimensionLineExtend", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how far dimension lines extend beyond extension lines when using dimension lines with oblique strokes.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns how far dimension lines extend beyond extension lines when using dimension lines with oblique strokes.
	///</summary>
	public class DimensionLineExtend : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineExtend);

		}
	}


	[NVP_Manifest(
		Id = "A3E1CABF-DAFC-4ACF-971F-55AADA18739A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimensionLineExtend", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimensionLineExtend", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how far dimension lines extend beyond extension lines when using dimension lines with oblique strokes.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("extend", typeof(System.Double))]

	///<summary>
	///Specifies or returns how far dimension lines extend beyond extension lines when using dimension lines with oblique strokes.
	///</summary>
	public class Set_DimensionLineExtend : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineExtend = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D6132D8F-ECC3-476A-8809-10D7E511890E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ExtensionLineExtend", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ExtensionLineExtend", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how far extension lines extend beyond dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns how far extension lines extend beyond dimension lines.
	///</summary>
	public class ExtensionLineExtend : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtensionLineExtend);

		}
	}


	[NVP_Manifest(
		Id = "F67FC464-92AD-4625-92C5-3BF579100103", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ExtensionLineExtend", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ExtensionLineExtend", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how far extension lines extend beyond dimension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("extend", typeof(System.Double))]

	///<summary>
	///Specifies or returns how far extension lines extend beyond dimension lines.
	///</summary>
	public class Set_ExtensionLineExtend : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtensionLineExtend = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DA654923-44D6-483D-9A8A-7E945191BD44", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Fit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Fit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.
	///</summary>
	public class Fit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Fit);

		}
	}


	[NVP_Manifest(
		Id = "7F03099A-0FAF-46EA-9986-840880C90352", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_Fit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_Fit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("OdaX.AcDimFit", typeof(System.Object))]

	///<summary>
	///Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.
	///</summary>
	public class Set_Fit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Fit = ((OdaX.AcDimFit)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "57137520-4491-4293-BBF3-B4509C3E8832", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.FractionFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "FractionFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how fractions display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns how fractions display for dimensions.
	///</summary>
	public class FractionFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FractionFormat);

		}
	}


	[NVP_Manifest(
		Id = "14EED2AA-9CB9-4ADB-B256-C6671CAEA647", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_FractionFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_FractionFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how fractions display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("OdaX.AcDimFractionType", typeof(System.Object))]

	///<summary>
	///Specifies or returns how fractions display for dimensions.
	///</summary>
	public class Set_FractionFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FractionFormat = ((OdaX.AcDimFractionType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E4626142-16B8-4087-8308-C7658A8439D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.HorizontalTextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "HorizontalTextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal position of dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the horizontal position of dimension text.
	///</summary>
	public class HorizontalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorizontalTextPosition);

		}
	}


	[NVP_Manifest(
		Id = "D0EE8F24-5CED-476B-8AE1-80309DF3FF2E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_HorizontalTextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_HorizontalTextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal position of dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("OdaX.AcDimHorizontalJustification", typeof(System.Object))]

	///<summary>
	///Specifies or returns the horizontal position of dimension text.
	///</summary>
	public class Set_HorizontalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorizontalTextPosition = ((OdaX.AcDimHorizontalJustification)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DF4CDEAF-6B66-4063-9E7E-698EB8CFBB99", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.LinearScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "LinearScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor for linear dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor for linear dimensions.
	///</summary>
	public class LinearScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinearScaleFactor);

		}
	}


	[NVP_Manifest(
		Id = "AE87118E-283E-43F0-8D95-7280B2E91673", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_LinearScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_LinearScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor for linear dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor for linear dimensions.
	///</summary>
	public class Set_LinearScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinearScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0BC1442B-CC15-4D77-9D66-109FD317F1E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.UnitsFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "UnitsFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the unit of measurement for linear dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the unit of measurement for linear dimensions.
	///</summary>
	public class UnitsFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitsFormat);

		}
	}


	[NVP_Manifest(
		Id = "26AE1CB5-5DA9-463F-B9B2-D000BCC0F289", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_UnitsFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_UnitsFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the unit of measurement for linear dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("OdaX.AcDimLUnits", typeof(System.Object))]

	///<summary>
	///Specifies or returns the unit of measurement for linear dimensions.
	///</summary>
	public class Set_UnitsFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnitsFormat = ((OdaX.AcDimLUnits)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C1FC92F8-E100-43C9-A4C3-DC2801E549DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ExtensionLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ExtensionLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of extension lines.
	///</summary>
	public class ExtensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtensionLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "0DDC8193-6FB3-44E9-8F75-A8923E058FFE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ExtensionLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ExtensionLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("lweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of extension lines.
	///</summary>
	public class Set_ExtensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtensionLineWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D081EAFE-DCD4-4714-A746-EA309F4879CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.RoundDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "RoundDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how measurements are rounded for all dimensions except angular dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns how measurements are rounded for all dimensions except angular dimensions.
	///</summary>
	public class RoundDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RoundDistance);

		}
	}


	[NVP_Manifest(
		Id = "A336782A-D6AA-4CD0-8A4C-2A3ADC9E87AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_RoundDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_RoundDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how measurements are rounded for all dimensions except angular dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Specifies or returns how measurements are rounded for all dimensions except angular dimensions.
	///</summary>
	public class Set_RoundDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RoundDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0D88F3E3-65DD-4D8C-B452-E89086E3DFE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimLine1Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimLine1Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the first dimension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether the first dimension line displays.
	///</summary>
	public class DimLine1Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimLine1Suppress);

		}
	}


	[NVP_Manifest(
		Id = "34EF6F8B-FDD0-447B-AEBE-6567ED4F08F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimLine1Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimLine1Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the first dimension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bSuppress", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the first dimension line displays.
	///</summary>
	public class Set_DimLine1Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimLine1Suppress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F11D1E76-EA27-4FEA-AF62-361991BBBED2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimLine2Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimLine2Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the second dimension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether the second dimension line displays.
	///</summary>
	public class DimLine2Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimLine2Suppress);

		}
	}


	[NVP_Manifest(
		Id = "1350BD5A-9C4B-4505-A31E-CFD87D747DAB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimLine2Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimLine2Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the second dimension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bSuppress", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the second dimension line displays.
	///</summary>
	public class Set_DimLine2Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimLine2Suppress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "58588A6B-0233-481F-9A65-AB35DA82C68D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ExtLine1Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ExtLine1Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the first extension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether the first extension line displays.
	///</summary>
	public class ExtLine1Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine1Suppress);

		}
	}


	[NVP_Manifest(
		Id = "8609605D-2BC5-4074-9CCA-B46E30544BAE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ExtLine1Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ExtLine1Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the first extension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bSuppress", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the first extension line displays.
	///</summary>
	public class Set_ExtLine1Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine1Suppress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2D4BAC53-4D53-4C02-AC4D-9DA3EE2781C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ExtLine2Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ExtLine2Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the second extension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether the second extension line displays.
	///</summary>
	public class ExtLine2Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine2Suppress);

		}
	}


	[NVP_Manifest(
		Id = "1D9B00F5-DA89-4705-9F60-175DB5420CBB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ExtLine2Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ExtLine2Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the second extension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bSuppress", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the second extension line displays.
	///</summary>
	public class Set_ExtLine2Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine2Suppress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B2C38271-B606-4D93-9FC3-DF730A204A91", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimLineInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimLineInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension lines are drawn outside of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether dimension lines are drawn outside of extension lines.
	///</summary>
	public class DimLineInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimLineInside);

		}
	}


	[NVP_Manifest(
		Id = "6DECB140-184C-4632-B493-4005BD8C1457", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimLineInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimLineInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension lines are drawn outside of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dimension lines are drawn outside of extension lines.
	///</summary>
	public class Set_DimLineInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimLineInside = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "14C0BD4C-F443-4281-8799-E3067E9BE39B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.TextInsideAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "TextInsideAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text displays between extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether dimension text displays between extension lines.
	///</summary>
	public class TextInsideAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextInsideAlign);

		}
	}


	[NVP_Manifest(
		Id = "DBC15EA8-B074-4009-969E-0ACEC608A5AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_TextInsideAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_TextInsideAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text displays between extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dimension text displays between extension lines.
	///</summary>
	public class Set_TextInsideAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextInsideAlign = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F209D6B4-DB4C-49B9-825C-BE2287E2790D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.TextInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "TextInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.
	///</summary>
	public class TextInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextInside);

		}
	}


	[NVP_Manifest(
		Id = "62D63874-6823-4217-8900-BEE85A995FE5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_TextInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_TextInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.
	///</summary>
	public class Set_TextInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextInside = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0A000A57-EDCA-4F43-81F9-90E8F97CEE63", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ForceLineInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ForceLineInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.
	///</summary>
	public class ForceLineInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForceLineInside);

		}
	}


	[NVP_Manifest(
		Id = "0E2B0AB0-06D3-4D9C-AFE1-5DA32182B3C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ForceLineInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ForceLineInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.
	///</summary>
	public class Set_ForceLineInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForceLineInside = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A566B24D-371A-4DE3-9698-960979D2DC81", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.TextOutsideAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "TextOutsideAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text displays outside of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether dimension text displays outside of extension lines.
	///</summary>
	public class TextOutsideAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextOutsideAlign);

		}
	}


	[NVP_Manifest(
		Id = "CE47F820-4985-40A2-A6FE-DAB72976D3FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_TextOutsideAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_TextOutsideAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text displays outside of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dimension text displays outside of extension lines.
	///</summary>
	public class Set_TextOutsideAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextOutsideAlign = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "55AC3E37-83ED-450C-A7D6-92F05DD2566A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ExtensionLineOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ExtensionLineOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the distance between extension lines and the object being dimensioned.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the distance between extension lines and the object being dimensioned.
	///</summary>
	public class ExtensionLineOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtensionLineOffset);

		}
	}


	[NVP_Manifest(
		Id = "B00027AE-0CF8-4E69-B453-2F40565A6C16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ExtensionLineOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ExtensionLineOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the distance between extension lines and the object being dimensioned.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("Offset", typeof(System.Double))]

	///<summary>
	///Specifies or returns the distance between extension lines and the object being dimensioned.
	///</summary>
	public class Set_ExtensionLineOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtensionLineOffset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "88F64D44-8769-4383-9D1F-24D2E9071211", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether leading zeros display for alternate unit dimensions.
	///</summary>
	public class AltSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSuppressLeadingZeros);

		}
	}


	[NVP_Manifest(
		Id = "975356A9-9B49-40FA-89D3-7663B3B2468D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether leading zeros display for alternate unit dimensions.
	///</summary>
	public class Set_AltSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSuppressLeadingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E107A94B-10CF-469F-897E-A084F48A6650", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether leading zeros display for alternate unit dimensions.
	///</summary>
	public class AltSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSuppressTrailingZeros);

		}
	}


	[NVP_Manifest(
		Id = "8F41A426-0050-4C3B-B540-3DB5C6D70928", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether leading zeros display for alternate unit dimensions.
	///</summary>
	public class Set_AltSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSuppressTrailingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4199901F-BD84-4B4E-8D45-6CAED6BEEB3F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for alternate unit dimensions.
	///</summary>
	public class AltSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSuppressZeroFeet);

		}
	}


	[NVP_Manifest(
		Id = "71E15957-D18C-4445-A214-1519ACAF368F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for alternate unit dimensions.
	///</summary>
	public class Set_AltSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSuppressZeroFeet = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "80213BB7-3250-4D24-B887-12C1A05BCD93", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for alternate unit dimensions.
	///</summary>
	public class AltSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSuppressZeroInches);

		}
	}


	[NVP_Manifest(
		Id = "4B60F6A3-6083-4FC3-8D1D-18E05C752D43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for alternate unit dimensions.
	///</summary>
	public class Set_AltSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSuppressZeroInches = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "19D70492-1B8D-43E5-AE2B-48E1D8CBA1E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltToleranceSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltToleranceSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.
	///</summary>
	public class AltToleranceSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltToleranceSuppressLeadingZeros);

		}
	}


	[NVP_Manifest(
		Id = "D1A06CF2-A30C-4507-8270-0C782050632C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltToleranceSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltToleranceSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.
	///</summary>
	public class Set_AltToleranceSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltToleranceSuppressLeadingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2B100598-2212-4638-B112-5C4D9F2D2AF7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltToleranceSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltToleranceSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.
	///</summary>
	public class AltToleranceSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltToleranceSuppressTrailingZeros);

		}
	}


	[NVP_Manifest(
		Id = "F172785D-DD69-472B-BE12-425499A783E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltToleranceSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltToleranceSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.
	///</summary>
	public class Set_AltToleranceSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltToleranceSuppressTrailingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "834E25F8-175F-4311-8F47-0A933277D715", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltToleranceSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltToleranceSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.
	///</summary>
	public class AltToleranceSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltToleranceSuppressZeroFeet);

		}
	}


	[NVP_Manifest(
		Id = "0B7FFA28-2F09-4FCB-91CE-A86648577644", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltToleranceSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltToleranceSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.
	///</summary>
	public class Set_AltToleranceSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltToleranceSuppressZeroFeet = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "503227DA-9AE1-4CED-AE72-F94EA0260961", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltToleranceSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltToleranceSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.
	///</summary>
	public class AltToleranceSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltToleranceSuppressZeroInches);

		}
	}


	[NVP_Manifest(
		Id = "256BB4D8-0CDB-4A0B-87F5-D3C09F3FA6A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltToleranceSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltToleranceSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.
	///</summary>
	public class Set_AltToleranceSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltToleranceSuppressZeroInches = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E904153A-EF96-447B-84D1-4C9B1D9B60A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.SuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "SuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for dimensions.
	///</summary>
	public class SuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressZeroFeet);

		}
	}


	[NVP_Manifest(
		Id = "9AC07887-A53C-48B8-8EDC-38DE294C0CEF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_SuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_SuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for dimensions.
	///</summary>
	public class Set_SuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressZeroFeet = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "78DFD150-2002-4094-A62F-B6A2920E4C3D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.SuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "SuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for dimensions.
	///</summary>
	public class SuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressZeroInches);

		}
	}


	[NVP_Manifest(
		Id = "1B43211B-B27B-4105-9A19-1AB835B3367A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_SuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_SuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for dimensions.
	///</summary>
	public class Set_SuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressZeroInches = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1DFF21D5-22AD-4FFD-B12E-3F3AFA9F7199", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ToleranceSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ToleranceSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for tolerance values of dimensions.
	///</summary>
	public class ToleranceSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceSuppressZeroFeet);

		}
	}


	[NVP_Manifest(
		Id = "224BF628-0349-4C23-ACDA-FE28516C40E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ToleranceSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ToleranceSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for tolerance values of dimensions.
	///</summary>
	public class Set_ToleranceSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceSuppressZeroFeet = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "14AAB0E9-A0E6-414E-9709-83B850145D32", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ToleranceSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ToleranceSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for tolerance values of dimensions.
	///</summary>
	public class ToleranceSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceSuppressZeroInches);

		}
	}


	[NVP_Manifest(
		Id = "A9460E5E-0081-4BD2-BAC1-8301F27BE9F5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ToleranceSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ToleranceSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for tolerance values of dimensions.
	///</summary>
	public class Set_ToleranceSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceSuppressZeroInches = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "40447EC8-9241-446E-B9C4-9E0FC6E8FD6B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimensionLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimensionLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of dimension lines.
	///</summary>
	public class DimensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "A8CE1D96-B39B-47D4-859F-AB5955BBABFE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimensionLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimensionLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of dimension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("weight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of dimension lines.
	///</summary>
	public class Set_DimensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "758F19FC-9DE2-4CEC-AAA2-013C32ED7851", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ArrowheadSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ArrowheadSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the size of dimension arrowheads.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the size of dimension arrowheads.
	///</summary>
	public class ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadSize);

		}
	}


	[NVP_Manifest(
		Id = "46686169-B059-4430-88A5-5F720973A438", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ArrowheadSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ArrowheadSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the size of dimension arrowheads.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("size", typeof(System.Double))]

	///<summary>
	///Specifies or returns the size of dimension arrowheads.
	///</summary>
	public class Set_ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "16D2549C-35F7-47D5-8448-E10C6C097573", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Arrowhead1Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Arrowhead1Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the first dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the arrowhead of the first dimension line.
	///</summary>
	public class Arrowhead1Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrowhead1Type);

		}
	}


	[NVP_Manifest(
		Id = "90B03872-8A7A-4F28-BB08-B3C7E8D9F0D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_Arrowhead1Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_Arrowhead1Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the first dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("OdaX.AcDimArrowheadType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the arrowhead of the first dimension line.
	///</summary>
	public class Set_Arrowhead1Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrowhead1Type = ((OdaX.AcDimArrowheadType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4514C286-E0C9-44E3-B73F-F21B38C1B56C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Arrowhead2Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Arrowhead2Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the second dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the arrowhead of the second dimension line.
	///</summary>
	public class Arrowhead2Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrowhead2Type);

		}
	}


	[NVP_Manifest(
		Id = "2067E5D6-D01A-49FA-A6EE-90C3C2A2CB09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_Arrowhead2Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_Arrowhead2Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the second dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("OdaX.AcDimArrowheadType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the arrowhead of the second dimension line.
	///</summary>
	public class Set_Arrowhead2Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrowhead2Type = ((OdaX.AcDimArrowheadType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "990E4E0A-FC8D-4577-9C22-690634D80B17", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Measurement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Measurement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the length measurement of linear dimensions or the angle measurement for angular dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Returns the length measurement of linear dimensions or the angle measurement for angular dimensions.
	///</summary>
	public class Measurement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Measurement);

		}
	}


	[NVP_Manifest(
		Id = "DE4CCD1B-1A42-4271-B1B7-B13CCE8F597D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Arrowhead1Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Arrowhead1Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a custom block to replace the arrowhead of the first dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns a custom block to replace the arrowhead of the first dimension line.
	///</summary>
	public class Arrowhead1Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrowhead1Block);

		}
	}


	[NVP_Manifest(
		Id = "584EC1BB-6083-4B81-9477-6EDFB76994C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_Arrowhead1Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_Arrowhead1Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a custom block to replace the arrowhead of the first dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies or returns a custom block to replace the arrowhead of the first dimension line.
	///</summary>
	public class Set_Arrowhead1Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrowhead1Block = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DC0A6763-DC16-48F4-871D-BCD7C09C6F5F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Arrowhead2Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Arrowhead2Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a custom block to replace the arrowhead of the second dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns a custom block to replace the arrowhead of the second dimension line.
	///</summary>
	public class Arrowhead2Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrowhead2Block);

		}
	}


	[NVP_Manifest(
		Id = "AE92084C-61F3-40B6-8A84-EFB1D721EE10", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_Arrowhead2Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_Arrowhead2Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a custom block to replace the arrowhead of the second dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies or returns a custom block to replace the arrowhead of the second dimension line.
	///</summary>
	public class Set_Arrowhead2Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrowhead2Block = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AE5B493F-F586-4CB9-9DCC-BC63E64EA029", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimensionLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimensionLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the linetype of a dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies the linetype of a dimension line.
	///</summary>
	public class DimensionLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLinetype);

		}
	}


	[NVP_Manifest(
		Id = "EEDE87F4-2707-47F6-9639-B339EC252B8C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimensionLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimensionLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the linetype of a dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies the linetype of a dimension line.
	///</summary>
	public class Set_DimensionLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5FA9277D-FB10-4C72-8B6D-FDCA0F8A7665", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ExtLine1Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ExtLine1Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of the first extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of the first extension line.
	///</summary>
	public class ExtLine1Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine1Linetype);

		}
	}


	[NVP_Manifest(
		Id = "0A515447-6919-46BB-A927-01C2AFAFD1D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ExtLine1Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ExtLine1Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of the first extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of the first extension line.
	///</summary>
	public class Set_ExtLine1Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine1Linetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5923B0EC-3A93-4B5B-B008-0AA2963D29DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ExtLine2Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ExtLine2Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of the second extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of the second extension line.
	///</summary>
	public class ExtLine2Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine2Linetype);

		}
	}


	[NVP_Manifest(
		Id = "52C2EFEA-F7F2-412E-98A7-D8E60CC43168", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ExtLine2Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ExtLine2Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of the second extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of the second extension line.
	///</summary>
	public class Set_ExtLine2Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine2Linetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D9965535-1ADD-4286-98EA-A2E8374424A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ExtLineFixedLenSuppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ExtLineFixedLenSuppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether fixed-length extension lines display.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether fixed-length extension lines display.
	///</summary>
	public class ExtLineFixedLenSuppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLineFixedLenSuppress);

		}
	}


	[NVP_Manifest(
		Id = "8DBC610A-480F-47D4-927B-507C95759BCD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ExtLineFixedLenSuppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ExtLineFixedLenSuppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether fixed-length extension lines display.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bFixedLen", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether fixed-length extension lines display.
	///</summary>
	public class Set_ExtLineFixedLenSuppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLineFixedLenSuppress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "26720428-7E51-4DF9-9387-FA2BCF79BED9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.ExtLineFixedLen", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "ExtLineFixedLen", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether extension lines are a fixed length.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies or returns whether extension lines are a fixed length.
	///</summary>
	public class ExtLineFixedLen : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLineFixedLen);

		}
	}


	[NVP_Manifest(
		Id = "07ADA529-DBC1-4B80-919D-11700E9D4C2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_ExtLineFixedLen", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_ExtLineFixedLen", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether extension lines are a fixed length.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("FixedLen", typeof(System.Double))]

	///<summary>
	///Specifies or returns whether extension lines are a fixed length.
	///</summary>
	public class Set_ExtLineFixedLen : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLineFixedLen = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "89043068-6389-4AE1-B292-24D8E0E422A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimConstrForm", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimConstrForm", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the constraint type - Dynamic or Annotational", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies the constraint type - Dynamic or Annotational
	///</summary>
	public class DimConstrForm : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrForm);

		}
	}


	[NVP_Manifest(
		Id = "880D1E71-5774-41A3-9F67-96860E3706EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimConstrForm", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimConstrForm", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the constraint type - Dynamic or Annotational", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bIsDynamic", typeof(System.Object))]

	///<summary>
	///Specifies the constraint type - Dynamic or Annotational
	///</summary>
	public class Set_DimConstrForm : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrForm = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4A9D2DC7-87C5-43A9-A497-DE3836684F2C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimConstrReference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimConstrReference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the parameter is a reference constraint. Reference dimensions can be used in expressions but don't drive geometry - similar to an associative dimension", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies whether the parameter is a reference constraint. Reference dimensions can be used in expressions but don't drive geometry - similar to an associative dimension
	///</summary>
	public class DimConstrReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrReference);

		}
	}


	[NVP_Manifest(
		Id = "04884013-7E29-4C51-96CF-4A4B3D7E5FEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimConstrReference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimConstrReference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the parameter is a reference constraint. Reference dimensions can be used in expressions but don't drive geometry - similar to an associative dimension", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bIsReference", typeof(System.Object))]

	///<summary>
	///Specifies whether the parameter is a reference constraint. Reference dimensions can be used in expressions but don't drive geometry - similar to an associative dimension
	///</summary>
	public class Set_DimConstrReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrReference = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8F477E62-B4B3-40DE-A59B-F450A0A94745", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimConstrName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimConstrName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the dimensional constraint. Names cannot have spaces", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies the name of the dimensional constraint. Names cannot have spaces
	///</summary>
	public class DimConstrName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrName);

		}
	}


	[NVP_Manifest(
		Id = "877D836D-B107-4EDA-8540-C48764DFC2EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimConstrName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimConstrName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the dimensional constraint. Names cannot have spaces", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the name of the dimensional constraint. Names cannot have spaces
	///</summary>
	public class Set_DimConstrName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DB0E1A25-041B-4062-A6C7-576A1315BDE9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimConstrExpression", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimConstrExpression", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the expression or the value of the constraint", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies the expression or the value of the constraint
	///</summary>
	public class DimConstrExpression : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrExpression);

		}
	}


	[NVP_Manifest(
		Id = "CE8B9D79-8FA4-4A8A-A924-D1DA88EA5FF6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimConstrExpression", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimConstrExpression", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the expression or the value of the constraint", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bstrExpression", typeof(System.String))]

	///<summary>
	///Specifies the expression or the value of the constraint
	///</summary>
	public class Set_DimConstrExpression : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrExpression = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "387D8096-2747-4BF9-BD1E-ADB2693B2169", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimConstrValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimConstrValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the value of the constraint", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies the value of the constraint
	///</summary>
	public class DimConstrValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrValue);

		}
	}


	[NVP_Manifest(
		Id = "C51E9E59-C44F-49AD-9073-FAFAEFA8DCC9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimConstrValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimConstrValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the value of the constraint", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///Specifies the value of the constraint
	///</summary>
	public class Set_DimConstrValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrValue = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BAB82708-2883-4654-A18C-B004F7865043", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.DimConstrDesc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "DimConstrDesc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies description for constraint", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies description for constraint
	///</summary>
	public class DimConstrDesc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrDesc);

		}
	}


	[NVP_Manifest(
		Id = "84F5387F-9C4C-4379-A683-F15B62323891", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_DimConstrDesc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_DimConstrDesc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies description for constraint", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("bstrDescription", typeof(System.String))]

	///<summary>
	///Specifies description for constraint
	///</summary>
	public class Set_DimConstrDesc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrDesc = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EB2A37A7-709F-4D31-940B-1EE4735B9F0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.SubUnitsSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "SubUnitsSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text suffix for all applicable linear dimension when change to sub-units", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies the text suffix for all applicable linear dimension when change to sub-units
	///</summary>
	public class SubUnitsSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SubUnitsSuffix);

		}
	}


	[NVP_Manifest(
		Id = "41BA455F-EF45-41BA-BAEB-2B96CB6013B2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_SubUnitsSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_SubUnitsSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text suffix for all applicable linear dimension when change to sub-units", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("suffix", typeof(System.String))]

	///<summary>
	///Specifies the text suffix for all applicable linear dimension when change to sub-units
	///</summary>
	public class Set_SubUnitsSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SubUnitsSuffix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AD646DFD-572A-4116-999C-F9D9734BD6EA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.SubUnitsFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "SubUnitsFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the sub-units scale factor for all applicable linear dimension", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies the sub-units scale factor for all applicable linear dimension
	///</summary>
	public class SubUnitsFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SubUnitsFactor);

		}
	}


	[NVP_Manifest(
		Id = "1433B75D-0EBE-4BFA-956D-5C42C7BD145B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_SubUnitsFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_SubUnitsFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the sub-units scale factor for all applicable linear dimension", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("factor", typeof(System.Double))]

	///<summary>
	///Specifies the sub-units scale factor for all applicable linear dimension
	///</summary>
	public class Set_SubUnitsFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SubUnitsFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E1017D62-77CC-406F-8673-6F47334F8BCC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltSubUnitsSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltSubUnitsSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text suffix for the alternate dimension when change to alternate sub-units", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies the text suffix for the alternate dimension when change to alternate sub-units
	///</summary>
	public class AltSubUnitsSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSubUnitsSuffix);

		}
	}


	[NVP_Manifest(
		Id = "565849DC-9FBA-4455-9171-B54D3564631D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltSubUnitsSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltSubUnitsSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text suffix for the alternate dimension when change to alternate sub-units", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("suffix", typeof(System.String))]

	///<summary>
	///Specifies the text suffix for the alternate dimension when change to alternate sub-units
	///</summary>
	public class Set_AltSubUnitsSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSubUnitsSuffix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6C8340D6-9F00-4271-A3E0-0D093DE9A2AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.AltSubUnitsFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "AltSubUnitsFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the alternate sub-units scale factor for all applicable linear dimension", 
		ViewType = "Data")]
	[NodeInput("AcadDimAligned", typeof(object))]

	///<summary>
	///Specifies the alternate sub-units scale factor for all applicable linear dimension
	///</summary>
	public class AltSubUnitsFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSubUnitsFactor);

		}
	}


	[NVP_Manifest(
		Id = "82C0B51B-4C7B-4AB2-A9F2-7822E1935ACC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimAligned.Set_AltSubUnitsFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimAligned", 
		NodeName = "Set_AltSubUnitsFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the alternate sub-units scale factor for all applicable linear dimension", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAligned", typeof(object))]
	[NodeInput("factor", typeof(System.Double))]

	///<summary>
	///Specifies the alternate sub-units scale factor for all applicable linear dimension
	///</summary>
	public class Set_AltSubUnitsFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSubUnitsFactor = inputs[1].Value;
			return null;
		}
	}
}
