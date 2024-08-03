using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a dimension measuring the length of an arc
///</summary>
namespace OdaX.AcadDimArcLength 
{

	[NVP_Manifest(
		Id = "1F453B22-0933-4C85-B652-C5619FC3A474", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AcadDimArcLength_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "_AcadDimArcLength_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimArcLength_Constructor : INode 
	{
		public OdaX.IAcadDimArcLength _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDimArcLength;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "367089AA-E22B-4282-9DF4-F36AF1E534F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AcadDimArcLength_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "_AcadDimArcLength_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimArcLength_ConstructorCast : INode 
	{
		public OdaX.IAcadDimArcLength _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDimArcLength;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "B5B87946-C678-4584-91D4-2C753B181BF5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether alternate units are used for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "F90B7D8E-69AE-4C4C-AF63-1D0ED512BDFD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether alternate units are used for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "F6FBBAB3-3244-4F37-A93B-1BEEFC7B5323", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltUnitsPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltUnitsPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for alternate unit dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "37D8E898-8D22-4AFA-9AFD-4E66448152DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltUnitsPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltUnitsPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for alternate unit dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "751FD6A6-7AD2-4700-8F68-6C3CBA97A9CA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltUnitsScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltUnitsScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "34D6E72E-1812-4894-98C9-C56E5EEE52ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltUnitsScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltUnitsScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "B23DE97A-3FEF-4A58-8C4E-6AA30668BC41", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltRoundDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltRoundDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rounding value for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "640C6EEA-1A31-4EBC-B8DD-BE35D7047BEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltRoundDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltRoundDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rounding value for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "F6923227-A24D-40FF-8EE1-C61B09D903EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltTolerancePrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltTolerancePrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "46E6BCBD-7C58-4A53-97BE-BCE8F4366752", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltTolerancePrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltTolerancePrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "E59A21E6-14F5-4C42-854E-ACAB5ECFE014", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltUnitsFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltUnitsFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "3C9D569F-8396-4E1D-9A31-16C1EB42DA82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltUnitsFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltUnitsFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "E61A65E6-ED27-4503-93A4-E05904D2D22B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltTextPrefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltTextPrefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "4C05381C-B1A5-4709-8076-35DAC4617386", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltTextPrefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltTextPrefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "467828B0-2FB0-4441-8150-603F14733EF3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltTextSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltTextSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "B75D5F96-DB2A-43E5-BFDF-D9D5E4E83144", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltTextSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltTextSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "not including angular dimensions).", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "C6311B69-B598-436E-92B6-5EF77EDAE5E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.DimensionLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "DimensionLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "879047E5-3F0D-46D1-9755-3F715617E731", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_DimensionLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_DimensionLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of dimension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "619B8DDF-3CD2-47B0-AD54-4F857F945193", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ExtensionLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ExtensionLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "D5FF8130-3722-4280-B60C-5550EC7314AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ExtensionLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ExtensionLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

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
		Id = "EDF8B15A-E085-4A43-AB14-3B5E87BE82F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.PrimaryUnitsPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "PrimaryUnitsPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for the primary units of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "BFD7385E-B9E9-41BE-88CC-9C8FF7330E51", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_PrimaryUnitsPrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_PrimaryUnitsPrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for the primary units of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "524F7DA5-E6F3-4DE6-8484-B4A664FDC575", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.DimensionLineExtend", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "DimensionLineExtend", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how far dimension lines extend beyond extension lines when using dimension lines with oblique strokes.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "CAC774D0-7B86-419E-B30C-5376CEC2F75B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_DimensionLineExtend", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_DimensionLineExtend", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how far dimension lines extend beyond extension lines when using dimension lines with oblique strokes.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "2EBAC4E5-D75A-40A4-823E-E1273B901902", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ExtensionLineExtend", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ExtensionLineExtend", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how far extension lines extend beyond dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "11974826-FA1C-44A7-8630-765D59151F8E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ExtensionLineExtend", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ExtensionLineExtend", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how far extension lines extend beyond dimension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "ED1C099C-63C1-4CD9-A12B-A1C717560DD3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Fit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Fit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "384B72B0-F0BC-4AC1-B138-43E0E8AA070C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_Fit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_Fit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "07A8FE86-6484-424E-98BD-79111BECCB12", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.FractionFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "FractionFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how fractions display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "4A9855D8-7CF2-4F0D-A336-15CB8BFD99BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_FractionFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_FractionFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how fractions display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "7B684A3C-511E-48FA-8B56-342006D70521", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.HorizontalTextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "HorizontalTextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal position of dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "4391DA26-19A7-4DED-8DEE-ACCC9035E395", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_HorizontalTextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_HorizontalTextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal position of dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "4B3EBF38-1C23-4A7B-9C8A-29A3E8AFE41A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.LinearScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "LinearScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor for linear dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "27A015DB-C27A-46FA-BB43-7BEB4A80BD68", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_LinearScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_LinearScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor for linear dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "4A4963C2-A865-4FC6-BB8F-CF3FFE041C7F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.UnitsFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "UnitsFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the unit of measurement for linear dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "EDAE168E-0165-4380-93BF-F280DF2703C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_UnitsFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_UnitsFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the unit of measurement for linear dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "30B6E4A3-4C4F-47D1-8F5D-3DE7E589CFF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ExtensionLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ExtensionLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "FFF3677F-C79C-4220-9FC0-FF9444CA62BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ExtensionLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ExtensionLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "720080F1-9D7E-4B10-9931-8160404DD6CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.RoundDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "RoundDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how measurements are rounded for all dimensions except angular dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "27252C70-D1FF-40EB-92E7-FA06BFF644B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_RoundDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_RoundDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how measurements are rounded for all dimensions except angular dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "0A577E4D-2636-4F4B-88F0-35674151535C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.DimLine1Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "DimLine1Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the first dimension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "E3E499EA-82DE-47ED-AE3A-AD51C03DFDA3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_DimLine1Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_DimLine1Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the first dimension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "8F8CE4F3-D69B-4B80-B3BD-8653EAF30874", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.DimLine2Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "DimLine2Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the second dimension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "E596D977-8F68-470E-96A4-58C5B403BA4A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_DimLine2Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_DimLine2Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the second dimension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "7C5E713E-7DDA-4A61-AD90-ECB7B2E396BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ExtLine1Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ExtLine1Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the first extension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "CAAB6E58-1849-42DF-B275-5A13AB9F7E66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ExtLine1Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ExtLine1Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the first extension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "1B6605AB-D2BA-49A4-A6C4-4164D5BF68B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ExtLine2Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ExtLine2Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the second extension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "73F605B0-B2E3-44AB-898C-3FCD453E6CFD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ExtLine2Suppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ExtLine2Suppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the second extension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "74FE18B5-A53D-4B40-A9DF-FCD5352E1874", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.DimLineInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "DimLineInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension lines are drawn outside of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "9EA6E191-2F36-4200-AF16-7B207BFACFFC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_DimLineInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_DimLineInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension lines are drawn outside of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "0F020B52-86F9-40B6-9B83-EAA0B267EBC8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.TextInsideAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "TextInsideAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text displays between extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "D0097BB6-1BF5-40E5-A777-F4BE36410128", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_TextInsideAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_TextInsideAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text displays between extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "CFE8ACD4-49BA-46C7-9435-9CDA68D86671", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.TextInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "TextInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "B5A8B579-7CEF-4B0A-915C-E2D022A0F816", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_TextInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_TextInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "FCD3D7C8-CC68-477E-9896-D8E6A3AA7B50", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ForceLineInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ForceLineInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "E669491C-8D76-44E7-A8CD-36EE414CDBF4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ForceLineInside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ForceLineInside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "6449DAB6-EF9B-4E7C-AD4D-C0D11823B840", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.TextOutsideAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "TextOutsideAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text displays outside of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "D35CC07C-E1AF-4F17-9C87-93D206FA8965", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_TextOutsideAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_TextOutsideAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension text displays outside of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "FF0F5229-18FE-436D-BC20-D5BE0CDBDBD4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ExtensionLineOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ExtensionLineOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the distance between extension lines and the object being dimensioned.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "190ED55F-D746-4126-8F18-89ED9C15CD8F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ExtensionLineOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ExtensionLineOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the distance between extension lines and the object being dimensioned.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "7B4EF058-94FC-429C-9413-B85BE644EBE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "CEEC83D6-C6B5-4D82-A78D-850CB2168894", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "3566D669-3879-4BFC-B167-529EF89B45AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "C65B1ACA-0C60-4C81-8646-BD6A4D7238FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "01B12513-735D-4A97-9017-65B7692373AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "CB4D1D3B-BB77-4E29-9202-42EC37EBB54A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "616E941C-1B49-48B7-A5AD-821FBB67583F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "9DB460D8-34E3-4F62-9116-DC214CE34B26", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "5421F1CF-23E4-4BC8-A1CC-C3C5E87519F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltToleranceSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltToleranceSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "BE3B3B60-7C5A-4178-AC43-7EC92F8088D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltToleranceSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltToleranceSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "CC802F6C-E455-41CC-8DAB-02EFCBDF04A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltToleranceSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltToleranceSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "5785F602-DE1F-43E2-947D-97D3C215F7D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltToleranceSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltToleranceSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "BD3C13AB-0B4C-42B2-A5BE-9078C80740ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltToleranceSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltToleranceSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "7873F762-6F6B-4968-8D27-97A765F529FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltToleranceSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltToleranceSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "25122463-A1B3-4B3C-9244-02E3FFCB3A03", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltToleranceSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltToleranceSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "98A707F7-7ED8-464A-A935-880AF83D2B9B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltToleranceSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltToleranceSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "A9018FCC-3C87-418B-B3F5-810D263EAC94", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.SuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "SuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "SSpecifies or returns whether zero feet measurements display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///SSpecifies or returns whether zero feet measurements display for dimensions.
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
		Id = "5B02DE0A-52C4-4460-91AD-22E4022A3FE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_SuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_SuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "SSpecifies or returns whether zero feet measurements display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///SSpecifies or returns whether zero feet measurements display for dimensions.
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
		Id = "83D3E126-DED4-4008-9B92-4D7511D73389", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.SuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "SuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "CAF4B445-D776-4E35-A0D6-8A588DE15314", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_SuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_SuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "6228CC58-53DC-4994-A118-07CEFB2FA2CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ToleranceSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ToleranceSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "3489AB89-8BAE-4365-904B-1F96F29E4FCD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ToleranceSuppressZeroFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ToleranceSuppressZeroFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "6DA73FC3-A8D7-4153-993D-B008875A0774", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ToleranceSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ToleranceSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "792CA96B-8B23-4547-A9BD-0BFC7C849390", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ToleranceSuppressZeroInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ToleranceSuppressZeroInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "76F8E5EC-E7B3-46DB-80B5-281F02B8E5CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.DimensionLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "DimensionLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "1CE15C71-BE83-4FA2-AA54-9367B2583019", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_DimensionLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_DimensionLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of dimension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "DBA8EDCB-A2CB-4245-A1A1-BF2E253C6DCB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ArrowheadSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ArrowheadSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the size of dimension arrowheads.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "4D31DA23-FA24-48A2-A40D-8FB885954560", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ArrowheadSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ArrowheadSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the size of dimension arrowheads.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "4A713301-99DB-477C-81F2-BF9DA254E8E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Arrowhead1Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Arrowhead1Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the first dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "832CAA9D-0AA7-458D-9190-97856E5AB7B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_Arrowhead1Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_Arrowhead1Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the first dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "F967DC9F-C46C-440F-9C89-D903C06B6092", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Arrowhead2Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Arrowhead2Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the second dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "552CD251-6C20-4FEB-8E15-B3801714A66D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_Arrowhead2Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_Arrowhead2Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the second dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "8004E179-D74E-4FED-82ED-A38CCCDEACC0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Measurement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Measurement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the length measurement of linear dimensions or the angle measurement for angular dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "4F6DB726-07EE-4726-B819-44F169ACD60E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Arrowhead1Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Arrowhead1Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the first dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Specifies or returns the arrowhead of the first dimension line.
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
		Id = "1F0F51B3-E467-4C45-96BC-03265646CF17", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_Arrowhead1Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_Arrowhead1Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the first dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies or returns the arrowhead of the first dimension line.
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
		Id = "470E3819-7C62-4BBD-B151-02184CA4302A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Arrowhead2Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Arrowhead2Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the second dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Specifies or returns the arrowhead of the second dimension line.
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
		Id = "230A0AF6-8EE4-4F21-BE4C-FCD29A6A3158", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_Arrowhead2Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_Arrowhead2Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrowhead of the second dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies or returns the arrowhead of the second dimension line.
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
		Id = "0CCD786F-EAC6-4A62-BF12-060F2820E95F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ArcPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ArcPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a point on the arc.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Specifies or returns a point on the arc.
	///</summary>
	public class ArcPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArcPoint);

		}
	}


	[NVP_Manifest(
		Id = "B7BB9833-9995-4C78-BAEE-419DADF61493", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ArcPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ArcPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a point on the arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns a point on the arc.
	///</summary>
	public class Set_ArcPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArcPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4B8996AC-3DA9-4DB6-BA5E-5A012C934446", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ExtLine1Point", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ExtLine1Point", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the first extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "A8B76166-2DC0-4E9C-99B3-A9FDAB618273", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ExtLine1Point", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ExtLine1Point", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the first extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

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
		Id = "D1BC859E-75B4-472E-A628-A9AAB9FB69E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ExtLine2Point", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ExtLine2Point", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the second extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "F89C0923-DCA6-4D7D-9363-10A65BB5DBBF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ExtLine2Point", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ExtLine2Point", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the second extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

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
		Id = "B31E5B23-10C7-451C-8634-D593E5EF1D93", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.CenterPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "CenterPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the center point of the arc.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Specifies or returns the center point of the arc.
	///</summary>
	public class CenterPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CenterPoint);

		}
	}


