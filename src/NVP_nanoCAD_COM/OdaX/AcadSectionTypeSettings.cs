using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of the settings that apply to the various types of sections
///</summary>
namespace OdaX.AcadSectionTypeSettings 
{

	[NVP_Manifest(
		Id = "3430836D-61BE-4DD4-8175-DB487FC6C5B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.AcadSectionTypeSettings_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "_AcadSectionTypeSettings_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionTypeSettings_Constructor : INode 
	{
		public OdaX.IAcadSectionTypeSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSectionTypeSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5D57678A-C293-4CE4-8044-99A2A2B6109D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.AcadSectionTypeSettings_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "_AcadSectionTypeSettings_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionTypeSettings_ConstructorCast : INode 
	{
		public OdaX.IAcadSectionTypeSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSectionTypeSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "521F4AE6-A47E-46DD-B8B6-B121ED14088D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.GenerationOptions", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "GenerationOptions", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the options used to generate a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the options used to generate a section.
	///</summary>
	public class GenerationOptions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GenerationOptions);

		}
	}


	[NVP_Manifest(
		Id = "A9634AAC-5944-43F1-B1A5-4664655B04BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_GenerationOptions", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_GenerationOptions", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the options used to generate a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("OdaX.AcSectionGeneration", typeof(System.Object))]

	///<summary>
	///Specifies or returns the options used to generate a section.
	///</summary>
	public class Set_GenerationOptions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GenerationOptions = ((OdaX.AcSectionGeneration)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4A1D2868-D49C-45E2-A8C2-5A9ACAA8F88D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.SourceObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "SourceObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the objects used to generate a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the objects used to generate a section.
	///</summary>
	public class SourceObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SourceObjects);

		}
	}


	[NVP_Manifest(
		Id = "A723F20E-966A-4B89-A386-E2DC81A2A257", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_SourceObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_SourceObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the objects used to generate a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the objects used to generate a section.
	///</summary>
	public class Set_SourceObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SourceObjects = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9A84FCF3-BEE4-4058-8884-5544EC6D44E8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.DestinationBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "DestinationBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the block used for the output of section generation.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the block used for the output of section generation.
	///</summary>
	public class DestinationBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DestinationBlock);

		}
	}


