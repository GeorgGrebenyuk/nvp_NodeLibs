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