	[NVP_Manifest(
		Id = "DB8224E6-F000-4077-82CF-6663EB481FCC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_CenterPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_CenterPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the center point of the arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the center point of the arc.
	///</summary>
	public class Set_CenterPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CenterPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3D1645B5-D2B6-41CD-BD89-9A63435D47DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Leader1Point", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Leader1Point", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the first leader.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Specifies or returns the start point of the first leader.
	///</summary>
	public class Leader1Point : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Leader1Point);

		}
	}


	[NVP_Manifest(
		Id = "F5213226-29ED-4F43-9C41-3CDFE642B4A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_Leader1Point", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_Leader1Point", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the first leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start point of the first leader.
	///</summary>
	public class Set_Leader1Point : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Leader1Point = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A69F09DF-8F76-4872-B0CD-B586F3ACE3BF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Leader2Point", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Leader2Point", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the second leader.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Specifies or returns the start point of the second leader.
	///</summary>
	public class Leader2Point : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Leader2Point);

		}
	}


	[NVP_Manifest(
		Id = "2B548C20-F972-4D3A-A164-BB729B722555", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_Leader2Point", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_Leader2Point", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start point of the second leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start point of the second leader.
	///</summary>
	public class Set_Leader2Point : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Leader2Point = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0CF8FDA0-13BE-4B42-BFBF-995900A0C3FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.IsPartial", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "IsPartial", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the dimension is for a partial arc.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Specifies or returns whether the dimension is for a partial arc.
	///</summary>
	public class IsPartial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPartial);

		}
	}


	[NVP_Manifest(
		Id = "BB98E0F7-AFE3-477A-8FC1-032B57821026", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_IsPartial", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_IsPartial", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the dimension is for a partial arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the dimension is for a partial arc.
	///</summary>
	public class Set_IsPartial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IsPartial = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C0D9F5A6-14E5-498D-ABF0-A5E97DC56369", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ArcStartParam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ArcStartParam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start parameter of the arc.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Specifies or returns the start parameter of the arc.
	///</summary>
	public class ArcStartParam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArcStartParam);

		}
	}


	[NVP_Manifest(
		Id = "FE8117AD-B6C7-4C52-86F7-169FD8131DCD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ArcStartParam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ArcStartParam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the start parameter of the arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the start parameter of the arc.
	///</summary>
	public class Set_ArcStartParam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArcStartParam = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "05456AA5-4BA9-4CC0-AAB6-ADBB8324CA0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ArcEndParam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ArcEndParam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the end parameter of the arc.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Specifies or returns the end parameter of the arc.
	///</summary>
	public class ArcEndParam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArcEndParam);

		}
	}


	[NVP_Manifest(
		Id = "5EECC6D7-82FB-4FF8-B738-68194D3D70FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ArcEndParam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ArcEndParam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the end parameter of the arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the end parameter of the arc.
	///</summary>
	public class Set_ArcEndParam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArcEndParam = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2951B4C4-EFCE-4414-BAC9-6F1CF2839E9B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.HasLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "HasLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the dimension has a leader.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Specifies or returns whether the dimension has a leader.
	///</summary>
	public class HasLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasLeader);

		}
	}


	[NVP_Manifest(
		Id = "910D6CF6-C377-463C-9296-F6772842FD0A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_HasLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_HasLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the dimension has a leader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the dimension has a leader.
	///</summary>
	public class Set_HasLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HasLeader = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FB7DA3B8-E066-4EE1-8A28-3A45BB7495E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.SymbolPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "SymbolPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the location of the arc length dimension symbol.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Specifies or returns the location of the arc length dimension symbol.
	///</summary>
	public class SymbolPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SymbolPosition);

		}
	}


	[NVP_Manifest(
		Id = "AF236E3C-4C87-40A8-B8CD-714DD3B1C166", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_SymbolPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_SymbolPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the location of the arc length dimension symbol.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("OdaX.AcDimArcLengthSymbol", typeof(System.Object))]

	///<summary>
	///Specifies or returns the location of the arc length dimension symbol.
	///</summary>
	public class Set_SymbolPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SymbolPosition = ((OdaX.AcDimArcLengthSymbol)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "78547B87-6925-48D9-98B4-1C248B709BD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.DimensionLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "DimensionLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies the linetype of a dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Not implemented. Specifies the linetype of a dimension line.
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
		Id = "BF70062B-6198-4BC7-81E3-925F0B42DC81", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_DimensionLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_DimensionLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies the linetype of a dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Not implemented. Specifies the linetype of a dimension line.
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
		Id = "6D90166B-AA14-4019-A7F2-F7F453250C2C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ExtLine1Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ExtLine1Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the linetype of the first extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the linetype of the first extension line.
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
		Id = "C05B1997-3381-49CC-B3C4-71F651DC5FD8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ExtLine1Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ExtLine1Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the linetype of the first extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Not implemented. Specifies or returns the linetype of the first extension line.
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
		Id = "1C057D34-75A4-49BD-9BFE-D76197F5A6D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ExtLine2Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ExtLine2Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the linetype of the second extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the linetype of the second extension line.
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
		Id = "2976E3B0-238B-4B5C-A528-900CEAE5F424", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ExtLine2Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ExtLine2Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the linetype of the second extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Not implemented. Specifies or returns the linetype of the second extension line.
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
		Id = "D35BEB62-BCA3-4A6A-A0B5-A91423429AA1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ExtLineFixedLenSuppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ExtLineFixedLenSuppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns whether fixed-length extension lines display.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns whether fixed-length extension lines display.
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
		Id = "82D2CC13-919E-4AA5-B48E-DECE54D7B0F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ExtLineFixedLenSuppress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ExtLineFixedLenSuppress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns whether fixed-length extension lines display.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("bFixedLen", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns whether fixed-length extension lines display.
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
		Id = "729C878C-9AB0-4E32-BCCE-F94D085B1070", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.ExtLineFixedLen", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "ExtLineFixedLen", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns whether extension lines are a fixed length.", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns whether extension lines are a fixed length.
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
		Id = "3251B920-62C6-4651-9B87-826F49B6A082", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_ExtLineFixedLen", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_ExtLineFixedLen", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns whether extension lines are a fixed length.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("FixedLen", typeof(System.Double))]

	///<summary>
	///Not implemented. Specifies or returns whether extension lines are a fixed length.
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
		Id = "6DB060D0-CF80-4067-ADC3-20F895B49EDC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_SubUnitsSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_SubUnitsSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text suffix for all applicable linear dimension when change to sub-units", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
	[NodeInput("rhs", typeof(System.String))]

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
		Id = "3086F557-4C41-4513-98D1-39B33C48AE6A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.SubUnitsFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "SubUnitsFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the sub-units scale factor for all applicable linear dimension", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "30AB626C-2D81-4C1D-AD39-3EA2370D7110", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_SubUnitsFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_SubUnitsFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the sub-units scale factor for all applicable linear dimension", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "47CF9463-57D2-4E66-BAE9-774E89E13613", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltSubUnitsSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltSubUnitsSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text suffix for the alternate dimension when change to alternate sub-units", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "FF0719B3-C65A-4C43-9B45-CF0771CB655B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltSubUnitsSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltSubUnitsSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text suffix for the alternate dimension when change to alternate sub-units", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
		Id = "77D6079C-6886-49C3-9F9B-267ADA8F241D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.AltSubUnitsFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "AltSubUnitsFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the alternate sub-units scale factor for all applicable linear dimension", 
		ViewType = "Data")]
	[NodeInput("AcadDimArcLength", typeof(object))]

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
		Id = "86EE2EF9-3DF8-47E5-AFEF-5D24F5106886", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimArcLength.Set_AltSubUnitsFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimArcLength", 
		NodeName = "Set_AltSubUnitsFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the alternate sub-units scale factor for all applicable linear dimension", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimArcLength", typeof(object))]
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
