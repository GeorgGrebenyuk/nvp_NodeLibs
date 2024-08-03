using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a dimension measuring the diameter of a circle or arc
///</summary>
namespace OdaX.AcadDimDiametric 
{

	[NVP_Manifest(
		Id = "3F01A974-217A-44AA-A150-80103E23E481", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AcadDimDiametric_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "_AcadDimDiametric_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimDiametric_Constructor : INode 
	{
		public OdaX.IAcadDimDiametric _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDimDiametric;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "FD2F94C1-2677-46C4-8A75-909CBD954E62", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AcadDimDiametric_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "_AcadDimDiametric_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimDiametric_ConstructorCast : INode 
	{
		public OdaX.IAcadDimDiametric _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDimDiametric;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A788B079-76BD-41F7-9444-1CB12207B82D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_LeaderLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_LeaderLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the length of the leader used with the diametral dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("rhs", typeof(System.Double))]

	///<summary>
	///Specifies the length of the leader used with the diametral dimension.
	///</summary>
	public class Set_LeaderLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2E660DE2-DCB2-40DD-ABE0-F990D2498E24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether alternate units are used for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "E590D9DF-2460-41E2-A002-82E2794F6C2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether alternate units are used for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "C580D2DE-3621-4D86-B493-10B94EC32257", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltUnitsPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltUnitsPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for alternate unit dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "8EF3C562-3441-4A46-B761-0AEF95B4D224", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltUnitsPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltUnitsPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for alternate unit dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "E1F5C9B3-1B4F-463E-9B78-DCF64FB2EF11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltUnitsScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltUnitsScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "A6022F44-8572-4362-9D1D-28E742C1A11A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltUnitsScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltUnitsScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "69FFF648-2F21-44E3-AA0B-06B5D6DDD78A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltRoundDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltRoundDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rounding value for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "BE1FDCBD-7287-4A48-A6D9-6091EAA89B1B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltRoundDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltRoundDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rounding value for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "4E7F9642-487E-4007-B541-1CA609646FC0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltTolerancePrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltTolerancePrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "35F9A954-9302-45F4-9A47-B1873E0EDE70", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltTolerancePrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltTolerancePrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "44E996D1-B78D-47B6-A8EB-E32DA99C19F5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltUnitsFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltUnitsFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "07AAA878-AACA-453D-A81E-13E8A027F5C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltUnitsFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltUnitsFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "3313FF7C-E253-4CD3-AC89-F9A919694E40", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltTextPrefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltTextPrefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "0F880E36-BE72-48C3-849B-53BAB8470B18", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltTextPrefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltTextPrefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "3A009A11-0A24-4371-BB2E-DBC2C5E8F039", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltTextSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltTextSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "781816A1-12A8-480B-B670-4A55E307522D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltTextSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltTextSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("prefix", typeof(System.String))]

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
		Id = "11A513EB-B12B-414E-95EA-81A45A87075B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.DimensionLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "DimensionLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "BDB72ADB-8931-4BE2-B664-EFAEB31AFFD2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_DimensionLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_DimensionLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of dimension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

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
		Id = "023805F2-1D64-4A5D-869E-6096E7056B9D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.PrimaryUnitsPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "PrimaryUnitsPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for the primary units of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "48A00620-5E6E-428B-9ABB-7485630249C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_PrimaryUnitsPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_PrimaryUnitsPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for the primary units of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "3723655C-5C61-40C3-83A2-CCF7C97DADEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.FractionFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "FractionFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how fractions display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "EF339E76-A3BA-4223-A240-1EA8D6392BAA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_FractionFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_FractionFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how fractions display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "E9C2CD7B-09AF-476F-9297-5EAC2D93A510", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Fit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Fit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "7C5B0AF5-7A5D-4976-854A-9EBBD16DE297", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_Fit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_Fit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "215C2110-E8F0-494A-AD10-B06E9279C4E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.LinearScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "LinearScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor for linear dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "DBD8265B-3073-4B94-A0C3-A6B2A9929799", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_LinearScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_LinearScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor for linear dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "A428198C-CECB-4587-AC5D-B8C7D445F1AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.UnitsFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "UnitsFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the unit of measurement for linear dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "5CAF0591-3ED4-4FA7-AEA2-38689FDC3AE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_UnitsFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_UnitsFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the unit of measurement for linear dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "F39A1261-239E-46A0-A5BA-BCFD215333DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.RoundDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "RoundDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how measurements are rounded for all dimensions except angular dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "711F9FE3-BB07-42BD-A01F-19BB755F37F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_RoundDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_RoundDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how measurements are rounded for all dimensions except angular dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "AEACC2C5-C8EE-4481-BB29-B272985E3FA1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.DimLine1Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "DimLine1Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the first dimension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "D0D944DF-A9BA-438A-AFC5-B649C408B00B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_DimLine1Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_DimLine1Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the first dimension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "8C1FCD5F-4109-4EE0-A6CA-984A2521FDCF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.DimLine2Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "DimLine2Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the second dimension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "1E2A75B9-971E-4BB0-AF71-724CEDF611A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_DimLine2Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_DimLine2Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the second dimension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "56877A37-3CEE-4E3C-87DC-6FCCF9551C29", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.TextInsideAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "TextInsideAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text displays between extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "D98147BF-A327-4AFE-BF74-F9A55CE058ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_TextInsideAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_TextInsideAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text displays between extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "E777FCB8-5838-4270-BC33-BF1E17DCF2D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.TextInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "TextInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "0CC5AA01-3511-4D24-96FF-366C6A2FEF26", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_TextInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_TextInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "851E260D-B534-47F2-8A9D-B39AFBADE299", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.ForceLineInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "ForceLineInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "CA78A029-420F-451D-B174-A5BE3AE24607", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_ForceLineInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_ForceLineInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "6C925C72-B326-481A-A27C-4FBDD5882001", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.TextOutsideAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "TextOutsideAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text displays outside of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "AFCA76C2-7372-4B83-8B61-5EE4D8B1CCDA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_TextOutsideAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_TextOutsideAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text displays outside of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "8A742111-9EB8-42C1-8848-931A778A88F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.CenterType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "CenterType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of center mark used for diametral dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the type of center mark used for diametral dimensions.
	///</summary>
	public class CenterType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CenterType);

		}
	}