	[NVP_Manifest(
		Id = "A69E9DD5-520E-4E90-99B3-19789EED3805", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_DestinationBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_DestinationBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the block used for the output of section generation.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the block used for the output of section generation.
	///</summary>
	public class Set_DestinationBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DestinationBlock = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1F6A83BA-15F7-49C3-AB07-821DD3FE6182", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.DestinationFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "DestinationFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the file used for the output of section generation.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the file used for the output of section generation.
	///</summary>
	public class DestinationFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DestinationFile);

		}
	}


	[NVP_Manifest(
		Id = "EABA5CC0-F0ED-4DEA-B9D4-32BACDF434A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_DestinationFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_DestinationFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the file used for the output of section generation.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Specifies or returns the file used for the output of section generation.
	///</summary>
	public class Set_DestinationFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DestinationFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "18F5739E-404A-49F3-8CF0-2C801022AB24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionBoundaryColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionBoundaryColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the color of an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryColor);

		}
	}


	[NVP_Manifest(
		Id = "783CE7B3-9602-4280-9D37-EAFAD48A0715", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionBoundaryColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionBoundaryColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "63D43F19-2FC0-4290-B260-EFC03414C930", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionBoundaryLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionBoundaryLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the layer of an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the layer of an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryLayer);

		}
	}


	[NVP_Manifest(
		Id = "F78A14EA-FB03-4FF8-BED3-0079D198F6E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionBoundaryLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionBoundaryLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the layer of an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]

	///<summary>
	///Specifies or returns the layer of an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CD1AEB1D-CFCA-4F33-A454-06F1900625F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionBoundaryLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionBoundaryLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryLinetype);

		}
	}


	[NVP_Manifest(
		Id = "D09BC3C8-C742-4DC9-B4AF-33C7F59C2BFB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionBoundaryLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionBoundaryLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A9CFF491-8AAE-45A5-98B1-86B4031D78E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionBoundaryLinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionBoundaryLinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype scale of an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype scale of an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryLinetypeScale);

		}
	}


	[NVP_Manifest(
		Id = "4FADCE3E-D27D-4753-ABEB-54D727DEFCD2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionBoundaryLinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionBoundaryLinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype scale of an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype scale of an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryLinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B34E6752-A104-4191-93FC-9A0532F50887", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionBoundaryPlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionBoundaryPlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the plot style name of an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the plot style name of an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryPlotStyleName);

		}
	}


	[NVP_Manifest(
		Id = "836643C0-D455-4A1D-8249-6C340B8C675A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionBoundaryPlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionBoundaryPlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the plot style name of an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies or returns the plot style name of an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryPlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FC3FBAC4-AB6D-40B7-BAA3-295128FCF22E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionBoundaryLineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionBoundaryLineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryLineweight);

		}
	}


	[NVP_Manifest(
		Id = "C6E494BB-4BD2-4E18-86E4-7B76FABA258F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionBoundaryLineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionBoundaryLineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryLineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "576C1FB2-D60D-4EAE-9841-E9B2E6CDDDBF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionBoundaryDivisionLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionBoundaryDivisionLines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether division lines are shown for an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether division lines are shown for an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryDivisionLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryDivisionLines);

		}
	}


	[NVP_Manifest(
		Id = "F3EC8E38-18C1-466E-9727-0291167A9B25", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionBoundaryDivisionLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionBoundaryDivisionLines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether division lines are shown for an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether division lines are shown for an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryDivisionLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryDivisionLines = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C084C681-B15E-4AC6-B81A-B363682A9B8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether an intersection fill section is visible.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether an intersection fill section is visible.
	///</summary>
	public class IntersectionFillVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillVisible);

		}
	}


	[NVP_Manifest(
		Id = "6E26DDA1-18A8-485F-99C4-E72B99BBE1F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether an intersection fill section is visible.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether an intersection fill section is visible.
	///</summary>
	public class Set_IntersectionFillVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillVisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ADB0A897-C53E-4B92-9FB0-83A131D92174", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillHatchPatternType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillHatchPatternType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch pattern type of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the hatch pattern type of an intersection fill section.
	///</summary>
	public class IntersectionFillHatchPatternType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchPatternType);

		}
	}


	[NVP_Manifest(
		Id = "98E441B8-83FF-4262-A068-EE9F0D5F5785", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillHatchPatternType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillHatchPatternType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch pattern type of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("OdaX.AcPatternType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the hatch pattern type of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillHatchPatternType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchPatternType = ((OdaX.AcPatternType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D9ECD9F8-5D67-4FA1-805A-36449F925C6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillHatchPatternName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillHatchPatternName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch pattern name of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the hatch pattern name of an intersection fill section.
	///</summary>
	public class IntersectionFillHatchPatternName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchPatternName);

		}
	}


	[NVP_Manifest(
		Id = "14988A47-85F6-46E7-A5A7-BC090DDA184D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillHatchPatternName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillHatchPatternName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch pattern name of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Specifies or returns the hatch pattern name of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillHatchPatternName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchPatternName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0C950EE1-2350-4F7B-89A1-F550B8817243", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillHatchAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillHatchAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch angle of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the hatch angle of an intersection fill section.
	///</summary>
	public class IntersectionFillHatchAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchAngle);

		}
	}


	[NVP_Manifest(
		Id = "DD333047-4B30-4069-BFBD-53564EBEF326", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillHatchAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillHatchAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch angle of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the hatch angle of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillHatchAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4237B502-B7D2-4451-9E2E-A7852D4AA07D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillHatchScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillHatchScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch scale of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the hatch scale of an intersection fill section.
	///</summary>
	public class IntersectionFillHatchScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchScale);

		}
	}


	[NVP_Manifest(
		Id = "49F6BFEF-058A-4642-9B68-7563FD2ACC64", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillHatchScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillHatchScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch scale of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the hatch scale of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillHatchScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D581CF38-577F-47AC-AE55-5A59FE838C49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillHatchSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillHatchSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch spacing of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the hatch spacing of an intersection fill section.
	///</summary>
	public class IntersectionFillHatchSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchSpacing);

		}
	}


	[NVP_Manifest(
		Id = "8E9049EF-CB94-40B2-AEB7-A67FFB9204C0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillHatchSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillHatchSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the hatch spacing of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the hatch spacing of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillHatchSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchSpacing = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "200C6647-864E-40C3-A623-D50538C2657D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the color of an intersection fill section.
	///</summary>
	public class IntersectionFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillColor);

		}
	}


	[NVP_Manifest(
		Id = "458F92E8-B4C3-4549-8D72-7D62993B2BBF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "657A1B6F-EBAA-429F-B4BB-F86A5E88FB26", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the layer of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the layer of an intersection fill section.
	///</summary>
	public class IntersectionFillLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillLayer);

		}
	}


	[NVP_Manifest(
		Id = "875FE7DA-9A6A-4406-BCD0-0DCA3630B3EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the layer of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]

	///<summary>
	///Specifies or returns the layer of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5F5C3773-A816-4989-8870-7E6D0D0B70AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of an intersection fill section.
	///</summary>
	public class IntersectionFillLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillLinetype);

		}
	}


	[NVP_Manifest(
		Id = "A399C094-C25C-4838-B759-91A51E8CD28F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "431D8A93-BE63-43CA-8A03-C10313517ABA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillLinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillLinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype scale of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype scale of an intersection fill section.
	///</summary>
	public class IntersectionFillLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillLinetypeScale);

		}
	}


	[NVP_Manifest(
		Id = "3C3C21D0-6009-4BEB-A012-6C4618EA36B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillLinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillLinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype scale of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype scale of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillLinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B1740F55-2F68-42FC-BDCF-A57E089E33F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillPlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillPlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the plot style name of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the plot style name of an intersection fill section.
	///</summary>
	public class IntersectionFillPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillPlotStyleName);

		}
	}


	[NVP_Manifest(
		Id = "ED12D884-779B-4E94-AD5F-DCE2A7CB332F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillPlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillPlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the plot style name of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies or returns the plot style name of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillPlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BD28007B-8C37-46AD-95BE-14F371FEE0AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillLineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillLineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of an intersection fill section.
	///</summary>
	public class IntersectionFillLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillLineweight);

		}
	}


	[NVP_Manifest(
		Id = "97222D9B-3579-4A10-BABB-60F0F0AB47E7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillLineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillLineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillLineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D96CBF86-E5D7-4EAF-8343-3A32C9ED33E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.IntersectionFillFaceTransparency", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "IntersectionFillFaceTransparency", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the face transparency value of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the face transparency value of an intersection fill section.
	///</summary>
	public class IntersectionFillFaceTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillFaceTransparency);

		}
	}


	[NVP_Manifest(
		Id = "5FE18686-E518-485C-BC11-5CD1413CA3E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_IntersectionFillFaceTransparency", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_IntersectionFillFaceTransparency", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the face transparency value of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the face transparency value of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillFaceTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillFaceTransparency = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E4F60EE6-1007-4084-81E0-66AFEB21CFA2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.BackgroundLinesVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "BackgroundLinesVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a background geometry section is visible.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether a background geometry section is visible.
	///</summary>
	public class BackgroundLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesVisible);

		}
	}


	[NVP_Manifest(
		Id = "E5A7D112-7C1F-4A07-883C-01A18DB6F2DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_BackgroundLinesVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_BackgroundLinesVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a background geometry section is visible.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a background geometry section is visible.
	///</summary>
	public class Set_BackgroundLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesVisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "117D032A-2B4B-471B-905C-E5DD8B156B1B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.BackgroundLinesHiddenLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "BackgroundLinesHiddenLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether hidden lines are visble for a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether hidden lines are visble for a background geometry section.
	///</summary>
	public class BackgroundLinesHiddenLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesHiddenLine);

		}
	}


	[NVP_Manifest(
		Id = "FB4D5645-4CB5-4768-8A6B-06715F7F7233", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_BackgroundLinesHiddenLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_BackgroundLinesHiddenLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether hidden lines are visble for a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether hidden lines are visble for a background geometry section.
	///</summary>
	public class Set_BackgroundLinesHiddenLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesHiddenLine = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "231F35F7-8398-43DB-B7AF-02E65304B80E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.BackgroundLinesColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "BackgroundLinesColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the color of a background geometry section.
	///</summary>
	public class BackgroundLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesColor);

		}
	}


	[NVP_Manifest(
		Id = "18EA6E88-A35B-46B0-8ED9-7B6E0491376D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_BackgroundLinesColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_BackgroundLinesColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of a background geometry section.
	///</summary>
	public class Set_BackgroundLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "488D681D-4A91-427C-BACA-649585D0C1D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.BackgroundLinesLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "BackgroundLinesLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the layer of a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the layer of a background geometry section.
	///</summary>
	public class BackgroundLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesLayer);

		}
	}


	[NVP_Manifest(
		Id = "E7469403-B01F-4FB7-96D6-B598751A5330", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_BackgroundLinesLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_BackgroundLinesLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the layer of a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]

	///<summary>
	///Specifies or returns the layer of a background geometry section.
	///</summary>
	public class Set_BackgroundLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E0210C7C-4A96-4B60-8DE7-7D70DA6CE792", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.BackgroundLinesLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "BackgroundLinesLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of a background geometry section.
	///</summary>
	public class BackgroundLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesLinetype);

		}
	}


	[NVP_Manifest(
		Id = "97FFB2F1-1DD4-46D8-917B-B1BC47078F0E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_BackgroundLinesLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_BackgroundLinesLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of a background geometry section.
	///</summary>
	public class Set_BackgroundLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4C4BB96B-1BF2-432D-9935-282AECB95FD4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.BackgroundLinesLinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "BackgroundLinesLinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype scale of a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype scale of a background geometry section.
	///</summary>
	public class BackgroundLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesLinetypeScale);

		}
	}


	[NVP_Manifest(
		Id = "30C9402A-2915-4575-860B-C0B6DC8AEFE2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_BackgroundLinesLinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_BackgroundLinesLinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype scale of a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype scale of a background geometry section.
	///</summary>
	public class Set_BackgroundLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesLinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "25AC1D55-56DB-43D6-BFE2-A061125AEB6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.BackgroundLinesPlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "BackgroundLinesPlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the plot style name of a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the plot style name of a background geometry section.
	///</summary>
	public class BackgroundLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesPlotStyleName);

		}
	}


	[NVP_Manifest(
		Id = "144956F7-1299-43E1-A631-E3410FE1A310", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_BackgroundLinesPlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_BackgroundLinesPlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the plot style name of a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies or returns the plot style name of a background geometry section.
	///</summary>
	public class Set_BackgroundLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesPlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "946E028B-FB37-49D5-8168-A666AFEC498B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.BackgroundLinesLineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "BackgroundLinesLineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of a background geometry section.
	///</summary>
	public class BackgroundLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesLineweight);

		}
	}


	[NVP_Manifest(
		Id = "65D67899-2A05-4C1D-90C1-038F564B4F11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_BackgroundLinesLineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_BackgroundLinesLineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of a background geometry section.
	///</summary>
	public class Set_BackgroundLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesLineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D058699D-BC49-4CF4-8CDB-CF001EBA2598", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.ForegroundLinesVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "ForegroundLinesVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a foreground geometry section is visible.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether a foreground geometry section is visible.
	///</summary>
	public class ForegroundLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesVisible);

		}
	}


	[NVP_Manifest(
		Id = "E227834C-4710-4764-993D-F0C633E4BA46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_ForegroundLinesVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_ForegroundLinesVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a foreground geometry section is visible.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a foreground geometry section is visible.
	///</summary>
	public class Set_ForegroundLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesVisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B65F955A-3BD1-450B-B5FF-04F533DD14CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.ForegroundLinesHiddenLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "ForegroundLinesHiddenLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether hidden lines are visble for a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether hidden lines are visble for a foreground geometry section.
	///</summary>
	public class ForegroundLinesHiddenLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesHiddenLine);

		}
	}


	[NVP_Manifest(
		Id = "36493BA9-EEFE-4779-896D-A50A18578D3A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_ForegroundLinesHiddenLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_ForegroundLinesHiddenLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether hidden lines are visble for a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether hidden lines are visble for a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesHiddenLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesHiddenLine = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "449BF9F6-4CA3-4AE3-8806-9293B99F70F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.ForegroundLinesColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "ForegroundLinesColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the color of a foreground geometry section.
	///</summary>
	public class ForegroundLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesColor);

		}
	}


	[NVP_Manifest(
		Id = "BB367BAB-449A-4C5B-9795-662835631843", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_ForegroundLinesColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_ForegroundLinesColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "64170C86-4295-4CEC-9A45-FD4F79BD6F51", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.ForegroundLinesLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "ForegroundLinesLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the layer of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the layer of a foreground geometry section.
	///</summary>
	public class ForegroundLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesLayer);

		}
	}


	[NVP_Manifest(
		Id = "862C118D-FA69-4772-95AC-EC23996701D8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_ForegroundLinesLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_ForegroundLinesLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the layer of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]

	///<summary>
	///Specifies or returns the layer of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EEA1B766-3E83-459C-A162-1F9E02EE8308", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.ForegroundLinesLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "ForegroundLinesLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of a foreground geometry section.
	///</summary>
	public class ForegroundLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesLinetype);

		}
	}


	[NVP_Manifest(
		Id = "2090382D-CB1E-4CEE-8C0A-6510ECDC6CBC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_ForegroundLinesLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_ForegroundLinesLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4FD876E3-B98F-43E7-9084-00964D674B59", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.ForegroundLinesLinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "ForegroundLinesLinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype scale of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype scale of a foreground geometry section.
	///</summary>
	public class ForegroundLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesLinetypeScale);

		}
	}


	[NVP_Manifest(
		Id = "F3CB3BC7-259B-4CD5-8D50-BC6417FF413B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_ForegroundLinesLinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_ForegroundLinesLinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype scale of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype scale of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesLinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7BFEBF5F-C519-4800-963B-58A5FF0C9850", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.ForegroundLinesPlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "ForegroundLinesPlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the plot style name of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the plot style name of a foreground geometry section.
	///</summary>
	public class ForegroundLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesPlotStyleName);

		}
	}


	[NVP_Manifest(
		Id = "E4FCFD47-1B14-418E-943C-E571CF1DC07D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_ForegroundLinesPlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_ForegroundLinesPlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the plot style name of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies or returns the plot style name of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesPlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "051A0767-925A-42BE-8E89-791116B88B16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.ForegroundLinesLineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "ForegroundLinesLineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of a foreground geometry section.
	///</summary>
	public class ForegroundLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesLineweight);

		}
	}


	[NVP_Manifest(
		Id = "1C67DD2A-44AD-4C13-82CD-4B23F7CA470D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_ForegroundLinesLineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_ForegroundLinesLineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesLineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9E1EF6A1-1582-4876-A866-8752EB3B8463", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.ForegroundLinesFaceTransparency", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "ForegroundLinesFaceTransparency", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the face transparency value of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the face transparency value of a foreground geometry section.
	///</summary>
	public class ForegroundLinesFaceTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesFaceTransparency);

		}
	}


	[NVP_Manifest(
		Id = "C1528ADB-303D-4059-A6CA-5C289693C966", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_ForegroundLinesFaceTransparency", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_ForegroundLinesFaceTransparency", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the face transparency value of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the face transparency value of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesFaceTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesFaceTransparency = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C193119F-B44C-4DED-895D-7C914A7AF5F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.ForegroundLinesEdgeTransparency", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "ForegroundLinesEdgeTransparency", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the edge transparency value of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the edge transparency value of a foreground geometry section.
	///</summary>
	public class ForegroundLinesEdgeTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesEdgeTransparency);

		}
	}


	[NVP_Manifest(
		Id = "FF3D15AA-6193-458C-AB7B-1E049EC0FF84", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_ForegroundLinesEdgeTransparency", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_ForegroundLinesEdgeTransparency", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the edge transparency value of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the edge transparency value of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesEdgeTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesEdgeTransparency = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FDAFEDE6-AB29-4C5E-9978-40934DA5C4D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.CurveTangencyLinesVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "CurveTangencyLinesVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a curve tangency line section is visible.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether a curve tangency line section is visible.
	///</summary>
	public class CurveTangencyLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesVisible);

		}
	}


	[NVP_Manifest(
		Id = "BF52C4BB-EC15-4BC1-AEA9-4216C82ED890", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_CurveTangencyLinesVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_CurveTangencyLinesVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a curve tangency line section is visible.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a curve tangency line section is visible.
	///</summary>
	public class Set_CurveTangencyLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesVisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DE6B09EA-E48D-44A6-B441-1A688A0E303F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.CurveTangencyLinesColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "CurveTangencyLinesColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of a curve tangency line section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the color of a curve tangency line section.
	///</summary>
	public class CurveTangencyLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesColor);

		}
	}


	[NVP_Manifest(
		Id = "29E72DDA-6536-486A-BF7D-C6606702EBD3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_CurveTangencyLinesColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_CurveTangencyLinesColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of a curve tangency line section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of a curve tangency line section.
	///</summary>
	public class Set_CurveTangencyLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2D9EC787-F935-4130-88AF-AACB29343AEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.CurveTangencyLinesLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "CurveTangencyLinesLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the layer of a curve tangency line section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the layer of a curve tangency line section.
	///</summary>
	public class CurveTangencyLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesLayer);

		}
	}


	[NVP_Manifest(
		Id = "D2A7D3B0-D53D-4174-B756-200BBFB35C7A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_CurveTangencyLinesLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_CurveTangencyLinesLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the layer of a curve tangency line section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]

	///<summary>
	///Specifies or returns the layer of a curve tangency line section.
	///</summary>
	public class Set_CurveTangencyLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "87E76159-3E0B-4395-90D2-94E6DCC21DD3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.CurveTangencyLinesLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "CurveTangencyLinesLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of a curve tangency line section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of a curve tangency line section.
	///</summary>
	public class CurveTangencyLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesLinetype);

		}
	}


	[NVP_Manifest(
		Id = "323BEB3D-B2FB-4CF0-BE3B-67DF5686E65C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_CurveTangencyLinesLinetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_CurveTangencyLinesLinetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of a curve tangency line section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of a curve tangency line section.
	///</summary>
	public class Set_CurveTangencyLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F6C8A2DB-A82E-4932-9B1F-B0456F31690C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.CurveTangencyLinesLinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "CurveTangencyLinesLinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype scale of a curve tangency line section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype scale of a curve tangency line section.
	///</summary>
	public class CurveTangencyLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesLinetypeScale);

		}
	}


	[NVP_Manifest(
		Id = "D1359300-3BF3-48A1-B922-FFF9AE419177", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_CurveTangencyLinesLinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_CurveTangencyLinesLinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype scale of a curve tangency line section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype scale of a curve tangency line section.
	///</summary>
	public class Set_CurveTangencyLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesLinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6374BD95-7917-482A-ACC4-3A58055DCB8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.CurveTangencyLinesPlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "CurveTangencyLinesPlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the plot style name of a curve tangency line section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies the plot style name of a curve tangency line section.
	///</summary>
	public class CurveTangencyLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesPlotStyleName);

		}
	}


	[NVP_Manifest(
		Id = "6E467965-79C5-4A4D-BDF8-4F3830A796EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_CurveTangencyLinesPlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_CurveTangencyLinesPlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the plot style name of a curve tangency line section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies the plot style name of a curve tangency line section.
	///</summary>
	public class Set_CurveTangencyLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesPlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B0B827D1-F1FE-4B3F-BE35-1279FB37A91D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.CurveTangencyLinesLineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "CurveTangencyLinesLineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of a curve tangency line section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of a curve tangency line section.
	///</summary>
	public class CurveTangencyLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesLineweight);

		}
	}


	[NVP_Manifest(
		Id = "09A2C7FC-EE42-46AE-AD3D-740271C64681", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadSectionTypeSettings.Set_CurveTangencyLinesLineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadSectionTypeSettings", 
		NodeName = "Set_CurveTangencyLinesLineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of a curve tangency line section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of a curve tangency line section.
	///</summary>
	public class Set_CurveTangencyLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesLineweight = inputs[1].Value;
			return null;
		}
	}
}
