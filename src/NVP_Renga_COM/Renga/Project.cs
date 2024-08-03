using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Project 
{

	[NVP_Manifest(
		Id = "F3CA0960-3366-4979-AA31-79031D9AEA51", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.Project_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "_Project_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Project_Constructor : INode 
	{
		public Renga.IProject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IProject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E79AD639-BCE5-4D7D-A761-C8C2BFE75461", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.Project_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "_Project_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Project_ConstructorCast : INode 
	{
		public Renga.IProject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IProject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "63877CCA-3555-4FFA-8A4F-8437253B8D84", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.FilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "FilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FilePath);

		}
	}


	[NVP_Manifest(
		Id = "905B3E37-DD26-4707-971E-68718E2C2C21", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.HasFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "HasFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasFile);

		}
	}


	[NVP_Manifest(
		Id = "DD667BD5-A3FE-4E0D-84ED-2C4255C187F7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.Model", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "Model", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Model : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Model);

		}
	}


	[NVP_Manifest(
		Id = "98A53621-CDE8-4E1E-BA6C-214EA7310DD5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.PropertyManager", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "PropertyManager", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PropertyManager : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PropertyManager);

		}
	}


	[NVP_Manifest(
		Id = "10CD998B-821C-4933-A925-84791A506640", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.MaterialManager", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "MaterialManager", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MaterialManager : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaterialManager);

		}
	}


	[NVP_Manifest(
		Id = "E33D893D-7D5B-4B9B-8AA5-2784CE3B0074", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.LayeredMaterialManager", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "LayeredMaterialManager", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LayeredMaterialManager : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayeredMaterialManager);

		}
	}


	[NVP_Manifest(
		Id = "425F55F8-BBA8-4E2D-A48D-164E805B115B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.DataExporter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "DataExporter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DataExporter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DataExporter);

		}
	}


	[NVP_Manifest(
		Id = "DA50FDDB-81D0-4067-91F8-D5C477F1D606", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ReinforcementUnitStyleManager", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ReinforcementUnitStyleManager", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ReinforcementUnitStyleManager : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReinforcementUnitStyleManager);

		}
	}


	[NVP_Manifest(
		Id = "3AAD83CC-639F-4380-966C-A3DD8EBCD7BD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ProjectType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ProjectType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ProjectType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProjectType);

		}
	}


	[NVP_Manifest(
		Id = "C722C5F9-57C2-45B0-BF5B-453EBC45F705", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.Drawings", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "Drawings", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Drawings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Drawings);

		}
	}


	[NVP_Manifest(
		Id = "AAD6C6AF-A3D2-4FC4-9AB9-E875BBCA8B7B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.HasUnsavedChanges", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "HasUnsavedChanges", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasUnsavedChanges : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasUnsavedChanges);

		}
	}


	[NVP_Manifest(
		Id = "79989CAF-A8D6-4EB7-A751-79A98EC4B3C2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.Save", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "Save", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Save : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Save);

		}
	}


	[NVP_Manifest(
		Id = "9D487EF7-4FCB-41F0-91A6-2CBF911E920B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.SaveAs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "SaveAs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("Renga.ProjectType", typeof(System.Object))]
	[NodeInput("overwrite", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SaveAs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SaveAs(inputs[1].Value,((Renga.ProjectType)inputs[2].Value),inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "0A11D54C-FF89-4348-9A8E-63679163EA90", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ExportToIfc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ExportToIfc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("overwrite", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class ExportToIfc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToIfc(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "1643410C-13B5-4E13-9026-7D0F4701D48A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ProfileDescriptionManager", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ProfileDescriptionManager", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ProfileDescriptionManager : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProfileDescriptionManager);

		}
	}


	[NVP_Manifest(
		Id = "3653E529-C6CC-4034-B841-CAA135D5045D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.BeamStyleManager", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "BeamStyleManager", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class BeamStyleManager : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BeamStyleManager);

		}
	}


	[NVP_Manifest(
		Id = "B6C7123E-4D2E-4520-A870-45FF8E73E299", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ColumnStyleManager", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ColumnStyleManager", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ColumnStyleManager : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColumnStyleManager);

		}
	}


	[NVP_Manifest(
		Id = "69C89961-E002-4495-9121-EF88C06C989C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ExportToCsv", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ExportToCsv", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]
	[NodeInput("folderPath", typeof(System.String))]
	[NodeInput("overwrite", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class ExportToCsv : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToCsv(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "97BD1962-F55B-4706-B97F-0C6CFECC37FB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ExportDrawingsToPdf", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ExportDrawingsToPdf", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ExportDrawingsToPdf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExportDrawingsToPdf();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D55BFC94-F37F-4166-887B-806357638D24", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.SystemStyleManager", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "SystemStyleManager", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SystemStyleManager : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SystemStyleManager);

		}
	}


	[NVP_Manifest(
		Id = "24FE6288-A200-4BE5-8216-F07C7335D190", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.PlumbingFixtureStyleManager", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "PlumbingFixtureStyleManager", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PlumbingFixtureStyleManager : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlumbingFixtureStyleManager);

		}
	}


	[NVP_Manifest(
		Id = "EA53EFF7-BBA8-474B-9129-53DEB5DE3424", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.EquipmentStyleManager", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "EquipmentStyleManager", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class EquipmentStyleManager : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EquipmentStyleManager);

		}
	}


	[NVP_Manifest(
		Id = "A6BA1499-986C-4959-8E5C-7A5F3C50CD7E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ExportToIfc2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ExportToIfc2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("overwrite", typeof(System.Object))]
	[NodeInput("pIfcExportSettings", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class ExportToIfc2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToIfc2(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "541F6CAE-B697-4F9D-82D7-4455AAF001D9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ProjectInfo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ProjectInfo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ProjectInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProjectInfo);

		}
	}


	[NVP_Manifest(
		Id = "8A05692A-02D5-40DE-888F-DDCEFDEDDE29", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.BuildingInfo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "BuildingInfo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class BuildingInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BuildingInfo);

		}
	}


	[NVP_Manifest(
		Id = "047E0361-F8AF-42F6-AFB0-532323BA311C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.LandPlotInfo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "LandPlotInfo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LandPlotInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LandPlotInfo);

		}
	}


	[NVP_Manifest(
		Id = "459A6119-8F2F-4634-B13A-1BDC4DCE4A11", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.PipeAccessoryStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "PipeAccessoryStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PipeAccessoryStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PipeAccessoryStyles);

		}
	}


	[NVP_Manifest(
		Id = "6F2D4DC1-D744-4F4E-92A5-EC17F2A472F6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.PipeStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "PipeStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PipeStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PipeStyles);

		}
	}


	[NVP_Manifest(
		Id = "C4250C8C-0641-4226-9BD1-1E71A2315F88", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.PipeFittingStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "PipeFittingStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PipeFittingStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PipeFittingStyles);

		}
	}


	[NVP_Manifest(
		Id = "30565662-40F2-4D8E-9BCE-5BE355727285", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.MechanicalEquipmentStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "MechanicalEquipmentStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MechanicalEquipmentStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MechanicalEquipmentStyles);

		}
	}


	[NVP_Manifest(
		Id = "82014A01-064F-4B83-ACEE-6DFE44CE06C3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.DuctStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "DuctStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DuctStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DuctStyles);

		}
	}


	[NVP_Manifest(
		Id = "6EB39744-6210-483E-9911-9812CF798A1E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.DuctFittingStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "DuctFittingStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DuctFittingStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DuctFittingStyles);

		}
	}


	[NVP_Manifest(
		Id = "E2514696-9A30-48FD-AFF2-09DE5E7EFAFF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.DuctAccessoryStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "DuctAccessoryStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DuctAccessoryStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DuctAccessoryStyles);

		}
	}


	[NVP_Manifest(
		Id = "EEB2181D-98C5-4634-9B8C-4BD68DFA939E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.LightFixtureStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "LightFixtureStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LightFixtureStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LightFixtureStyles);

		}
	}


	[NVP_Manifest(
		Id = "2B54F0A1-2A91-45F3-95A0-81CAA530C18E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.WiringAccessoryStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "WiringAccessoryStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WiringAccessoryStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WiringAccessoryStyles);

		}
	}


	[NVP_Manifest(
		Id = "31C14142-8C18-41BD-92A1-8E63BC6CBD07", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ElectricDistributionBoardStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ElectricDistributionBoardStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ElectricDistributionBoardStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElectricDistributionBoardStyles);

		}
	}


	[NVP_Manifest(
		Id = "57CDA014-408A-4BB1-B403-61353DA21FD9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ElectricalConductorStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ElectricalConductorStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ElectricalConductorStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElectricalConductorStyles);

		}
	}


	[NVP_Manifest(
		Id = "62B11A8B-864F-44FF-A9A3-BE2C14A4887B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ElectricalCircuitLineStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ElectricalCircuitLineStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ElectricalCircuitLineStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElectricalCircuitLineStyles);

		}
	}


	[NVP_Manifest(
		Id = "826E2C05-A44C-4822-8614-49D0847DB91E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.SystemStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "SystemStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SystemStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SystemStyles);

		}
	}


	[NVP_Manifest(
		Id = "FC9CA0F4-E18C-42F7-974D-D78C8B217443", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.PlumbingFixtureStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "PlumbingFixtureStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PlumbingFixtureStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlumbingFixtureStyles);

		}
	}


	[NVP_Manifest(
		Id = "EF7AA08C-7EF0-408E-A4EA-8CC91287B4EA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.EquipmentStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "EquipmentStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class EquipmentStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EquipmentStyles);

		}
	}


	[NVP_Manifest(
		Id = "272B4BC6-D403-43AA-86AB-8927607F0BB3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.Assemblies", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "Assemblies", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Assemblies : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Assemblies);

		}
	}


	[NVP_Manifest(
		Id = "BA1E45E5-4BE0-43A8-9B32-7E3DD0D62773", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ExportDrawingsToPdfS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ExportDrawingsToPdfS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ExportDrawingsToPdfS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExportDrawingsToPdfS();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C4F0B5DE-97F0-46A7-9B3C-B7B558BC3E3B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ExportDrawingsToOpenXpsS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ExportDrawingsToOpenXpsS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ExportDrawingsToOpenXpsS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExportDrawingsToOpenXpsS();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "55C333F6-8CE2-4614-AA76-DC78CD3DD7F6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.Drawings2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "Drawings2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Drawings2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Drawings2);

		}
	}


	[NVP_Manifest(
		Id = "C00E2C62-1765-4E43-9F25-41C0E1B24815", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ElementStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ElementStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ElementStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElementStyles);

		}
	}


	[NVP_Manifest(
		Id = "2AC41794-0F81-411A-91AF-735AAE25790B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.BeamStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "BeamStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class BeamStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BeamStyles);

		}
	}


	[NVP_Manifest(
		Id = "698AAA4B-2B1B-445C-898A-F82D72F50F7C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ColumnStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ColumnStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ColumnStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColumnStyles);

		}
	}


	[NVP_Manifest(
		Id = "E8D86735-7BE4-403E-9422-51A48007611D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.PlateStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "PlateStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PlateStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlateStyles);

		}
	}


	[NVP_Manifest(
		Id = "D1FCD3D5-AD97-4364-88D5-312A2FD6C0C6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.Materials", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "Materials", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Materials : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Materials);

		}
	}


	[NVP_Manifest(
		Id = "53B21A00-20CF-4089-BC24-0AEDAAD7613B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.WindowStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "WindowStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WindowStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowStyles);

		}
	}


	[NVP_Manifest(
		Id = "D8630847-9304-413E-AF37-BAD7EC42F6B3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.DoorStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "DoorStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DoorStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoorStyles);

		}
	}


	[NVP_Manifest(
		Id = "88E508A8-915D-47CF-A01B-1BCA13A6436D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.LayeredMaterials", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "LayeredMaterials", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LayeredMaterials : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayeredMaterials);

		}
	}


	[NVP_Manifest(
		Id = "9E5EA0AF-5D08-41A6-8A4D-6DAF8F699152", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.Profiles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "Profiles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Profiles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Profiles);

		}
	}


	[NVP_Manifest(
		Id = "548DF505-EF35-45E8-AA85-34761F500F58", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.CreateOperation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "CreateOperation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateOperation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateOperation);

		}
	}


	[NVP_Manifest(
		Id = "A5E18299-3BD5-4AAD-9C93-184D53B989C7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.Topics", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "Topics", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Topics : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Topics);

		}
	}


	[NVP_Manifest(
		Id = "20F5F086-7176-4194-AAE0-AD353AE0DB56", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.LayoutStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "LayoutStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LayoutStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayoutStyles);

		}
	}


	[NVP_Manifest(
		Id = "B8AD342D-90E1-458A-81C8-9007A9FEE684", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.PageFormatStyles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "PageFormatStyles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PageFormatStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PageFormatStyles);

		}
	}


	[NVP_Manifest(
		Id = "EB33A842-384A-44DB-B70A-DDB993D3E195", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.GetEntityNumberInTopic", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "GetEntityNumberInTopic", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]
	[NodeInput("entityId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetEntityNumberInTopic : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEntityNumberInTopic(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "95806A8B-65CC-47B0-9CAC-CE31A53E7A48", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.GetEntityNumberInTopicS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "GetEntityNumberInTopicS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]
	[NodeInput("entityId", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetEntityNumberInTopicS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEntityNumberInTopicS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "F88EE143-4546-4DF0-AFE5-FF8CCD09D4A1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.JournalPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "JournalPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class JournalPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.JournalPath);

		}
	}


	[NVP_Manifest(
		Id = "27ED2D8F-0CB1-4D2B-9E7C-740599CBEF9E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.HasActiveOperation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "HasActiveOperation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasActiveOperation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasActiveOperation);

		}
	}


	[NVP_Manifest(
		Id = "A883A22B-A43E-47EB-828F-74F960BC0F77", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.CreateOperationWithUndo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "CreateOperationWithUndo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]
	[NodeInput("modelId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class CreateOperationWithUndo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateOperationWithUndo(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "F51F6A35-D530-4B5B-A4FC-4CB629E5F654", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.GetUndoStack", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "GetUndoStack", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]
	[NodeInput("modelId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetUndoStack : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUndoStack(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "8EEC3AFB-AD51-435E-8796-BAE105B827FA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.DuctAccessoryCategories", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "DuctAccessoryCategories", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DuctAccessoryCategories : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DuctAccessoryCategories);

		}
	}


	[NVP_Manifest(
		Id = "F6FAFAD8-950B-43F0-9D54-A19C79EE9F15", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.PipeAccessoryCategories", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "PipeAccessoryCategories", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PipeAccessoryCategories : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PipeAccessoryCategories);

		}
	}


	[NVP_Manifest(
		Id = "75B42653-4728-464B-8141-8B5AAF299495", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.DuctFittingCategories", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "DuctFittingCategories", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DuctFittingCategories : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DuctFittingCategories);

		}
	}


	[NVP_Manifest(
		Id = "45A57EBE-E2C4-4327-91D5-7FAD101246EC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.PipeFittingCategories", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "PipeFittingCategories", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PipeFittingCategories : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PipeFittingCategories);

		}
	}


	[NVP_Manifest(
		Id = "42DFEC22-46FD-4E61-8315-5A456473747A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.MechanicalEquipmentCategories", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "MechanicalEquipmentCategories", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MechanicalEquipmentCategories : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MechanicalEquipmentCategories);

		}
	}


	[NVP_Manifest(
		Id = "F2DAE6A3-A52D-45C6-A252-63927F836376", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.EquipmentCategories", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "EquipmentCategories", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class EquipmentCategories : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EquipmentCategories);

		}
	}


	[NVP_Manifest(
		Id = "3F2FEB2E-3458-4DB5-A0F4-548D49F86822", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.PlumbingFixtureCategories", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "PlumbingFixtureCategories", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PlumbingFixtureCategories : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlumbingFixtureCategories);

		}
	}


	[NVP_Manifest(
		Id = "68D580A4-B70E-4993-A5AD-1D396285E678", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.ElectricDistributionBoardCategories", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "ElectricDistributionBoardCategories", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ElectricDistributionBoardCategories : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElectricDistributionBoardCategories);

		}
	}


	[NVP_Manifest(
		Id = "05DD20EC-66C6-4F88-B59C-A8DB549CE853", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.WiringAccessoryCategories", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "WiringAccessoryCategories", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WiringAccessoryCategories : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WiringAccessoryCategories);

		}
	}


	[NVP_Manifest(
		Id = "90C25E37-5145-4300-944B-E94903B7E589", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Project.LightningFixtureCategories", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Project", 
		NodeName = "LightningFixtureCategories", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Project", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LightningFixtureCategories : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LightningFixtureCategories);

		}
	}
}