	[NVP_Manifest(
		Id = "FBE7CC08-B983-4F63-BACC-E5B0A970A31F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_CenterType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_CenterType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of center mark used for diametral dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("OdaX.AcDimCenterType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of center mark used for diametral dimensions.
	///</summary>
	public class Set_CenterType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CenterType = ((OdaX.AcDimCenterType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "52E12BA1-03A3-4FEC-8959-7AAF6B083EBB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.CenterMarkSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "CenterMarkSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the size of the center mark used for diametral dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the size of the center mark used for diametral dimensions.
	///</summary>
	public class CenterMarkSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CenterMarkSize);

		}
	}


	[NVP_Manifest(
		Id = "DB2D460A-9B49-4529-B648-D3AD5221CDAE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_CenterMarkSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_CenterMarkSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the size of the center mark used for diametral dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Type", typeof(System.Double))]

	///<summary>
	///Specifies or returns the size of the center mark used for diametral dimensions.
	///</summary>
	public class Set_CenterMarkSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CenterMarkSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F8BE3533-CD82-4320-AF3E-F38727662F71", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "B7CC3453-BEF1-4058-8451-D4028F4B6B20", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "12834DB2-313C-487A-BF1F-A70A8EF97D86", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "53E661B5-C499-4552-ACC5-415BBD86A0E7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "02994147-7C58-48A2-84D9-ED4CA830D5E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "426506CD-1201-4F5D-B9EC-4C795BF50C25", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "15C84E90-C2A8-43EB-8AD3-CF29A57D2F42", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "4ACBBD98-BB4D-482D-8D22-572B158F5EEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "0FADA938-E650-4BD3-A8E3-FE744D2C8955", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltToleranceSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltToleranceSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "EAB45BB1-572D-406A-A208-EF7DD91CB52B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltToleranceSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltToleranceSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "1EBEA39B-F4C9-4AF7-BC12-F012654CC11F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltToleranceSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltToleranceSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "60006711-3C71-4672-AAE3-FC1074875400", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltToleranceSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltToleranceSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "7373BAA6-5588-42BB-A6CD-0CBC8E1A2AD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltToleranceSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltToleranceSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "2218C92C-524F-4EB6-9E9A-31A9801F20BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltToleranceSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltToleranceSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "EABDE080-4297-45B8-AF34-9C46EBC63B44", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.AltToleranceSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "AltToleranceSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "14890124-92BB-4B18-B2DB-DE8A51215BB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_AltToleranceSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_AltToleranceSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "42CEE0A4-72E1-495C-82D0-2857676CD60E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.SuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "SuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "578A3685-109A-4984-A966-4F0A392D7357", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_SuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_SuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "21868CED-B733-4D38-90B6-B8168211F135", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.SuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "SuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "0B165C3D-CFD1-488D-B2DB-4213695A971C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_SuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_SuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "184BAF1A-40C1-42C6-9DF7-869BF1101C56", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.ToleranceSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "ToleranceSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "57B00C35-DC21-4AE0-8A6F-57A318FD7D7C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_ToleranceSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_ToleranceSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "6F2451F6-49E5-4ACB-BE18-44E0B1ABE15E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.ToleranceSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "ToleranceSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "5D420B2C-E801-42D8-942B-F44C58E1E7B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_ToleranceSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_ToleranceSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "18D11228-44B9-4BBB-8657-B42C68B2234B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.DimensionLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "DimensionLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "A74C6837-4E8C-4AA0-8311-7F896CD843E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_DimensionLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_DimensionLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of dimension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "45466149-6B00-4868-887B-806122720BAE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.ArrowheadSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "ArrowheadSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the size of dimension arrowheads.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "1D090594-1D90-4CE9-B5E8-CF8D0D4FE92E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_ArrowheadSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_ArrowheadSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the size of dimension arrowheads.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "0277F9DD-0527-4849-9D94-AE2B91F75BB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Arrowhead1Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Arrowhead1Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the first dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "6D976326-7193-4D62-96B5-501A6E12A1B2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_Arrowhead1Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_Arrowhead1Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the first dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "435793B6-99C9-4F92-84F5-243585422DA2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Arrowhead2Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Arrowhead2Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the second dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "82B98EBC-5A2C-4DAC-9F33-679C9A762147", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_Arrowhead2Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_Arrowhead2Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the second dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "CC538F4A-C390-4EE7-9070-7B4AA1BC1B3C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Measurement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Measurement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the length measurement of linear dimensions or the angle measurement for angular dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "E5819ED8-D17F-40A6-BC14-72E5A21BF305", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Arrowhead1Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Arrowhead1Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a custom block to replace the arrowhead of the first dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "350EA4A7-65C2-4415-A913-173CB19748F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_Arrowhead1Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_Arrowhead1Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a custom block to replace the arrowhead of the first dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "21CB634F-D9EE-40D5-AF0C-2077B48E5D51", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Arrowhead2Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Arrowhead2Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a custom block to replace the arrowhead of the second dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "A110B764-64B6-44EE-9903-E968A8FF086E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_Arrowhead2Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_Arrowhead2Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a custom block to replace the arrowhead of the second dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "0C7B9FC2-058D-460D-9AFC-5DE478EF4A96", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.DimensionLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "DimensionLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the linetype of a dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "70CF5280-C2B8-47A6-9D84-4C9C6479C785", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_DimensionLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_DimensionLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the linetype of a dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "D162AC59-DF26-4979-B695-8B6EAA63740D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.DimConstrForm", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "DimConstrForm", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the constraint type - Dynamic or Annotational", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "56E94AEF-AF0D-4BE6-866D-19E0AC4B9C34", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_DimConstrForm", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_DimConstrForm", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the constraint type - Dynamic or Annotational", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "EC163262-E526-4D4C-8BC1-055714B34900", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.DimConstrReference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "DimConstrReference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the parameter is a reference constraint. Reference dimensions can be used in expressions but don't drive geometry - similar to an associative dimension", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "42CE9468-A394-4EF9-9052-622A10D54DC2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_DimConstrReference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_DimConstrReference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the parameter is a reference constraint. Reference dimensions can be used in expressions but don't drive geometry - similar to an associative dimension", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "81718AAD-AA8A-4598-921B-B3F2BBC25F64", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.DimConstrName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "DimConstrName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the dimensional constraint. Names cannot have spaces", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "B54AC966-75B2-4190-B1BC-D2609B6C8FC4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_DimConstrName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_DimConstrName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the dimensional constraint. Names cannot have spaces", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "7CA2A205-C66E-49E3-BE5C-16D635A08C19", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.DimConstrExpression", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "DimConstrExpression", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the expression or the value of the constraint", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "CBC8E0E6-BF35-4DE3-ACCE-4FB18FBBBB1B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_DimConstrExpression", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_DimConstrExpression", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the expression or the value of the constraint", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "F8EC587C-DCED-48A4-9453-24B29B8350B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.DimConstrValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "DimConstrValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the value of the constraint", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "73C87B10-685A-487A-B7D7-677F0378F117", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_DimConstrValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_DimConstrValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the value of the constraint", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
		Id = "8C086AB8-DD8B-4CB3-84F1-64C585D13C93", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.DimConstrDesc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "DimConstrDesc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies description for constraint", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

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
		Id = "CA8DF87B-ED12-42B8-AB1E-50D8D698405F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimDiametric.Set_DimConstrDesc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimDiametric", 
		NodeName = "Set_DimConstrDesc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies description for constraint", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
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
}
